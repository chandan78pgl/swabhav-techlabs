using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TenantManagementApi.Models.DTO
{
    public class UserDetailsDTO
    {
        public Guid Id { set; get; }
        public string Name { set; get; }
        public string Role { set; get; }
        public string Currency { set; get; }
        public string ShortName { set; get; }
        public string WebUrl { set; get; }

        public List<ContactDetailsDTO> ContactDetails { set; get; }
        public List<AddressDetailsDTO> AddressDetails { set; get; }
    }
}