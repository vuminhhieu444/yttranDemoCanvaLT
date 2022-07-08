using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Yttran.Models;

namespace Yttran.Controllers
{
    public class SlideLogoesController : Controller
    {
        private readonly YttranContext _context;

        public SlideLogoesController(YttranContext context)
        {
            _context = context;
        }

        // GET: SlideLogoes
        public async Task<IActionResult> Index()
        {
            return View(await _context.SlideLogos.ToListAsync());
        }

        // GET: SlideLogoes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var slideLogo = await _context.SlideLogos
                .FirstOrDefaultAsync(m => m.Id == id);
            if (slideLogo == null)
            {
                return NotFound();
            }

            return View(slideLogo);
        }

        // GET: SlideLogoes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: SlideLogoes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,SlidePath,LogoPath,UpdateDate,CreateDate")] SlideLogo slideLogo)
        {
            if (ModelState.IsValid)
            {
                _context.Add(slideLogo);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(slideLogo);
        }

        // GET: SlideLogoes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var slideLogo = await _context.SlideLogos.FindAsync(id);
            if (slideLogo == null)
            {
                return NotFound();
            }
            return View(slideLogo);
        }

        // POST: SlideLogoes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,SlidePath,LogoPath,UpdateDate,CreateDate")] SlideLogo slideLogo)
        {
            if (id != slideLogo.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(slideLogo);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SlideLogoExists(slideLogo.Id))
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
            return View(slideLogo);
        }

        // GET: SlideLogoes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var slideLogo = await _context.SlideLogos
                .FirstOrDefaultAsync(m => m.Id == id);
            if (slideLogo == null)
            {
                return NotFound();
            }

            return View(slideLogo);
        }

        // POST: SlideLogoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var slideLogo = await _context.SlideLogos.FindAsync(id);
            _context.SlideLogos.Remove(slideLogo);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SlideLogoExists(int id)
        {
            return _context.SlideLogos.Any(e => e.Id == id);
        }
    }
}
