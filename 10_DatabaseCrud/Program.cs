using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_DatabaseCrud
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Crud-->Create-Read-Update-Delete

            //Console.WriteLine("***** Menü Sipariş İşlem Paneli *****");
            //Console.WriteLine();

            //Console.WriteLine("----------------------------");

            #region Kateori Ekleme İşlemi
            //Console.WriteLine("Eklemek istediğiniz Kategori Adı: ");
            //string categoryName = Console.ReadLine();

            //SqlConnection conn = new SqlConnection("Server=DESKTOP-U7A1D87\\SQLEXPRESS;Database=EgitimKampiDb;Integrated Security=True;TrustServerCertificate=True;");



            //connection.Open();
            //SqlCommand command = new SqlCommand("insert into TBL_CATEGORY(CategoryName) values (@p1)", connection);
            //command.Parameters.AddWithValue("@p1", categoryName);
            //command.ExecuteNonQuery();
            //connection.Close();

            //Console.Write("Kategori başarıyla eklendi!");
            #endregion

            #region ürün Ekleme İşlemi

            //string productName;
            //decimal productPrice;
            //// bool productStatus;

            //Console.Write("Eklemek istediniz ürün adı: ");
            //productName = Console.ReadLine();
            //Console.Write("Ürün Fiyatı: ");
            //productPrice = int.Parse(Console.ReadLine());

            //SqlConnection conn = new SqlConnection("Server=DESKTOP-U7A1D87\\SQLEXPRESS;Database=EgitimKampiDb;Integrated Security=True;TrustServerCertificate=True;");

            //conn.Open();

            //SqlCommand command = new SqlCommand("insert into TBL_PRODUCT(productName,productPrice,productStatus) values (@productName,@productPrice,@productStatus)", conn);

            //command.Parameters.AddWithValue("@productName", productName);
            //command.Parameters.AddWithValue("@productPrice", productPrice);
            //command.Parameters.AddWithValue("@productStatus", true);
            //command.ExecuteNonQuery();
            //conn.Close();

            //Console.Write("Ürün Eklemesi başarıyla tamamlandı...");
            #endregion

            #region Ürün Listeleme İşlemi

            //SqlConnection connection = new SqlConnection("Server=DESKTOP-U7A1D87\\SQLEXPRESS;Database=EgitimKampiDb;Integrated Security=True;TrustServerCertificate=True;");

            //connection.Open();
            //SqlCommand cmd = new SqlCommand("Select * from TBL_PRODUCT", connection);
            //SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            //DataTable dataTable = new DataTable();
            //adapter.Fill(dataTable);

            //foreach(DataRow row in dataTable.Rows)
            //{
            //    foreach(var item in row.ItemArray)
            //    {
            //        Console.Write(item.ToString()+" ");
            //    }
            //    Console.WriteLine();
            // connection.Close();
            //}




            #endregion

            #region Ürün Silme İşlemi

            int prdocutId;

            Console.WriteLine("Lütfen silmek istediğiniz ürünün id'sini giriniz: ");
            prdocutId = int.Parse(Console.ReadLine());

            SqlConnection connection = new SqlConnection("Server=DESKTOP-U7A1D87\\SQLEXPRESS;Database=EgitimKampiDb;Integrated Security=True;TrustServerCertificate=True;");

            connection.Open();

            SqlCommand cmd = new SqlCommand("DELETE FROM TBL_PRODUCT WHERE ProductId=@id",connection);
            cmd.Parameters.AddWithValue("@id", prdocutId);
            cmd.ExecuteNonQuery();

            connection.Close();

            #endregion

            Console.Read();
        }
    }
}
