using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace VIPProgramAssessment.ViewModels
{
    public class UserRegisterViewModel
    {
        [Required(ErrorMessage = "FirstName is Requirde")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "LastName is Requirde")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Phone is Requirde")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Email is Requirde")]
        [RegularExpression(@"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
                            @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
                            @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$",
                            ErrorMessage = "Email is not valid")]
        public string Email { get; set; }

       
        public string Address { get; set; }

       

        [Required(ErrorMessage = "Password is Requirde")]
        public string Password { get; set; }
    }
}