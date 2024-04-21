using System;

namespace girilen_3_basamaklı_sayının_basamaklarına_ayıran
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int sayi, yuzler, onlar, birler;
            Console.Write(" Lütfen Bir Sayı Girin : ");           
            sayi = Convert.ToInt32(Console.ReadLine());
            yuzler = sayi / 100;
            sayi = sayi - (yuzler * 100);
            onlar = sayi / 10;
            sayi = sayi - (onlar * 10);
            birler = sayi;
            Console.WriteLine("Yüzler basamağı : {0}", yuzler);
            Console.WriteLine("Onlar basamağı : {0}", onlar);
            Console.WriteLine("Birler basamağı : {0}", birler);
            Console.ReadKey();

        }
    }
}
