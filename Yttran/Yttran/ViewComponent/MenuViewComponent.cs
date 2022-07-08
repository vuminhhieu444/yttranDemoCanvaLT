using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Yttran.Models;
using Yttran.ViewModels;

namespace Yttran.Component
{
    public class MenuViewComponent : ViewComponent
    {
        private readonly YttranContext _context;

        public MenuViewComponent(YttranContext context) => _context = context;
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var homeViewModel = new HomeViewModels();
            homeViewModel.Menus = new List<MenuItem>();
            homeViewModel.Contacts = new List<Contact>();
            homeViewModel.Contacts = _context.Contacts.Take(3).ToList();
            var listMenu = _context.Menus.ToList();
            if (listMenu.Count > 0)
            {
                foreach (var item in listMenu)
                {
                    var menuItem = new MenuItem();
                    menuItem.MenuName = item.Name;
                    menuItem.MenuId = item.Id;
                    var subMenuList = _context.SubMenus.Where(m => m.MenuId == item.Id).ToList();
                    menuItem.Items = new List<SubMenu>();
                    if (subMenuList.Count > 0)
                    {
                        //menuItem.Items = new List<SubMenu>();
                        foreach (var el in subMenuList)
                        {
                            menuItem.Items.Add(el);
                        }
                    }
                    homeViewModel.Menus.Add(menuItem);
                }
            }
            return View(homeViewModel);

        }
    }
}
