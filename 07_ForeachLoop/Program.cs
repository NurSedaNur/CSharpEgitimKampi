using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ForeachLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Foreach Döngüsü
            //Forecah(1;2;3;4)
            //1:Degisken türü
            //2:DEgsiken adı
            //3:In
            //4:Liste,Koleksiyon,Dizi

            //string[] cities = { "milano", "roma", "budapeşte", "ankara", "istanbul", "varşova" };
            //foreach (string city in cities)
            //{
            //    Console.WriteLine(city);
            //}

            //int[] numbers = { 45, 78, 985, 635, 74, 11, 22, 33, 41, 205, 6578, 10394 };
            //foreach (int i in numbers)
            //{
            //    if(i%2 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //int[] numbers = { 45, 78, 985, 635, 74, 11, 22, 33, 41, 205, 6578, 10394 };
            //int total = 0;
            //foreach (int i in numbers)
            //{
            //    total += i;
            //}
            //Console.WriteLine(total);

            //List<int> list = new List<int>()
            //{
            //    1,2,34,5,8
            //};
            //foreach (int i in list)
            //{
            //    Console.WriteLine(i);
            //}

            //string word = "Merhaba";
            //foreach (char c in word)
            //{
            //    Console.WriteLine(c);
            //}
            #endregion

            #region Örnek Sınav Sistemi Uygulaması
            Console.WriteLine("***** C# Eğitim Kampı Uygulaması *****");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            //Sınıftaki öğrenci sayısını kullanıcıdan almak
            Console.WriteLine("------------------------------");
            Console.WriteLine("Sınıfınızda kaç öğrenci var?");
            int studentCount=int.Parse(Console.ReadLine());
            Console.WriteLine("------------------------------");

            //Öğrenci isimlerini ve not ortalamalarını saklayacak diziler
            string [] studentNames =new string[studentCount];
            double[] studentExamAvg=new double[studentCount];

            for (int i = 0; i < studentCount; i++)
            {
                Console.Write($"{i + 1}. Öğrencinin adı: ");
                studentNames[i] = Console.ReadLine();

                double totalExampleResult = 0;

                //Her öğrenci için 3 sınav notu girişi
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"{studentNames[i]} isimli öğrencinin {j + 1}. Notunu giriniz: ");
                    double value=double.Parse(Console.ReadLine());
                    totalExampleResult += value;//notları topluyoruz
                }
                Console.WriteLine();
                studentExamAvg[i] = totalExampleResult/3;
            }

            //Sıav ortalamaları
            for (int i = 0; i < studentCount; i++)
            {
                Console.WriteLine("------------------------------");
                Console.WriteLine($"{studentNames[i]} adlı öğreninin ortalaması: {studentExamAvg[i]}");

                //Öğrencilerin ortalaması ve geçip kalma durumları
                if (studentExamAvg[i] >= 50)
                {
                    Console.WriteLine($"{studentNames[i]} adlı öğrenci dersi geçti.");
                }
                else
                {
                    Console.WriteLine($"{studentNames[i]} adlı öğrenci dersten kaldı.");
                }
                Console.WriteLine("------------------------------");
            }
            #endregion


            Console.Read();
        }
    }
}
