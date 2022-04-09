// out parametreler
string sayi = "999";
int outSayi;

bool sonuc = int.TryParse(sayi, out outSayi);
if (sonuc)
{
    Console.WriteLine("Dönüşüm gerçekleştirildi.");
}
else
{
    Console.WriteLine("Dönüşüm gerçekleştirilemedi.");
}
Metotlar instance = new Metotlar();
instance.Topla(4,2, out int toplamSonuc); // return yerine out kullanılabilir
Console.WriteLine(toplamSonuc);

// Metot Overloading

int number = 987;
instance.EkranaYazdir(Convert.ToString(number));
instance.EkranaYazdir(number);

instance.EkranaYazdir("Python is", " the best");

//Metot Imzası
//metotAdı + parametre sayisi + parametre (Overloading olabilmesi için sadece bunlar farklılaştırılabilir.)

class Metotlar
{
    public void Topla(int a, int b, out int toplam)
    {
        toplam = a+b;
    }
    public void EkranaYazdir(string veri)
    {
        Console.WriteLine(veri);
    }
    public void EkranaYazdir(int veri)
    {
        Console.WriteLine(veri);
    }
    public void EkranaYazdir(string veri, string veri2)
    {
        Console.WriteLine(veri + veri2);
    }
}