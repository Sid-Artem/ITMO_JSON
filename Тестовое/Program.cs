using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.IO;
using System.Text.Encodings.Web;
using System.Text.Unicode;

namespace Тестовое
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int n = 5;
            Employ[] employs = new Employ[n];
            
            
            for (int i = 0; i < n; i++)

            {
                Console.WriteLine("Введите номер");
                int num = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите имя");
                string name = (Console.ReadLine());
                Console.WriteLine("Введите сумму");
                int summa = Convert.ToInt32(Console.ReadLine());

                employs[i] = new Employ() { Name = name, Num = num, Summa = summa };

            }
            JsonSerializerOptions options = new JsonSerializerOptions()
            {
                Encoder = JavaScriptEncoder.Create(UnicodeRanges.BasicLatin, UnicodeRanges.Cyrillic),
                WriteIndented = true
            };


            string jsonString = JsonSerializer.Serialize(employs);

            using (StreamWriter sw = new StreamWriter("../../../Employs.json"))
            {
                sw.WriteLine(jsonString);

            }

        }

    }
}
