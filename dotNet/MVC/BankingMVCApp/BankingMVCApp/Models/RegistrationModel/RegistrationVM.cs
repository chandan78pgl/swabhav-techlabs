using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BankingMVCApp.Models.RegistrationModel
{
    public class RegistrationVM
    {
        public int AccountNo { set; get; }
        public String Name { set; get; }
        public Double Balance { set; get; }
        [Required(ErrorMessage = "This Field is Required")]
        public String Password { set; get; }

        [Required(ErrorMessage = "This Field is Required")]
        [Compare("Password", ErrorMessage = "Password Must Be Same")]
        public String RetypePassword { set; get; }
    }
}