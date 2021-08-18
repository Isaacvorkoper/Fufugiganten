using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace FufugigantenModels
{
    public class Manufacturer
    {
        public int ManufacturerId { get; set; }

        public string Name { get; set; }

        // Constructor, takes name
        [JsonConstructor]
        public Manufacturer(string name)
        {
            Name = name;
        }

        // Constructor overload, takes id, name
        public Manufacturer(int manufacturerid, string name)
        {
            ManufacturerId = manufacturerid;

            Name = name;

        }

        public void SetId(int id)
        {
            ManufacturerId = id;
        }
    }
}
