using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CursoMvc.Models.FormViewModels
{
    public class UserFormViewModel
    {
        public string Email { get; set;}
        public string Password { get; set;}
        public string ConfirmPassword { get; set;}
        public int Edad { get; set; }

    }
}