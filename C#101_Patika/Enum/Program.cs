Console.WriteLine(Gunler.Salı);
Console.WriteLine((int)Gunler.Salı);
Console.WriteLine(Gunler.Cumartesi);
Console.WriteLine((int)Gunler.Cumartesi);



int sicaklik = 20;

if (sicaklik < (int)HavaDurumu.Normal)
    Console.WriteLine("Hava soğuk");
else if(sicaklik >= (int)HavaDurumu.Sicak)
    Console.WriteLine("Hava Sıcak");
else if(sicaklik >= (int)HavaDurumu.Normal && sicaklik <= (int)HavaDurumu.Sicak)
    Console.WriteLine("Hava gayet iyi");
enum Gunler{
    Pazartesi = 1,
    Salı,
    Çarşamba,
    Perşembe,
    Cuma = 23,
    Cumartesi,
    Pazar
}

enum HavaDurumu
{
    Soguk = 0,

    Normal = 15,
    
    Sicak = 25,

    CokSicak = 35
}