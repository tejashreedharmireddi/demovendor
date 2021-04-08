using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VendorService.Repository;

namespace VendorService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VendorController : ControllerBase
    {
        private IVendorRepo _repo;
        public VendorController(IVendorRepo repo)
        {
            _repo = repo;
        }
        [HttpGet]
        public IActionResult SearchProduct(int prodid)
        {
            var result = _repo.SearchProduct(prodid);
            if (result == null)
            {
               
                return NotFound();
            }
            
            return Ok(result);
        }
    }
}
