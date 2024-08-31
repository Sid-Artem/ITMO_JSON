using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.IO;
using System.Text.Encodings.Web;
using System.Text.Unicode;


namespace Контрольное_задание_1
{
    internal class Program
    {
        static void Main(string[] args)
        {

           const int n= 5;

            Product[] product = new Product[n];
            for (int i = 0; i < n; i++) 
            
            {
                Console.WriteLine("Введите код товара");
                int id= Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите имя товара");
                string name = Console.ReadLine();
                Console.WriteLine("Введите цену товара");
                double price = Convert.ToDouble(Console.ReadLine());

                product[i] = new Product() { Id = id, Name = name, Price = price };


            }
            JsonSerializerOptions options = new JsonSerializerOptions()
            {
                Encoder = JavaScriptEncoder.Create(UnicodeRanges.BasicLatin, UnicodeRanges.Cyrillic),
                WriteIndented = true
            };
            string json = JsonSerializer.Serialize(product);
            using (StreamWriter sw = new StreamWriter("../../../Product.json"))
            {
                sw.WriteLine(json);

            }


        }
    }
}
