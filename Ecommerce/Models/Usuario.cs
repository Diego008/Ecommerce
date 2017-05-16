using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Ecommerce.Models
{
    public class Usuario
    {
        public int UsuarioID { get; set; }
        [Required(ErrorMessage = "Preencha o campo nome")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Preencha o campo Cpf")]
        public string Cpf { get; set; }

        [Required(ErrorMessage = "Preencha o campo Rg")]
        public string Rg { get; set; }

        [Required(ErrorMessage = "Preencha o campo Cep")]
        public string Cep { get; set; }

        [Required(ErrorMessage = "Preencha o campo Endereço")]
        public string Endereco { get; set; }

        [Required(ErrorMessage = "Preencha o campo Número")]
        public string Numero { get; set; }

        [Required(ErrorMessage = "Preencha o campo Bairro")]
        public string Bairro { get; set; }

        [Required(ErrorMessage = "Preencha o campo Cidade")]
        public string Cidade { get; set; }

        [Required(ErrorMessage = "Preencha pelo menos um contato")]
        public string Contato { get; set; }

        [Required(ErrorMessage = "Preencha o campo email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Digite uma senha com no mínimo 6 caracteres")]
        [StringLength(100, MinimumLength = 6, ErrorMessage = "A senha deve conter no minimo 6 caracteres")]
        public string Senha { get; set; }

        [Required(ErrorMessage = "Selecione uma imagem para seu perfil")]
        public string Imagem { get; set; }
    }
}