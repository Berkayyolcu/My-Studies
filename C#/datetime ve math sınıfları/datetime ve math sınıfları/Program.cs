using System;

namespace datetime_ve_math_sınıfları
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("\n******* DateTime Kütüphanesi *******\n");


            Console.WriteLine(DateTime.Now); //Yerel bilgisayarın o anki tarih ve saatini döndürür.
            Console.WriteLine(DateTime.Now.Date); //Tarih formatındaki tarih değerini döndürür Saat formatını ise 00:00:00 şeklinde döndürür.
            Console.WriteLine(DateTime.Now.Day); //Tarih bilgisindeki gün sayısını döndürür.
            Console.WriteLine(DateTime.Now.Month); //Tarih bilgisindeki ay sayısını döndürür.
            Console.WriteLine(DateTime.Now.Year); //Tarih bilgisindeki yıl sayısını döndürür.
            Console.WriteLine(DateTime.Now.Hour); // Saat bilgisini döndürür.
            Console.WriteLine(DateTime.Now.Minute); // Dakika bilgisini döndürür.
            Console.WriteLine(DateTime.Now.Second); //Saniye bilgisini döndürür.

            Console.WriteLine(DateTime.Now.DayOfWeek);//String değerde gün bilgisini döndürür.
            Console.WriteLine(DateTime.Now.DayOfYear);//Yılın kaçıncı günde olduğumuzun bilgisini döndürür.

            Console.WriteLine(DateTime.Now.ToLongDateString());//Sadece tarih bilgisini, uzunca DateTime olarak verir. Gün ve ay isimleri görünür.
            Console.WriteLine(DateTime.Now.ToShortDateString());//Sadece tarih bilgisini, gün ay yıl olarak döndürür.
            Console.WriteLine(DateTime.Now.ToLongTimeString());//Sadece Saat dakika ve saniye bilgisi görünür.
            Console.WriteLine(DateTime.Now.ToShortTimeString());//Sadece saat bilgisi, saat ve dakika olarak görünür.

            Console.WriteLine(DateTime.Now.AddDays(2));//O anki günün üzerine ekleme islemi yapar.
            Console.WriteLine(DateTime.Now.AddHours(3));//O anki saatin üzerine ekleme islemi yapar.
            Console.WriteLine(DateTime.Now.AddSeconds(30));//O anki saniyenin üzerine ekleme islemi yapar.
            Console.WriteLine(DateTime.Now.AddMonths(5));//O anki ayın üzerine ekleme islemi yapar.
            Console.WriteLine(DateTime.Now.AddYears(10));//O anki yılın üzerine ekleme islemi yapar.
            Console.WriteLine(DateTime.Now.AddMilliseconds(10));//O anki milisaniyenin üzerine ekleme islemi yapar.


            //Datetime Format
            Console.WriteLine(DateTime.Now.ToString("dd"));//Ayın kaçıncı gün olduğu bilgisini verir.(03)
            Console.WriteLine(DateTime.Now.ToString("ddd"));//Gün bilgisinin bir kısmını gösterir. (paz)
            Console.WriteLine(DateTime.Now.ToString("dddd"));//Gün bilgisinin tamamını gösterir. (pazar)

            Console.WriteLine(DateTime.Now.ToString("MM"));//Kaçıncı ayda olduğumuzu gösterir. (9)
            Console.WriteLine(DateTime.Now.ToString("MMM"));//Ay bilgisinin bir kısmını gösterir. (Eyl)
            Console.WriteLine(DateTime.Now.ToString("MMMM"));//Ay bilgisinin tamamını gösterir. (Eylül)

            Console.WriteLine(DateTime.Now.ToString("yy"));//Yıl bilgisin son 2 basamığını gösterir. (23)
            Console.WriteLine(DateTime.Now.ToString("yyyy"));////Yıl bilgisin son tamamını gösterir. (2023)


            Console.WriteLine("\n******* Math Kütüphanesi ******* \n");


            //Math Kütüphanesi
            Console.WriteLine(Math.Abs(-25));//Girilen sayının mutlak değerini alır.
            Console.WriteLine(Math.Sin(10));//Trigonometri içerisinde bulunan sinüs değerinin hesaplanması için kullanılır.
            Console.WriteLine(Math.Cos(10));//Radyan cinsinden verilen parametredeki değeri bizlere kosinüs değeri olarak döndürür.
            Console.WriteLine(Math.Tan(10));//Girilen sayının tanjantını alır.

            Console.WriteLine(Math.Ceiling(22.3));//Girilen sayıyı yukarı yuvarlar. (23)
            Console.WriteLine(Math.Round(22.3));//Girilen kendine en yakın tamsayı değerine yuvarlar.(22)
            Console.WriteLine(Math.Round(22.6));//Girilen kendine en yakın tamsayı değerine yuvarlar.(23)
            Console.WriteLine(Math.Floor(22.7));//Girilen sayıyı aşağı yuvarlar.(22)

            Console.WriteLine(Math.Max(2,6));//Kendisine parametre olarak girilen iki sayıdan büyük olanı yazdırır.
            Console.WriteLine(Math.Min(2,6));//kendisine parametre olarak girilen iki sayıdan küçük olanı yazdırır.

            Console.WriteLine(Math.Pow(3,4));//Üs alma işlemi gerçekleştirir.(3 ^ 4 ü verir 81)
            Console.WriteLine(Math.Sqrt(9));//Girilen sayının karekökünü bulur.(3)  
            Console.WriteLine(Math.Log(9));//Girilen sayının e tabanında logaritmasını bulur.
            Console.WriteLine(Math.Exp(3));//e üzeri 3 ü verir.
            Console.WriteLine(Math.Log10(10));//Verilen parametreyi 10 tabanında logaritmasının hesaplamasını gerçekleştirerek sonucu gösterir.
            Console.WriteLine(Math.PI);//Matematikteki π (pi) sayısını döndürür. (3,14)

            Console.ReadLine();

        }
    }
}
