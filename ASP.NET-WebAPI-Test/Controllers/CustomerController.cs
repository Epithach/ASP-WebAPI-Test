using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ASP.NET_WebAPI_Test.Models;
using System.Web.Http;
using System.Net.Http;
using System.Net;

namespace ASP.NET_WebAPI_Test.Controllers
{
    public class CustomerController : ApiController
    {

        Customer[] Customers = new Customer[]
        {
            new Customer { Id = 1, FirstName = "Hinault", LastName = "Romaric", EMail = "hr@gmail.com"},
            new Customer { Id = 2, FirstName = "Thomas", LastName = "Perrin", EMail = "thomas@outlook.com"},
            new Customer { Id = 3, FirstName = "Allan", LastName = "Croft", EMail = "allan.croft@crt.com"},
            new Customer { Id = 3, FirstName = "Sahra", LastName = "Parker", EMail = "sahra@yahoo.com"},
        };

        public IEnumerable<Customer> GetAllCustomers()
        {
            return Customers;
        }

        public Customer GetCustomerById(int id)
        {
            var Customer = Customers.FirstOrDefault((c) => c.Id == id);
            if (Customer == null)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.NotFound));
            }
            return Customer;
        }
    }
}