using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json;

namespace Lab16_task2
{
    class Program
    {
        static void Main(string[] args)
        {
            string jsonString = string.Empty;
            using (StreamReader sr=new StreamReader("H:\\Visual Studio проект\\Lab16\\Products.json"))
            {
                jsonString = sr.ReadToEnd();
            }
            Product[] products = JsonSerializer.Deserialize<Product[]>(jsonString);
            Product maxPrice = products[0];
            foreach (Product p in products)
            {
                if (p.Price>maxPrice.Price)
                {
                    maxPrice = p;
                }
            }
            Console.WriteLine($"{ maxPrice.Name}");
            Console.ReadKey();
        }
    }
    class Product
    {
        public int ProductСode { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
    }
}
