using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Yttran.Models;

namespace Yttran.ViewModels
{
    public class ServiceDetailsViewModel
    {
        public ServiceDetail ServiceDetail { get; set; }
        public string ServiceName { get; set; }
        public int ServiceId { get; set; }
    }
}
