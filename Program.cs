﻿
using System;
using System.Data.SqlTypes;

// namespace declaration 
namespace HelloWorldApp
{
    
    // Class declaration 
    class HomeWork
    {
        
        static void minance(int a, int b)
        {
            Console.WriteLine(a-b);
        }

        static void square(int a)
        {
            Console.WriteLine(a*a);
        }

        static void mod(int a, int b)
        {
            Console.WriteLine(a%b);
        }

        // Main Method 
        static void Main(string[] args)

        {

        // 2 sayının farkını bulan c# kodu
        int e = 4;
        int s = 6;
        int y = s - e;
        Console.WriteLine("çıkarma işlemi sonucu:" + y);
        Console.ReadKey();

            // 2 sayının farkını bulan c# kodu2
            int a = 1;
            int b = 2;
            minance(a, b);

            // 5 sayısının karesini bulan c# kodu
            int k = 5;
            int kare = k * k;
            Console.WriteLine("5 sayısısnın karesi:" + kare);

            // 5 sayısının karesini bulan c# kodu2
            a = 5;
            square(a);

            // 10 sayısının 3e bölümünden kalanı bulan c# kodu
            int l = 10; int r = 3;
            int kalan = l % r;
            Console.WriteLine("10 sayısının 3e bolumunden kalan:" + kalan);

            // 10 sayısının 3e bölümünden kalanı bulan c# kodu
            a = 10;
            b = 3;
            mod(a, b);

            // 10 sayısının 3e bölümünden kalanı bulan c# kodu
            Console.WriteLine("1. Sayıyı Giriniz");
            int Sayi_1= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2. Sayıyı Giriniz");
            int Sayi_2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("3. Sayıyı Giriniz");
            int Sayi_3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("4. Sayıyı Giriniz");
            int Sayi_4 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Girmiş olduğunuz 4 sayının çarpımı: "+ (Sayi_1 * Sayi_2 * Sayi_3 * Sayi_4 ) + 
                              "\nGirmiş olduğunuz 4 sayının toplamı: " + (Sayi_1 + Sayi_2 + Sayi_3 + Sayi_4 ));

            // klavyeden girilen 2 syının bölümünü bulan c# kodu
            Console.WriteLine("bölüneni giriniz:");
            int sayi_5 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("bölümü giriniz:");
            int sayi_6 = Convert.ToInt32(Console.ReadLine());
            int bolum = sayi_5 / sayi_6;
            Console.WriteLine("girmis oldugunuz iki sayinin bolumu:" + bolum);

            // klavyeden girilen dikdörtgenler prizmasının hacmini hesaplayan c# kodu
            Console.WriteLine("1. kenarı giriniz:");
            int kenar_1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2. kenarı giriniz:");
            int kenar_2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("3 kenarı giriniz:");
            int kenar_3 = Convert.ToInt32(Console.ReadLine());
            int hacim = kenar_1 * kenar_2 * kenar_3;
            Console.WriteLine("dikdortgenin hacmi:" + hacim);



            Console.ReadKey();
        }
    }
}


