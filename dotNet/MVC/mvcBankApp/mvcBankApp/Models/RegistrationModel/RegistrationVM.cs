using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace mvcBankApp.Models.RegistrationModel
{
    public class RegistrationVM
    {
        public int AccountNo { get; set; }

        public string AccountHolderName { get; set; }
        public double AccountBalance { get; set; }

        [Required(ErrorMessage ="Password Field is required...")]
        public string AccountPassword { get; set; }

        [Required(ErrorMessage = "Password Field is required...")]
        [Compare("AccountPassword",ErrorMessage = "Password and Confirmation Password must match.")]
        public string AccountConfirmPass { get; set; }
        public DateTime AccountCreatedDate { get; set; }
    }
}