using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tek_Çift_Sayı
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            { 
                

                Console.WriteLine("TEK ÇİFT SAYI");
                Console.Write("SAYIYI GİRİNİZ = ");
                int Sayı = Convert.ToInt32(Console.ReadLine());
                int Sonuç = Sayı % 2;
                if (Sonuç == 0)
                {
                    Console.WriteLine("{0}  BU Sayı Çift Bir Sayı",Sayı);
                }
                else
                {
                    Console.WriteLine("{0}  Bu Sayı Tek bir Sayı", Sayı);
                }
                Console.WriteLine("");
            }
        }
    }
}
