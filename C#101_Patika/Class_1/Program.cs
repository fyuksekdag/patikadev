/*
Calisan calisan1 = new Calisan();
calisan1.Ad = "Alpaslan";
calisan1.Soyad = "Ali";
calisan1.No = 33425539;
calisan1.Departman = "Muhasebe";

calisan1.CalisanBilgileriYazdir();

Calisan calisan2 = new Calisan();
calisan2.Ad = "Mert";
calisan2.Soyad = "Kara";
calisan2.No = 33425531;
calisan2.Departman = "İnsan Kaynakları";

calisan2.CalisanBilgileriYazdir();
class Calisan
{
    public string Ad;
    public string Soyad;
    public int No;
    public string Departman;

    public void CalisanBilgileriYazdir()
    {
        Console.WriteLine($"Çalışan Adı: {Ad}, Çalışan Soyad: {Soyad}, Çalışan No: {No}, Çalışan Departman: {Departman}");
    }
}
*/

using System;
using System.Collections.Generic;
using System.IO;

class Person {
    public int age;     
	public Person(int initialAge) {
        // Add some more code to run some checks on initialAge
        age = initialAge;
        if(initialAge < 0)
            {
                age = 0;
                Console.WriteLine("Age is not valid, setting age to 0.");
            }
     }
     public void amIOld() {
        // Do some computations in here and print out the correct statement to the console
        if(age < 13)
            Console.WriteLine("You are young.");
        else if(age > 12 && age < 18)
            Console.WriteLine("You are a teenager.");
        else
            Console.WriteLine("You are old.");

     }

     public void yearPasses() {
        // Increment the age of the person in here
        age++;
     }

static void Main(String[] args) {
        int T=int.Parse(Console.In.ReadLine());
        for (int i = 0; i < T; i++) {
            int age=int.Parse(Console.In.ReadLine());
            Person p=new Person(age);
             p.amIOld();
                for (int j = 0; j < 3; j++) {
                  p.yearPasses();
                }
                p.amIOld();
                Console.WriteLine();
        }
    }
}
