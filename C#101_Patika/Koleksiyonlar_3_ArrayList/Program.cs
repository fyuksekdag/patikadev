using System.Collections;

ArrayList list = new ArrayList();
//list.Add("Alice");
//list.Add("Bob");
//list.Add(33);
//list.Add(true);
//
//Console.WriteLine(list[2]);
//foreach (var item in list)
//{
//    Console.WriteLine(item);
//}

//AddRange
Console.WriteLine("******AddRange******");
//string[] renkler = {"Kırmızı","Siyah","Gri"};
List<int> sayilar = new List<int>(){1,5,3,8,22,4};
//list.AddRange(renkler);
list.AddRange(sayilar);

foreach (var item in list)
{
    Console.WriteLine(item);
}

//Sort
Console.WriteLine("******Sort******");
list.Sort();
foreach (var item in list)
{
    Console.WriteLine(item);
}

//BinarySearch
Console.WriteLine("******BinarySearch******");
Console.WriteLine(list.BinarySearch(8));

//Reverse
Console.WriteLine("******Reverse******");
list.Reverse();
foreach (var item in list)
{
    Console.WriteLine(item);
}

//Clear
list.Clear();
foreach (var item in list)
{
    Console.WriteLine(item);
}