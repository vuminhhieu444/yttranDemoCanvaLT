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
    public class SubMenusController : Controller
    {
        private readonly YttranContext _context;

        public SubMenusController(YttranContext context)
        {
            _context = context;
        }

        // GET: Admin/SubMenus
        public async Task<IActionResult> Index()
        {
            if (string.IsNullOrEmpty(HttpContext.Session.GetString("Admin")))
            {
                return Redirect("/Admin/Login/Index");
            }
            var yttranContext = _context.SubMenus.Include(s => s.Menu);
            return View(await yttranContext.ToListAsync());
        }

        // GET: Admin/SubMenus/Details/5
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

            var subMenu = await _context.SubMenus
                .Include(s => s.Menu)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (subMenu == null)
            {
                return NotFound();
            }

            return View(subMenu);
        }

        // GET: Admin/SubMenus/Create
        public IActionResult Create()
        {
            if (string.IsNullOrEmpty(HttpContext.Session.GetString("Admin")))
            {
                return Redirect("/Admin/Login/Index");
            }
            ViewData["MenuId"] = new SelectList(_context.Menus, "Id", "Id");
            ViewBag.Menus = _context.Menus.ToList();
            return View();
        }

        // POST: Admin/SubMenus/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,MenuId,CreateDate,UpdateDate")] SubMenu subMenu)
        {
            if (string.IsNullOrEmpty(HttpContext.Session.GetString("Admin")))
            {
                return Redirect("/Admin/Login/Index");
            }
            try
            {
                subMenu.CreateDate = DateTime.Now;
                _context.Add(subMenu);
                await _context.SaveChangesAsync();
                return Redirect("/Admin/SubMenus/Index");
            }
            catch (Exception e)
            {

                ViewData["MenuId"] = new SelectList(_context.Menus, "Id", "Id", subMenu.MenuId);
                ViewBag.Menus = _context.Menus.ToList();
                return View(subMenu);
                throw;
            }
        }

        // GET: Admin/SubMenus/Edit/5
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

            var subMenu = await _context.SubMenus.FindAsync(id);
            if (subMenu == null)
            {
                return NotFound();
            }
            ViewData["MenuId"] = new SelectList(_context.Menus, "Id", "Id", subMenu.MenuId);
            ViewBag.Menus = _context.Menus.ToList();
            return View(subMenu);
        }

        // POST: Admin/SubMenus/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,MenuId,CreateDate,UpdateDate")] SubMenu subMenu)
        {
            if (string.IsNullOrEmpty(HttpContext.Session.GetString("Admin")))
            {
                return Redirect("/Admin/Login/Index");
            }
            if (id != subMenu.Id)
            {
                return NotFound();
            }

            try
            {
                var model = _context.SubMenus.Find(id);
                model.UpdateDate = DateTime.Now;
                //model.Menu = subMenu.Menu;
                model.MenuId = subMenu.MenuId;
                model.Name = subMenu.Name;
                _context.Update(model);
                await _context.SaveChangesAsync();
                return Redirect("/Admin/SubMenus/Index");
            }
            catch (DbUpdateConcurrencyException)
            {

                ViewData["MenuId"] = new SelectList(_context.Menus, "Id", "Id", subMenu.MenuId);
                ViewBag.Menus = _context.Menus.ToList();
                return View(subMenu);
                throw;
            }
        }

        // GET: Admin/SubMenus/Delete/5
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

            var subMenu = await _context.SubMenus
                .Include(s => s.Menu)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (subMenu == null)
            {
                return NotFound();
            }

            return View(subMenu);
        }

        // POST: Admin/SubMenus/Delete/5
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
                var subMenu = await _context.SubMenus.FindAsync(id);
                _context.SubMenus.Remove(subMenu);
                await _context.SaveChangesAsync();
                return Redirect("/Admin/SubMenus/Index");
            }
            catch (Exception e)
            {
                return Redirect("/Admin/SubMenus/Delete/" + id);
                throw;
            }

        }

        private bool SubMenuExists(int id)
        {
            return _context.SubMenus.Any(e => e.Id == id);
        }
    }
}
