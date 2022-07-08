using System;
using System.Collections.Generic;

#nullable disable

namespace Yttran.Models
{
    public partial class Contact
    {
        public int Id { get; set; }
        public string Phonenumber { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
    }
}
