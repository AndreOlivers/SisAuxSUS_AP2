using SisAuxSUS_AP2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SisAuxSUS_AP2.Services
{
    public interface ILoginService
    {
        public Task<Usuario> AutenticaUsuario(string loginUsuario, string senhaUsuario);
    }
}
