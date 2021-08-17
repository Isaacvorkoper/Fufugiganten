using System;
using System.Collections.Generic;

namespace FufugigantenModels
{
    public class Customer
    {
        public int CustomerId { get; set; }

        public string FName { get; set; }

        public string LName { get; set; }

        public string Email { get; set; }

        public string PhoneNr { get; set; }

        public List<Orders> Orders { get; set; }

        public Address Address { get; set; }

        // Constructor, takes name
        public Customer(string fname, string lname, string email, string phonenr, List<Orders> orders, Address address)
        {
            FName = fname;

            LName = lname;

            Email = email;

            PhoneNr = phonenr;

            Orders = orders;

            Address = address;
        }

        // Constructor overload, takes id, name
        public Customer(int customerid, string fname, string lname, string email, string phonenr, List<Orders> orders, Address address)
        {
            CustomerId = customerid;

            FName = fname;

            LName = lname;

            Email = email;

            PhoneNr = phonenr;

            Orders = orders;

            Address = address;
        }
    }
}
