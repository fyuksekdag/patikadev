 Dikdortgen dikdortgen = new Dikdortgen();
 dikdortgen.KisaKenar = 6;
 dikdortgen.UzunKenar = 7;
 Console.WriteLine($"Dikdörtgenin alanı: {dikdortgen.AlanHesapla()}");

 Dikdortgen_struct dikdortgen_struct; // nesne oluşturmadan kullanılabilir.
 dikdortgen_struct.KisaKenar = 4;
 dikdortgen_struct.UzunKenar = 8;
 Console.WriteLine($"Dikdörtgenin alanı: {dikdortgen_struct.AlanHesapla()}"); 
 class Dikdortgen
 {
     public int KisaKenar;
     public int UzunKenar;

    public Dikdortgen(){}
     public int AlanHesapla()
     {
         return this.KisaKenar * this.UzunKenar;
     }
 }
 struct Dikdortgen_struct
 {
     public int KisaKenar;
     public int UzunKenar;

    public Dikdortgen_struct(int kisaKenar, int uzunKenar) { KisaKenar = kisaKenar; UzunKenar = uzunKenar; };
    public int AlanHesapla()
     {
         return this.KisaKenar * this.UzunKenar;
     }
 }