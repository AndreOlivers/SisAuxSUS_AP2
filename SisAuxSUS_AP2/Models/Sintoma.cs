using SisAuxSUS_AP2.Models.Enumeradores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SisAuxSUS_AP2.Models
{
    public class Sintoma
    {
        public int Id { get; set; }
        public bool Situacao { get; set; }
        public TipoDeSintomas TipoDeSintoma { get; set; }
    }
}
