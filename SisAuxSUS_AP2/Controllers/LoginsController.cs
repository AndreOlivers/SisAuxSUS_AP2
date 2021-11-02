using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SisAuxSUS_AP2.Context;
using SisAuxSUS_AP2.Models;
using SisAuxSUS_AP2.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SisAuxSUS_AP2.Controllers
{
    public class LoginsController : Controller
    {
        //private ILoginService _loginService;

        //public LoginsController(ILoginService loginService)
        //{
        //    _loginService = loginService;
        //}
        private readonly AppDbContext _context;
        private readonly IHttpContextAccessor _contextAccessor;

        public LoginsController(AppDbContext context, IHttpContextAccessor contextAccessor)
        {
            _context = context;
            _contextAccessor = contextAccessor;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Index(LoginVM login)
        {
            if (string.IsNullOrEmpty(login.Email) || string.IsNullOrEmpty(login.Senha))
                return View(login);

            var usuario = _context.Usuarios.FirstOrDefault(x => x.Email == x.Email && x.Senha == x.Senha);
            if (usuario == null)
                return View(login);

            _contextAccessor.HttpContext.Session.SetString("Email", usuario.Email); //Salva sessão do usuário

            return RedirectToAction("Index", "Pacientes");
        }
    }
}

