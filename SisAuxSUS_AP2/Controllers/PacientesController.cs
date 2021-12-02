using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SisAuxSUS_AP2.Context;
using SisAuxSUS_AP2.Models;
using SisAuxSUS_AP2.Models.Enumeradores;
using SisAuxSUS_AP2.Models.ViewModel;

namespace SisAuxSUS_AP2.Controllers
{
    public class PacientesController : Controller
    {
        private readonly AppDbContext _context;

        public PacientesController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Pacientes
        [Route("Index")]
        public async Task<IActionResult> Index()
        {
            var pacienteViewModel = new PacientesViewModel
            {
                Pacientes = await _context.Pacientes.ToListAsync()
            };
            //return View(pacienteViewModel);
            //return RedirectToAction(nameof(pacienteViewModel));
            return View(await _context.Pacientes.ToListAsync());
        }
        public async Task<IActionResult> ListaPacientes(PacientesViewModel paciente)
        {
            paciente = new PacientesViewModel
            {
                Pacientes = await _context.Pacientes.ToListAsync()
            };
            return View("ListaPacientes", paciente);
        }
        // GET: Pacientes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var paciente = await _context.Pacientes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (paciente == null)
            {
                return NotFound();
            }

            return View(paciente);
        }

        // GET: Pacientes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Pacientes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,NomeDoPaciente,IdadeDoPaciente,CidadeDoPaciente,SituacaoPaciente,TipoDeSintoma")] Paciente paciente)
        {

            if (ModelState.IsValid)
            {
                _context.Add(paciente);
                await _context.SaveChangesAsync();
                return RedirectToAction("Alerta", new { id = paciente.Id });
            }
            return View(await _context.Pacientes.ToListAsync());
            //return RedirectToAction(nameof(Index));
        }

        // GET: Pacientes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var paciente = await _context.Pacientes.FindAsync(id);
            if (paciente == null)
            {
                return NotFound();
            }
            return View(paciente);
        }

        // POST: Pacientes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,NomeDoPaciente,IdadeDoPaciente,CidadeDoPaciente,SituacaoPaciente,TipoDeSintoma")] Paciente paciente)
        {
            if (id != paciente.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(paciente);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PacienteExists(paciente.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("Alerta", new { id = paciente.Id });
                //return RedirectToAction(nameof(Index));
            }
            return View(paciente);
        }

        // GET: Pacientes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var paciente = await _context.Pacientes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (paciente == null)
            {
                return NotFound();
            }

            return View(paciente);
        }

        // POST: Pacientes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var paciente = await _context.Pacientes.FindAsync(id);
            _context.Pacientes.Remove(paciente);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(ListaPacientes));
        }

        private bool PacienteExists(int id)
        {
            return _context.Pacientes.Any(e => e.Id == id);
        }

        public async Task<IActionResult> Dados()
        {
            return View(await _context.Pacientes.ToListAsync());
        }

        public async Task<IActionResult> Alerta(int id) 
            => View(await _context.Pacientes.FirstOrDefaultAsync(x => x.Id == id));
           
    }
}
