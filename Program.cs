﻿using System;

namespace degiskenler
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("");

            byte b = 5;         //1 byte
            sbyte c = 5;        //1 byte

            short u = 5;        //2 byte
            ushort us=5;        //2 byte

            Int16 i16 =2;       //2 byte
            int i = 2;          //4 byte
            Int32 i32 = 2;      //4 byte
            Int64 i64 = 2;      //8 byte

            uint ui = 2;        //4 byte
            long l  =4;         //4 byte
            ulong ul = 4;       //8 byte

            // Reel Sayılar
            float f =5;         //4 byte
            double d = 5;       //8 byte
            decimal de = 5;     //16 byte

            char ch = 2;        //2 byte
            string str = "Kerem"; //sınırsız

            bool b1 = true; 
            bool b2 = false;

            DateTime dt = DateTime.Now;

            Console.WriteLine(dt);

            object o1 = "x";
            object o2 = 'y';
            object o3 = 4;
            object o4 = 4.3;

            //String İfadeler
            string str1 = string.Empty;
            str1 = "Kerem Çelik";
            string ad = "Kerem";
            string soyad = "Çelik";
            string tamIsim = ad + " " + soyad;

            //Integer Tanımalma Şekilleri
             int integer1 = 5;
             int integer2 = 3;
             int integer3 = integer1 + integer2;

             //boolean
             bool bool1 = 10>2;

             //Degisken Dönüsümleri
             string str20 = "20";
             int int20 = 20;
             string yeniDeger = str20 + int20.ToString();
             Console.WriteLine(yeniDeger); // Çıktısı 40

             int int21 = int20 + Convert.ToInt32(str20);
            Console.WriteLine(int21); // Çıktısı 40

            //datetime
            string datetime = DateTime.Now.ToString(dd.mm.yyyy);
            Console.WriteLine(datetime);

            string datetime2 = DateTime.Now.ToString(dd/mm/yyyy);
            Console.WriteLine(datetime2);

            //saat
            string hour = DateTime.Now.ToString(HH.mm);
            Console.WriteLine(hour);



        } 
    }
}
