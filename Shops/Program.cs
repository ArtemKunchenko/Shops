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

            serviceRozetka.AddCategory("Phones");
            serviceRozetka.AddCategory("Tablets");
            serviceRozetka.AddCategory("Laptops");
            Console.WriteLine("-----------------------ALL CATEGORIES-----------------------------");
            serviceRozetka.ShowAllCategories();
            Console.WriteLine("-----------------------ALL MANUFACTURERS--------------------------");
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
            Console.WriteLine("-----------------------ALL CUSTOMERS-----------------------------");
            serviceRozetka.AddCustomer("Jim", "095-950-99-55");
            serviceRozetka.AddCustomer("Katty", "066-660-66-66");
            serviceRozetka.AddCustomer("Mike", "050-500-50-50");
            serviceRozetka.ShowAllCustomers();
            Console.WriteLine("-----------------------ALL PRODUCTS------------------------------");
            serviceRozetka.AddProduct("IPhone 14 Pro", 1000, serviceRozetka.GetCategory("Phones"), serviceRozetka.GetManufacturer("Apple"));
            serviceRozetka.AddProduct("Galaxy tab s9", 900, serviceRozetka.GetCategory("Tablets"), serviceRozetka.GetManufacturer("Samsung"));
            serviceRozetka.AddProduct("Aspire 7", 800, serviceRozetka.GetCategory("Laptops"), serviceRozetka.GetManufacturer("Acer"));
            serviceRozetka.ShowAllProducts();
            Console.WriteLine("-----------------------ALL ORDERS--------------------------------");
            serviceRozetka.AddOrder("31.11.2023", serviceRozetka.GetProduct(1), serviceRozetka.GetCustomerUseName("Jim"));
            serviceRozetka.AddOrder("01.12.2023", serviceRozetka.GetProduct(2), serviceRozetka.GetCustomerUseName("Katty"));
            serviceRozetka.AddOrder("02.12.2023", serviceRozetka.GetProduct(3), serviceRozetka.GetCustomerUseName("Mike"));
            serviceRozetka.ShowAllOrders();

            Console.ReadKey();
        }
    }
}