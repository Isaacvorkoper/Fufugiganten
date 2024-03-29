﻿using Microsoft.AspNetCore.Http;
using FufugigantenORM;
using FufugigantenModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;

namespace FufugigantenAPI.Controllers
{
    [Authorize]
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
        [AllowAnonymous]
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
        // Get all manufacturers
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

            if (manufacturers.Count < 1) return NotFound();

            return manufacturers;
        }
        // Create new manufacturers
        [AllowAnonymous]
        [HttpPost]
        public ActionResult<Manufacturer> Post([FromBody] Manufacturer manufacturer)
        {
            ORM.CreateManufacturer(manufacturer);
            return manufacturer;
        }
        // Update a manufacturer
        [AllowAnonymous]
        [HttpPut]
        public ActionResult<Manufacturer> Put([FromBody] Manufacturer manufacturer)
        {
            ORM.UpdateManufacturer(manufacturer);
            return manufacturer;
        }

        // Delete a manufacturer
        [AllowAnonymous]
        [HttpDelete]
        public ActionResult<Manufacturer> Delete([FromBody] Manufacturer manufacturer)
        {
            ORM.DeleteManufacturer(manufacturer);
            return manufacturer;
        }
    }
}
