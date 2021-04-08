using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VendorService.Models
{
        public class VendorDbContext : DbContext
        {
            public VendorDbContext(DbContextOptions<VendorDbContext> options) : base(options)
            {

            }
            public virtual DbSet<Vendor> Vendor { get; set; }
        }
    
}
