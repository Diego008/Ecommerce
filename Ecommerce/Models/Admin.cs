using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Ecommerce.Models
{
    public class Admin
    {
        [Key]
        public int AdminId { get; set; }

        [Required(ErrorMessage = "Preencha o campo nome")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Preencha o campo email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Digite uma senha com no mínimo 6 caracteres")]
        [StringLength(100, MinimumLength = 6, ErrorMessage = "A senha deve conter no minimo 6 caracteres")]
        public string Senha { get; set; }
    }
}