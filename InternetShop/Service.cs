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
    } 
    #endregion

}
