using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternetShop
{
    public class Category: IComparable<Category>
    {
        public int Id { get; set; }
        private string Title;
        public Category(string title)
        {
            Id = 0;
            Title = title;
        }
        public string GetTitle() { return Title; }
        public void SetTitle(string title) {  Title = title; }
        public void ShowCategory()
        {
            Console.WriteLine("ID: {0}\t Title: {1}", Id, Title);
        }
        public int CompareTo(Category? other)
        {
            if (Id < other?.Id) return -1;
            if (Id > other?.Id) return 1;
            return 0;
            
        }

    }
}
