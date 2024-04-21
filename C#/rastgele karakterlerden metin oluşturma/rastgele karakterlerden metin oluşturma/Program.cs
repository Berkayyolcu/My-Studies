using System;

namespace rastgele_karakterlerden_metin_oluşturma
{
    internal class Program
    {
        static void Main(string[] args)
        {         
            Random rnd = new Random();
            String harfler = "qwertyuıopğüasdfghjklşizxcvbnmöçQWERTYUIOPĞÜASDFGHJKLŞİZXCVBNMÖÇ";
            String uret = "";
            for(int i=0; i<10; i++)
            {
                uret+= harfler[rnd.Next(harfler.Length)];
            }
            Console.WriteLine(uret);
            Console.ReadKey();
        }
    }
}
