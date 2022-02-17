//Sort

int[] sayiDizisi = {45,22,563,363,1231,353,6};
Console.WriteLine("Sırasız Dizi");
foreach (var item in sayiDizisi)
{
    Console.WriteLine(item);
}
Console.WriteLine("Sıralı Dizi");
Array.Sort(sayiDizisi); //bu bir void değişken, verdiğim dizi üzerinde değişiklik yapar. Yeni bir atama yapmama gerek yok.
foreach (var item in sayiDizisi)
{
    Console.WriteLine(item);
}
//Clear (Dizi içerisinde verdiğimiz indexten başlayarak verdiğimiz eleman sayısı kadar 0 atıyor.)
Console.WriteLine("Array Clear");

Array.Clear(sayiDizisi,2,2);
foreach (var item in sayiDizisi)
{
    Console.WriteLine(item);
}
//Reverse (Diziyi tersten yazdırır, sıralamaz.)
Console.WriteLine("Array Reverse");
Array.Reverse(sayiDizisi);
foreach (var item in sayiDizisi)
{
    Console.WriteLine(item);
}
//IndexOf (Kacıncı sırada)
Console.WriteLine("Array IndexOf");

Console.WriteLine(Array.IndexOf(sayiDizisi, 563));

//Resize
Console.WriteLine("Array Resize");
Array.Resize<int>(ref sayiDizisi, 9);
sayiDizisi[7] = 55;
sayiDizisi[8] = 931;
foreach (var item in sayiDizisi)
{
    Console.WriteLine(item);
}