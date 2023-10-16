using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CLINICA_ALPHAVILLE.Models;

namespace CLINICA_ALPHAVILLE.Controllers
{
    public class PacienteController : Controller
    {
        private readonly DATACLINICA _context;

        public PacienteController(DATACLINICA context)
        {
            _context = context;
        }

        // GET: Paciente
        public async Task<IActionResult> Index()
        {
            return View(await _context.ListaPacientes.ToListAsync());
        }

        // GET: Paciente/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var listaPaciente = await _context.ListaPacientes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (listaPaciente == null)
            {
                return NotFound();
            }

            return View(listaPaciente);
        }

        // GET: Paciente/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Paciente/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nome,Sexo,DataDeNascimento,Profissao,Estado,Cidade,Bairro,Cep,HorariosDisponiveis,NomeDoPai,NomeDaMae,Responsavel,Telefone,Celular,Observacao,Atendimento1,Atendimento2,Atendimento3,Atendimento4,Atendimento5")] ListaPaciente listaPaciente)
        {
            if (ModelState.IsValid)
            {
                _context.Add(listaPaciente);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(listaPaciente);
        }

        // GET: Paciente/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var listaPaciente = await _context.ListaPacientes.FindAsync(id);
            if (listaPaciente == null)
            {
                return NotFound();
            }
            return View(listaPaciente);
        }

        // POST: Paciente/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nome,Sexo,DataDeNascimento,Profissao,Estado,Cidade,Bairro,Cep,HorariosDisponiveis,NomeDoPai,NomeDaMae,Responsavel,Telefone,Celular,Observacao,Atendimento1,Atendimento2,Atendimento3,Atendimento4,Atendimento5")] ListaPaciente listaPaciente)
        {
            if (id != listaPaciente.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(listaPaciente);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ListaPacienteExists(listaPaciente.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(listaPaciente);
        }

        // GET: Paciente/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var listaPaciente = await _context.ListaPacientes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (listaPaciente == null)
            {
                return NotFound();
            }

            return View(listaPaciente);
        }

        // POST: Paciente/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var listaPaciente = await _context.ListaPacientes.FindAsync(id);
            _context.ListaPacientes.Remove(listaPaciente);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ListaPacienteExists(int id)
        {
            return _context.ListaPacientes.Any(e => e.Id == id);
        }
    }
}
