using FirstApiApp.Models.ContactModel;
using FirstApiApp.Repository;
using FirstApiApp.Services;
using FirstApiApp.Specification;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Web.Http.Description;

namespace FirstApiApp.Controllers
{
    [EnableCors(origins: "http://localhost",headers:"*",methods:"*")]
    [RoutePrefix("api/hitech/Contacts")]
    public class ContactController : ApiController
    {
        private IRepository<Contact> _contactRepository = new ContactRepository();
        // GET: Contact

        [Route("AllContacts")]
        public IHttpActionResult GetContacts()
        {
            return Ok(_contactRepository.GetAll());
        }

        [Route("AddContact")]
        public IHttpActionResult PostAddContact(Contact contact)
        {
            _contactRepository.Add(contact);
            return Ok("Contact Added SuccessFully - " + contact.Name);
        }

        [Route("ContactByName/{contactName:alpha}")]
        public IHttpActionResult GetContactsByName(string contactName)
        {
            return Ok(_contactRepository.Find(new ContactSpecificationForSearch(new ContactSearchCriteria { ContactName = contactName })));
        }

        [Route("ContactById/{id}")]
        public IHttpActionResult GetContactById(string id)
        {
            return Ok(_contactRepository.Find(new ContactSpecificationForSearch(new ContactSearchCriteria { ContactID = Guid.Parse(id)})));
        }

        [Route("Contact/{name:alpha}/{id}")]
        public IHttpActionResult GetContact(string name,string id)
        {
            return Ok(_contactRepository.Find(new ContactSpecificationForSearch(new ContactSearchCriteria { ContactName=name, ContactID = Guid.Parse(id) })));
        }

    }
}