using System.Collections;

//Soru - 1: Klavyeden girilen 20 adet pozitif sayının asal ve asal olmayan olarak 2 ayrı listeye atın.
//  ArrayList sınıfını kullanarak yazınız
//- Negatif ve numeric olmayan girişleri engelleyin.
//- Her bir dizinin elemanlarını büyükten küçüğe olacak şekilde ekrana yazdırın.
//- Her iki dizinin eleman sayısını ve ortalamasını ekrana yazdırın.
int x = 0;
ArrayList arrList = new ArrayList();
Console.WriteLine("Lütfen 20 adet pozitif sayı giriniz.");

int loop = 0;
while(loop < 20)
{
    Console.WriteLine($"{loop+1}. sayıyı giriniz");
    try
    {
        x = int.Parse(Console.ReadLine());
        if(x < 0)
        {
            Console.WriteLine("Lütfen pozitif bir sayı giriniz.");
        }
        else{
            arrList.Add(x);
            loop++;
        }
    }
    catch(System.Exception)
    {
        Console.WriteLine("Lütfen sayı değeri giriniz.");
    }
}

ArrayList primeNumbers = new ArrayList();
ArrayList notPrimeNumbers = new ArrayList();

//PrimeCheck
foreach (int item in arrList)
{
    if(item == 1 || item == 2)
        primeNumbers.Add(item);
    else
    {
        int primeCheck = 0;
        for (int i = 2; i < item; i++)
        {
            if(item % i == 0)
                primeCheck++;
        }
        if(primeCheck == 0)
            primeNumbers.Add(item);
        else
            notPrimeNumbers.Add(item);
    }
    
}
//Her bir dizinin elemanlarını büyükten küçüğe olacak şekilde ekrana yazdırın.
primeNumbers.Sort();
primeNumbers.Reverse();
notPrimeNumbers.Sort();
notPrimeNumbers.Reverse();
foreach (var item in primeNumbers)
{
    Console.WriteLine(item);
}
foreach (var item in notPrimeNumbers)
{
    Console.WriteLine(item);
}

//Her iki dizinin eleman sayısını ve ortalamasını ekrana yazdırın.
Console.WriteLine($"Asal dizinin eleman sayısı = {primeNumbers.Count}, ortalaması = {GetAverage(primeNumbers)}");
Console.WriteLine($"Asal olmayan dizinin eleman sayısı = {notPrimeNumbers.Count}, ortalaması = {GetAverage(notPrimeNumbers)}");

static decimal GetAverage(ArrayList arr)
{
    decimal total = 0;
    foreach (int item in arr)
    {
        total += item;
    }
    return total / arr.Count;
}