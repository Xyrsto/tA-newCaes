using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using tA_Caes.Data;
using tA_Caes.Models;

namespace tA_Caes.Controllers
{
    public class AnimaisController : Controller
    {
        private readonly ApplicationDbContext _bd;

        public AnimaisController(ApplicationDbContext context)
        {
            _bd = context;
        }

        // GET: Animais
        public async Task<IActionResult> Index()
        {
            var listaAnimais = _bd.Animais.Include(a => a.criador).Include(a => a.raca);
            return View(await listaAnimais.ToListAsync());
        }

        // GET: Animais/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _bd.Animais == null)
            {
                return NotFound();
            }

            var animal = await _bd.Animais
                .Include(a => a.criador)
                .Include(a => a.raca)
                .FirstOrDefaultAsync(m => m.id == id);
            if (animal == null)
            {
                return NotFound();
            }

            return View(animal);
        }

        // GET: Animais/Create
        public IActionResult Create()
        {
            ViewData["criadorFK"] = new SelectList(_bd.Criadores, "id", "nome");
            ViewData["racaFK"] = new SelectList(_bd.Racas, "id", "nome");
            return View();
        }

        // POST: Animais/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,nome,dataNascimento,dataCompra,sexo,numLOP,criadorFK,racaFK")] Animais animal)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _bd.Add(animal);
                    await _bd.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
                catch (Exception)
                {
                    ModelState.AddModelError("", "Ocorreu um erro");
                    throw;
                }

                
            }
            ViewData["criadorFK"] = new SelectList(_bd.Criadores, "id", "nome", animal.criadorFK);
            ViewData["racaFK"] = new SelectList(_bd.Racas, "id", "nome", animal.racaFK);
            return View(animal);
        }

        // GET: Animais/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _bd.Animais == null)
            {
                return NotFound();
            }

            var animais = await _bd.Animais.FindAsync(id);
            if (animais == null)
            {
                return NotFound();
            }
            ViewData["criadorFK"] = new SelectList(_bd.Criadores, "id", "codPostal", animais.criadorFK);
            ViewData["racaFK"] = new SelectList(_bd.Racas, "id", "id", animais.racaFK);
            return View(animais);
        }

        // POST: Animais/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id,nome,dataNascimento,dataCompra,sexo,numLOP,criadorFK,racaFK")] Animais animais)
        {
            if (id != animais.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _bd.Update(animais);
                    await _bd.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AnimaisExists(animais.id))
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
            ViewData["criadorFK"] = new SelectList(_bd.Criadores, "id", "codPostal", animais.criadorFK);
            ViewData["racaFK"] = new SelectList(_bd.Racas, "id", "id", animais.racaFK);
            return View(animais);
        }

        // GET: Animais/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _bd.Animais == null)
            {
                return NotFound();
            }

            var animais = await _bd.Animais
                .Include(a => a.criador)
                .Include(a => a.raca)
                .FirstOrDefaultAsync(m => m.id == id);
            if (animais == null)
            {
                return NotFound();
            }

            return View(animais);
        }

        // POST: Animais/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_bd.Animais == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Animais'  is null.");
            }
            var animais = await _bd.Animais.FindAsync(id);
            if (animais != null)
            {
                _bd.Animais.Remove(animais);
            }
            
            await _bd.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AnimaisExists(int id)
        {
          return _bd.Animais.Any(e => e.id == id);
        }
    }
}
