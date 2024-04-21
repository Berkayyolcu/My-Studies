using System;

namespace ehliyet_alabilme_yasını_hesaplama
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int yas, fark;

            Console.Write("Yaşınızı giriniz : ");
            yas = Convert.ToInt32(Console.ReadLine());

            if (yas >= 18)
            {
                Console.WriteLine("Ehliyet alabilirsiniz.");
            }
            else
            {
                fark = 18 - yas;
                Console.WriteLine("Ehliyet alamazsınız. {0} yıl daha beklemeniz gerekiyor.", fark);
            }

            Console.ReadKey();
        
        }
    }
}
