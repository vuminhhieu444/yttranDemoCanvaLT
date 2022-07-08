using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Yttran.Models;
using Yttran.ViewModels;

namespace Yttran.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly YttranContext _context;

        public HomeController(ILogger<HomeController> logger, YttranContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            var homeViewModels = new HomeViewModels();
            homeViewModels.Banner1= _context.SlideLogos.FirstOrDefault().SlidePath;
            homeViewModels.Banner2 = _context.SlideLogos.Skip(1).FirstOrDefault().SlidePath;
            //homeViewModels.Menus = _context.Menus.ToList();
            return View(homeViewModels);
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Service()
        {
            return View();
        }
        public IActionResult Blogs()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
