using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_DatabaseCrud
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Crud=>create-read-update-delete
            Console.WriteLine("***** Menü Sipariş İşlem Paneli *****");
            Console.WriteLine();
           
            Console.WriteLine("---------------------------------");

            #region Kategori Ekleme İşlemi
            //Console.WriteLine("Eklemek İstefiğiniz Kategori Adı: ");
            //string categoryName=Console.ReadLine();

            //SqlConnection connection = new SqlConnection("Data Source=DESKTOP-24PQ4L5\\SQLEXPRESS;initial Catalog=EgitimKampiDb;integrated security=true");
            //connection.Open();

            //SqlCommand command = new SqlCommand("insert into TblCategory (CategoryName) values (@p1)", connection);
            //command.Parameters.AddWithValue("@p1", categoryName);
            //command.ExecuteNonQuery();
            //connection.Close();

            //Console.WriteLine("Kategori başarıyla eklendi.");
            #endregion

            #region Ürün Ekleme İşlemi
            //string productName;
            //decimal productPrice;
            ////bool productStatus;

            //Console.Write("Ürün adı: ");
            //productName = Console.ReadLine();

            //Console.Write("Ürün fiyatı: ");
            //productPrice=decimal.Parse(Console.ReadLine());

            //SqlConnection connection = new SqlConnection("Data Source=DESKTOP-24PQ4L5\\SQLEXPRESS;initial Catalog=EgitimKampiDb;integrated security=true");
            //connection.Open();

            //SqlCommand command = new SqlCommand("insert into TblProduct (ProductName,ProductPrice,ProductStatus) values (@p1,@p2,@p3)", connection);
            //command.Parameters.AddWithValue("@p1",productName);
            //command.Parameters.AddWithValue("@p2", productPrice);
            //command.Parameters.AddWithValue("@p3", true);

            //command.ExecuteNonQuery();
            //connection.Close();
            //Console.WriteLine("Ürün Eklemesi Başarılı.");
            #endregion

            #region Ürün Listeleme
            //sqlconnection connection = new sqlconnection("data source=desktop-24pq4l5\\sqlexpress;initial catalog=egitimkampidb;integrated security=true");
            //connection.open();

            //sqlcommand command = new sqlcommand("select * from tblproduct", connection);
            //sqldataadapter adapter = new sqldataadapter(command);
            //datatable datatable = new datatable();
            //adapter.fill(datatable);

            //foreach (datarow row in datatable.rows)
            //{
            //    foreach (var item in row.ıtemarray)
            //    {
            //        console.writeline(item.tostring());
            //    }
            //    console.writeline();
            //}
            //connection.close();
            #endregion

            #region Ürün Silme İşlemi
            //Console.WriteLine("Silinecek ürün Id: ");
            //int productId=int.Parse(Console.ReadLine());

            //SqlConnection connection = new SqlConnection("Data Source=DESKTOP-24PQ4L5\\SQLEXPRESS;initial Catalog=EgitimKampiDb;integrated security=true");

            //connection.Open();
            //SqlCommand command=new SqlCommand("Delete From TblProduct where ProductId=@p1",connection);
            //command.Parameters.AddWithValue("@p1", productId);
            //command.ExecuteNonQuery();

            //connection.Close();

            //Console.WriteLine("Silme işlemi gerçekleşti.");
            #endregion

            #region Ürün Güncelleme İşlemi
            Console.WriteLine("Güncellenecek ürün Id: ");
            int productId=int.Parse(Console.ReadLine());

            Console.WriteLine("Güncellenecek ürün adı: ");
            string productName=Console.ReadLine();

            Console.WriteLine("Güncellenecek ürün fiyatı: ");
            decimal productPrice=decimal.Parse(Console.ReadLine());

            SqlConnection connection = new SqlConnection("Data Source=DESKTOP-24PQ4L5\\SQLEXPRESS;initial Catalog=EgitimKampiDb;integrated security=true");

            connection.Open();
            SqlCommand command = new SqlCommand("Update TblProduct set ProductName=@p1,ProductPrice=@p2 where ProductId=@p3", connection);
            command.Parameters.AddWithValue("@p1", productName);
            command.Parameters.AddWithValue("@p2", productPrice);
            command.Parameters.AddWithValue("@p3", productId);

            command.ExecuteNonQuery();

            connection.Close();


            Console.WriteLine("Güncelleme Başarılı.");
            #endregion

            Console.Read();
        }
    }
}
