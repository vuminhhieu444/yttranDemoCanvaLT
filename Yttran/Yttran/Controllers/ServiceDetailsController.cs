using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Yttran.Models;
using Yttran.ViewModels;

namespace Yttran.Controllers
{
    public class ServiceDetailsController : Controller
    {
        private readonly YttranContext _context;

        public ServiceDetailsController(YttranContext context)
        {
            _context = context;
        }

        // GET: ServiceDetails
        public async Task<IActionResult> Index()
        {
            var yttranContext = _context.ServiceDetails.Include(s => s.Menu);
            return View(await yttranContext.ToListAsync());
        }

        // GET: ServiceDetails/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var service = _context.Menus.Find(id);
            var serviceDetail = await _context.ServiceDetails
                .Include(s => s.Menu)
                .FirstOrDefaultAsync(m => m.MenuId == id);
            var serviceDetailViewModel = new ServiceDetailsViewModel();
            serviceDetailViewModel.ServiceDetail = serviceDetail;
            serviceDetailViewModel.ServiceId = int.Parse(id.ToString());
            serviceDetailViewModel.ServiceName = service.Name;
            if (serviceDetail == null)
            {
                return NotFound();
            }

            return View(serviceDetailViewModel);
        }

        // GET: ServiceDetails/Create
        public IActionResult Create()
        {
            ViewData["MenuId"] = new SelectList(_context.Menus, "Id", "Id");
            return View();
        }

        // POST: ServiceDetails/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,MenuId,Detail")] ServiceDetail serviceDetail)
        {
            if (ModelState.IsValid)
            {
                _context.Add(serviceDetail);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["MenuId"] = new SelectList(_context.Menus, "Id", "Id", serviceDetail.MenuId);
            return View(serviceDetail);
        }

        // GET: ServiceDetails/Edit/5
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
            return View(serviceDetail);
        }

        // POST: ServiceDetails/Edit/5
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

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(serviceDetail);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ServiceDetailExists(serviceDetail.Id))
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
            ViewData["MenuId"] = new SelectList(_context.Menus, "Id", "Id", serviceDetail.MenuId);
            return View(serviceDetail);
        }

        // GET: ServiceDetails/Delete/5
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

        // POST: ServiceDetails/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var serviceDetail = await _context.ServiceDetails.FindAsync(id);
            _context.ServiceDetails.Remove(serviceDetail);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ServiceDetailExists(int id)
        {
            return _context.ServiceDetails.Any(e => e.Id == id);
        }
    }
}
