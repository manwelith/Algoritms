using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritma_Ödevleri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ciftSayilar();
            tamBolunen();
            nkadarKelime();
            toplamHarf();

            Console.ReadLine();
        }
        static void ciftSayilar()
        {
            var ciftsayilar = new List<int>();
            Console.WriteLine("Bir Sayı Giriniz. (Pozitif olsun)");
            while (true)
            {
                int n = Convert.ToInt32(Console.ReadLine());
                if (n > 0)
                {
                    Console.WriteLine($"{n} tane pozitif sayı giriniz.");
                    var sayilar = new List<int>();
                    while (sayilar.Count <= n - 1)
                    {
                        sayilar.Add(Convert.ToInt32(Console.ReadLine()));
                    }
                    Console.WriteLine($"{n} tane sayıyı başarılı bir şekilde girdiniz.");

                    for (int i = 0; i < sayilar.Count; i++)
                    {
                        if (sayilar[i] % 2 == 0)
                        {
                            ciftsayilar.Add(sayilar[i]);
                        }
                    }

                    break;
                }
                else
                {
                    Console.WriteLine("0'dan büyük bir değer giriniz.");
                }
            }
            foreach (var item in ciftsayilar)
            {

                Console.Write(item + "  ");
            }






        }
        static void tamBolunen()
        {
            Console.WriteLine("2 adet pozitif sayı giriniz.");
            int n = Convert.ToInt16(Console.ReadLine());
            int m = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Başarılı bir şekilde girdiniz.");

            var sayilar = new List<int>();
            Console.WriteLine($"{n} tane pozitif sayı giriniz.");
            while (sayilar.Count <= n - 1)
            {
                sayilar.Add(Convert.ToInt32(Console.ReadLine()));
            }

            for (int i = 0; i < sayilar.Count; i++)
            {
                if (sayilar[i]%m==0 || sayilar[i]==m)
                {
                    Console.Write(sayilar[i] + "  ");
                }
            }



        }
        static void nkadarKelime()
        {
            Console.WriteLine("Pozitif bir sayı giriniz.");
            int n = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine($"{n} tane kelime giriniz.");
            var kelimeler = new List<string>();         
            
            while (kelimeler.Count <= n - 1)
            {
                kelimeler.Add(Console.ReadLine());

            }
            Console.WriteLine($"{n} tane kelimeyi başarılı bir şekilde girdiniz.");

            kelimeler.Reverse();

            foreach (var item in kelimeler)
            {
                Console.Write(item + "  ");
            }
            

        }
        static void toplamHarf()
        {
            Console.WriteLine("Bir cümle giriniz.");
            string cumle = Console.ReadLine();
            string[] kelimeler = cumle.Split(' ');
            Console.WriteLine("Cümlenizde {0} tane kelime vardır.", kelimeler.Length);
            string cumle2=cumle.Replace(" ", "");

            char[] harfler = new char[cumle2.Length];
            
            Console.WriteLine("Cümlenizde {0} tane harf vardır.", harfler.Length);


        }


    }
}
