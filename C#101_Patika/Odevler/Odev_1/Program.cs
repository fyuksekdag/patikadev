/*
Console.WriteLine("Lütfen bir sayı giriniz.");
int sayi = int.Parse(Console.ReadLine());
int[] dizi = new int[sayi];

for (int i = 0; i < sayi; i++)
{
    Console.WriteLine("Lütfen {0}. sayıyı giriniz.", i+1);
    dizi[i] = int.Parse(Console.ReadLine());
}

foreach (int item in dizi)
{
    if(item%2 == 0)
    {
        Console.WriteLine(item);
    }
}
*/

// 2-Bir konsol uygulamasında kullanıcıdan pozitif iki sayı girmesini isteyin (n, m)

/*
Console.WriteLine("Lütfen kaç elemanlı olacağını giriniz.");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("Lütfen böleni giriniz.");
int m = int.Parse(Console.ReadLine());
int[] dizi = new int[n];

for (int i = 0; i < n; i++)
{
    Console.WriteLine("Lütfen {0}. sayıyı giriniz.", i+1);
    dizi[i] = int.Parse(Console.ReadLine());
}

foreach (int item in dizi)
{
    if(item == m || item % m == 0)
    {
        Console.WriteLine(item);
    }
}
*/

// 3-Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin (n). Sonrasında kullanıcıdan n adet kelime girmesi isteyin. Kullanıcının girişini yaptığı kelimeleri sondan başa doğru console'a yazdırın.
/*
Console.WriteLine("Lütfen kelime sayısı giriniz.");
int kelimeSayisi = int.Parse(Console.ReadLine());

string[] kelimeDizisi = new string[kelimeSayisi];

for (int i = 0; i < kelimeSayisi; i++)
{
    Console.WriteLine("Lütfen {0}. kelimeyi giriniz.", i + 1);
    kelimeDizisi[i] = Console.ReadLine();
}
Array.Reverse(kelimeDizisi);
foreach (string item in kelimeDizisi)
{
    Console.WriteLine(item);
}
*/

// 4-Bir konsol uygulamasında kullanıcıdan bir cümle yazması isteyin. Cümledeki toplam kelime ve harf sayısını console'a yazdırın.

Console.WriteLine("Lütfen bir cümle giriniz.");
string kelime = Console.ReadLine();
string kelime_2 = kelime.Replace(" ", "");
string[] dizi = kelime.Split(' ');

Console.WriteLine("Kelime sayısı: {0}, Harf sayısı: {1}", dizi.Count(), kelime_2.Count());

