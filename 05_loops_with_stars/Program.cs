using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _05_loops_with_stars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region alt alta 10 tane yıldız oluşturun

            //for (int i = 1;i<=10;i++)
            //{
            //    Console.WriteLine("*");
            //}
            #endregion

            #region yan yana 10 tane yıldız oluşturma
            //for (int i = 1;i<=10;i++)
            //{
            //    Console.Write("*");
            //}
            #endregion

            #region Alt alta 10 tane yıldız oluşturma her satırda 10 tane yıldız olsun 
            //for(int j = 1; j <= 10; j++)
            //{
            //    for (int i = 1; i <= 10; i++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            #endregion

            #region Dik Üçgen

            //for(int i=1;i<=5;i++)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #region mete hoca sorduğu algoritma
            //int n = 6;

            //for (int i = 0; i < n; i++)
            //{
            //    if (i != 0)
            //    {
            //        Console.Write("*");
            //    }

            //    int k = i;
            //    while (k > 0)
            //    {
            //        Console.Write(" ");
            //        k--;
            //    }

            //    Console.WriteLine("*");
            //}
            #endregion

            #region Ters Dik Üçgen

            //for (int i=5;i>=1;i--)
            //{
            //    for(int j=1;j<=i;j++)
            //        Console.Write("*");
            //    Console.WriteLine();
            //}

            #endregion

            #region dik ve ters dik içgen beraber

            //for(int i=1;i<=5;i++)
            //{
            //    for(int j=1;j<=i;j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            //for(int i=4;i>=1; i--)
            //{
            //    for(int j=1;j<=i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #region deneme

            //int n = 4; // Üçgenin yüksekliği

            //// Üst kısım (yukarı doğru genişleyen)
            //for (int i = 1; i <= n; i++)
            //{
            //    // Boşlukları yazdır
            //    for (int j = 1; j <= n - i; j++)
            //    {
            //        Console.Write(" ");
            //    }

            //    // Yıldız ve boşlukları yazdır
            //    for (int k = 1; k <= i; k++)
            //    {
            //        Console.Write("* ");
            //    }

            //    Console.WriteLine(); // Satır sonu
            //}

            // Alt kısım (aşağı doğru daralan)
            //for (int i = n - 1; i >= 1; i--)
            //{
            //    // Boşlukları yazdır
            //    for (int j = 1; j <= n - i; j++)
            //    {
            //        Console.Write(" ");
            //    }

            //    // Yıldız ve boşlukları yazdır
            //    for (int k = 1; k <= i; k++)
            //    {
            //        Console.Write("* ");
            //    }

            //    Console.WriteLine(); // Satır sonu

            //}
            #endregion

            #region Baklava Dilimi

            //int m = 5;

            //for (int i = 1; i <= m; i++)
            //{
            //    for (int j = m - i; j > 0; j--)
            //    {
            //        Console.Write(" ");
            //    }

            //    for (int k = 1; k <= 2 * i - 1; k++)
            //    {
            //        Console.Write("*");
            //    }

            //    Console.WriteLine();
            //}

            //for (int i = m - 1; i >= 1; i--)
            //{
            //    for (int j = m - i; j > 0; j--)
            //    {
            //        Console.Write(" ");
            //    }

            //    for (int k = 1; k <= 2 * i - 1; k++)
            //    {
            //        Console.Write("*");
            //    }

            //    Console.WriteLine();
            //}

            #endregion

            #region Piramit

            int n = 5;
            for (int i = 1; i <= n; i++)
            {
                //boşluklar için
                for (int j = n - i; j > 0; j--)
                {
                    Console.Write(" ");
                }

                //yıldızlar için
                for (int k = 1; k <= 2 * i - 1; k++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }

            #endregion

            #region ters piramit

            int n1 = 6;

            for (int i = n1; i >= 1;i--)
            {
                for(int j=n1-i;j>0;j--)
                {
                    Console.Write(" ");
                }
                for(int k=2*i-1;k>0;k--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            #endregion

            Console.ReadLine();
            



        }
    }
}

