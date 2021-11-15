using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.IO;

namespace Занятие_16
{
    class Products //разработать класс для моделирования объекта "Товар"
    {
        int code;
        string name;
        double price;

        public int Code { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }

        void products(int code, string name, double price) //конструктор
        {
            this.code = code;
            this.name = name;
            this.price = price;
        }
    }
    class Program
    {
        static async Task Main(string[] args)
        {
            Products products = new Products();
            Console.WriteLine("Ввести код товара:");
            products.Code = int.Parse(Console.ReadLine());
            Console.WriteLine("Ввести название товара:");
            products.Name = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Ввести цену товара:");
            products.Price = double.Parse(Console.ReadLine());

            const int n = 6;
            int[] arrayCode = new int[6];
            for (int i = 1; i < n; i++)
            {
                Console.WriteLine("Введите коды товаров {0}", i );
                arrayCode[i] = int.Parse (Console.ReadLine());
            }
            string jsonString = JsonSerializer.Serialize<Products>(products);
            Console.WriteLine(jsonString);
            using (FileStream fs = new FileStream("Products.json", FileMode.OpenOrCreate))
            {               
                await JsonSerializer.SerializeAsync<Products>(fs, products);
                Console.WriteLine("Данные сохранены в файл Products.json");
            }
            Console.ReadKey();

        }
    }
}
