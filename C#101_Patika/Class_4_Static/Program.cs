Console.WriteLine("Çalışan Sayısı: " + Calisan.CalisanSayisi); //
Calisan calisan1 = new Calisan("Ali", "Veli", "İK");
Calisan calisan2 = new Calisan("Ali", "Veli", "İK");
Calisan calisan3 = new Calisan("Ali", "Veli", "İK");
Console.WriteLine("Çalışan Sayısı: " + Calisan.CalisanSayisi);

Console.WriteLine($"Toplama Sonucu: {Islemler.Topla(259,41)}");
Console.WriteLine($"Çıkarma Sonucu: {Islemler.Cikar(259,41)}");
class Calisan
{
    private static int calisanSayisi;

    public static int CalisanSayisi { get => calisanSayisi;}

    private string isim;
    private string soyisim;
    private string departman;
    
    static Calisan() //Sadece ilk çalıştırmada bir kere giriliyor.
    {
        calisanSayisi = 0;
    }

    public Calisan(string Isim, string Soyisim, string Departman)
    {
        this.isim = Isim;
        this.soyisim = Soyisim;
        this.departman = Departman;
        calisanSayisi++;
    }
}

static class Islemler
{
    public static long Topla(int x, int y)
    {
        return x + y;
    }
    public static long Cikar(int x, int y)
    {
        return x - y;
    }
}