using SisAuxSUS_AP2.Models.Enumeradores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SisAuxSUS_AP2.Models.ViewModel
{
    public class PacientesViewModel
    {
        public List<Paciente> Pacientes { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Cidade { get; set; }
        public TipoDeSintomas TipoDeSintoma { get; set; }
    }
}
