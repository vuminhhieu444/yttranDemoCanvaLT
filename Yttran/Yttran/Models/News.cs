using System;
using System.Collections.Generic;

#nullable disable

namespace Yttran.Models
{
    public partial class News
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string AllContent { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
    }
}
