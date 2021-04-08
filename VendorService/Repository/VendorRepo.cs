using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VendorService.Models;

namespace VendorService.Repository
{
    public class VendorRepo : IVendorRepo
    {
        private readonly VendorDbContext _db;
       // List<Vendor> vendorslist = new List<Vendor>();
        public VendorRepo(VendorDbContext db)
        {
            _db = db;
        }
        public Vendor SearchProduct(int prodid)
        {
            Vendor finalvendor = _db.Vendor.FirstOrDefault(x => x.ProdId == prodid);
           
            return finalvendor;
        }
    }
}
