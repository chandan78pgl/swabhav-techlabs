using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace mvcBankApp.Models.LoginModel
{
    public class LoginVM
    {
        [Required(ErrorMessage ="Account no is required....")]
        public int AcntNo { get; set; }

        [Required(ErrorMessage = "Account Password is required....")]
        public string AccountPassword { get; set; }
    }
}