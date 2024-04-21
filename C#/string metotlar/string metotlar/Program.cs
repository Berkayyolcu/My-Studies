using System;
using System.Linq;

namespace string_metotlar
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string degisken = "Dersimiz CSharp, Hoşgeldiniz!";
            string degisken2 = "Dersimiz CSharp";

            //Length : Bir dizideki karakter sayısını döndürür.
            Console.WriteLine(degisken.Length);
            Console.ReadKey();

            //ToUpper : Değişkenin içeriğindeki harflerin tamamını büyük harfe dönüştürür.
            //Tolower : Değişkenin içeriğindeki harflerin tamamını küçük harfe dönüştürür.
            Console.WriteLine(degisken.ToUpper());
            Console.WriteLine(degisken.ToLower());
            Console.ReadKey();

            //Concat : Dize değerlerini birleştirmek için kullanılır.
            Console.WriteLine(String.Concat(degisken, " Merhaba! "));
            Console.ReadKey();

            /*Compare : İki tane string ifadeyi karşılaştırıp
             sonucunda int bir değer döndürür. (0,1,-1) */
            //CompareTo : Verilen iki string ifadeyi karşılaştırır.
            Console.WriteLine(degisken.CompareTo(degisken2));
            Console.WriteLine(String.Compare(degisken, degisken2, true));
            Console.WriteLine(String.Compare(degisken, degisken2, false));
            Console.ReadKey();

            /*Contains : Belirtilen karakterin bu dize içinde olup 
              olmadığını belirten bir değer döndürür. */
            Console.WriteLine(degisken.Contains(degisken2));
            Console.WriteLine(degisken.EndsWith("Hoşgeldiniz!"));
            Console.WriteLine(degisken.StartsWith("Merhaba!"));
            Console.ReadKey();

            /*IndexOf : Var olan bir dizi içerisinde aradığımız 
             bir elemanın indeks numarasını geriye döndürür.*/
            Console.WriteLine(degisken.IndexOf("CS"));
            Console.WriteLine(degisken.IndexOf("Zikriye"));
            Console.WriteLine(degisken.LastIndexOf("1"));
            Console.ReadKey();

            /*Insert : Bir string değerinin istenilen index'inden 
             itibaren bir başka string değeri eklemek için kullanılır. */
            Console.WriteLine(degisken.Insert(0, "Merhaba! "));
            Console.ReadKey();

            /*PadLeft, PadRight : String bir ifadenin başından ve sonundan
             belitilen karakter sayısı kadar boşluk ile 
             ya da karakter ile başlamasını sağlamaktadır.*/
            Console.WriteLine(degisken + degisken2.PadLeft(30));
            Console.WriteLine(degisken + degisken2.PadLeft(30, '*'));
            Console.WriteLine(degisken.PadRight(50) + degisken2);
            Console.WriteLine(degisken.PadRight(50, '-') + degisken2);
            Console.ReadKey();

            //Remove : String içindeki karakterleri silmek için kullanılır. 
            Console.WriteLine(degisken.Remove(10));
            Console.WriteLine(degisken.Remove(5, 3));
            Console.WriteLine(degisken.Remove(0, 1));
            Console.ReadKey();

            /*Replace : String bir ifade içerisinde yer alan 
             karakterleri değiştirmek için kullanılır.*/
            Console.WriteLine(degisken.Replace("CSharp", "C#"));
            Console.WriteLine(degisken.Replace(" ", "*"));
            Console.ReadKey();

            /*Split : String değişkeninin içindeki verileri
             kelimelere, cümlelere ve ayırmayı sağlar.*/
            Console.WriteLine(degisken.Split(' ')[1]);
            Console.ReadKey();

            //Substring :  Bir karakter aralığını almamızı sağlar.
            Console.WriteLine(degisken.Substring(4));
            Console.WriteLine(degisken.Substring(4, 6));
            Console.ReadKey();
        }
    }
}
