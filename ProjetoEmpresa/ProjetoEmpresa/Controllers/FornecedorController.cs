using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ProjetoEmpresa.Models;

namespace ProjetoEmpresa.Controllers
{
    public class FornecedorController : Controller
    {
        private readonly Contexto _context;

        public FornecedorController(Contexto context)
        {
            _context = context;
        }
        //public async Task<JsonResult> fornecedorpessoa(string pessoa)
        //{
        //    if (await _context.Fornecedores.AnyAsync(x => x.pessoa == "fisica"))
        //        return Json("Usuário deve inserir também data de nascimento e CPF.");
        //    return Json(true);
        //}

        // GET: Fornecedor
        public async Task<IActionResult> Index()
        {
            var contexto = _context.Fornecedores.Include(f => f.Empresa);
            return View(await contexto.ToListAsync());
        }
        [HttpPost]
        public async Task<IActionResult> Index(string txtPesquisar)
        {
            if (!String.IsNullOrEmpty(txtPesquisar))
            {
                return View(await _context.Fornecedores.Where(x => x.nome.ToUpper().Contains(txtPesquisar.ToUpper())).ToListAsync());
            }
            return View(await _context.Fornecedores.ToListAsync());
        }

        // GET: Fornecedor/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var fornecedor = await _context.Fornecedores
                .Include(f => f.Empresa)
                .FirstOrDefaultAsync(m => m.idfornecedor == id);
            if (fornecedor == null)
            {
                return NotFound();
            }

            return View(fornecedor);
        }

        // GET: Fornecedor/Create
        public IActionResult Create()
        {
            ViewData["empresaId"] = new SelectList(_context.Empresas, "empresaId", "nomeFantasia");
            return View();
        }

        // POST: Fornecedor/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("idfornecedor,empresaId,nome,pessoa,cpf_cnpj,rg,datahora,nascimento,telefone")] Fornecedor fornecedor)
        {
            if (ModelState.IsValid)
            {
                _context.Add(fornecedor);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["empresaId"] = new SelectList(_context.Empresas, "empresaId", "nomeFantasia", fornecedor.empresaId);
            return View(fornecedor);
        }

        // GET: Fornecedor/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var fornecedor = await _context.Fornecedores.FindAsync(id);
            if (fornecedor == null)
            {
                return NotFound();
            }
            ViewData["empresaId"] = new SelectList(_context.Empresas, "empresaId", "nomeFantasia", fornecedor.empresaId);
            return View(fornecedor);
        }

        // POST: Fornecedor/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("idfornecedor,empresaId,nome,pessoa,cpf_cnpj,rg,datahora,nascimento,telefone")] Fornecedor fornecedor)
        {
            if (id != fornecedor.idfornecedor)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(fornecedor);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FornecedorExists(fornecedor.idfornecedor))
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
            ViewData["empresaId"] = new SelectList(_context.Empresas, "empresaId", "nomeFantasia", fornecedor.empresaId);
            return View(fornecedor);
        }

        // GET: Fornecedor/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var fornecedor = await _context.Fornecedores
                .Include(f => f.Empresa)
                .FirstOrDefaultAsync(m => m.idfornecedor == id);
            if (fornecedor == null)
            {
                return NotFound();
            }

            return View(fornecedor);
        }

        // POST: Fornecedor/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var fornecedor = await _context.Fornecedores.FindAsync(id);
            _context.Fornecedores.Remove(fornecedor);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FornecedorExists(int id)
        {
            return _context.Fornecedores.Any(e => e.idfornecedor == id);
        }
    }
}
