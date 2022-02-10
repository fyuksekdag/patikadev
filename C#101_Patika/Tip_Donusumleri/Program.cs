using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Implicit Conversion");
            // Implicit Conversion (Bilinçsiz Dönüşüm)
            byte a = 5;
            sbyte b = 30;
            short c = 10;

            int d = a+b+c; // d üstteklilerden daha küçük olsaydı atama işlemi yapılamazdı.
            Console.WriteLine("d:" + d);

            long h = d; // long integerdan büyüktür.
            Console.WriteLine("h:" + h);

            float i = h;
            Console.WriteLine("i:" + i);

            string e = "firat";
            char f = 'k';
            object g = e+f+d;
            Console.WriteLine("g:" + g); // objectte hepsini birleştirebiliyorum veri tiplerinin.

            // Explicit Conversion (Bilinçli Dönüşüm)
            Console.WriteLine("***** Explicit Conversion *****");
            int x = 4;
            byte y = (byte)x; // parantez içindeki veri tipi sağındaki veri tipini dönüştürür.
            Console.WriteLine("y:" + y);

            int z = 100;
            byte t = (byte)z;
            Console.WriteLine("t:" + t);

            float w = 10.3f;
            byte v = (byte)w;
            Console.WriteLine("v:" + v);

            // **** To String Methodu ****

            int xx = 6;
            string yy = xx.ToString();
            Console.WriteLine("yy:" + yy);

            string zz = 12.5f.ToString();
            Console.WriteLine("z:" + zz);

            // System.Convert
            string s1 = "10", s2 = "20";
            int sayi1, sayi2;
            int Toplam;

            sayi1 = Convert.ToInt32(s1);
            sayi2 = Convert.ToInt32(s2);
            Toplam = sayi1 + sayi2;
            Console.WriteLine("Toplam:" + Toplam);

            // Parse
            ParseMethod();
        }
        public static void ParseMethod()
        {
            string metin1 = "10";
            string metin2 = "10.25";
            int rakam1;
            double double1;

            rakam1 = Int32.Parse(metin1); // string ifadeyi int'e dönüştürdük, parse her zaman string alır.
            double1 = Double.Parse(metin2); // case sens 
            Console.WriteLine("Rakam:" + rakam1);
            Console.WriteLine("Double:" + double1);
        }
    }
}