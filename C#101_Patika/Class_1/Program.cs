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