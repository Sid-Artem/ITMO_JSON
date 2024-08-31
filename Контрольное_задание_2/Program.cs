using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;


namespace Контрольное_задание_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string json = String.Empty;
            using (StreamReader sr = new StreamReader("../../../Product.json"))
            {
                json = sr.ReadToEnd();

            }
            Product[] product = JsonSerializer.Deserialize<Product[]>(json);

            Product maxPrice = product[0];
            foreach (Product e in product)
            {
                if (e.Price > maxPrice.Price)
                {
                    maxPrice = e;
                }

            }
            Console.WriteLine($"{maxPrice.Name} {maxPrice.Id} {maxPrice.Price}");
            Console.ReadKey();
        }
    }
}
