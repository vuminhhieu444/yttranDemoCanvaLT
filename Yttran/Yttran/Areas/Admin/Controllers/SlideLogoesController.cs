using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Yttran.Models;

namespace Yttran.Areas.Admin.Controllers
{
    [Area("Admin")]
    
    public class SlideLogoesController : Controller
    {
        private readonly YttranContext _context;
        const string slidePath = "wwwroot/User/Images";
        const string Logo = "wwwroot/User/Images";


        public SlideLogoesController(YttranContext context)
        {
            _context = context;
        }

        // GET: Admin/SlideLogoes
        public async Task<IActionResult> Index()
        {
            if (string.IsNullOrEmpty(HttpContext.Session.GetString("Admin")))
            {
                return Redirect("/Admin/Login/Index");
            }
            return View(await _context.SlideLogos.ToListAsync());
        }

        // GET: Admin/SlideLogoes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (string.IsNullOrEmpty(HttpContext.Session.GetString("Admin")))
            {
                return Redirect("/Admin/Login/Index");
            }
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

        // GET: Admin/SlideLogoes/Create
        public IActionResult Create()
        {
            if (string.IsNullOrEmpty(HttpContext.Session.GetString("Admin")))
            {
                return Redirect("/Admin/Login/Index");
            }
            return View();
        }

        // POST: Admin/SlideLogoes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(IFormFile SlidePath, IFormFile LogoPath)
        {
            if (string.IsNullOrEmpty(HttpContext.Session.GetString("Admin")))
            {
                return Redirect("/Admin/Login/Index");
            }
            if (LogoPath.Length <= 0 && LogoPath.Length <= 0)
            {
                return NotFound();
            }
            var slideLogo = new SlideLogo();
            try
            {
                if (SlidePath.Length > 0)
                {
                    var SlideFilePath = Path.Combine(slidePath, SlidePath.FileName);


                    using (var stream = System.IO.File.Create(SlideFilePath))
                    {
                        await SlidePath.CopyToAsync(stream);
                        slideLogo.SlidePath = "/User/Images/" + SlidePath.FileName;
                    }

                }
                if (LogoPath.Length > 0)
                {
                    var LogoFilePath = Path.Combine(Logo, LogoPath.FileName);
                    using (var stream = System.IO.File.Create(LogoFilePath))
                    {
                        await LogoPath.CopyToAsync(stream);
                        slideLogo.LogoPath = "/User/Images/" + LogoPath.FileName;
                    }
                }

                slideLogo.CreateDate = DateTime.Now;
                _context.Add(slideLogo);
                await _context.SaveChangesAsync();
                return Redirect("/Admin/SlideLogoes/Index");
            }
            catch (Exception e)
            {

                return View(slideLogo);
                throw;
            }
        }

        // GET: Admin/SlideLogoes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (string.IsNullOrEmpty(HttpContext.Session.GetString("Admin")))
            {
                return Redirect("/Admin/Login/Index");
            }
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

        // POST: Admin/SlideLogoes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, IFormFile SlidePath, IFormFile LogoPath)
        {
            if (string.IsNullOrEmpty(HttpContext.Session.GetString("Admin")))
            {
                return Redirect("/Admin/Login/Index");
            }
            var dataModel = _context.SlideLogos.Find(id);
            if (dataModel == null)
            {
                return NotFound();
            }
            if (LogoPath.Length <= 0 && LogoPath.Length <= 0)
            {
                return NotFound();
            }
            var slideLogo = new SlideLogo();
            try
            {

                if (SlidePath.Length > 0)
                {
                    var SlideFilePath = Path.Combine(slidePath, SlidePath.FileName);


                    using (var stream = System.IO.File.Create(SlideFilePath))
                    {
                        await SlidePath.CopyToAsync(stream);
                        slideLogo.SlidePath = "/User/Images/" + SlidePath.FileName;
                    }

                }
                if (LogoPath.Length > 0)
                {
                    var LogoFilePath = Path.Combine(Logo, LogoPath.FileName);
                    using (var stream = System.IO.File.Create(LogoFilePath))
                    {
                        await LogoPath.CopyToAsync(stream);
                        slideLogo.LogoPath = "/User/Images/" + LogoPath.FileName;
                    }
                }
                var model = _context.SlideLogos.Find(id);
                model.UpdateDate = DateTime.Now;
                model.LogoPath = slideLogo.LogoPath;
                model.SlidePath = slideLogo.SlidePath;
                _context.Update(model);
                await _context.SaveChangesAsync();
                return Redirect("/Admin/SlideLogoes/Index");
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
        }

        // GET: Admin/SlideLogoes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (string.IsNullOrEmpty(HttpContext.Session.GetString("Admin")))
            {
                return Redirect("/Admin/Login/Index");
            }
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

        // POST: Admin/SlideLogoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (string.IsNullOrEmpty(HttpContext.Session.GetString("Admin")))
            {
                return Redirect("/Admin/Login/Index");
            }
            try
            {
                var slideLogo = await _context.SlideLogos.FindAsync(id);
                _context.SlideLogos.Remove(slideLogo);
                await _context.SaveChangesAsync();
                return Redirect("/Admin/SlideLogoes/Index");
            }
            catch (Exception e)
            {
                return Redirect("/Admin/SlideLogoes/Delete/" + id);
                throw;
            }
        }

        private bool SlideLogoExists(int id)
        {
            return _context.SlideLogos.Any(e => e.Id == id);
        }
    }
}
