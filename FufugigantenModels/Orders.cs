using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FufugigantenModels
{
    public class Orders
    {

        public int OrdersId { get; set; }
        public DateTime Date { get; set; }
        public string Address { get; set; }
        public Customer Customer { get; set; }

        // Constructor, takes name
        public Orders(DateTime date, string address, Customer customer)
        {
            Date = date;
            Address = address;
            Customer = customer;
        }

        // Constructor overload, takes id, name
        public Orders(int ordersId, DateTime date, string address, Customer customer)
        {
            OrdersId = ordersId;
            Date = date;
            Address = address;
            Customer = customer;
        }
    }
}
