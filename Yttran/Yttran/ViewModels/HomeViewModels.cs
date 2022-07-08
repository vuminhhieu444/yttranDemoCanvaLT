using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Yttran.Models;

namespace Yttran.ViewModels
{
    public class HomeViewModels
    {
        public string Banner1 { get; set; }
        public string Banner2 { get; set; }
        public List<MenuItem> Menus { get; set; }
        public List<Contact> Contacts { get; set; }
    }
}
