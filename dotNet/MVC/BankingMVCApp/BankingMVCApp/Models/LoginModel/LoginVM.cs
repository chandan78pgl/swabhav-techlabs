using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BankingMVCApp.Models.LoginModel
{
    public class LoginVM
    {
        [Required]
        public int AccountNo { set; get; }
        [Required]
        public String Password { set; get; }
    }
}