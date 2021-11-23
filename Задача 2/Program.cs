using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Text.Json;
using System.IO;

namespace Задача_2
{
    class Program
    {//получение информации из json-файла
        static void Main(string[] args)
        {
            string path = "C:/Users/s.fedorovich/Desktop/C#/Занятие 16/Занятие 16/Занятие 16/bin/Debug/Products.json";

            string jsonString = File.ReadAllText(path);
            Console.WriteLine(jsonString);
            
            arrayPrice[] products = JsonSerializer.Deserialize<arrayPrice[]>(jsonString);
            double max = 0;
            string maxPrice = "";
            foreach (var product in products)
            {
                if (max < product.PriceProducts)
                {
                    max = product.PriceProducts;
                    maxPrice = product.NameProducts;
                }
            }
            Console.WriteLine("Максимальная цена у товара \"{0}\" = {1:F2} руб. ", maxPrice, max);
            Console.ReadKey();
        }
    }
}
