using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternetShop
{
    public class DBContext
    {
        public List<Category> Categories { get; }
        public List<Manufacturer> Manufacturers { get; }
        public List<Product> Products { get; }
        public List<Order> Orders { get; }
        public List<Customer> Customers { get; }
        public DBContext()
        {
            Categories = new List<Category>();
            Manufacturers = new List<Manufacturer>();
            Products = new List<Product>();
            Orders = new List<Order>();
            Customers = new List<Customer>();
        }
     
    }
}
