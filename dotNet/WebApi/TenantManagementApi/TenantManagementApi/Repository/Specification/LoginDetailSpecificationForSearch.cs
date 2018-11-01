using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using TenantManagementApi.Models.Login;

namespace TenantManagementApi.Repository.Specification
{
    public class LoginDetailSpecificationForSearch:ISpecification<LoginDetail>
    {
        private LoginDetailSearchCriteria _loginDetailSearchCriteria;

        public LoginDetailSpecificationForSearch(LoginDetailSearchCriteria loginDetailSearchCriteria)
        {
            _loginDetailSearchCriteria = loginDetailSearchCriteria;
        }

        public Expression<Func<LoginDetail, bool>> SearchExpression
        {
            get
            {
                Expression<Func<LoginDetail, bool>> query = null;

                if (!String.IsNullOrWhiteSpace(_loginDetailSearchCriteria.LoginDetailUsername))
                {
                    
                    query = (x) => x.Username.Equals(_loginDetailSearchCriteria.LoginDetailUsername);
                    return query;
                }

                if (_loginDetailSearchCriteria.LoginDetailId != Guid.Empty)
                {
                    query = (x) => x.Id == _loginDetailSearchCriteria.LoginDetailId;
                    return query;
                }

                return query;
            }
        }
    }
}