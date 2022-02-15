using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace CursoMvc.Models.FormViewModels
{
    public class UserFormViewModel
    {
        [Required]
        [EmailAddress]
        [StringLength (100, ErrorMessage ="La direccion es demasiado larga.",MinimumLength =6)]
        [Display(Name ="Correo electronico")]
        public string Email { get; set;}

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Contraseña")]
        public string Password { get; set;}

        [DataType(DataType.Password)]
        [Display(Name = "Confirmar Contraseña")]
        [Compare("Password", ErrorMessage ="Contraseñas distintas")]
        public string ConfirmPassword { get; set;}

        [Required]
        public int Edad { get; set; }

    }
}