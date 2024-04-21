using System;

namespace girilen_3_sayıdan_büyük_olanı_ekranda_gösterme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int s1, s2, s3;

            Console.Write("1. sayıyı girin : ");
            s1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("2. sayıyı girin : ");
            s2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("3. sayıyı girin : ");
            s3 = Convert.ToInt32(Console.ReadLine());

            if (s1 > s2 && s1 > s3)
            {
                Console.WriteLine("1. sayı en büyük");
            }
            else if (s2 > s1 && s2 > s3)
            {
                Console.WriteLine("2. sayı en büyük");
            }
            else if (s3 > s1 && s3 > s2)
            {
                Console.WriteLine("3. sayı en büyük");
            }
            else
            {
                Console.WriteLine("Farklı sayılar girin");
            }
            Console.ReadKey();
        }
    }
}
