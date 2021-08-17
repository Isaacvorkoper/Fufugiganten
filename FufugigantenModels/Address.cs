using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace FufugigantenModels
{
    public class Address
    {
        public int AddressId { get; set; }

        public string Road { get; set; }

        public string Road_Num { get; set; }
        
        public int Zip { get; set; }

        public string Country { get; set; }

        // Constructor, takes name
        [JsonConstructor]
        public Address(string road, string road_num, int zip, string country)
        {
            Road = road;
            Road_Num = road_num;
            Zip = zip;
            Country = country;
        }

        // Constructor overload, takes id, name
        public Address(int addressid, string road, string road_num, int zip, string country)
        {
            AddressId = addressid;
            Road = road;
            Road_Num = road_num;
            Country = country;

        }
        public void SetId(int id)
        {
            AddressId = id;
        }
    }
}
