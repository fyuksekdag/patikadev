
Ogrenci ogrenci = new Ogrenci("Lewis", "Hamilton", 244, 5);
ogrenci.OgrenciBilgiGetir();
ogrenci.SinifAtlat();
ogrenci.OgrenciBilgiGetir();
ogrenci.SinifDusur();
ogrenci.OgrenciBilgiGetir();

Ogrenci ogrenci2 = new Ogrenci("Fernando", "Alonso", 235, 2);
ogrenci2.OgrenciBilgiGetir();
ogrenci2.SinifDusur();
ogrenci2.OgrenciBilgiGetir();
ogrenci2.SinifDusur();
ogrenci2.OgrenciBilgiGetir();



class Ogrenci
{
    private string isim;
    private string soyisim;
    private int ogrenciNo;
    private int sinif;

    public string Isim 
    { 
        get {return isim; } 
        set {isim = value;} 
    }

    public string Soyisim { get => soyisim; set => soyisim = value; }
    public int OgrenciNo { get => ogrenciNo; set => ogrenciNo = value; }
    public int Sinif 
    { 
        get => sinif; 
        set 
        {
            if(value < 1)
            {
                Console.WriteLine("Sınıf değeri 1'den küçük olamaz!");
                sinif = 1;
            }
            else
                sinif = value;
        } 
    }

    public Ogrenci(string ısim, string soyisim, int ogrenciNo, int sinif)
    {
        Isim = ısim;
        Soyisim = soyisim;
        OgrenciNo = ogrenciNo;
        Sinif = sinif;
    }

    public Ogrenci(){}

    public void OgrenciBilgiGetir()
    {
        Console.WriteLine("***********OgrenciBilgileri****************");
        Console.WriteLine($"Öğrenci Adı     : {this.Isim}");
        Console.WriteLine($"Öğrenci Soyadı  : {this.Soyisim}");
        Console.WriteLine($"Öğrenci No      : {this.ogrenciNo}");
        Console.WriteLine($"Öğrenci Sınıfı  : {this.Sinif}");
    }

    public void SinifAtlat()
    {
        this.Sinif++;
    }
    public void SinifDusur()
    {
        this.Sinif--;
    }
}