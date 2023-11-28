using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternetShop
{
    public class Manufacturer
    {
        public int Id { get; set; }
        private string Title;

        public Manufacturer(int id, string title)
        {
            Id = id;
            Title = title;          
        }
    }
}
