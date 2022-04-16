//Klavyeden girilen cümle içerisindeki sesli harfleri bir dizi içerisinde saklayan ve dizinin elemanlarını sıralayan programı yazınız.
using System.Collections;

Console.WriteLine("Lütfen bir cümle giriniz.");
string sentence = Console.ReadLine();
sentence = sentence.ToLower();

string vowels = "aeıioöuü";

ArrayList words = new ArrayList();
for (int i = 0; i < sentence.Length; i++)
{
    if (vowels.Contains(sentence[i]))
        words.Add(sentence[i]);
}
//Sıralama
words.Sort();
foreach (var item in words)
{
    Console.Write(item);
}