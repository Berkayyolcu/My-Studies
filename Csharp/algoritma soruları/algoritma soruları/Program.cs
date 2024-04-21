using System;
using System.ComponentModel;

namespace algoritma_soruları
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //  SORU 1 

            /* Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin(n).
               Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. 
               Kullanıcının girmiş olduğu sayılardan çift olanlar console'a yazdırın. */

            // klavyeden bir sayı girilir 
            Console.Write("Bir Sayı Giriniz : ");
            int sayiAdeti = int.Parse(Console.ReadLine());

            // dizi olusturma
            int[] sayiDizisi = new int[sayiAdeti];

            // klavyeden girilen sayı kadar for ile döngü olusturma
            for (int i = 0; i < sayiAdeti; i++)
            {
                // girilen sayıadeti kadar klavyeden sayı girme
                Console.Write("Lütfen {0}. Sayısı Giriniz : ", i + 1);
                sayiDizisi[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("Girmiş Olduğunuz Çift Sayılar : ");
            int bolunebilenSayi = 0;

            // klavyeden girilen sayı kadar for ile döngü olusturma
            for (int i = 0; i < sayiAdeti; i++)
            {
                /* if ile girilen sayıyı diziye atayıp 
                2 ye tam bölünenleri console yazdırılır.*/
                if (sayiDizisi[i] % 2 == 0)
                {
                    bolunebilenSayi++;
                    Console.Write(sayiDizisi[i] + " ");
                }
            }

            Console.ReadKey();

            Console.WriteLine("\n\n ************************************** \n\n");

            // SORU 2

            /* Bir konsol uygulamasında kullanıcıdan pozitif iki sayı girmesini isteyin (n, m). 
               Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin.
               Kullanıcının girmiş olduğu sayılardan m'e eşit yada tam bölünenleri console'a yazdırın */

            // klavyeden 2 adet sayı girilir 
            Console.Write("Bölmek istediğiniz bir sayı giriniz : ");
            int m = int.Parse(Console.ReadLine());

            Console.Write("Kaç Adet Sayı Girmek İstersiniz : ");
            int adet = int.Parse(Console.ReadLine());

            // dizi olusturma
            int[] sayi = new int[adet];

            // klavyeden girilen sayı kadar for ile döngü olusturma
            for (int i = 0; i < adet; i++)
            {
                // girilen sayıadeti kadar klavyeden sayı girme
                Console.Write("Lütfen {0}. Sayısı Giriniz : ", i + 1);
                sayi[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("{0} Sayısına esit yada tam bölünebilen sayılar : ", m);
            int bolonebilenSayi = 0;

            // klavyeden girilen sayı kadar for ile döngü olusturma
            for (int i = 0; i < adet; i++)
            {
                /* if ile bölünmesini istegimiz sayıyı
                 girdigimiz sayılara esit veya tam
                 bölünenleri console yazdırılır */
                if (sayi[i] % m == 0 || sayi[i] == m)
                {
                    bolonebilenSayi++;
                    Console.Write(sayi[i] + " ");
                }
            }

            Console.ReadKey();

            Console.WriteLine("\n\n ************************************** \n\n");

            // SORU 3

            /* Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin (n). 
             Sonrasında kullanıcıdan n adet kelime girmesi isteyin. 
             Kullanıcının girişini yaptığı kelimeleri sondan başa doğru console'a yazdırın. */

            // klavyeden kac kelime girilecek ise o sayı girilir
            Console.Write("Kaç Adet Kelime Girmek İstersiniz : ");
            int sayii = int.Parse(Console.ReadLine());

            // dizi olusturma
            String[] Dizi = new String[sayii];

            // klavyeden girilen sayı kadar for ile döngü olusturma
            for (int i = 0; i < sayii; i++)
            {
                Console.Write("Lütfen {0}. Kelimeyi Giriniz : ", i + 1);
                Dizi[i] = (Console.ReadLine());
            }

            Array.Reverse(Dizi);
            Console.Write("Girmiş Olduğunuz Kelimeler : ");
            for (int i = 0; i < sayii; i++)
            {
                Console.Write(Dizi[i] + " ");
            }

            Console.ReadKey();

            Console.WriteLine("\n\n ************************************** \n\n");

            // SORU 4

            /* Bir konsol uygulamasında kullanıcıdan bir cümle yazması isteyin. 
              Cümledeki toplam kelime ve harf sayısını console'a yazdırın. */

            // klavyeden bir sayı girilir 
            // girilen cümle (Berkay Yolcu)
            Console.Write("Bir Cümle Yazınız : ");
            String x = Console.ReadLine();

            /* Berkay Yolcu Cümlesinin uzunlugu bulmak için
             0 dan baslar ve 12 harfden olusur */
            int harf = x.Length;

            /* split metodu bir veya daha fazla sınırlayıcıya 
             göre bölerek bir alt dize dizisi oluşturur. */
            string[] bos = x.Split(' ');

            /* bos.length ile iki satıra böler ve sonuc 2 gelir
              harf değiskeninden harf sayısı 12 gelir */

            // 12 (2-1)
            // sonuc 11 olur ve bosluksuzharf değiskenine atanır.
            // toplam kelime : 2
            // toplam harf : 11

            int bosluksuzharf = harf - (bos.Length - 1);
            Console.WriteLine("Toplam Kelime: " + bos.Length + "\nToplam Harf: " + bosluksuzharf);

            Console.ReadKey();
        }
    }
}
