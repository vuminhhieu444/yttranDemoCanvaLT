using System;
using System.Collections.Generic;

#nullable disable

namespace Yttran.Models
{
    public partial class Menu
    {
        public Menu()
        {
            ServiceDetails = new HashSet<ServiceDetail>();
            SubMenus = new HashSet<SubMenu>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }

        public virtual ICollection<ServiceDetail> ServiceDetails { get; set; }
        public virtual ICollection<SubMenu> SubMenus { get; set; }
    }
}
