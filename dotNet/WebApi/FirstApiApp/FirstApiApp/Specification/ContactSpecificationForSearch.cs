using FirstApiApp.Models.ContactModel;
using FirstApiApp.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;

namespace FirstApiApp.Specification
{
    public class ContactSpecificationForSearch : ISpecification<Contact>
    {
        private ContactSearchCriteria _contactSearchCriteria;

        public ContactSpecificationForSearch(ContactSearchCriteria contactSearchCriteria)
        {
            _contactSearchCriteria = contactSearchCriteria;
        }

        public Expression<Func<Contact, bool>> SearchFunction
        {
            get
            {
               Expression<Func<Contact, bool>> query = null;

                if (_contactSearchCriteria.ContactName!=null && _contactSearchCriteria.ContactID!=Guid.Empty)
                {
                    query = (x) => x.Name == _contactSearchCriteria.ContactName && x.Id == _contactSearchCriteria.ContactID;
                    return query;
                }

                if (!String.IsNullOrEmpty(_contactSearchCriteria.ContactName))
                {
                    query = (x) => x.Name == _contactSearchCriteria.ContactName;
                }

                if (_contactSearchCriteria.ContactID != Guid.Empty)
                {
                    query = (x) => x.Id == _contactSearchCriteria.ContactID;
                }

                return query;
            }
        }
    }
}