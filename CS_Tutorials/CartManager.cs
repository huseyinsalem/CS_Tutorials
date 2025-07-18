using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Tutorials
{
    internal class CartManager
    {
       public void ekle(Product product)
        {
            Console.WriteLine("Tebrikler Sepete eklendi :" + product.Name  );
        }


        public void toplam(int number1,int number2)
        {
            int toplam = number1 + number2;
            Console.WriteLine("Sonuç :"+ toplam);

        }

    }
}
