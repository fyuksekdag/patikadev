Calisan calisan1 = new Calisan("Alpaslan", "Ali", 33425539, "Muhasebe");
calisan1.CalisanBilgileriYazdir();

Calisan calisan2 = new Calisan();
calisan2.Ad = "Mert";
calisan2.Soyad = "Kara";
calisan2.No = 33425531;
calisan2.Departman = "İnsan Kaynakları";
calisan2.CalisanBilgileriYazdir();

Calisan calisan3 = new Calisan("Deniz","Dereli");
calisan3.CalisanBilgileriYazdir();

class Calisan
{
    public string Ad;
    public string Soyad;
    public int No;
    public string Departman;
    public Calisan(string ad, string soyad, int no, string departman)
    {
           this.Ad = ad;
           Soyad = soyad;
           this.No = no;
           this.Departman = departman;
    }
    public Calisan(string ad, string soyad)
    {
           this.Ad = ad;
           this.Soyad = soyad;
    }    
    public Calisan(){}
    public void CalisanBilgileriYazdir()
    {
        Console.WriteLine($"Çalışan Adı: {Ad}, Çalışan Soyad: {Soyad}, Çalışan No: {No}, Çalışan Departman: {Departman}");
    }
}