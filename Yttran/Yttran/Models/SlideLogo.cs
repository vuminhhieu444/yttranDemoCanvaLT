using System;
using System.Collections.Generic;

#nullable disable

namespace Yttran.Models
{
    public partial class SlideLogo
    {
        public int Id { get; set; }
        public string SlidePath { get; set; }
        public string LogoPath { get; set; }
        public DateTime? UpdateDate { get; set; }
        public DateTime? CreateDate { get; set; }
    }
}
