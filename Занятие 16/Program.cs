using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace Занятие_16
{   //разработать класс для моделирования объекта "Товар"
    class Products
    {
        int code; //код товара
        string name; //название товара
        double price; // цена товара

    }
    class Program
    {

        static void Main(string[] args)
        {
            Products products = new Products();
            Console.WriteLine("Ввести код товара:");
            int code = int.Parse(Console.ReadLine());
            Console.WriteLine("Ввести название товара:");
            string name = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Ввести цену товара:");
            double price = double.Parse(Console.ReadLine());
            const int n = 5;
            const int m = 3;


            int[,] array = new int[n, m];
            Console.WriteLine("Массив записи информации Products");
            code[0]
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    array[i, j] 
                    Console.Write("{0}", array[i, j]);
                }
                Console.WriteLine();
            }

            Console.ReadKey();

        }
    }
}
