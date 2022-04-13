//List<T> class
//System.Collections.Generic
// T-> object türündedir.

List<int> sayiListesi = new List<int>();

sayiListesi.Add(33);
sayiListesi.Add(34);
sayiListesi.Add(35);
sayiListesi.Add(26);
sayiListesi.Add(37);
sayiListesi.Add(68);

List<string> renkListesi = new List<string>();
renkListesi.Add("Kırmızı");
renkListesi.Add("Sarı");
renkListesi.Add("Turuncu");
renkListesi.Add("Siyah");
renkListesi.Add("Bordo");

//Count
Console.WriteLine(renkListesi.Count);
Console.WriteLine(sayiListesi.Count);

foreach (var sayi in sayiListesi)
{
    Console.WriteLine(sayi);
}
foreach (var renk in renkListesi)
{
    Console.WriteLine(renk);
}

sayiListesi.ForEach(sayi => Console.WriteLine(sayi));
renkListesi.ForEach(renk => Console.WriteLine(renk));

//Listeden eleman çıkarma
sayiListesi.Remove(34);
renkListesi.Remove("Turuncu");

//Indexe göre eleman çıkarma
sayiListesi.RemoveAt(3);

//Liste içerisinde arama
if(renkListesi.Contains("Siyah"))
    Console.WriteLine("Siyah bulundu!");

//Eleman ile indexe erişme
Console.WriteLine(renkListesi.BinarySearch("Bordo"));

//Diziyi List'e çevirme
string[] hayvanlar = {"Kedi", "Köpek", "Kuş"};
List<string> hayvanListesi = new List<string>(hayvanlar);

//Listeyi nasıl temizleriz?
hayvanListesi.Clear();

//Liste içerisinde nesne tutmak
List<Kullanicilar> kullaniciListesi = new List<Kullanicilar>();

Kullanicilar kullanici1 = new Kullanicilar();
kullanici1.Isim = "Hıdır";
kullanici1.Soyisim = "Ali";
kullanici1.Yas = 24;

Kullanicilar kullanici2 = new Kullanicilar();
kullanici2.Isim = "Hasan";
kullanici2.Soyisim = "Kaan";
kullanici2.Yas = 22;

kullaniciListesi.Add(kullanici1);
kullaniciListesi.Add(kullanici2);

List<Kullanicilar> yeniListe = new List<Kullanicilar>();
yeniListe.Add(new Kullanicilar(){
    Isim = "Gül",
    Soyisim = "Arda",
    Yas=25
});

foreach (var kullanici in kullaniciListesi)
{
    Console.WriteLine("Ad:" + kullanici.Isim);
    Console.WriteLine("Soyad: "+ kullanici.Soyisim);
    Console.WriteLine("Yas: " + kullanici.Yas);
}


public class Kullanicilar{
    private string isim;
    private string soyisim;
    private int yas;

    public int Yas { get => yas; set => yas = value; }
    public string Isim { get => isim; set => isim = value; }
    public string Soyisim { get => soyisim; set => soyisim = value; }
}