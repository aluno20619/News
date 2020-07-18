using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using News.Data;
using News.Models;

namespace News.Controllers
{
    public class NTsController : Controller
    {
        private readonly NewsDb _context;

        public NTsController(NewsDb context)
        {
            _context = context;
        }

        // GET: NTs
        public async Task<IActionResult> Index()
        {
            var newsDb = _context.NT.Include(n => n.Noticias).Include(n => n.Topicos);
            return View(await newsDb.ToListAsync());
        }

        // GET: NTs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nT = await _context.NT
                .Include(n => n.Noticias)
                .Include(n => n.Topicos)
                .FirstOrDefaultAsync(m => m.Topicosid == id);
            if (nT == null)
            {
                return NotFound();
            }

            return View(nT);
        }

        // GET: NTs/Create
        public IActionResult Create()
        {
            ViewData["Noticiasid"] = new SelectList(_context.Noticias, "Id", "Corpo");
            ViewData["Topicosid"] = new SelectList(_context.Topicos, "Id", "Id");
            return View();
        }

        // POST: NTs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Noticiasid,Topicosid")] NT nT)
        {
            if (ModelState.IsValid)
            {
                _context.Add(nT);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["Noticiasid"] = new SelectList(_context.Noticias, "Id", "Corpo", nT.Noticiasid);
            ViewData["Topicosid"] = new SelectList(_context.Topicos, "Id", "Id", nT.Topicosid);
            return View(nT);
        }

        // GET: NTs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nT = await _context.NT.FindAsync(id);
            if (nT == null)
            {
                return NotFound();
            }
            ViewData["Noticiasid"] = new SelectList(_context.Noticias, "Id", "Corpo", nT.Noticiasid);
            ViewData["Topicosid"] = new SelectList(_context.Topicos, "Id", "Id", nT.Topicosid);
            return View(nT);
        }

        // POST: NTs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Noticiasid,Topicosid")] NT nT)
        {
            if (id != nT.Topicosid)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(nT);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!NTExists(nT.Topicosid))
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
            ViewData["Noticiasid"] = new SelectList(_context.Noticias, "Id", "Corpo", nT.Noticiasid);
            ViewData["Topicosid"] = new SelectList(_context.Topicos, "Id", "Id", nT.Topicosid);
            return View(nT);
        }

        // GET: NTs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nT = await _context.NT
                .Include(n => n.Noticias)
                .Include(n => n.Topicos)
                .FirstOrDefaultAsync(m => m.Topicosid == id);
            if (nT == null)
            {
                return NotFound();
            }

            return View(nT);
        }

        // POST: NTs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var nT = await _context.NT.FindAsync(id);
            _context.NT.Remove(nT);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool NTExists(int id)
        {
            return _context.NT.Any(e => e.Topicosid == id);
        }
    }
}
