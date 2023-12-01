using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace InternetShop
{
    public class Order: IComparable<Order>
    {
        public int Id { get; set; }
        private string Date;
        public int ProductId {  get; }
        public int CustomerId { get; }
        
        public Order( string date, Product product, Customer customer )
        {
            Id = 0;
            Date = date;
            ProductId = product.Id;
            CustomerId = customer.Id;
        }
        public string GetDate() { return Date; }       
        public void SetDate(string date) { Date = date; }

        public int CompareTo(Order? other)
        {
            if (Id < other?.Id) return -1;
            if (Id > other?.Id) return 1;
            return 0;
        }
    }
}
