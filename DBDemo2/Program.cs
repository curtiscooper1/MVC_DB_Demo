using MySql.Data.MySqlClient;
using System;
using Dapper.Contrib.Extensions;
using System.Collections.Generic;
using System.Linq;

namespace DBDemo2
{
    [Table("category")]
    class Category
    {
        [Key]
        public int categoryId { get; set; }
        public string categoryName { get; set; }
        public string  description { get; set; }

        public override string ToString()
        {
            return $"{categoryId} {categoryName} {description }";
        }
    }
    class Program
    {
        static MySqlConnection db = new MySqlConnection("Server=localhost;Database=Northwind;Uid=root;Password=abc123");

        static void ReadAll()
        {
            List<Category> cats = db.GetAll<Category>().ToList();

            foreach (Category cat in cats)
            {
                Console.WriteLine(cat);
            }
        }

        static void AddOne()
        {
            Category cat = new Category();
            cat.categoryName = "Cleaning";
            cat.description = "Cleaning and home maintenance products";
            db.Insert(cat);
        }

        static void ReadOne()
        {
            Category cat = db.Get<Category>(5);
            cat.categoryName = "Grains";        
            db.Update(cat);
        }

        static void DeleteOne()
        {
            Category cat = db.Get<Category>(9);
            db.Delete(cat);
        }
        static void Main(string[] args)
        {
            ReadAll();
        }
    }
}
