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
            #region Void Metotlar
            //void CustomerList()
            //{
            //    Console.WriteLine("Ali Yıldız");
            //    Console.WriteLine("Ayşe Yıldız");
            //    Console.WriteLine("Hakan Öztürk");
            //    Console.WriteLine("Merve Çınar");
            //}
            //CustomerList();

            //void Sum()
            //{
            //    int x = 1, y = 2;
            //    int z = x + y;
            //    Console.WriteLine(z);
            //}
            //Sum();
            #endregion

            #region Geriye Değer Döndürmeyen String Parametreli Metodlar
            //void WriteMethod(string customerName)
            //{
            //    Console.WriteLine(customerName);
            //}
            //WriteMethod("Mehmet Yıldırım");

            //void CustomerCard(string name, string surName)
            //{
            //    Console.WriteLine("Name: " + name + " Surname: " + surName);
            //}
            //CustomerCard("Mehmet", "Yıldız");
            //CustomerCard("Ayşegül", "Kaya");
            #endregion

            #region Geriye Değer Döndürmeyen int Parametreli Metodlar
            //void Sum(int number1,int number2,int number3)
            //{   
            //    int result=number1+number2 +number3;
            //    Console.WriteLine(result);
            //}
            //Sum(1 , 2 , 3);
            #endregion

            #region Geriye Değer Döndüren Metotlar
            //string CustomerName()
            //{
            //    return "Buse YILDIZ";
            //}
            //Console.WriteLine(CustomerName());

            //string StudentCard()
            //{
            //    string name = "Ali";
            //    string surname = "Kaya";
            //    return name+" "+surname;
            //}
            //Console.WriteLine(StudentCard());
            #endregion

            #region Geriye Değer Döndüren Parametreli Metotlar
            //string CountryCard(string countryName,string capital,string flagColor){
            //    string cardInfo = "Ülke: " + countryName + " - Başkent: " + capital + " - Bayrak Rengi:" + flagColor;
            //    return cardInfo;
            //}
            //string x, y, z;
            //Console.WriteLine("Ülke adını giriniz: ");
            //x = Console.ReadLine();

            //Console.WriteLine("Başkenti girniz: ");
            //y= Console.ReadLine();

            //Console.WriteLine("Bayrak rengini giriniz: ");
            //z= Console.ReadLine();

            //Console.WriteLine(CountryCard(x, y, z));
            //Console.WriteLine(CountryCard("Türkiye", "Ankara", "kırmızı-beyaz"));
            #endregion

            #region Geriye Değer Döndüren Int Paramatreli Metotlar
            //int Sum(int number1, int number2)
            //{
            //    int result = number1 + number2;
            //    return result;
            //}
            //Console.WriteLine(Sum(45, 98));
            //Console.WriteLine(Sum(36, 25));
            //Console.WriteLine(Sum(44, 36));
            //Console.WriteLine(Sum(14, 20));
            #endregion

            #region Örnek Uygulama
            string ExamResult(string student, int exam1, int exam2, int exam3)
            {
                int result = (exam1 + exam2 + exam3) / 3;
                if (result >= 50)
                {
                    return student + " adlı öğrenci sınavı geçti. Ortalama: " + result;
                }
                else
                {
                    return student + " adlı öğrenci başarısız oldu. Ortalama: " + result;
                }
            }
            Console.WriteLine(ExamResult("Ali", 50, 55, 60));
            #endregion
            Console.Read();
        }
    }
}
