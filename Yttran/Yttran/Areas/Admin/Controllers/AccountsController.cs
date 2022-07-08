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
    public class AccountsController : Controller
    {
        private readonly YttranContext _context;

        public AccountsController(YttranContext context)
        {
            _context = context;
        }

        // GET: Admin/Accounts
        public async Task<IActionResult> Index()
        {
            if (string.IsNullOrEmpty(HttpContext.Session.GetString("Admin")))
            {
                return Redirect("/Admin/Login/Index");
            }
            return View(await _context.Accounts.ToListAsync());
        }

        // GET: Admin/Accounts/Details/5
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

            var account = await _context.Accounts
                .FirstOrDefaultAsync(m => m.Id == id);
            if (account == null)
            {
                return NotFound();
            }

            return View(account);
        }

        // GET: Admin/Accounts/Create
        public IActionResult Create()
        {
            if (string.IsNullOrEmpty(HttpContext.Session.GetString("Admin")))
            {
                return Redirect("/Admin/Login/Index");
            }
            return View();
        }

        // POST: Admin/Accounts/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,UsrerName,Password,CreateDate,UpdateDate")] Account account)
        {
            if (string.IsNullOrEmpty(HttpContext.Session.GetString("Admin")))
            {
                return Redirect("/Admin/Login/Index");
            }
            try
            {
                account.CreateDate = DateTime.Now;
                _context.Add(account);
                await _context.SaveChangesAsync();
                return Redirect("/Admin/Accounts/Index");
            }
            catch (Exception e)
            {

                return View(account);
                throw;
            }
        }

        // GET: Admin/Accounts/Edit/5
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

            var account = await _context.Accounts.FindAsync(id);
            if (account == null)
            {
                return NotFound();
            }
            return View(account);
        }

        // POST: Admin/Accounts/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,UsrerName,Password,CreateDate,UpdateDate")] Account account)
        {
            if (string.IsNullOrEmpty(HttpContext.Session.GetString("Admin")))
            {
                return Redirect("/Admin/Login/Index");
            }
            if (id != account.Id)
            {
                return NotFound();
            }
            try
            {
                var accountModel = _context.Accounts.Find(id);
                accountModel.UsrerName = account.UsrerName;
                accountModel.Password = account.Password;
                accountModel.UpdateDate = DateTime.Now;
                _context.Update(accountModel);
                await _context.SaveChangesAsync();
                return Redirect("/Admin/Accounts/Index");
            }
            catch (DbUpdateConcurrencyException)
            {
                return View(account);
                throw;
            }
        }

        // GET: Admin/Accounts/Delete/5
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

            var account = await _context.Accounts
                .FirstOrDefaultAsync(m => m.Id == id);
            if (account == null)
            {
                return NotFound();
            }

            return View(account);
        }

        // POST: Admin/Accounts/Delete/5
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
                var account = await _context.Accounts.FindAsync(id);
                _context.Accounts.Remove(account);
                await _context.SaveChangesAsync();
                return Redirect("/Admin/Menus/Index");
            }
            catch (Exception)
            {

                return Redirect("/Admin/Accounts/Delete/" + id);
                throw;
            }
        }

        private bool AccountExists(int id)
        {
            return _context.Accounts.Any(e => e.Id == id);
        }
    }
}
