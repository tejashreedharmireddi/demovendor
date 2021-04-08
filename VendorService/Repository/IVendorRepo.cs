using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VendorService.Models;

namespace VendorService.Repository
{
    public interface IVendorRepo
    {
        public Vendor SearchProduct(int prodid);
    }
}
