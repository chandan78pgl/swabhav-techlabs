using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TenantManagementApi.Models.Tenant;
using TenantManagementApi.Repository.Specification;

namespace TenantManagementApi.Repository
{
    public class TenantRepository : ITenantRepository<User>
    {
        private TenantDBContext _tenantDBContext;

        public TenantRepository()
        {
            _tenantDBContext = new TenantDBContext();
        }

        public Guid Add(User entity)
        {
            _tenantDBContext.Users.Add(entity);
            _tenantDBContext.SaveChanges();

            return entity.Id;
        }

        public void Delete(Guid entityId)
        {
            User user = GetById(entityId);
            _tenantDBContext.Users.Remove(user);
            _tenantDBContext.SaveChanges();
        }

        public IList<User> Find(ISpecification<User> specification)
        {
            return _tenantDBContext.Users.Where(specification.SearchExpression).ToList();
        }

        public IList<User> GetAll()
        {
            return _tenantDBContext.Users.ToList();
        }

        public User GetById(Guid entityId)
        {
            return _tenantDBContext.Users.Where((u) => u.Id == entityId).SingleOrDefault();
        }

        public void Update(User entity)
        {
            User user = GetById(entity.Id);

            user.Name = entity.Name;
            user.Role = entity.Role;
            user.ShortName = entity.ShortName;
            user.UserLoginDetails = entity.UserLoginDetails;
            user.UserMasterDetails = entity.UserMasterDetails;
            user.UserSubscriptionDetails = entity.UserSubscriptionDetails;
            user.WebUrl = entity.WebUrl;
            user.AddressDetail = entity.AddressDetail;
            user.ContactDetail = entity.ContactDetail;
            user.Currency = entity.Currency;

            _tenantDBContext.SaveChanges();
        }
    }
}