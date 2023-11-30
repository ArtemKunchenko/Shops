using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            else Console.WriteLine("Item with current ID isn't exist!");
        }
        public void ShowCategory(string title)
        {
            int index = -1;
            foreach (Category category in DataBase.Categories)
            {
                if (category.GetTitle() == title) { index = DataBase.Categories.IndexOf(category); break; }

            }
            if (index != -1) DataBase.Categories[index].ShowCategory();
            else Console.WriteLine("Item with current title isn't exist!");
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
            else Console.WriteLine("Item with current ID isn't exist!");

        }
        public void UpdateCategoryTitle(string oldTitle, string newTitle)
        {
            int index = -1;
            foreach (Category category in DataBase.Categories)
            {
                if (category.GetTitle() == oldTitle) { index = DataBase.Categories.IndexOf(category); break; }

            }
            if (index != -1) { DataBase.Categories[index].SetTitle(newTitle); }
            else Console.WriteLine("Item with current title isn't exist!");

        }
        public void DeleteCategory(int id)
        {
            int index = -1;
            foreach (Category category in DataBase.Categories)
            {
                if (category.Id == id) { index = DataBase.Categories.IndexOf(category); break; }

            }
            if (index != -1) { DataBase.Categories.Remove(DataBase.Categories[index]); }
            else Console.WriteLine("Item with current ID isn't exist!");

        }
        public void DeleteCategory(string title)
        {
            int index = -1;
            foreach (Category category in DataBase.Categories)
            {
                if (category.GetTitle() == title) { index = DataBase.Categories.IndexOf(category); break; }

            }
            if (index != -1) { DataBase.Categories.Remove(DataBase.Categories[index]); }
            else Console.WriteLine("Item with current title isn't exist!");

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
            else Console.WriteLine("Item with current ID isn't exist!");
        }
        public void ShowManufacturer(string title)
        {
            int index = -1;
            foreach (Manufacturer manufacturer in DataBase.Manufacturers)
            {
                if (manufacturer.GetTitle() == title) { index = DataBase.Manufacturers.IndexOf(manufacturer); break; }

            }
            if (index != -1) DataBase.Manufacturers[index].ShowManufacturer();
            else Console.WriteLine("Item with current title isn't exist!");
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
            else Console.WriteLine("Item with current ID isn't exist!");

        }
        public void UpdateManufacturerTitle(string oldTitle, string newTitle)
        {
            int index = -1;
            foreach (Manufacturer manufacturer in DataBase.Manufacturers)
            {
                if (manufacturer.GetTitle() == oldTitle) { index = DataBase.Manufacturers.IndexOf(manufacturer); break; }

            }
            if (index != -1) { DataBase.Manufacturers[index].SetTitle(newTitle); }
            else Console.WriteLine("Item with current title isn't exist!");

        }
        public void DeleteManufacturer(int id)
        {
            int index = -1;
            foreach (Manufacturer manufacturer in DataBase.Manufacturers)
            {
                if (manufacturer.Id == id) { index = DataBase.Manufacturers.IndexOf(manufacturer); break; }

            }
            if (index != -1) { DataBase.Manufacturers.Remove(DataBase.Manufacturers[index]); }
            else Console.WriteLine("Item with current ID isn't exist!");

        }
        public void DeleteManufacturer(string title)
        {
            int index = -1;
            foreach (Manufacturer manufacturer in DataBase.Manufacturers)
            {
                if (manufacturer.GetTitle() == title) { index = DataBase.Manufacturers.IndexOf(manufacturer); break; }

            }
            if (index != -1) { DataBase.Manufacturers.Remove(DataBase.Manufacturers[index]); }
            else Console.WriteLine("Item with current title isn't exist!");

        }
        public void ClearManufacturerList() { DataBase.Manufacturers.Clear(); } 
        #endregion


    }




}
