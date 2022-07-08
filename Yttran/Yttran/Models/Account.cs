using System;
using System.Collections.Generic;

#nullable disable

namespace Yttran.Models
{
    public partial class Account
    {
        public int Id { get; set; }
        public string UsrerName { get; set; }
        public string Password { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
    }
}
