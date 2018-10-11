using MVCApp.Models.Contact;
using MVCApp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCApp.Controllers
{
    public class ContactController : Controller
    {
        private ContactService contactService = new ContactService();
        // GET: Contact
        public ActionResult Index()
        {
            return RedirectToAction("Home","Contact");
        }

        public ActionResult Home()
        {
            ContactVM contactVM = new ContactVM();
            contactVM.Contacts = contactService.Contacts;
            
            return View(contactVM);
        }

        public ActionResult Add()
        {
            if (Session["user"]==null)
            {
                return RedirectToAction("Index","Login",new { data="Add"});
            }
            AddVM addVm = new AddVM();
            addVm.Id = contactService.Contacts.Count+1;
            return View(addVm);
        }

        [HttpPost]
        public ActionResult Add(AddVM addVm)
        {
            contactService.AddContact(addVm.Id,addVm.ContactNo,addVm.FName,addVm.LName,addVm.Email);
            
            return RedirectToAction("Home","Contact");
        }

        public ActionResult Edit(int? id)
        {
            if (Session["user"]==null)
            {
                return RedirectToAction("Index","Login",new {data="Home"});
            }
            EditVM editVM = new EditVM();
            Contact contact=contactService.SearchContact(Convert.ToInt32(id));

            editVM.Id = contact.Id;
            editVM.ContactNo = contact.ContactNo;
            editVM.FName = contact.FName;
            editVM.LName = contact.LName;
            editVM.Email = contact.Email;

            return View(editVM);
        }

        [HttpPost]
        public ActionResult Edit(EditVM vm)
        {
            Contact editContact = new Contact {Id=vm.Id, ContactNo = vm.ContactNo, FName = vm.FName, LName = vm.LName, Email = vm.Email };
            contactService.UpdateContact(editContact);
            return RedirectToAction("Home","Contact");
        }
    }
}