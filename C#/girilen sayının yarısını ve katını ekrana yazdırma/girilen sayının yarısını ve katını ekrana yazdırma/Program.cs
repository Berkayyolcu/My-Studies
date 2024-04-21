using System;

namespace girilen_sayının_yarısını_ve_katını_ekrana_yazdırma
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int sayi, sonuc;

            Console.Write("Sayıyı giriniz : ");
            sayi = Convert.ToInt32(Console.ReadLine());

            if (sayi % 2 == 0)
            {
                sonuc = sayi / 2;
                Console.Write("Girilen sayı çifttir : " + sonuc);
            }
            else
            {
                sonuc = sayi * 2;
                Console.Write("Girilen sayı tektir :  {0}", sonuc);
            }

            Console.ReadKey();

        }
    }
}
