using System;

namespace Klavyeden_girilen_metnin_kaç_kelimeden_oluştuğunu_bulma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string cumle;
            Console.Write("Cümleyi Giriniz : ");
            cumle = Console.ReadLine();
            string[] kelimeler = cumle.Split(' ');
            Console.WriteLine(kelimeler.Length);
            Console.ReadLine();
        }
    }
}
