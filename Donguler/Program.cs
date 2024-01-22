using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Donguler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] kurslar = new string[] { "C#", "Java", "Kotlin", "Javascript" };

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }
            for(int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            for (int i = 1; i <= 10; i+=2)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}
