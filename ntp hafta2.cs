using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



// girilen sayının çift tek kontrolü
namespace NumberCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Bir sayı giriniz: ");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number % 2 == 0)
            {
                Console.WriteLine("Girdiğiniz sayı çift bir sayıdır.");
            }
            else
            {
                Console.WriteLine("Girdiğiniz sayı tek bir sayıdır.");
            }
        }
    }
}

// 1 den 10 a kadar sayıları ekrana yazı değeri olarak yazma işlemi


namespace NumberToText
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("1 ile 10 arasında bir sayı giriniz: ");
            int number = Convert.ToInt32(Console.ReadLine());

            switch (number)
            {
                case 1: Console.WriteLine("BİR"); break;
                case 2: Console.WriteLine("İKİ"); break;
                case 3: Console.WriteLine("ÜÇ"); break;
                case 4: Console.WriteLine("DÖRT"); break;
                case 5: Console.WriteLine("BEŞ"); break;
                case 6: Console.WriteLine("ALTI"); break;
                case 7: Console.WriteLine("YEDİ"); break;
                case 8: Console.WriteLine("SEKİZ"); break;
                case 9: Console.WriteLine("DOKUZ"); break;
                case 10: Console.WriteLine("ON"); break;
                default: Console.WriteLine("Lütfen 1 ile 10 arasında bir sayı giriniz."); break;
            }
        }
    }
}


// kullanıcı adı şifre kontrolü


namespace LoginSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Kullanıcı adını giriniz: ");
            string username = Console.ReadLine();

            Console.Write("Şifrenizi giriniz: ");
            string password = Console.ReadLine();

            if (username == "admin" && password == "Admin_32453@")
            {
                Console.WriteLine("Giriş başarılı.");
            }
            else
            {
                Console.WriteLine("Giriş başarısız. Kullanıcı adı veya şifre hatalı.");
            }
        }
    }
}

// sıcaklık durumlarına göre uyarı



namespace TemperatureAlert
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Sıcaklık değerini giriniz: ");
            int temperature = Convert.ToInt32(Console.ReadLine());

            if (temperature >= 10 && temperature < 20)
            {
                Console.WriteLine("Normal sıcaklık.");
            }
            else if (temperature >= 20 && temperature < 30)
            {
                Console.WriteLine("Sıcak.");
            }
            else if (temperature >= 30 && temperature < 40)
            {
                Console.WriteLine("Çok sıcak.");
            }
            else
            {
                Console.WriteLine("Sıcaklık aralık dışı.");
            }
        }
    }
}
