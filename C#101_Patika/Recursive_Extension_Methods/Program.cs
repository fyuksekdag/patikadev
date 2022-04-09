// Recursive
// 3 ^ 4

int res = 1;
for (int i = 1; i < 5; i++)
{
    res = res * 3;
}
Console.WriteLine(res);

Islemler instance = new Islemler();
Console.WriteLine(instance.Expo(3,4));

// Extension

string ifade = "Ali Veli Konya";
bool sonuc = ifade.CheckSpaces();
Console.WriteLine(sonuc);
if(sonuc)
{
    Console.WriteLine(ifade.ReplaceSpaces());
}
Console.WriteLine(ifade.MakeUpperCase());
Console.WriteLine(ifade.MakeLowerCase());

int[] dizi = {1,4,6,7,3,5};
dizi.SortArray();
dizi.EkranaYazdir();

Console.WriteLine(ifade.GetFirstCharacter());

public class Islemler
{
    public int Expo(int sayi, int us)
    {
        if(us < 2)
        {
            return sayi;
        }
        else
        {
            return Expo(sayi, us-1)*sayi;
        }
    }
}
public static class Extension
{
    public static bool CheckSpaces(this string param)
    {
        return param.Contains(" ");
    }
    public static string ReplaceSpaces(this string param)
    {
        string[] dizi = param.Split(' ');
        return string.Join(",", dizi);
    }
    public static string MakeUpperCase(this string param)
    {
        return param.ToUpper();
    }
    public static string MakeLowerCase(this string param)
    {
        return param.ToLower();
    }
    public static int[] SortArray(this int[] param)
    {
        Array.Sort(param);
        return param;
    }
    public static void EkranaYazdir(this int[] param)
    {
        foreach (int item in param)
        {
            Console.WriteLine(item);
        }
    }
    public static string GetFirstCharacter(this string param)
    {
        return param.Substring(0, 1);
    }
}