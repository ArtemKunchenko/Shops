using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace InternetShop
{
    public class Service
    {
        private DBContext DataBase;
        public Service(DBContext dataBase) { DataBase = dataBase; }

        #region METHODS FOR CATEGORY LIST
        public void SortCategory()
        {
            DataBase.Categories.Sort();
        }
        public void AddCategory(string title)
        {
            Category category = new Category(title);
            if (DataBase.Categories.Count == 0) category.Id = 1;
            else category.Id = DataBase.Categories[DataBase.Categories.Count - 1].Id + 1;
            DataBase.Categories.Add(category);
            DataBase.Categories.Sort();
        }
        public void ShowCategory(int id)
        {
            int index = -1;
            foreach (Category category in DataBase.Categories)
            {
                if (category.Id == id) { index = DataBase.Categories.IndexOf(category); break; }

            }
            if (index != -1) DataBase.Categories[index].ShowCategory();
            else Console.WriteLine("Category with current ID isn't exist!");
        }
        public void ShowCategory(string title)
        {
            int index = -1;
            foreach (Category category in DataBase.Categories)
            {
                if (category.GetTitle() == title) { index = DataBase.Categories.IndexOf(category); break; }

            }
            if (index != -1) DataBase.Categories[index].ShowCategory();
            else Console.WriteLine("Category with current title isn't exist!");
        }
        public void ShowAllCategories()
        {
            foreach (Category category in DataBase.Categories)
            {
                category.ShowCategory();
            }
        }
        public Category GetCategory(int id)
        {
            int index = -1;
            foreach (Category category in DataBase.Categories)
            {
                if (category.Id == id) { index = DataBase.Categories.IndexOf(category); break; }

            }
            if (index != -1) return DataBase.Categories[index];
            else return null;
        }
        public Category GetCategory(string title)
        {
            int index = -1;
            foreach (Category category in DataBase.Categories)
            {
                if (category.GetTitle() == title) { index = DataBase.Categories.IndexOf(category); break; }

            }
            if (index != -1) return DataBase.Categories[index];
            else return null;
        }
        public void UpdateCategoryTitle(int id, string newTitle)
        {
            int index = -1;
            foreach (Category category in DataBase.Categories)
            {
                if (category.Id == id) { index = DataBase.Categories.IndexOf(category); break; }

            }
            if (index != -1) { DataBase.Categories[index].SetTitle(newTitle); }
            else Console.WriteLine("Category with current ID isn't exist!");

        }
        public void UpdateCategoryTitle(string oldTitle, string newTitle)
        {
            int index = -1;
            foreach (Category category in DataBase.Categories)
            {
                if (category.GetTitle() == oldTitle) { index = DataBase.Categories.IndexOf(category); break; }

            }
            if (index != -1) { DataBase.Categories[index].SetTitle(newTitle); }
            else Console.WriteLine("Category with current title isn't exist!");

        }
        public void DeleteCategory(int id)
        {
            int index = -1;
            foreach (Category category in DataBase.Categories)
            {
                if (category.Id == id) { index = DataBase.Categories.IndexOf(category); break; }

            }
            if (index != -1) { DataBase.Categories.Remove(DataBase.Categories[index]); }
            else Console.WriteLine("Category with current ID isn't exist!");

        }
        public void DeleteCategory(string title)
        {
            int index = -1;
            foreach (Category category in DataBase.Categories)
            {
                if (category.GetTitle() == title) { index = DataBase.Categories.IndexOf(category); break; }

            }
            if (index != -1) { DataBase.Categories.Remove(DataBase.Categories[index]); }
            else Console.WriteLine("Category with current title isn't exist!");

        }
        public void ClearCategoryList() { DataBase.Categories.Clear(); }
        #endregion

        #region METHODS FOR MANUFACTURER LIST
        public void SortManufacturer()
        {
            DataBase.Manufacturers.Sort();
        }
        public void AddManufacturer(string title)
        {
            Manufacturer manufacturer = new Manufacturer(title);
            if (DataBase.Manufacturers.Count == 0) manufacturer.Id = 1;
            else manufacturer.Id = DataBase.Manufacturers[DataBase.Manufacturers.Count - 1].Id + 1;
            DataBase.Manufacturers.Add(manufacturer);
            DataBase.Manufacturers.Sort();
        }
        public void ShowManufacturer(int id)
        {
            int index = -1;
            foreach (Manufacturer manufacturer in DataBase.Manufacturers)
            {
                if (manufacturer.Id == id) { index = DataBase.Manufacturers.IndexOf(manufacturer); break; }

            }
            if (index != -1) DataBase.Manufacturers[index].ShowManufacturer();
            else Console.WriteLine("Manufacturer with current ID isn't exist!");
        }
        public void ShowManufacturer(string title)
        {
            int index = -1;
            foreach (Manufacturer manufacturer in DataBase.Manufacturers)
            {
                if (manufacturer.GetTitle() == title) { index = DataBase.Manufacturers.IndexOf(manufacturer); break; }

            }
            if (index != -1) DataBase.Manufacturers[index].ShowManufacturer();
            else Console.WriteLine("Manufacturer with current title isn't exist!");
        }
        public void ShowAllManufacturers()
        {
            foreach (Manufacturer manufacturer in DataBase.Manufacturers)
            {
                manufacturer.ShowManufacturer();
            }
        }
        public Manufacturer GetManufacturer(int id)
        {
            int index = -1;
            foreach (Manufacturer manufacturer in DataBase.Manufacturers)
            {
                if (manufacturer.Id == id) { index = DataBase.Manufacturers.IndexOf(manufacturer); break; }

            }
            if (index != -1) return DataBase.Manufacturers[index];
            else return null;
        }
        public Manufacturer GetManufacturer(string title)
        {
            int index = -1;
            foreach (Manufacturer manufacturer in DataBase.Manufacturers)
            {
                if (manufacturer.GetTitle() == title) { index = DataBase.Manufacturers.IndexOf(manufacturer); break; }

            }
            if (index != -1) return DataBase.Manufacturers[index];
            else return null;
        }
        public void UpdateManufacturerTitle(int id, string newTitle)
        {
            int index = -1;
            foreach (Manufacturer manufacturer in DataBase.Manufacturers)
            {
                if (manufacturer.Id == id) { index = DataBase.Manufacturers.IndexOf(manufacturer); break; }

            }
            if (index != -1) { DataBase.Manufacturers[index].SetTitle(newTitle); }
            else Console.WriteLine("Manufacturer with current ID isn't exist!");

        }
        public void UpdateManufacturerTitle(string oldTitle, string newTitle)
        {
            int index = -1;
            foreach (Manufacturer manufacturer in DataBase.Manufacturers)
            {
                if (manufacturer.GetTitle() == oldTitle) { index = DataBase.Manufacturers.IndexOf(manufacturer); break; }

            }
            if (index != -1) { DataBase.Manufacturers[index].SetTitle(newTitle); }
            else Console.WriteLine("Manufacturer with current title isn't exist!");

        }
        public void DeleteManufacturer(int id)
        {
            int index = -1;
            foreach (Manufacturer manufacturer in DataBase.Manufacturers)
            {
                if (manufacturer.Id == id) { index = DataBase.Manufacturers.IndexOf(manufacturer); break; }

            }
            if (index != -1) { DataBase.Manufacturers.Remove(DataBase.Manufacturers[index]); }
            else Console.WriteLine("Manufacturer with current ID isn't exist!");

        }
        public void DeleteManufacturer(string title)
        {
            int index = -1;
            foreach (Manufacturer manufacturer in DataBase.Manufacturers)
            {
                if (manufacturer.GetTitle() == title) { index = DataBase.Manufacturers.IndexOf(manufacturer); break; }

            }
            if (index != -1) { DataBase.Manufacturers.Remove(DataBase.Manufacturers[index]); }
            else Console.WriteLine("Manufacturer with current title isn't exist!");

        }
        public void ClearManufacturerList() { DataBase.Manufacturers.Clear(); }
        #endregion

        #region METHODS FOR CUSTOMER LIST
        public void SortCustomer()
        {
            DataBase.Customers.Sort();
        }
        public void AddCustomer(string name, string phoneNumber)
        {
            Customer customer = new Customer(name, phoneNumber);
            if (DataBase.Customers.Count == 0) customer.Id = 1;
            else customer.Id = DataBase.Customers[DataBase.Customers.Count - 1].Id + 1;
            DataBase.Customers.Add(customer);
            DataBase.Customers.Sort();
        }
        public void ShowCustomerUseId(int id)
        {
            int index = -1;
            foreach (Customer customer in DataBase.Customers)
            {
                if (customer.Id == id) { index = DataBase.Customers.IndexOf(customer); break; }

            }
            if (index != -1) DataBase.Customers[index].ShowCustomer();
            else Console.WriteLine("Customer with current ID isn't exist!");
        }
        public void ShowCustomerUseName(string name)
        {
            int index = -1;
            foreach (Customer customer in DataBase.Customers)
            {
                if (customer.GetName() == name) { index = DataBase.Customers.IndexOf(customer); break; }

            }
            if (index != -1) DataBase.Customers[index].ShowCustomer();
            else Console.WriteLine("Customer with current name isn't exist!");
        }
        public void ShowCustomerUsePhoneNumber(string phoneNumber)
        {
            int index = -1;
            foreach (Customer customer in DataBase.Customers)
            {
                if (customer.GetPhoneNumber() == phoneNumber) { index = DataBase.Customers.IndexOf(customer); break; }

            }
            if (index != -1) DataBase.Customers[index].ShowCustomer();
            else Console.WriteLine("Customer with current name isn't exist!");
        }
        public void ShowAllCustomers()
        {
            foreach (Customer customer in DataBase.Customers)
            {
                customer.ShowCustomer();
            }
        }
        public Customer GetCustomerUseId(int id)
        {
            int index = -1;
            foreach (Customer customer in DataBase.Customers)
            {
                if (customer.Id == id) { index = DataBase.Customers.IndexOf(customer); break; }

            }
            if (index != -1) return DataBase.Customers[index];
            else return null;
        }
        public Customer GetCustomerUseName(string name)
        {
            int index = -1;
            foreach (Customer customer in DataBase.Customers)
            {
                if (customer.GetName() == name) { index = DataBase.Customers.IndexOf(customer); break; }

            }
            if (index != -1) return DataBase.Customers[index];
            else return null;
        }
        public Customer GetCustomerUsePhoneNumber(string phoneNumber)
        {
            int index = -1;
            foreach (Customer customer in DataBase.Customers)
            {
                if (customer.GetPhoneNumber() == phoneNumber) { index = DataBase.Customers.IndexOf(customer); break; }

            }
            if (index != -1) return DataBase.Customers[index];
            else return null;
        }
        public void UpdateCustomerNameUseId(int id, string newName)
        {
            int index = -1;
            foreach (Customer customer in DataBase.Customers)
            {
                if (customer.Id == id) { index = DataBase.Customers.IndexOf(customer); break; }

            }
            if (index != -1) { DataBase.Customers[index].SetName(newName); }
            else Console.WriteLine("Customer with current ID isn't exist!");

        }
        public void UpdateCustomerPhoneNumberUseId(int id, string newPhoneNumber)
        {
            int index = -1;
            foreach (Customer customer in DataBase.Customers)
            {
                if (customer.Id == id) { index = DataBase.Customers.IndexOf(customer); break; }

            }
            if (index != -1) { DataBase.Customers[index].SetPhoneNumber(newPhoneNumber); }
            else Console.WriteLine("Customer with current ID isn't exist!");

        }
        public void UpdateCustomerNameUseName(string oldName, string newName)
        {
            int index = -1;
            foreach (Customer customer in DataBase.Customers)
            {
                if (customer.GetName() == oldName) { index = DataBase.Customers.IndexOf(customer); break; }

            }
            if (index != -1) { DataBase.Customers[index].SetName(newName); }
            else Console.WriteLine("Customer with current name isn't exist!");

        }
        public void UpdateCustomerPhoneNumberUseName(string name, string newPhoneNumber)
        {
            int index = -1;
            foreach (Customer customer in DataBase.Customers)
            {
                if (customer.GetName() == name) { index = DataBase.Customers.IndexOf(customer); break; }

            }
            if (index != -1) { DataBase.Customers[index].SetPhoneNumber(newPhoneNumber); }
            else Console.WriteLine("Customer with current name isn't exist!");

        }
        public void UpdateCustomerNameUsePhoneNumber(string phoneNumber, string newName)
        {
            int index = -1;
            foreach (Customer customer in DataBase.Customers)
            {
                if (customer.GetPhoneNumber() == phoneNumber) { index = DataBase.Customers.IndexOf(customer); break; }

            }
            if (index != -1) { DataBase.Customers[index].SetName(newName); }
            else Console.WriteLine("Customer with current phone number isn't exist!");

        }
        public void UpdateCustomerPhoneNumberUsePhoneNumber(string oldPhoneNumber, string newPhoneNumber)
        {
            int index = -1;
            foreach (Customer customer in DataBase.Customers)
            {
                if (customer.GetPhoneNumber() == oldPhoneNumber) { index = DataBase.Customers.IndexOf(customer); break; }

            }
            if (index != -1) { DataBase.Customers[index].SetPhoneNumber(newPhoneNumber); }
            else Console.WriteLine("Customer with current phone number isn't exist!");

        }
        public void DeleteCustomerUseId(int id)
        {
            int index = -1;
            foreach (Customer customer in DataBase.Customers)
            {
                if (customer.Id == id) { index = DataBase.Customers.IndexOf(customer); break; }

            }
            if (index != -1) { DataBase.Customers.Remove(DataBase.Customers[index]); }
            else Console.WriteLine("Customer with current ID isn't exist!");

        }
        public void DeleteCustomerUseName(string name)
        {
            int index = -1;
            foreach (Customer customer in DataBase.Customers)
            {
                if (customer.GetName() == name) { index = DataBase.Customers.IndexOf(customer); break; }

            }
            if (index != -1) { DataBase.Customers.Remove(DataBase.Customers[index]); }
            else Console.WriteLine("Customer with current name isn't exist!");

        }
        public void DeleteCustomerUsePhoneNumber(string phoneNumber)
        {
            int index = -1;
            foreach (Customer customer in DataBase.Customers)
            {
                if (customer.GetPhoneNumber() == phoneNumber) { index = DataBase.Customers.IndexOf(customer); break; }

            }
            if (index != -1) { DataBase.Customers.Remove(DataBase.Customers[index]); }
            else Console.WriteLine("Customer with current phone number isn't exist!");

        }
        public void ClearCustomersList() { DataBase.Customers.Clear(); }
        #endregion

        #region METHODS FOR ORDER LIST
        public void SortOrder()
        {
            DataBase.Orders.Sort();
        }
        public void AddOrder(string date, Product product, Customer customer)
        {
            Order order = new Order(date, product, customer);
            if (DataBase.Orders.Count == 0) order.Id = 1;
            else order.Id = DataBase.Orders[DataBase.Orders.Count - 1].Id + 1;
            DataBase.Orders.Add(order);
            DataBase.Orders.Sort();
        }
        public void ShowOrder(int id)
        {
            int index = -1;
            foreach (Order order in DataBase.Orders)
            {
                if (order.Id == id) { index = DataBase.Orders.IndexOf(order); break; }

            }
            if (index != -1)
            {
                string displayOrder =
                    $"ID: {DataBase.Orders[index].Id}\t Date: {DataBase.Orders[index].GetDate()}\n" +
                    $"Product title: {DataBase.Products[DataBase.Products.IndexOf(GetProduct(DataBase.Orders[index].ProductId))].GetTitle()}\t Cost: ${DataBase.Products[DataBase.Products.IndexOf(GetProduct(DataBase.Orders[index].ProductId))].GetCost()}\n" +
                    $"Customer name: {DataBase.Customers[DataBase.Customers.IndexOf(GetCustomerUseId(DataBase.Orders[index].CustomerId))].GetName()}\t Phone number: {DataBase.Customers[DataBase.Customers.IndexOf(GetCustomerUseId(DataBase.Orders[index].CustomerId))].GetPhoneNumber()}\n";
                Console.WriteLine(displayOrder);

            }
            else Console.WriteLine("Order with current ID isn't exist!");
        }
        public void ShowOrder(string date)
        {
            int index = -1;
            foreach (Order order in DataBase.Orders)
            {
                if (order.GetDate() == date) { index = DataBase.Orders.IndexOf(order); break; }

            }
            if (index != -1)
            {
                string displayOrder =
                    $"ID: {DataBase.Orders[index].Id}\t Date: {DataBase.Orders[index].GetDate()}\n" +
                    $"Product title: {DataBase.Products[DataBase.Products.IndexOf(GetProduct(DataBase.Orders[index].ProductId))].GetTitle()}\t Cost: ${DataBase.Products[DataBase.Products.IndexOf(GetProduct(DataBase.Orders[index].ProductId))].GetCost()}\n" +
                    $"Customer name: {DataBase.Customers[DataBase.Customers.IndexOf(GetCustomerUseId(DataBase.Orders[index].CustomerId))].GetName()}\t Phone number: {DataBase.Customers[DataBase.Customers.IndexOf(GetCustomerUseId(DataBase.Orders[index].CustomerId))].GetPhoneNumber()}\n";
                Console.WriteLine(displayOrder);

            }
            else Console.WriteLine("Order with current date isn't exist!");
        }
        public void ShowAllOrders()
        {
            foreach (Order order in DataBase.Orders)
            {
                ShowOrder(order.Id);
            }
        }
        public Order GetOrder(int id)
        {
            int index = -1;
            foreach (Order order in DataBase.Orders)
            {
                if (order.Id == id) { index = DataBase.Orders.IndexOf(order); break; }

            }
            if (index != -1) return DataBase.Orders[index];
            else return null;
        }
        public Order GetOrder(string date)
        {
            int index = -1;
            foreach (Order order in DataBase.Orders)
            {
                if (order.GetDate() == date) { index = DataBase.Orders.IndexOf(order); break; }

            }
            if (index != -1) return DataBase.Orders[index];
            else return null;
        }
        public void UpdateOrderDate(int id, string newDate)
        {
            int index = -1;
            foreach (Order order in DataBase.Orders)
            {
                if (order.Id == id) { index = DataBase.Orders.IndexOf(order); break; }

            }
            if (index != -1) { DataBase.Orders[index].SetDate(newDate); }
            else Console.WriteLine("Order with current ID isn't exist!");

        }
        public void UpdateOrderDate(string oldDate, string newDate)
        {
            int index = -1;
            foreach (Order order in DataBase.Orders)
            {
                if (order.GetDate() == oldDate) { index = DataBase.Orders.IndexOf(order); break; }

            }
            if (index != -1) { DataBase.Orders[index].SetDate(newDate); }
            else Console.WriteLine("Order with current date isn't exist!");

        }
        public void DeleteOrder(int id)
        {
            int index = -1;
            foreach (Order order in DataBase.Orders)
            {
                if (order.Id == id) { index = DataBase.Orders.IndexOf(order); break; }

            }
            if (index != -1) { DataBase.Orders.Remove(DataBase.Orders[index]); }
            else Console.WriteLine("Order with current ID isn't exist!");

        }
        public void DeleteOrder(string date)
        {
            int index = -1;
            foreach (Order order in DataBase.Orders)
            {
                if (order.GetDate() == date) { index = DataBase.Orders.IndexOf(order); break; }

            }
            if (index != -1) { DataBase.Orders.Remove(DataBase.Orders[index]); }
            else Console.WriteLine("Order with current date isn't exist!");

        }
        public void ClearOrderList() { DataBase.Orders.Clear(); }
        #endregion

        #region METHODS FOR PRODUCT LIST
        public void SortProduct()
        {
            DataBase.Products.Sort();
        }
        public void AddProduct(string title, double cost, Category category, Manufacturer manufacturer)
        {
            Product product = new Product(title, cost, category, manufacturer);
            if (DataBase.Products.Count == 0) product.Id = 1;
            else product.Id = DataBase.Products[DataBase.Products.Count - 1].Id + 1;
            DataBase.Products.Add(product);
            DataBase.Products.Sort();
        }
        public void ShowProduct(int id)
        {
            int index = -1;
            foreach (Product product in DataBase.Products)
            {
                if (product.Id == id) { index = DataBase.Products.IndexOf(product); break; }

            }
            if (index != -1)
            {
                string displayProduct =
                    $"ID: {DataBase.Products[index].Id}\t Title: {DataBase.Products[index].GetTitle()}\t Cost: ${DataBase.Products[index].GetCost()}\n" +
                    $"Manufacturer: {DataBase.Manufacturers[DataBase.Manufacturers.IndexOf(GetManufacturer(DataBase.Products[index].ManufacturerId))].GetTitle()} \n" +
                    $"Category: {DataBase.Categories[DataBase.Categories.IndexOf(GetCategory(DataBase.Products[index].CategoryId))].GetTitle()}\n";
                Console.WriteLine(displayProduct);

            }
            else Console.WriteLine("Product with current ID isn't exist!");
        }
        public void ShowProduct(string title)
        {
            int index = -1;
            foreach (Product product in DataBase.Products)
            {
                if (product.GetTitle() == title) { index = DataBase.Products.IndexOf(product); break; }

            }
            if (index != -1)
            {
                string displayProduct =
                     $"ID: {DataBase.Products[index].Id}\t Title: {DataBase.Products[index].GetTitle()}\t Cost: $ {DataBase.Products[index].GetCost()}\n" +
                     $"Manufacturer: {DataBase.Manufacturers[DataBase.Manufacturers.IndexOf(GetManufacturer(DataBase.Products[index].ManufacturerId))].GetTitle()} \n" +
                     $"Category: {DataBase.Categories[DataBase.Categories.IndexOf(GetCategory(DataBase.Products[index].CategoryId))].GetTitle()}\n";
                Console.WriteLine(displayProduct);

            }
            else Console.WriteLine("Product with current title isn't exist!");
        }
        public void ShowProduct(double cost)
        {
            int index = -1;
            foreach (Product product in DataBase.Products)
            {
                if (product.GetCost() == cost) { index = DataBase.Products.IndexOf(product); break; }

            }
            if (index != -1)
            {
                string displayProduct =
                     $"ID: {DataBase.Products[index].Id}\t Title: {DataBase.Products[index].GetTitle()}\t Cost: $ {DataBase.Products[index].GetCost()} \n" +
                     $"Manufacturer: {DataBase.Manufacturers[DataBase.Manufacturers.IndexOf(GetManufacturer(DataBase.Products[index].ManufacturerId))].GetTitle()} \n" +
                     $"Category: {DataBase.Categories[DataBase.Categories.IndexOf(GetCategory(DataBase.Products[index].CategoryId))].GetTitle()}\n";
                Console.WriteLine(displayProduct);

            }
            else Console.WriteLine("Product with current cost isn't exist!");
        }
        public void ShowAllProducts()
        {
            foreach (Product product in DataBase.Products)
            {
                ShowProduct(product.Id);
            }
        }
        public Product GetProduct(int id)
        {
            int index = -1;
            foreach (Product product in DataBase.Products)
            {
                if (product.Id == id) { index = DataBase.Products.IndexOf(product); break; }

            }
            if (index != -1) return DataBase.Products[index];
            else return null;
        }
        public Product GetProduct(string title)
        {
            int index = -1;
            foreach (Product product in DataBase.Products)
            {
                if (product.GetTitle() == title) { index = DataBase.Products.IndexOf(product); break; }

            }
            if (index != -1) return DataBase.Products[index];
            else return null;
        }
        public Product GetProduct(double cost)
        {
            int index = -1;
            foreach (Product product in DataBase.Products)
            {
                if (product.GetCost() == cost) { index = DataBase.Products.IndexOf(product); break; }

            }
            if (index != -1) return DataBase.Products[index];
            else return null;
        }
        public void UpdateProductTitle(int id, string newTitle)
        {
            int index = -1;
            foreach (Product product in DataBase.Products)
            {
                if (product.Id == id) { index = DataBase.Products.IndexOf(product); break; }

            }
            if (index != -1) { DataBase.Products[index].SetTitle(newTitle); }
            else Console.WriteLine("Product with current ID isn't exist!");

        }
        public void UpdateProductTitle(double cost, string newTitle)
        {
            int index = -1;
            foreach (Product product in DataBase.Products)
            {
                if (product.GetCost() == cost) { index = DataBase.Products.IndexOf(product); break; }

            }
            if (index != -1) { DataBase.Products[index].SetTitle(newTitle); }
            else Console.WriteLine("Product with current cost isn't exist!");

        }
        public void UpdateProductTitle(string oldTitle, string newTitle)
        {
            int index = -1;
            foreach (Product product in DataBase.Products)
            {
                if (product.GetTitle() == oldTitle) { index = DataBase.Products.IndexOf(product); break; }

            }
            if (index != -1) { DataBase.Products[index].SetTitle(newTitle); }
            else Console.WriteLine("Product with current title isn't exist!");

        }
        public void UpdateProductCost(int id, double newCost)
        {
            int index = -1;
            foreach (Product product in DataBase.Products)
            {
                if (product.Id == id) { index = DataBase.Products.IndexOf(product); break; }

            }
            if (index != -1) { DataBase.Products[index].SetCost(newCost); }
            else Console.WriteLine("Product with current ID isn't exist!");

        }
        public void UpdateProductCost(double oldCost, double newCost)
        {
            int index = -1;
            foreach (Product product in DataBase.Products)
            {
                if (product.GetCost() == oldCost) { index = DataBase.Products.IndexOf(product); break; }

            }
            if (index != -1) { DataBase.Products[index].SetCost(newCost); }
            else Console.WriteLine("Product with current cost isn't exist!");

        }
        public void UpdateProductCost(string title, double newCost)
        {
            int index = -1;
            foreach (Product product in DataBase.Products)
            {
                if (product.GetTitle() == title) { index = DataBase.Products.IndexOf(product); break; }

            }
            if (index != -1) { DataBase.Products[index].SetCost(newCost); }
            else Console.WriteLine("Product with current title isn't exist!");

        }
        public void DeleteProduct(int id)
        {
            int index = -1;
            foreach (Product product in DataBase.Products)
            {
                if (product.Id == id) { index = DataBase.Products.IndexOf(product); break; }

            }
            if (index != -1) { DataBase.Products.Remove(DataBase.Products[index]); }
            else Console.WriteLine("Product with current ID isn't exist!");

        }
        public void DeleteProduct(string title)
        {
            int index = -1;
            foreach (Product product in DataBase.Products)
            {
                if (product.GetTitle() == title) { index = DataBase.Products.IndexOf(product); break; }

            }
            if (index != -1) { DataBase.Products.Remove(DataBase.Products[index]); }
            else Console.WriteLine("Product with current title isn't exist!");

        }
        public void DeleteProduct(double cost)
        {
            int index = -1;
            foreach (Product product in DataBase.Products)
            {
                if (product.GetCost() == cost) { index = DataBase.Products.IndexOf(product); break; }

            }
            if (index != -1) { DataBase.Products.Remove(DataBase.Products[index]); }
            else Console.WriteLine("Product with current cost isn't exist!");

        }
        public void ClearProductList() { DataBase.Products.Clear(); }


        #endregion
    }

}
