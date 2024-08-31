using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json;

namespace Тестовое_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string jsonString = String.Empty;
            using (StreamReader sr = new StreamReader("../../../Employs.json"))
            {
                jsonString=sr.ReadToEnd();

            }
            Employ[] employs = JsonSerializer.Deserialize<Employ[]>(jsonString);

            Employ maxEmployee=employs[0];
            foreach (Employ e in employs)
            {
                if (e.Summa > maxEmployee.Summa)
                {
                    maxEmployee = e;
                }

            }
            Console.WriteLine($"{maxEmployee.Name} {maxEmployee.Num} {maxEmployee.Summa}");
            Console.ReadKey();

        }
    }
}
