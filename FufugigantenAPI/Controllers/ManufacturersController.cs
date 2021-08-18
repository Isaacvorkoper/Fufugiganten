using Microsoft.AspNetCore.Http;
using FufugigantenORM;
using FufugigantenModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FufugigantenAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ManufacturersController : ControllerBase
    {
        private readonly ORM_MsSql ORM;

        public ManufacturersController()
        {
            ORM = new ORM_MsSql();
        }

        // Get Manufacturers by id
        [HttpGet("{id}")]
        public ActionResult<Manufacturer> Get(int id)
        {
            Manufacturer manufacturer;

            try
            {
                manufacturer = ORM.GetManufacturer(id);
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Something went wrong" + ex.Message);
            }

            if (manufacturer == null) return NotFound();

            // 200 ok 
            return manufacturer;
        }
        [HttpGet]
        public ActionResult<IEnumerable<Manufacturer>> Get()
        {
            List<Manufacturer> manufacturers = new();

            try
            {
                manufacturers = ORM.GetManufacturers();
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Something went wrong" + ex.Message);
            }

            if(manufacturers.Count < 1) return NotFound();

            return manufacturers;
        }

        [HttpPost]
        public ActionResult<Manufacturer> Post([FromBody] Manufacturer manufacturer)
        {
            ORM.CreateManufacturer(manufacturer);
            return manufacturer;
        }
    }
}
