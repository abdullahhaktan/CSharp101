using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_MainSubjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region YazdırmaKomutları
            //Console.Write("Merhaba Dünya");
            //Console.WriteLine("Selam");

            //Console.WriteLine("***** Yemek Kategorileri *****");
            //Console.WriteLine();
            //Console.WriteLine("1-Çorbalar");
            //Console.WriteLine("2-Ana Yemekler");
            //Console.WriteLine("3-Soğuk başlangıçlar");
            //Console.WriteLine("4-Salatalar");
            //Console.WriteLine("5-Tatlılar");
            //Console.WriteLine("6-İçecekler");
            //Console.WriteLine("6-İçecekler");
            //Console.WriteLine("***** Yemek Kategorileri *****");
            #endregion

            #region Değişkenler

            //string
            //Değişken_türü değişken_adı;

            //string name;
            //name = "Abdullah";
            //Console.Write(name);

            //string customerName;
            //string customerSurname;
            //string customerPhone;
            //string customerEmail,district,city;

            //customerName = "Ali";
            //customerSurname = "Çınar";
            //customerPhone = "+90 500 400 30 20";
            //customerEmail = "deneme@gmail.com";
            //district = "Kadıköy";
            //city = "İstanbul";

            //Console.WriteLine("**** Rezervasyon Kartı ****");
            //Console.WriteLine();
            //Console.WriteLine("---------------------------------------");
            //Console.WriteLine("Müşteri: " + customerName + " " + customerSurname);
            //Console.WriteLine("İletişim: " + customerPhone);
            //Console.WriteLine("Email adresi: " + customerEmail);
            //Console.WriteLine("Adres: " + district + "/" + city);
            //Console.WriteLine("---------------------------------------");

            //Console.WriteLine();
            //customerName = "Ayşegül";
            //customerSurname = "Kaya";
            //customerPhone = "+90 400 300 80 70";
            //customerEmail = "test@gmail.com";
            //district = "Sapanca";
            //city = "Sakarya";

            //Console.WriteLine("---------------------------------------");
            //Console.WriteLine("Müşteri: " + customerName + " " + customerSurname);
            //Console.WriteLine("İletişim: " + customerPhone);
            //Console.WriteLine("Email adresi: " + customerEmail);
            //Console.WriteLine("Adres: " + district + "/" + city);
            //Console.WriteLine("---------------------------------------");


            #endregion

            #region Int Değişkenler

            //Int
            //int number = 24;
            //Console.WriteLine(number);

            int hamburgerPrice = 300;
            int cokePrice = 35;
            int waterPrice = 10;
            int friesPrice = 50;
            int pizzaPrice = 250;
            int lemonadePrice = 30;

            Console.WriteLine("***** Restoran Menü Fiyatı *****");
            Console.WriteLine();
            Console.WriteLine("------ Hamburger Fiyatı: " + hamburgerPrice + "TL");
            Console.WriteLine("------ Pizza: " + pizzaPrice + "TL");
            Console.WriteLine("------ Kola: " + cokePrice + "TL");
            Console.WriteLine("------ Limonata: " + lemonadePrice + "TL");
            Console.WriteLine("------ Kızartma: " + friesPrice + "TL");
            Console.WriteLine("------ Su: " + waterPrice + "TL");
            Console.WriteLine();
            Console.WriteLine("***** Restoran Menü Fiyatı *****");

            Console.WriteLine();

            int hamburgerCount = 3;
            int cokeCount = 5;
            int waterCount = 0;
            int friesCount = 4;
            int pizzaCount = 4;
            int lemonadeCount = 0;

            int totalHamburgerPrice = hamburgerPrice * hamburgerCount;
            int totalCokePrice = cokePrice * cokeCount;
            int totalWaterPrice = waterPrice * waterCount;
            int totalFriesPrice = friesPrice * friesCount;
            int totalPizzaPrice = pizzaPrice * pizzaCount;
            int totalLemonadePrice = lemonadePrice * lemonadeCount;

            Console.WriteLine("---------------------------------");
            Console.WriteLine("Hamburger Tutarı: " + totalHamburgerPrice + " TL");
            Console.WriteLine("Pizza Tutarı: " + totalPizzaPrice + " TL");
            Console.WriteLine("Su Tutarı: " + totalHamburgerPrice + " TL");
            Console.WriteLine("Kızartma Tutarı: " + totalHamburgerPrice + " TL");
            Console.WriteLine("Kola Tutarı: " + totalCokePrice + " TL");
            Console.WriteLine("Limonata Tutarı: " + totalLemonadePrice + " TL");
            Console.WriteLine("---------------------------------");

            int toplamTutar = totalCokePrice + totalHamburgerPrice + totalWaterPrice + totalFriesPrice + totalPizzaPrice + totalLemonadePrice;

            Console.WriteLine("Toplam Ödenecek Tutar: " + toplamTutar);

            #endregion
            Console.Read();
        }
    }
}
