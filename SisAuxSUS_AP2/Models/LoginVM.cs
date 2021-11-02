using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SisAuxSUS_AP2.Models
{
    public class LoginVM
    {
        public LoginVM()
        {

        }
        public LoginVM(string email, string senha)
        {
            Email = email;
            Senha = senha;
        }
        [Required(ErrorMessage = "E-mail Obrigatório")]
        [EmailAddress]
        public string Email { get; set; }
        [Required(ErrorMessage = "A Senha é obrigatória")]
        [DataType(DataType.Password)]
        [StringLength(10, MinimumLength = 4, ErrorMessage = "A senha deve ter entre 4 e 10 caracteres")]
        public string Senha { get; set; }

    }
}

