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
    public class MenusController : Controller
    {
        private readonly YttranContext _context;

        public MenusController(YttranContext context)
        {
            _context = context;
        }

        // GET: Admin/Menus
        public async Task<IActionResult> Index()
        {
            if (string.IsNullOrEmpty(HttpContext.Session.GetString("Admin")))
            {
                return Redirect("/Admin/Login/Index");
            }
            return View(await _context.Menus.ToListAsync());
        }

        // GET: Admin/Menus/Details/5
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

            var menu = await _context.Menus
                .FirstOrDefaultAsync(m => m.Id == id);
            if (menu == null)
            {
                return NotFound();
            }

            return View(menu);
        }

        // GET: Admin/Menus/Create
        public IActionResult Create()
        {
            if (string.IsNullOrEmpty(HttpContext.Session.GetString("Admin")))
            {
                return Redirect("/Admin/Login/Index");
            }
            return View();
        }

        // POST: Admin/Menus/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,CreateDate,UpdateDate")] Menu menu)
        {
            if (string.IsNullOrEmpty(HttpContext.Session.GetString("Admin")))
            {
                return Redirect("/Admin/Login/Index");
            }
            try
            {
                menu.CreateDate = DateTime.Now;
                _context.Add(menu);
                await _context.SaveChangesAsync();
                return Redirect("/Admin/Menus/Index");
            }
            catch (Exception)
            {

                throw;
            }
            return View(menu);
        }

        // GET: Admin/Menus/Edit/5
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

            var menu = await _context.Menus.FindAsync(id);
            if (menu == null)
            {
                return NotFound();
            }
            return View(menu);
        }

        // POST: Admin/Menus/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,CreateDate,UpdateDate")] Menu menu)
        {
            if (string.IsNullOrEmpty(HttpContext.Session.GetString("Admin")))
            {
                return Redirect("/Admin/Login/Index");
            }
            if (id != menu.Id)
            {
                return NotFound();
            }

            try
            {
                var menuModel = _context.Menus.Find(id);
                menuModel.Name = menu.Name;
                menuModel.UpdateDate = DateTime.Now;
                _context.Update(menuModel);
                await _context.SaveChangesAsync();
                return Redirect("/Admin/Menus/Edit/"+id);
            }
            catch (DbUpdateConcurrencyException)
            {
                return View(menu);
            }
        }

        // GET: Admin/Menus/Delete/5
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

            var menu = await _context.Menus
                .FirstOrDefaultAsync(m => m.Id == id);
            if (menu == null)
            {
                return NotFound();
            }

            return View(menu);
        }

        // POST: Admin/Menus/Delete/5
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
                var menu = await _context.Menus.FindAsync(id);
                _context.Menus.Remove(menu);
                await _context.SaveChangesAsync();
                return Redirect("/Admin/Menus/Index");
            }
            catch (Exception e)
            {
                return Redirect("/Admin/Menus/Delete/" + id);
                throw;
            }
        }

        private bool MenuExists(int id)
        {
            return _context.Menus.Any(e => e.Id == id);
        }
    }
}
