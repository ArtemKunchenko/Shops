using InternetShop;
using Microsoft.VisualBasic;
using System.Collections.Generic;
namespace Shops
{
    public class Program
    {
        static void Main(string[] args)
        {
            DBContext rozetka = new DBContext();
            Service serviceRozetka = new Service(rozetka);

            serviceRozetka.AddCategory("Phone");
            serviceRozetka.AddCategory("Tablet");
            serviceRozetka.AddCategory("Laptop");
            serviceRozetka.ShowAllCategories();
            Console.WriteLine();
            //serviceRozetka.UpdateCategoryTitle("Phone", "Phones");
            //serviceRozetka.ShowAllCategories();
            //Console.WriteLine();
            //serviceRozetka.DeleteCategory(2);
            //serviceRozetka.ShowAllCategories();
            //Console.WriteLine();
            //serviceRozetka.AddCategory("Tablet");
            //serviceRozetka.ShowAllCategories();
            serviceRozetka.AddManufacturer("Apple");
            serviceRozetka.AddManufacturer("Samsung");
            serviceRozetka.AddManufacturer("Acer");
            serviceRozetka.ShowAllManufacturers();
            Console.WriteLine();
            serviceRozetka.AddCustomer("Jim", "095-950-99-55");
            serviceRozetka.AddCustomer("Katty", "066-660-66-66");
            serviceRozetka.AddCustomer("Mike", "050-500-50-50");
            serviceRozetka.ShowAllCustomers();
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}