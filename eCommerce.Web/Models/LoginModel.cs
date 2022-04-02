using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace eCommerce.Web.Models
{
    public class LoginRegisterModel
    {
        public Login Login { get; set; }
        public Register Register { get; set; }
    }

    public class Login
    {
        [Required]
        [Display(Name = "Username")]
        public string Username { get; set; }
        [Required]
        [Display(Name = "Password")]
        public string Password { get; set; }
        public string ReturnUrl { get; set; }
    }

    public class Register
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Cel { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        [Required]
        [Display(Name = "Username")]
        public string Username { get; set; }
        [Required]
        [Display(Name = "Password")]
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public DateTime BirthDate { get; set; }
        public string ReturnUrl { get; set; }
    }
}
