using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            IKrediManager konutKrediManager = new KonutKrediManager();
            IKrediManager tasitKrediManager = new TasitKrediManager();

            BasvuruManager basvuruManager = new BasvuruManager();
            ILoggerService fileLoggerService = new FileLoggerService();
            ILoggerService databaseLoggerService = new DatabaseLoggerService();

            basvuruManager.BasvuruYap(tasitKrediManager,databaseLoggerService);
            Console.ReadLine();

            List<IKrediManager> krediManagers = new List<IKrediManager>() { ihtiyacKrediManager,konutKrediManager,tasitKrediManager};
            basvuruManager.KrediOnBilgilendirmesiYap(krediManagers,new DatabaseLoggerService());
            Console.ReadLine();
        }
    }
}
