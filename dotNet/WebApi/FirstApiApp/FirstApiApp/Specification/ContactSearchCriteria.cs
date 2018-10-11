using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FirstApiApp.Specification
{
    public class ContactSearchCriteria
    {
        public string ContactName { set; get; }
        public Guid ContactID { set; get; }
    }
}