using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class MongoDataAccess : IDataAccess
    {
        public static List<Product> Products = new List<Product>()
        { new Product() {Name = "xbox", Price = 350},
           new Product() {Name = "golf clubs", Price = 500},
           new Product() {Name = "couch", Price = 1000},
           new Product() {Name = "shoes", Price = 100},

        };

        public List<Product> LoadData()
        {
            Console.WriteLine($"I am reading data from Mongo Data Access.");

            return Products;
        }

        public void SaveData()
        {
            Console.WriteLine("I am saving data from SQL Mongo Access");
        }
    }
}
