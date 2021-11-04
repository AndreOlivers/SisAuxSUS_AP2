using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SisAuxSUS_AP2.Models.Enumeradores
{
    public enum TipoDeSintomas
    {
        [Display(Name = "Temperatura normal , apenas dor de cabeça.")]
        Sintomas1,
        [Display(Name = "Febre, Tosse , Cansaço ,Perda de paladar ou olfato.")]
        Sintomas2,
        [Display(Name = "Tosse seca , febre alta e Falta de ar.")]
        Sintomas3,
        [Display(Name = "Dificuldade de respirar , Perda da fala ,Febre Alta , Dores no peito.")]
        Sintomas4

    }
}
