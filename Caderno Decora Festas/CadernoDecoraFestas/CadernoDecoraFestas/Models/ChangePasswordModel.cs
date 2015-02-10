using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CadernoDecoraFestas.Models
{
    public class ChangePasswordModel
    {
        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Senha")]
        public string OldPassword { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "O {0} deve ter no mínimo {2} caracteres.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Nova senha")]
        public string NewPassword { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirmação da senha")]
        [Compare("NewPassword", ErrorMessage = "A senha e a confirmação não conferem.")]
        public string ConfirmPassword { get; set; }
    }

    public class LoginModel
    {
        [Required]
        [Display(Name = "email")]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Senha")]
        public string Password { get; set; }

        [Display(Name = "Lembrar?")]
        public bool RememberMe { get; set; }
    }

    

}