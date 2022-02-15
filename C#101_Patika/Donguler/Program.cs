Console.WriteLine("Lütfen bir sayı giriniz: ");
int girdi = int.Parse(Console.ReadLine());

for (int i = 0; i <= girdi; i++)
{
    if(i%2 != 0)
        Console.WriteLine(i);
}
int toplam = 0;
for (int i = 0; i <= 100; i++)
{
    if(i%2 == 0)
        toplam += i;
}
Console.WriteLine(toplam);