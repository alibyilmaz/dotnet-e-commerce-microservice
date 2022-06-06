using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FreeCourse.Web.Client.Models
{
    public class SignInInput
    {
        [Display(Name = "Your email address")]
        public string Email { get; set; }

        [Display(Name = "Password")]
        public string Password { get; set; }
        [Display(Name = "Remember me")]
        public bool IsRemember { get; set; }
    }
}
