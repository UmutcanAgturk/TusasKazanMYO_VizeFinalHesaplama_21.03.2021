using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TusasKazanMYO_VizeFinalHesaplama_21._03._2021
{
    class Program
    {
        static void Main(string[] args)
        {
            double vize, final, vize2, final2, ortalama;//Verilerini çekip kullanacağımız veriler.
            int sayi;//Belirlediğimiz sayıdaki öğrenci verisi.
            string ogrenci;//Öğrenci isimlerini çektiğimiz veri.

            Console.Write("Sınava Giren Öğrenci Sayısı: ");
            sayi = Convert.ToInt16(Console.ReadLine());
            string[] mevcut = new string[sayi];//bir dizi oluşturarak gereken verileri çekiyoruz
            for (int i = 0; i < sayi; i++)//for döngüsü oluşturarak istediğimiz sayıdaki kadar öğrencinin notunu hesaplıyoruz
            {

                Console.WriteLine();
                Console.WriteLine();
                Console.Write("Öğrenci Adı Giriniz: ");
                ogrenci = Convert.ToString(Console.ReadLine());
                Console.Write("Vize Notunuzu Giriniz: ");//Notumuzun verisini alıyoruz
                vize = Convert.ToInt16(Console.ReadLine());//Notumuzu Bilgisayarın anlayacağı şekilde dönüştürüp bilgisayara okutuyoruz
                Console.Write("Final Notunuzu Giriniz: ");//Notumuzun verisini alıyoruz
                final = Convert.ToInt16(Console.ReadLine());//Notumuzu Bilgisayarın anlayacağı şekilde dönüştürüp bilgisayara okutuyoruz
         

            //Notların matematiksel olarak hesaplamaları
                vize2 = (vize * 4/10);
                final2 = (final * 6/10);
                ortalama = vize2 + final2;

                if (final < 50)//Eğer finalden kalınırsa oromatik olarak ff ile geçirilmeyecektir 
                {
                    Console.Write("Öğrenci Adı:"+ogrenci+" Ortalamanız: " + ortalama + " (Harf Notunuz FF) Final Sınavından 50 Barajını Geçemediniz İçin Kaldınız.");
                    // 'ogrenci'= isimleri direk yazdırıyoruz // 'ortalama' = yaptığımız matematik işleminin verisini vermektedir.
                    Console.WriteLine("Devam etmek istiyorsanız enter tuşuna basınız");
                }
                else
                {
                    //Matematiksel işlemlerden sonra oratalama not verilen değerler arasındaysa o kod aktif ediliyor. 
                    if (ortalama >= 92 && ortalama <= 100)
                    {
                        Console.Write("Öğrenci Adı:" + ogrenci + " Ortalamanız: " + ortalama + " (Harf Notunuz AA) Dersten Pekiyi Derecede Geçtiniz");
                        // 'ogrenci'= isimleri direk yazdırıyoruz // 'ortalama' = yaptığımız matematik işleminin verisini vermektedir.
                        Console.WriteLine("Devam etmek istiyorsanız enter tuşuna basınız");
                    }
                    else if (ortalama >= 82 && ortalama <= 91)
                    {
                        Console.WriteLine("Öğrenci Adı:" + ogrenci + " Ortalamanız: " + ortalama + " (Harf Notunuz BA) Bu Dersten İyi-Pekiyi Derecede Geçtiniz");
                        // 'ogrenci'= isimleri direk yazdırıyoruz // 'ortalama' = yaptığımız matematik işleminin verisini vermektedir.
                        Console.WriteLine("Devam etmek istiyorsanız enter tuşuna basınız");
                    }
                    else if (ortalama >= 73 && ortalama <= 81)
                    {
                        Console.WriteLine("Öğrenci Adı:" + ogrenci + " Ortalamanız: " + ortalama + " (Harf Notunuz BB) Bu Dersten İyi Derecede Geçtiniz");
                        // 'ogrenci'= isimleri direk yazdırıyoruz // 'ortalama' = yaptığımız matematik işleminin verisini vermektedir.
                        Console.WriteLine("Devam etmek istiyorsanız enter tuşuna basınız");
                    }
                    else if (ortalama >= 65 && ortalama <= 72)
                    {
                        Console.WriteLine("Öğrenci Adı:" + ogrenci + " Ortalamanız: " + ortalama + " (Harf Notunuz CB) Bu Dersten Orta-İyi Derecede Geçtiniz");
                        // 'ogrenci'= isimleri direk yazdırıyoruz // 'ortalama' = yaptığımız matematik işleminin verisini vermektedir.
                        Console.WriteLine("Devam etmek istiyorsanız enter tuşuna basınız");
                    }
                    else if (ortalama >= 55 && ortalama <= 64)
                    {
                        Console.WriteLine("Öğrenci Adı:" + ogrenci + " Ortalamanız: " + ortalama + " (Harf Notunuz CC) Bu Dersten Orta Derecede Geçtiniz");
                        // 'ogrenci'= isimleri direk yazdırıyoruz // 'ortalama' = yaptığımız matematik işleminin verisini vermektedir.
                        Console.WriteLine("Devam etmek istiyorsanız enter tuşuna basınız");
                    }
                    else if (ortalama >= 48 && ortalama <= 54)
                    {
                        Console.WriteLine("Öğrenci Adı:" + ogrenci + " Ortalamanız: " + ortalama + " (Harf Notunuz DC) Bu Dersten Şartlı Olarak Geçtiniz");
                        // 'ogrenci'= isimleri direk yazdırıyoruz // 'ortalama' = yaptığımız matematik işleminin verisini vermektedir.
                        Console.WriteLine("Devam etmek istiyorsanız enter tuşuna basınız");

                    }
                    else if (ortalama >= 40 && ortalama <= 47)
                    {
                        Console.WriteLine("Öğrenci Adı:" + ogrenci + " Ortalamanız: " + ortalama + " (Harf Notunuz DD) Bu Dersten Şartlı Olarak Geçtiniiz");
                        // 'ogrenci'= isimleri direk yazdırıyoruz // 'ortalama' = yaptığımız matematik işleminin verisini vermektedir.
                        Console.WriteLine("Devam etmek istiyorsanız enter tuşuna basınız");
                    }
                    else if (ortalama >= 0 && ortalama <= 39)
                    {
                        Console.WriteLine("Öğrenci Adı:" + ogrenci + " Ortalamanız: " + ortalama + " (Harf Notunuz FF) Bu Dersten Kaldınız");
                        // 'ogrenci'= isimleri direk yazdırıyoruz // 'ortalama' = yaptığımız matematik işleminin verisini vermektedir.
                        Console.WriteLine("Devam etmek istiyorsanız enter tuşuna basınız");
                    }

                    if (vize < 0 || vize > 100)
                    {
                        Console.WriteLine("Geçersiz Not");
                        Console.WriteLine("Devam etmek istiyorsanız enter tuşuna basınız");
                    }

                    else if (final < 0 || final > 100)
                    {
                        Console.WriteLine("Geçersiz Not");
                        Console.WriteLine("Devam etmek istiyorsanız enter tuşuna basınız");
                    }
                }
                
                
                
            }
            Console.ReadKey();
        }
    }
}
