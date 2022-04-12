string degisken = "Hoşgeldiniz C# Dersi";
string degisken2 = "C# Dersi!";

Console.WriteLine(degisken.Length);
Console.WriteLine(degisken.Count());
Console.WriteLine(degisken.ToUpper());
Console.WriteLine(degisken.ToLower());

//Concat
Console.WriteLine(String.Concat(degisken, degisken2));

//Compare, CompareTo
Console.WriteLine(degisken.CompareTo(degisken2)); //1,0,-1
Console.WriteLine(String.Compare(degisken, degisken2, true));
Console.WriteLine(String.Compare(degisken, degisken2, false));

//Contains
Console.WriteLine(degisken2.Contains(degisken));
Console.WriteLine(degisken.StartsWith("C#"));
Console.WriteLine(degisken.EndsWith("!"));

//IndexOf
Console.WriteLine(degisken2.IndexOf("Ders"));
Console.WriteLine(degisken.LastIndexOf("i"));

//Insert
Console.WriteLine(degisken.Insert(0,"Merhaba "));

//PadLeft, PadRight
Console.WriteLine(degisken + degisken2.PadLeft(30));
Console.WriteLine(degisken.PadRight(30,'*') + degisken2);

//Remove
Console.WriteLine(degisken.Remove(10));
Console.WriteLine(degisken.Remove(5,3));
Console.WriteLine(degisken.Remove(0,1));

//Replace
Console.WriteLine(degisken.Replace("C#", "CSharp"));

//Split
Console.WriteLine(degisken.Split(' ')[1]);

//Substring
Console.WriteLine(degisken.Substring(4));
Console.WriteLine(degisken.Substring(4,6));
