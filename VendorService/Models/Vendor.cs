using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VendorService.Models
{
    public class Vendor
    {
        public int VendorId { get; set; }
        public string VendorName { get; set; }
        public int ProdId { get; set; }
        public string ProdName { get; set; }
    }
}
