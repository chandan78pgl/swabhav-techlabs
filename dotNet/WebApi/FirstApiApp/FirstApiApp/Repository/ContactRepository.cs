using FirstApiApp.Models.ContactModel;
using FirstApiApp.Specification;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FirstApiApp.Repository
{
    public class ContactRepository:IRepository<Contact>
    {
        public List<Contact> GetAll()
        {
            using (var unitOfWork = new UnitOfWorkScope<ContactDBContext>(UnitOfWorkScopePurpose.Reading))
            {
                return unitOfWork.DbContext.Contacts.ToList();
            }
        }

        public Guid Add(Contact entity)
        {
            using (var unitOfWork = new UnitOfWorkScope<ContactDBContext>(UnitOfWorkScopePurpose.Writing))
            {
                unitOfWork.DbContext.Contacts.Add(entity);
                unitOfWork.SaveChanges();
                return entity.Id;
            }
        }

        public void Delete(Guid entityId)
        {
            using (var unitOfWork = new UnitOfWorkScope<ContactDBContext>(UnitOfWorkScopePurpose.Reading))
            {
                unitOfWork.DbContext.Contacts.Remove(GetById(entityId));
            }
        }

        public Contact GetById(Guid entityId)
        {
            /*foreach (var contact in Contacts)
            {
                if (contact.Id == entityId)
                {
                    return contact;
                }
            }*/
            return null;
        }

        public void Update(Contact entity)
        {
            /*for (int i = 0; i < Contacts.Count; i++)
            {
                if (Contacts[i].Id == entity.Id)
                {
                    Contacts[i] = entity;
                }
            }*/
        }

        public List<Contact> Find(ISpecification<Contact> specification)
        {
            using (var unitOfWork = new UnitOfWorkScope<ContactDBContext>(UnitOfWorkScopePurpose.Reading))
            {
                return unitOfWork.DbContext.Contacts.Where(specification.SearchFunction).ToList(); ;
            }
        }
    }
}