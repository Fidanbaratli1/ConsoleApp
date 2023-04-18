using ConsoleApp7.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7.Models
{
    internal class Category
    {
        private int _id;
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public int MyProperty { get; set; }
        public Category(string categoryname)
        {
            CategoryName = categoryname;
            _id++;
            CategoryId = _id;
        }
        public static void CreateCategory()
        {
            Console.WriteLine("Zehmet olmasa dermanin cateqorysinin adini qeyd edin");
            string name = Console.ReadLine();
            Category category=new Category(name);
            Context.categories.Add(category);
        }
       public  void Deletecategory()
        {
            Console.WriteLine("Categoryni secin");
            foreach (var category in Context.categories)
            {
                Console.WriteLine(category.CategoryId + " " + category.CategoryName);
               

            }
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("Slmek istediyiniz category" + Search(id).CategoryName);
            Context.categories.Remove(Search(id));
        }
        public Category Search(int id)
        {
            foreach (var category in Context.categories)
            {
                if(category.CategoryId == id)
                {
                    return category;
                }
            }
            throw new Exception("Duzgun daxil edin");
        }
       public void UpdateCategory()
        {


        }
    }
}
