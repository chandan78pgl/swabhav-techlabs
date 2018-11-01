using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TenantManagementApi.Models.Login;
using TenantManagementApi.Repository.Specification;

namespace TenantManagementApi.Repository
{
    public class LoginRepository : ILoginRepository<LoginDetail>
    {
        private TenantDBContext _tenantDBContext;

        public LoginRepository()
        {
            _tenantDBContext = new TenantDBContext();
        }

        public object LoginDetailDTO { get; private set; }

        public Guid Add(LoginDetail entity)
        {
            _tenantDBContext.LoginDetails.Add(entity);
            _tenantDBContext.SaveChanges();
            return entity.Id;
        }

        public bool AuthenticateUser(string loginUsername, string loginPassword)
        {
            var user = GetByUsername(loginUsername);
            if (user.Username.Equals(loginUsername) && user.Password.Equals(loginPassword))
            {
                return true;
            }
            return false;
        }

        public void Delete(Guid entityId)
        {
            _tenantDBContext.LoginDetails.Remove(GetById(entityId));
            _tenantDBContext.SaveChanges();
        }

        public IList<LoginDetail> Find(ISpecification<LoginDetail> specification)
        {
            return _tenantDBContext.LoginDetails.Where(specification.SearchExpression).ToList();
        }

        public IList<LoginDetail> GetAll()
        {
            return _tenantDBContext.LoginDetails.ToList();
        }

        public LoginDetail GetById(Guid entityId)
        {
            return _tenantDBContext.LoginDetails.Where((l) => l.Id == entityId).SingleOrDefault();
        }

        public LoginDetail GetByUsername(string loginUsername)
        {
            return _tenantDBContext.LoginDetails.Where((l) => l.Username == loginUsername).SingleOrDefault(); ;
        }

        public void Update(LoginDetail entity)
        {
            var userLoginDetail = GetById(entity.Id);

            userLoginDetail.Username = entity.Username;
            userLoginDetail.Password = entity.Password;
            userLoginDetail.Captcha = entity.Captcha;
            userLoginDetail.UserDetails = entity.UserDetails;

            _tenantDBContext.SaveChanges();
        }
    }
}