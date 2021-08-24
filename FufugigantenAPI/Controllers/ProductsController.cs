using FufugigantenORM;
using FufugigantenModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FufugigantenAPI.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : Controller
    {
        private readonly ORM_MsSql ORM;

        public ProductsController()
        {
            ORM = new ORM_MsSql();
        }

        // Get all manufacturers
        [AllowAnonymous]
        [HttpGet]
        public ActionResult<IEnumerable<Product>> Get()
        {
            List<Product> products = new();

            try
            {
                products = ORM.GetProducts();
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Something went wrong" + ex.Message);
            }

            if (products.Count < 1) return NotFound();

            return products;
        }
    }
}
