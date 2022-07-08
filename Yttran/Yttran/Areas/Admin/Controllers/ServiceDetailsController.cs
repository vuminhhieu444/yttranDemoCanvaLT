using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Yttran.Models;

namespace Yttran.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ServiceDetailsController : Controller
    {
        private readonly YttranContext _context;

        public ServiceDetailsController(YttranContext context)
        {
            _context = context;
        }

        // GET: Admin/ServiceDetails
        public async Task<IActionResult> Index()
        {
            var yttranContext = _context.ServiceDetails.Include(s => s.Menu);
            return View(await yttranContext.ToListAsync());
        }

        // GET: Admin/ServiceDetails/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var serviceDetail = await _context.ServiceDetails
                .Include(s => s.Menu)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (serviceDetail == null)
            {
                return NotFound();
            }

            return View(serviceDetail);
        }

        // GET: Admin/ServiceDetails/Create
        public IActionResult Create()
        {
            ViewData["MenuId"] = new SelectList(_context.Menus, "Id", "Id");
            ViewBag.Menus = _context.Menus.ToList();
            return View();
        }

        // POST: Admin/ServiceDetails/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,MenuId,Detail")] ServiceDetail serviceDetail)
        {
            try
            {
                _context.Add(serviceDetail);
                await _context.SaveChangesAsync();
                return Redirect("/Admin/ServiceDetails/Index");
            }
            catch (Exception e)
            {

                ViewData["MenuId"] = new SelectList(_context.Menus, "Id", "Id", serviceDetail.MenuId);
                return View(serviceDetail);
                throw;
            }
        }

        // GET: Admin/ServiceDetails/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var serviceDetail = await _context.ServiceDetails.FindAsync(id);
            if (serviceDetail == null)
            {
                return NotFound();
            }
            ViewData["MenuId"] = new SelectList(_context.Menus, "Id", "Id", serviceDetail.MenuId);
            ViewBag.Menus = _context.Menus.ToList();
            return View(serviceDetail);
        }

        // POST: Admin/ServiceDetails/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,MenuId,Detail")] ServiceDetail serviceDetail)
        {
            if (id != serviceDetail.Id)
            {
                return NotFound();
            }

            try
            {
                var model = _context.ServiceDetails.Find(id);
                model.Detail = serviceDetail.Detail;
                model.MenuId = serviceDetail.MenuId;
                _context.Update(model);
                await _context.SaveChangesAsync();
                return Redirect("/Admin/ServiceDetails/Index");
            }
            catch (DbUpdateConcurrencyException)
            {

                ViewData["MenuId"] = new SelectList(_context.Menus, "Id", "Id", serviceDetail.MenuId);
                return View(serviceDetail);
                throw;
            }
        }

        // GET: Admin/ServiceDetails/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var serviceDetail = await _context.ServiceDetails
                .Include(s => s.Menu)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (serviceDetail == null)
            {
                return NotFound();
            }

            return View(serviceDetail);
        }

        // POST: Admin/ServiceDetails/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            try
            {
                var serviceDetail = await _context.ServiceDetails.FindAsync(id);
                _context.ServiceDetails.Remove(serviceDetail);
                await _context.SaveChangesAsync();
                return Redirect("/Admin/ServiceDetails/Index");
            }
            catch (Exception e)
            {
                return Redirect("/Admin/ServiceDetails/Delete/" + id);
                throw;
            }
        }

        private bool ServiceDetailExists(int id)
        {
            return _context.ServiceDetails.Any(e => e.Id == id);
        }
    }
}
