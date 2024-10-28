using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Temel Dizi Örnekleri
            //2,4,6,8
            //sarı,kırmızı,mavi,turuncu,beyaz
            //adana,ankara,istanbul,burs
            //DeğişkenTürü [] DiziAdı = new DeğişkenTürü(ElemanSayısı)
            //string[] colors = new string[4];
            //colors[0] = "kırmızı";
            //colors[1] = "Sarı";
            //colors[2] = "Mavi";
            //colors[3] = "Beyaz";


            //Console.WriteLine(colors[2]);

            //string[] cities = new string[5];
            //cities[0] = "Milano";
            //cities[1] = "Budapeşte";
            //cities[2] = "Lyon";
            //cities[3] = "Kahire";
            //cities[4] = "Üsküp";

            //Console.WriteLine(cities[5]); // hata verir

            //int[] numbers = new int[10];
            //numbers[0] = 50;
            //numbers[1] = 48;
            //numbers[2] = 698;
            //numbers[3] = 24;
            //numbers[7] = 748;
            //Console.WriteLine(numbers[5]);

            //string[] cities = { "Prag", "Roma", "Atina", "Ankara", "Bursa" };

            //Console.WriteLine(cities[2]);

            #endregion

            #region dizideki tüm elemanları listeleme

            //string[] colors = { "Sarı", "Kırmızı", "Beyaz", "Mavi", "Yeşil", "Turuncu", "Pembe" };

            //for (int i = 0; i < colors.Length; i++)
            //{
            //    Console.WriteLine(colors[i]);
            //}



            //int[] numbers = { 4, 85, 96, 74, 75, 125, 635, 522, 488, 520, 7456, 23 };

            //for(int i=0;i<numbers.Length; i++)
            //{
            //    if (numbers[i]%3 == 0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}

            //char[] symbols = { 'a', 'b', 'c', '*', '/', '-' };
            //for(int i=0;i<symbols.Length; i++)
            //{
            //    Console.WriteLine(symbols[i]);
            //}

            #endregion

            #region dizi maximumu bulma

            //int[] myArray = { 47, 85, 95, 41, 25, 635, 789, 85 };

            //int maxNumber = myArray[0];

            //for(int i=0;i<myArray.Length;i++)
            //{
            //    if(myArray[i] > maxNumber)
            //        maxNumber = myArray[i];
            //}

            //Console.WriteLine(maxNumber);

            //string[] persons = { "ali", "ahmet", "ayşe", "buse", "cem", "deniz" };
            //Console.WriteLine(persons.Length);

            //int[] numbers = { 45, 85, 52, 41, 86, 10, 22, 35 };
            //Array.Sort(numbers);
            //for(int i=0;i<numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            //int[] numbers = { 45, 85, 52, 41, 86, 10, 22, 35 };
            //Array.Reverse(numbers);
            //for(int i = 0;i<numbers.Length;i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            #endregion

            #region Dizi Metotlar

            //string[] customers = { "ali", "buse", "ayşegül", "merve", "çına", "kaya" };
            //int index = Array.IndexOf(customers, "merve");

            //Console.WriteLine(index);

            //int[] numbers = { 45, 85 ,96,63,74,10,25,22,36};
            //Console.WriteLine("Dizini en büyük elemanı: " + numbers.Max() + " - Dizinin en küçük elemanı: " + numbers.Min());

            #endregion

            #region Kullanıcıdan Değer Alma

            //string[] cities = new string[6];

            //for(int i=0; i < cities.Length; i++)
            //{
            //    Console.WriteLine($"Lütfen {i + 1}. şehri giriniz: ");
            //    cities[i] = Console.ReadLine();
            //}
            //Console.WriteLine();
            //for (int i = 0; i < cities.Length; i++)
            //{
            //    Console.WriteLine(cities[i]);
            //}

            //int[] numbers = { 10, 20, 30, 40, 50 };
            //int sum = 0;

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    sum += numbers[i];
            //}

            //Console.WriteLine(sum);

            int[] numbers = { 12, 24, 34, 32, 27, 67, 92 };
            Console.WriteLine("------ Çift Sayılar ------");

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                    Console.WriteLine(numbers[i]);
            }

            Console.WriteLine();

            Console.WriteLine("-------------------");

            Console.WriteLine();

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 != 0)
                    Console.WriteLine(numbers[i]);
            }

            Console.WriteLine("Tüm sayıların toplamı ise: "+numbers.Sum());

            Console.WriteLine();

            #endregion


            Console.Read();
        }
    }
}
