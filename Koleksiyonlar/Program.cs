using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Koleksiyonlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string[] isimler = new string[] { "Engin", "Murat", "Kerem", "Halil" };
            //Console.WriteLine(isimler[0]);
            //Console.WriteLine(isimler[1]);
            //Console.WriteLine(isimler[2]);
            //Console.WriteLine(isimler[3]);

            //isimler[4] = "Umut";              Dizileri bu şekilde genişletemediğimiz için genişletirsek de değerleri kaybedeceğimiz için
            //Console.WriteLine(isimler[4]);    biz dizi yerine koleksiyonları kullanıyoruz

            List<string> isimler2 = new List<string>() { "Engin","Murat","Kerem","Halil"};
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);
            isimler2.Add("Umut");
            Console.WriteLine(isimler2[4]);



        }
    }
}
