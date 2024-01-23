using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    internal class BasvuruManager
    {
        // methot injection yani -> bu metodun 
        public void BasvuruYap(IKrediManager krediManager,ILoggerService loggerService)
        {
            // Başvuran bilgilerini değerlendir ...
            // kredi hesaplama vs bir sürü işlem ...
            // kredi hesaplayacağım fakat hangi kredi türü için ?
            //  İşte bu yüzden hepsinin referansın tutan IKrediManager parametre olarak alınır
            krediManager.Hesapla();
            // Başvuruyu kredi bağımsız hale getirdim
            loggerService.Log();
        }
        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediManagers,ILoggerService loggerService)
        {
            foreach (var krediManager in krediManagers)
            {
                krediManager.Hesapla();
            }
            loggerService.Log();
        }
    }
}
