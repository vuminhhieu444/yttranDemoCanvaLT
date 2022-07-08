using System;
using System.Collections.Generic;
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
    public class NewsController : Controller
    {
        private readonly YttranContext _context;

        public NewsController(YttranContext context)
        {
            _context = context;
        }

        // GET: Admin/News
        public async Task<IActionResult> Index()
        {
            if (string.IsNullOrEmpty(HttpContext.Session.GetString("Admin")))
            {
                return Redirect("/Admin/Login/Index");
            }
            return View(await _context.News.ToListAsync());
        }

        // GET: Admin/News/Details/5
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

            var news = await _context.News
                .FirstOrDefaultAsync(m => m.Id == id);
            if (news == null)
            {
                return NotFound();
            }

            return View(news);
        }

        // GET: Admin/News/Create
        public IActionResult Create()
        {
            if (string.IsNullOrEmpty(HttpContext.Session.GetString("Admin")))
            {
                return Redirect("/Admin/Login/Index");
            }
            return View();
        }

        // POST: Admin/News/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Title,AllContent,CreateDate,UpdateDate")] News news)
        {
            if (string.IsNullOrEmpty(HttpContext.Session.GetString("Admin")))
            {
                return Redirect("/Admin/Login/Index");
            }
            try
            {
                news.CreateDate = DateTime.Now;
                _context.Add(news);
                await _context.SaveChangesAsync();
                return Redirect("/Admin/News/Index");
            }
            catch (Exception e)
            {

                return View(news);
                throw;
            }
        }

        // GET: Admin/News/Edit/5
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

            var news = await _context.News.FindAsync(id);
            if (news == null)
            {
                return NotFound();
            }
            return View(news);
        }

        // POST: Admin/News/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Title,AllContent,CreateDate,UpdateDate")] News news)
        {
            if (string.IsNullOrEmpty(HttpContext.Session.GetString("Admin")))
            {
                return Redirect("/Admin/Login/Index");
            }
            if (id != news.Id)
            {
                return NotFound();
            }

            try
            {
                var model = _context.News.Find(id);
                model.AllContent = news.AllContent;
                model.Title = news.Title;
                model.UpdateDate = DateTime.Now;
                _context.Update(model);
                await _context.SaveChangesAsync();
                return Redirect("/Admin/News/Index");
            }
            catch (Exception e)
            {

                return View(news);
                throw;
            }
        }

        // GET: Admin/News/Delete/5
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

            var news = await _context.News
                .FirstOrDefaultAsync(m => m.Id == id);
            if (news == null)
            {
                return NotFound();
            }

            return View(news);
        }

        // POST: Admin/News/Delete/5
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
                var news = await _context.News.FindAsync(id);
                _context.News.Remove(news);
                await _context.SaveChangesAsync();
                return Redirect("/Admin/News/Index");
            }
            catch (Exception e)
            {
                return Redirect("/Admin/News/Delete/" + id);
                throw;
            }
        }

        private bool NewsExists(int id)
        {
            return _context.News.Any(e => e.Id == id);
        }
    }
}
