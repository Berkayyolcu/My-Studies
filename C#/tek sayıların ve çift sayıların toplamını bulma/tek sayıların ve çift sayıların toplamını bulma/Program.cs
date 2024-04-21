using System;

namespace tek_sayıların_ve_çift_sayıların_toplamını_bulma
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int cifttoplam = 0;
            int tektoplam = 0;

            int sayi = 0;
            Console.Write("Bir sayı giriniz: ");
            sayi = Convert.ToInt32(Console.ReadLine());
           
            for (int i = 0; i <= sayi; i++)
            {
                if (i % 2 == 0)
                {
                    cifttoplam += i;
                }
                else
                {
                    tektoplam += i;
                }
            }

            Console.WriteLine(sayi + " sayısına kadar çift sayıların toplamı: " + cifttoplam);
            Console.WriteLine(sayi + " sayısına kadar tek sayıların toplamı: " + tektoplam);
            Console.ReadKey();

        }
    }
}
