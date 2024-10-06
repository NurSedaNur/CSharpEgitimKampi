using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_MakingDecision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region If Else
            //Console.WriteLine("Lütfen şifreyi giriniz:");
            //string password=Console.ReadLine();
            //if (password == "abcd")
            //{
            //    Console.WriteLine("Şifre doğru");
            //}
            //else
            //{
            //    Console.WriteLine("Şifre yanlış");
            //}

            //string capital, country;
            //Console.WriteLine("Başkenti giriniz:");
            //capital = Console.ReadLine();

            //Console.WriteLine("Ülkeyi giriniz:");
            //country = Console.ReadLine();

            //if(capital =="ankara" &&  country == "Türkiye")
            //{
            //    Console.WriteLine("veriler doğrulandı");
            //}
            //else
            //{
            //    Console.WriteLine("hatalı bilgi");
            //}

            //int number;
            //Console.WriteLine("sayi giriniz");
            //number = int.Parse(Console.ReadLine());
            //if (number == 5)
            //{
            //    Console.WriteLine("sayı doğru");
            //}
            //else 
            //{
            //    Console.WriteLine("sayı hatalı");
            //}

            //int exam1, exam2, exam3, average;
            //string result = "";

            //Console.Write("Sınav 1:");
            //exam1=int.Parse(Console.ReadLine());
            //Console.Write("Sınav 2:");
            //exam2 = int.Parse(Console.ReadLine());
            //Console.Write("Sınav 3:");
            //exam3 = int.Parse(Console.ReadLine());

            //average = (exam1 + exam2 + exam3) / 3;
            //Console.WriteLine("Sınavların ortalaması:"+average);

            //if(average>0 && average <= 50)
            //{
            //    result = "sonuç vasat";
            //}
            //if (average > 50 && average <= 70)
            //{
            //    result = "sonuç orta";
            //}
            //if (average > 70 && average <= 84)
            //{
            //    result = "sonuç iyi";
            //}
            //if(average > 84)
            //{
            //    result = "sonuç çok iyi";
            //}
            //Console.WriteLine(result);

            //string city;
            //Console.WriteLine("lütfen bir şehir girişi yapınız:");
            //city = Console.ReadLine();

            //if(city=="adana" | city == "ankara" | city == "bursa" | city == "trabzon")
            //{
            //    Console.WriteLine("şehir mevcut");
            //}
            //else
            //{
            //    Console.WriteLine("şehir mevcut değil");
            //}

            //Console.WriteLine("Lütfen kullanıcı adını girimiz:");
            //string userName=Console.ReadLine();

            //if (userName != "admin")
            //{
            //    Console.WriteLine("Bu kullanıcı adı kabul edilemez");
            //}
            //else
            //{
            //    Console.WriteLine("Hoş geldiniz");
            //}

            #endregion

            #region Mod İşlemleri

            //int number = 26;
            //int result = number % 5;
            //Console.Write(result);

            //Console.WriteLine("Lütfen birinci sayıyı giriniz:");
            //int number1=int.Parse(Console.ReadLine());

            //Console.WriteLine("Lütfen ikinci sayıyı giriniz:");
            //int number2 = int.Parse(Console.ReadLine());

            //int result=number1%number2;
            //Console.WriteLine("1.sayının 2. sayıya bölümünden kalan:"+result);

            //Console.WriteLine("Lütfen sayıyı giriniz:");
            //int number=int.Parse(Console.ReadLine());

            //if (number % 2 == 0)
            //{
            //    Console.WriteLine("sayı çifttir");
            //}
            //else
            //{
            //    Console.WriteLine("sayı tektir");
            //}

            #endregion

            #region Char
            //char team;
            //Console.WriteLine("Lütfen takım sembolü giriniz:");
            //team=char.Parse(Console.ReadLine());

            //if(team =='g' | team == 'G')
            //{
            //    Console.WriteLine("Galatasaray");
            //}
            //if (team == 'f' | team == 'F')
            //{
            //    Console.WriteLine("Fenerbahçe");
            //}
            //if (team == 'b' | team == 'B')
            //{
            //    Console.WriteLine("Beşiktaş");
            //}

            #endregion

            #region Örnek Uygulama

            //Console.WriteLine("****** C# Eğitim Kampı Restoran ******");
            //Console.WriteLine();
            //Console.WriteLine("-----------------------------------");
            //Console.WriteLine("1-Ana Yemekler");
            //Console.WriteLine("2-Çorbalar");
            //Console.WriteLine("3-Pizzalar");
            //Console.WriteLine("4-İçecekler");
            //Console.WriteLine("5-Tatlılar");
            //Console.WriteLine("-----------------------------------");

            //string menuItem;
            //Console.Write("Detaylarını görmek isteidğiniz menüyü seçiniz:");
            //menuItem = Console.ReadLine();

            //if (menuItem == "1")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("---------- Ana Yemekler ----------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Köri Soslu Tavuk");
            //    Console.WriteLine("2-Kızartma Tabağı");
            //    Console.WriteLine("3-Fasulye Pilav");
            //    Console.WriteLine("4-Fırında Somon");
            //    Console.WriteLine("5-Patlıcan Musakka");
            //    Console.WriteLine("---------- Ana Yemekler ----------");
            //    Console.WriteLine();
            //}
            //if (menuItem == "2")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("---------- Çorbalar ----------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Mercimek Çorbası");
            //    Console.WriteLine("2-Ezogelin Çorbası");
            //    Console.WriteLine("---------- Çorbalar ----------");
            //    Console.WriteLine();
            //}
            //if (menuItem == "3")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("---------- Pizzalar ----------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Akdeniz Pizza");
            //    Console.WriteLine("2-Margaritha");
            //    Console.WriteLine("3-Tavuklu Pizza");
            //    Console.WriteLine("---------- Pizzalar ----------");
            //    Console.WriteLine();
            //}
            //if (menuItem == "4")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("---------- İçecekler ----------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Kola");
            //    Console.WriteLine("2-Ayran");
            //    Console.WriteLine("3-su");
            //    Console.WriteLine("---------- İçecekler ----------");
            //    Console.WriteLine();
            //}
            //if (menuItem == "5")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("---------- Tatlılar ----------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Triliçe");
            //    Console.WriteLine("2-Kazandibi");
            //    Console.WriteLine("3-Sütlaç");
            //    Console.WriteLine("---------- Tatlılar ----------");
            //    Console.WriteLine();
            //}


            #endregion

            #region Switch Case
            //Console.Write("Lütfen ay girişi yapınız:");
            //int monthNumber=int.Parse(Console.ReadLine());

            //switch (monthNumber)
            //{
            //    case 1:Console.Write("Ocak");break;
            //    case 2: Console.Write("Şubat"); break;
            //    case 3: Console.Write("Mart"); break;
            //    case 4: Console.Write("Nisan"); break;
            //    case 5: Console.Write("Mayıs"); break;
            //    case 6: Console.Write("Haziran"); break;
            //    case 7: Console.Write("Temmuz"); break;
            //    case 8: Console.Write("Ağustos"); break;
            //    case 9: Console.Write("Eylül"); break;
            //    case 10: Console.Write("Ekim"); break;
            //    case 11: Console.Write("Kasım"); break;
            //    case 12: Console.Write("Aralık"); break;
            //    default: Console.Write("Hatalı Giriş");break;
            //}
            #endregion

            #region Switch Case Hesap Makinesi
            int number1, number2, result;
            char symbol;

            Console.Write("1.Sayıyı giriniz:");
            number1=int.Parse(Console.ReadLine());
            Console.Write("2.Sayıyı giriniz:");
            number2=int.Parse(Console.ReadLine());

            Console.Write("Lütfen yapmak istediğiniz işlemi giriniz:");
            symbol=char.Parse(Console.ReadLine());

            switch (symbol)
            {
                case '+': result=number1 + number2; Console.Write("Toplam: "+result); break;
                case '-': result=number1 - number2; Console.Write("Fark: " + result); break;
                case '*': result=number1 * number2; Console.Write("Çarpım: " + result); break;
                case '/': result=number1 / number2; Console.Write("Bölüm: " + result); break;
            }
            #endregion

            Console.Read();
        }
    }
}
