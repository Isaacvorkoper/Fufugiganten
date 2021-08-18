using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FufugigantenModels
{
    public class ProductType
    {

        public int ProductTypeId { get; set; }

        public string Type { get; set; }

        // Constructor, takes name
        public ProductType(string type)
        {
            Type = type;
        }

        // Constructor overload, takes id, name
        public ProductType(int productTypeId, string type)
        {
            ProductTypeId = productTypeId;
            Type = type;
        }
    }
}
