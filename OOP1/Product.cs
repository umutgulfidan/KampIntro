using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    internal class Product // Entity * - Varlık
            // CRUD - CREATE - READ -  UPDATE - DELETE
            // Gibi varlığı yönettiğimiz operasyonlar EntityManager ya da EntityService gibi classlar da yapılır
            // Bu şekilde bir isimlendirme görülürse o ürünle ilgili operasyonları içerdiğini bilmeliyiz
    {
        public int Id { get; set; } 
        public int CategoryId { get; set; } // FK ler ana ıd nın altına yazılır ki okunurluk artsın 
        public string ProductName { get; set; }
        public double UnitPrice { get; set; }
        public int UnitsInStock { get; set; }



    }
}
