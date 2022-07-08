using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Yttran.Models;

namespace Yttran.ViewModels
{
    public class MenuItem
    {
        public List<SubMenu> Items { get; set; }
        public int MenuId{ get; set; }
        public string MenuName { get; set; }
    }
}
