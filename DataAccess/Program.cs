using System;
using System.Threading;

namespace DataAccess
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            bool correctInput;

            do 
            {
                Console.Clear();

                correctInput = true;

                Console.WriteLine("What database would you like to use?");
                Console.WriteLine("Type: slq");
                Console.WriteLine("Type: mongo");
                Console.WriteLine("Type: list");


                input = Console.ReadLine();

                if (input != "sql" && input != "list" && input != "mongo")
                {
                    correctInput = false;
                    Console.WriteLine("Bad input!");
                    Thread.Sleep(1000); 
                    
                }
            } while (!correctInput); ; 

            Console.Clear ();
           IDataAccess db = DataAccessFactory.GetDataAccessType(input);

            var products = db.LoadData();
            db.SaveData();

            foreach (var product in products)
            {
                Console.WriteLine($"Name: {product.Name} Price:{product.Price}");
            }

        }
    }
}
