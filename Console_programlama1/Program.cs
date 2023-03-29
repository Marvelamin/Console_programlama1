using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Console_programlama1
{
    class Program
    {
        static void Main(string[] args)
        {

            byte b = 5;// 1 byte
            sbyte c = 5; // 1 byte

            short s = 5;//2 byte
            ushort us = 5;   //2 byte

            Int16 int16 = 2;// 2 byte
            int i = 2; // 2 byte
            Int32 int32 = 2;// 4 byte
            Int64 int64 = 2;    // 8 byte

            uint ui = 2; // 4 byte
            long l = 4;// 8 byte
            ulong ul = 4;// 8 byte

            // Reel Sayılar

            float f = 5;// 4 byte
            double d = 5;// 8 byte
            decimal dc = 5;// 16 byte

            char ch = '2';// 2 byte
            string str = "EFE";// SINIRSIZ

            bool b1 = true;
            bool b2 = false;
            DateTime dt = DateTime.Now;
            Console.WriteLine(dt);

            object o1 = 'x';
            object o2 = 'y';
            object o3 = 4.3;

            //string ifadeler

            string str1 = null;
            string str2 = string.Empty;
            string str3 = "";



            //integer tanımlama şekilleri

            int i1 = 5;
            int i2 = 4;
            int i3 = i1 + i2;

            //boolen
            bool bool1 = 10 > 2;

            //Değişken dönüştürme

            string str4 = "20";
            int i5 = 20;

            string yenideger = str4 + i5.ToString();
            Console.WriteLine(yenideger);//çıktısı 2020

            int i6 = i5 + Convert.ToInt16(str4);
            Console.WriteLine(i6);//çıktısı 40

            int i22 = i5 + int.Parse(str4);
            Console.WriteLine(i22);

            String datetime = DateTime.Now.ToString("dd/mm/yyyy");
            Console.WriteLine(datetime);

            //saat

            String hour = DateTime.Now.ToString("hh.mm");
            Console.WriteLine(hour);
           




        }
    }
}
