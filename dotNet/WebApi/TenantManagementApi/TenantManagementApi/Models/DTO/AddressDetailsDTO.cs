using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TenantManagementApi.Models.DTO
{
    public class AddressDetailsDTO
    {
        public Guid Id { set; get; }
        public string Street { set; get; }
        public string City { set; get; }
        public string State { set; get; }
        public string Country { set; get; }
        public int ZipCode { set; get; }
    }
}