using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    interface IKrediManager
    {
        // Bu bankada 100 lerce kredi türü var 
        // her kredi türünün ayrı ayrı hesaplama yöntemi varsa
        // bunu tek tek iflerle yönetemezsin !
        // bunun için KrediManager class değil interface olarak tanımlanır bir şablondur. Class Değil !
        // Bir interface i tanımlarken isminin başına "I" konur ki okunurluk artsın ve interface olduğunu anlayalım
        void Hesapla();
        void BirSeyYap();
    }
}
