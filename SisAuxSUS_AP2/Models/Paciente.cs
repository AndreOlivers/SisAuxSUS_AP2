using SisAuxSUS_AP2.Models.Enumeradores;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SisAuxSUS_AP2.Models
{
    public class Paciente
    {
        [key]
        public int Id { get; set; }
        [Required(ErrorMessage ="O nome é obrigatório")]
        [Display(Name ="Nome")]
        public string NomeDoPaciente { get; set; }
        [Required(ErrorMessage = "A idade é obrigatório")]
        [Display(Name = "Idade")]
        public int IdadeDoPaciente { get; set; }
        [Required(ErrorMessage = "O nome da cidade é obrigatório")]
        [Display(Name = "Cidade")]
        public string CidadeDoPaciente { get; set; }
        [Display(Name = "Tipo de Sintomas")]
        public TipoDeSintomas TipoDeSintoma { get; set; }
    }
}
