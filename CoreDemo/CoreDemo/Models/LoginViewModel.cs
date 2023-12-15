using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.Models
{
    public class LoginViewModel
    {
        [Required(ErrorMessage ="Lütfen email adresinizi girin.")]
        public string email { get; set; }

        [Required(ErrorMessage = "Lütfen şifrenizi girin.")]

        public string password { get; set; }

    }
}
