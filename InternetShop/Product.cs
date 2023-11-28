namespace InternetShop
{
    public class Product
    {
        public int Id { get; set; }
        private string Title;
        private double Cost;
        public int CategoryId { get; }
        public int ManufacturerId {  get; }
        public Product(int id, string title, double cost, Category category, Manufacturer manufacturer)
        {
            Id = id;
            Title = title;
            Cost = cost;
            CategoryId=category.Id;
            ManufacturerId=manufacturer.Id;
        }
    }
}