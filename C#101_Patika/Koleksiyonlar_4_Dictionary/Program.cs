Dictionary<int, string> kullanicilar = new Dictionary<int, string>();

kullanicilar.Add(10, "Can Ağar");
kullanicilar.Add(12, "Banu Elmacı");
kullanicilar.Add(15, "Ece Kara");
kullanicilar.Add(22, "Özcan Çoşar");

//Dizi elemanlarına erişim
Console.WriteLine(kullanicilar[12]);
foreach (var item in kullanicilar)
{
    Console.WriteLine(item);
}

//Count
Console.WriteLine(kullanicilar.Count);

//Contains
Console.WriteLine(kullanicilar.ContainsKey(12));
Console.WriteLine(kullanicilar.ContainsValue("Banu Elmacı"));

//Remove
kullanicilar.Remove(22);
foreach (var item in kullanicilar)
{
    Console.WriteLine(item.Value);
}

//Keys
foreach (var item in kullanicilar.Keys)
{
    Console.WriteLine(item);
}

//Values
foreach (var item in kullanicilar.Values){
    Console.WriteLine(item);
}