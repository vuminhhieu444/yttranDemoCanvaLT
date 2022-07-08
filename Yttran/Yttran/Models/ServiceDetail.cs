using System;
using System.Collections.Generic;

#nullable disable

namespace Yttran.Models
{
    public partial class ServiceDetail
    {
        public int Id { get; set; }
        public int? MenuId { get; set; }
        public string Detail { get; set; }

        public virtual Menu Menu { get; set; }
    }
}
