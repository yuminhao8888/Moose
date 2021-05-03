using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace VIPProgramAssessment.ViewModels
{
    public class UserLoginViewModel
    {
        [Required(ErrorMessage = "UserName is Requirde")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Password is Requirde")]
        public string Password { get; set; }
    }
}