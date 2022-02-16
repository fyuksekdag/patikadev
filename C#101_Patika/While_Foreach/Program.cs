int toplam = 0;
int n = int.Parse(Console.ReadLine());
int i = 0;
while (i <= n)
{
    toplam += i;
    i++;
}
float ort = (toplam / n);
Console.WriteLine("Girdiğiniz sayıların ortalaması: " + ort);

// a'dan z'ye
char c = 'a';
while (c <= 'z')
{
    Console.Write(c);
    c++;
}

Console.WriteLine("******* Foreach ********");

string[] arabalar = {"Mercedes", "BMW", "Audi", "Opel"};


foreach (var araba in arabalar)  // var tipi belli olmayan, genel bir tanımlama, generic
{
    int uzunluk = araba.Length;
    Console.WriteLine(araba + " Harf sayısı: "+ uzunluk);
}