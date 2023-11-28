using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternetShop
{
    public class Category
    {
        public int Id { get; set; }
        private string Title { get; set; }
        public Category(int id, string title) 
        {
            Id = id;
            Title = title;
        }
    }
}
