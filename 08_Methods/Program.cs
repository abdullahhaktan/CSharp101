using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Void Metodlar

            // ()
            //Geriye değer Döndürmeyen Metodlar
            //Customer ---> Listele, ekle, sil,güncelle

            //void CustomerList()
            //{
            //    Console.WriteLine("Ali yıldız");
            //    Console.WriteLine("Ayşe yıldız");
            //    Console.WriteLine("Hakan öztürk");
            //    Console.WriteLine("Merve Çınar");
            //}
            //#endregion

            //CustomerList();
            //CustomerList();
            //CustomerList();
            //CustomerList();

            //void Sum()
            //{
            //    int x = 1;
            //    int y = 2;
            //    int z = x + y;
            //    Console.WriteLine(z);
            //}

            //Sum();

            #endregion

            #region geriye değer Döndürmeyen String Parametreli metotlar

            //void writeMethod(string customerName)
            //{
            //    Console.WriteLine(customerName);
            //}

            //writeMethod("Mehmet yıldırım");

            //void CustomerCard(string name,string surName)
            //{
            //    Console.WriteLine("Müşteri: " + name +" "+ surName);
            //}

            //CustomerCard("Abdullah", "Haktan");
            //CustomerCard("Ahmet", "Haktan");

            #endregion

            #region geriye değer döndürmeyen int parametreli metotlar

            //void sum(int number1,int number2,int number3)
            //{
            //   int toplamDeger=number1 + number2+number3;

            //   Console.WriteLine("Sayıarın toplam  değeri: "+toplamDeger);
            //}

            //sum(1, 2, 3);

            #endregion

            #region geriye değer döndüren metotlar

            //string customerName()
            //{
            //    return "Buse Yıldız";
            //}

            //customerName();

            //string studentCard()
            //{
            //    string name = "Ali";
            //    string surName = "Kaya";

            //    return name + " " + surName;
            //}

            //Console.WriteLine(studentCard());

            #endregion

            #region geriye değer döndüren string parametreli metotlar

            //string CountryCard(string countryName,string capital,string flagColor)
            //{
            //    string cardInfo = "Ülke: " + countryName + " Başkent: " + capital + " Bayrak rengi: "+flagColor;

            //    return cardInfo;
            //}

            //string x, y, z;

            //Console.WriteLine("Ülke Adını giriniz: ");
            //x = Console.ReadLine();


            //Console.WriteLine("Başkenti giriniz: ");
            //y = Console.ReadLine();

            //Console.WriteLine("Bayrak rengini giriniz: ");
            //z = Console.ReadLine();

            //Console.WriteLine(CountryCard(x,y,z));

            #endregion

            #region geriye değer döndüren int parametreli metotlar

            //int Sum(int number1,int number2)
            //{
            //    int result = number1 + number2;
            //    return result;
            //}

            //Console.WriteLine(Sum(45, 98));
            //Console.WriteLine(Sum(36,25));
            //Console.WriteLine(Sum(44,36));
            //Console.WriteLine(Sum(14,20));


            #endregion

            #region örnek uygulamalar
            //string ExamResult(string student ,int exam1, int exam2, int exam3)
            //{
            //    int result = (exam1 + exam2 + exam3) / 3;

            //    if (result >= 50)
            //    {
            //        return student + " adlı öğrenci sınavı geçti";
            //    }

            //    else
            //    {
            //        return student + " adlı öğrenci sınavdan kaldı";
            //    }

            //}

            //Console.WriteLine(ExamResult("Abdullah", 75, 68, 60));

            //Console.WriteLine("Öğrenci adını giriniz: ");
            //string studentName = Console.ReadLine();

            //Console.WriteLine("Sınav1 için değer giriniz: ");
            //int note1 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Sınav2 için değer giriniz: ");
            //int note2 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Sınav3 için değer giriniz: ");
            //int note3 = int.Parse(Console.ReadLine());


            //bool ExamResult1(string name,int not1,int not2,int not3)
            //{
            //    int result = (note1 + note2 + note3) / 3;
            //    if (result >= 50)
            //    {
            //        return true;
            //    }
            //    else
            //    {
            //        return false;
            //    }
            //}
            //bool sonuc = ExamResult1(studentName, note1, note2, note3);

            //if (sonuc)
            //{
            //    Console.WriteLine("Öğrenci sınavı geçti...");
            //}
            //else
            //    Console.WriteLine("Öğrenci sınavdan kaldı");

            //Console.Read();

            #endregion
        }
    }
}