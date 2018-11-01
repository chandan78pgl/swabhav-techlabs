using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using TenantManagementApi.Models.Tenant;

namespace TenantManagementApi.Repository.Specification
{
    public class UserSpecificationForSearch : ISpecification<User>
    {
        private UserSearchCriteria _userSearchCriteria;

        public UserSpecificationForSearch(UserSearchCriteria userSearchCriteria)
        {
            _userSearchCriteria = userSearchCriteria;
        }

        public Expression<Func<User, bool>> SearchExpression
        {
            get
            {
                Expression<Func<User, bool>> query = null;

                if (!String.IsNullOrWhiteSpace(_userSearchCriteria.UserName))
                {
                    query = (x) => x.Name.Equals(_userSearchCriteria.UserName);
                    return query;
                }

                if (_userSearchCriteria.UserId != Guid.Empty)
                {
                    query = (x) => x.Id == _userSearchCriteria.UserId;
                    return query;
                }

                return query;
            }
        }
    }
}