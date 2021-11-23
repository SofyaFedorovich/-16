using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.IO;
using System.Text.Json.Serialization;
using System.Text.Unicode;
using System.Text.Encodings.Web;

namespace Занятие_16
{
    public class Products //разработать класс для моделирования объекта "Товар"
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
            Console.WriteLine("Ввести код товара:  ");
            products.Code = int.Parse(Console.ReadLine());
            Console.WriteLine("Ввести название товара латинскими буквами:  ");
            products.Name = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Ввести цену товара:  ");
            products.Price = double.Parse(Console.ReadLine());

            const int n = 5;
            double[] arrayPrice = new double[6];
            for (int i = 1; i <= n; i++)
            {
                arrayPrice[i] = products.Price;
                Console.Write("{0,5}", arrayPrice[i]);

            }
           /* JsonDocumentOptions options = new JsonDocumentOptions();
             {
                Encoder = JavaScriptEncoder.Create(UnicodeRanges.BasicLatin, UnicodeRanges.Cyrillic);
                WriteIndented = true;
             }*/

            string jsonString = JsonSerializer.Serialize<Products>(products);
            Console.WriteLine(jsonString);
            using (FileStream fs = new FileStream("Products.json", FileMode.OpenOrCreate))
            {
                await JsonSerializer.SerializeAsync<Products>(fs, products);
                Console.WriteLine("Данные сохранены в файл Products.json");
            }

            //using (FileStream fs = new FileStream("Products.json", FileMode.OpenOrCreate))
            //{
            //    Products restoredProducts = await JsonSerializer.DeserializeAsync<Products>(fs);
            //    Console.WriteLine($"Price: {restoredProducts.Price}  Code: {restoredProducts.Code} Name: {restoredProducts.Name}");
            //}

            Console.ReadKey();
        }
    }
}
