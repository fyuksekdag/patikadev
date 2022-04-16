/*Klavyeden girilen 20 adet sayının en büyük 3 tanesi ve en küçük 3 tanesi bulan, 
her iki grubun kendi içerisinde ortalamalarını alan ve bu ortalamaları ve ortalama toplamlarını console'a yazdıran programı yazınız. (Array sınıfını kullanarak yazınız.)*/

Console.WriteLine("Lütfen 20 adet sayı giriniz.");
int[] fDizi = new int[20];
for (int i = 0; i < 20; i++)
{
    Console.WriteLine($"{i+1}. sayıyı giriniz");
    int number = int.Parse(Console.ReadLine());
    fDizi[i] = number;
}
Array.Sort(fDizi);
Console.WriteLine($"En küçük üç sayı: {fDizi[0]}, {fDizi[1]}, {fDizi[2]} ve Ortalaması: {(fDizi[0] + fDizi[1] + fDizi[2]) / 3}");
Console.WriteLine($"En büyük üç sayı: {fDizi[19]}, {fDizi[18]}, {fDizi[17]} ve Ortalaması: {(fDizi[19] + fDizi[18] + fDizi[17]) / 3}");
Console.WriteLine($"Her iki grubun ortalamaları toplamı: {((fDizi[19] + fDizi[18] + fDizi[17]) / 3) + ((fDizi[0] + fDizi[1] + fDizi[2]) / 3)}");

/*
//daha genel çözüm
int[] maxValues = new int[3];
int[] minValues = new int[3];
List<int> lst_numbers = new List<int>(fDizi);
for (int j = 0; j < 3; j++)
{
    maxValues[j] = lst_numbers.Max();
    lst_numbers.Remove(lst_numbers.Max());
    minValues[j] = lst_numbers.Min();
    lst_numbers.Remove(lst_numbers.Min());    
}
Console.WriteLine("En büyük 3 sayının ortalaması " + ortalamaAl(maxValues));
Console.WriteLine("En küçük 3 sayının ortalaması " + ortalamaAl(minValues));
Console.WriteLine("Ortalama Toplamları: " + (ortalamaAl(maxValues)+ortalamaAl(minValues)));



static decimal ortalamaAl(Array x)
{
    decimal total = 0;
    int count = 0;
    foreach(int item in x)
    {
        total += item;
        count++;
    }
    return total / count;
}
*/