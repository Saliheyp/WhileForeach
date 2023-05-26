using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //while
            // 1 den başlayarak konsoldan girilen sayıya kadar (dahil)olan sayıların ortalamaları 
            // Console.WriteLine("bir sayı giriniz");
            
            // int sayi1 =Int32.Parse(Console.ReadLine());
            // int sayac = 1;
            // int toplam = 0;
            // while (sayac <= sayi1)
            // {
            //     toplam += sayac;
            //     sayac++;
            // }
            // Console.WriteLine(toplam/sayi1);

            // a dan z ye kadar olan bütün harfleri konsola yazdıralom
            // char karakter = 'a';
            // while (karakter <= 'z')
            // {
            //     Console.Write(karakter);
            //     karakter++;
            // }
            Console.WriteLine("*********foreach*******");
            string[] arabalar ={"bmw","ford","nissan","toyota"};
            
            foreach (var araba in arabalar)
            {
                Console.WriteLine(araba);
            }



        }
    }
}