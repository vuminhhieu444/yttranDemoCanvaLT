using System;
using System.Collections.Generic;

#nullable disable

namespace Yttran.Models
{
    public partial class SubMenu
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? MenuId { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }

        public virtual Menu Menu { get; set; }
    }
}
