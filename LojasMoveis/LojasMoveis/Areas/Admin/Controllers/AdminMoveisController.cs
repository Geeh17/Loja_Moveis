using LojasMoveis.Context;
using LojasMoveis.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace LojasMoveis.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class AdminMoveisController : Controller
    {
        private readonly AppDbContext _context;

        public AdminMoveisController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Admin/AdminMoveiss
        public async Task<IActionResult> Index()
        {
            var appDbContext = _context.Moveis.Include(l => l.Categoria);
            return View(await appDbContext.ToListAsync());
        }

        // GET: Admin/AdminMoveis/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var movel = await _context.Moveis
                .Include(l => l.Categoria)
                .FirstOrDefaultAsync(m => m.MovelId == id);
            if (movel == null)
            {
                return NotFound();
            }

            return View(movel);
        }

        // GET: Admin/AdminMoveis/Create
        public IActionResult Create()
        {
            ViewData["CategoriaId"] = new SelectList(_context.Categorias, "CategoriaId", "CategoriaNome");
            return View();
        }

        // POST: Admin/AdminMoveis/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("MovelId,Nome,DescricaoCurta,DescricaoDetalhada,Preco,ImagemUrl,ImagemThumbnailUrl,IsMovelPreferido,EmEstoque,CategoriaId")] Movel movel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(movel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CategoriaId"] = new SelectList(_context.Categorias, "CategoriaId", "CategoriaNome", movel.CategoriaId);
            return View(movel);
        }

        // GET: Admin/AdminMoveis/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var movel = await _context.Moveis.FindAsync(id);
            if (movel == null)
            {
                return NotFound();
            }
            ViewData["CategoriaId"] = new SelectList(_context.Categorias, "CategoriaId", "CategoriaNome", movel.CategoriaId);
            return View(movel);
        }

        // POST: Admin/AdminMoveis/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("MovelId,Nome,DescricaoCurta,DescricaoDetalhada,Preco,ImagemUrl,ImagemThumbnailUrl,IsMovelPreferido,EmEstoque,CategoriaId")] Movel movel)
        {
            if (id != movel.MovelId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(movel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MovelExists(movel.MovelId))
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
            ViewData["CategoriaId"] = new SelectList(_context.Categorias, "CategoriaId", "CategoriaNome", movel.CategoriaId);
            return View(movel);
        }

        // GET: Admin/AdminMoveis/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var movel = await _context.Moveis
                .Include(l => l.Categoria)
                .FirstOrDefaultAsync(m => m.MovelId == id);
            if (movel == null)
            {
                return NotFound();
            }

            return View(movel);
        }

        // POST: Admin/AdminMoveis/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var movel = await _context.Moveis.FindAsync(id);
            _context.Moveis.Remove(movel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MovelExists(int id)
        {
            return _context.Moveis.Any(e => e.MovelId == id);
        }
    }
}
