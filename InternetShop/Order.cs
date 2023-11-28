using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternetShop
{
    public class Order
    {
        public int Id { get; set; }
        private string Date;
        public int ProductId {  get; }
        public int CustomerId { get; }
        
        public Order(int id, string date, Product product, Customer customer )
        {
            Id = id;
            Date = date;
            ProductId = product.Id;
            CustomerId = customer.Id;
        }
    }
}
