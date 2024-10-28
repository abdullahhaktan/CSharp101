using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ForeachLoops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region foreach döngüsü

            //Foreach(1;2;3;4)

            //1:değişken türü
            //2:değişken adı
            //3:in
            //4:liste , koleksiyon dizi

            //string[] cities = {"milano","roma","budapeşte",
            //"ankara","istanbul","varşova"};

            //foreach(string x in cities)
            //{
            //    Console.WriteLine(x);
            //}

            //int[] numbers = { 45, 78, 985, 635, 74, 11, 22, 33, 41, 205, 6578, 103, 10304 };

            //foreach(int number in numbers)
            //{
            //    Console.WriteLine(number);
            //}

            //int[] numbers = { 45, 78, 985, 635, 74, 11, 22, 33, 41, 205, 6578, 103, 10304 };

            //foreach (int number in numbers)
            //{
            //    if(number%2==0)
            //        Console.WriteLine(number);
            //}

            //int[] numbers = { 45, 78, 985, 635, 74, 11, 22, 33, 41, 205, 6578, 10394 };

            //int total = 0;

            //foreach(int i in numbers)
            //{
            //    total += i;
            //}

            //Console.WriteLine(total);

            //List<int> numbers = new List<int>()
            //{
            //    1,2,3,4,5,8
            //};

            //foreach (int i in numbers)
            //{
            //    Console.WriteLine(i);
            //}

            //string word = "Merhaba";

            //foreach(char c in word)
            //{
            //    Console.WriteLine(c);
            //}
            #endregion

            #region Örnek Sınav sistemi

            Console.WriteLine(" ***** C# Eğitim Kampı Sınav Uygulaması *****");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            //Sınıftaki öğrenci sayısını kullanıcıdan alma
            Console.WriteLine("--------------------");
            Console.Write("Sınıfınızda kaç öğrenci var: "); ;
            int studentCount = int.Parse(Console.ReadLine());
            Console.WriteLine("--------------------");

            //Öğrenci isimlerini ve not ortamalarını saklayacak diziler
            string[] studentNames = new string[studentCount];
            double[] studentExamAvg = new double[studentCount];

            for (int i = 0; i < studentCount; i++)
            {
                Console.Write($"{i + 1}. öğrencinin adını giriniz: ");
                studentNames[i] = Console.ReadLine();

                double totalExamResult = 0;
           
                //her öğrenci içinn 3 sınav notu girişi

                for(int j=0;j<3;j++)
                {
                    Console.Write($"{studentNames[i]} adlı öğrencinin {i + 1}. sınavı giriniz: ");
                    totalExamResult += int.Parse(Console.ReadLine());
                }
                studentExamAvg[i] = totalExamResult / 3;
            }

            //Öğrencilerin ortalaması ve geçip kalma durumları

            for (int i = 0; i < studentCount; i++)
            {
                Console.WriteLine($"{studentNames[i]} adlı öğrencinin ortalaması: { studentExamAvg[i]}");

                if (studentExamAvg[i] >= 50)
                {
                    Console.WriteLine($"{i + 1}. adlı öğrenci dersi geçti");
                }
                else
                {
                    Console.WriteLine($"{i + 1}. adlı öğrenci dersden geçti");

                }
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine(" ***** C# Eğitim Kampı Sınav Uygulaması *****");

            #endregion



            Console.Read();

        }
    }
}
