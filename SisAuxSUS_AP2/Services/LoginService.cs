using Microsoft.EntityFrameworkCore;
using SisAuxSUS_AP2.Context;
using SisAuxSUS_AP2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SisAuxSUS_AP2.Services
{
    public class LoginService : ILoginService
    {
        private readonly AppDbContext _context;
        public LoginService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<Usuario> AutenticaUsuario(string loginUsuario, string senhaUsuario)
        {
            return await _context.Usuarios
                .FirstOrDefaultAsync(u => u.Email == u.Email && u.Senha == u.Senha);
        }
    }
}
