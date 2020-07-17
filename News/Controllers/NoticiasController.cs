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
    public class NoticiasController : Controller
    {
        private readonly NewsDb bd;

        public NoticiasController(NewsDb context)
        {
            bd = context;
        }

        // GET: Noticias
        public async Task<IActionResult> Index()
        {
            var newsDb = bd.Noticias.Include(n => n.Utilizadoresid);
            return View(await newsDb.ToListAsync());
        }

        // GET: Noticias/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index");
            }
           
            var noticia = await bd.Noticias
                .Include(n => n.Utilizadoresid)
                //.Include(n => n.ListaNI)
                //.Include(n => n.ListaNT)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (noticia == null)
            {
                return RedirectToAction("Index");
            }

            return View(noticia);
        }

        // GET: Noticias/Create
        public IActionResult Create()
        {
            ViewData["UtilizadoresidFK"] = new SelectList(bd.Utilizadores, "Id", "Id");
            return View();
        }

        // POST: Noticias/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Titulo,Resumo,Corpo,Data_De_Publicacao,Visivel,UtilizadoresidFK")] Noticias noticia)
        {
            if (ModelState.IsValid)
            {
                bd.Add(noticia);
                await bd.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["UtilizadoresidFK"] = new SelectList(bd.Utilizadores, "Id", "Id", noticia.UtilizadoresidFK);
            return View(noticia);
        }

        // GET: Noticias/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var noticia = await bd.Noticias.FindAsync(id);
            if (noticia == null)
            {
                return NotFound();
            }
            ViewData["UtilizadoresidFK"] = new SelectList(bd.Utilizadores, "Id", "Id", noticia.UtilizadoresidFK);
            return View(noticia);
        }

        // POST: Noticias/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Titulo,Resumo,Corpo,Data_De_Publicacao,Visivel,UtilizadoresidFK")] Noticias noticia)
        {
            if (id != noticia.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    bd.Update(noticia);
                    await bd.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!NoticiasExists(noticia.Id))
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
            ViewData["UtilizadoresidFK"] = new SelectList(bd.Utilizadores, "Id", "Id", noticia.UtilizadoresidFK);
            return View(noticia);
        }

        // GET: Noticias/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var noticia = await bd.Noticias
                .Include(n => n.Utilizadoresid)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (noticia == null)
            {
                return NotFound();
            }

            return View(noticia);
        }

        // POST: Noticias/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var noticias = await bd.Noticias.FindAsync(id);
            bd.Noticias.Remove(noticias);
            await bd.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool NoticiasExists(int id)
        {
            return bd.Noticias.Any(e => e.Id == id);
        }
    }
}
