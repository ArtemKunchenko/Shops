using static System.Runtime.InteropServices.JavaScript.JSType;

namespace InternetShop
{
    public class Product: IComparable<Product>
    {
        public int Id { get; set; }
        private string Title;
        private double Cost;
        public int CategoryId { get; }
        public int ManufacturerId {  get; }
        public Product( string title, double cost, Category category, Manufacturer manufacturer)
        {
            Id = 0;
            Title = title;
            Cost = cost;
            CategoryId=category.Id;
            ManufacturerId=manufacturer.Id;
        }
        public string GetTitle() { return Title; }
        public void SetTitle(string title) { Title = title; }
        public double GetCost() { return Cost; }
        public void SetCost(double cost) { Cost = cost; }

        public int CompareTo(Product? other)
        {
            if (Id < other?.Id) return -1;
            if (Id > other?.Id) return 1;
            return 0;
        }
    }
}