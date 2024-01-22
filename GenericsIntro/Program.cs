using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsIntro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyList<string> list = new MyList<string>("ahmet", "mehmet", "umut");
            Console.WriteLine(list.Lenght);
            Yazdir(list);
            Console.WriteLine("-----------");
            list.Add("MERT");
            Console.WriteLine(list.Lenght);
            Yazdir(list);
            Console.WriteLine("-----------");
            list.Clear();
            Console.WriteLine(list.Lenght);
            Yazdir(list);
            Console.ReadLine();

        }

        private static void Yazdir(MyList<string> list)
        {
            foreach (var item in list.Items)
            {
                Console.WriteLine(item);
            }
        }
    }
}
