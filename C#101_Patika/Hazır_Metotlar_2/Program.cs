Console.WriteLine(DateTime.Now); // Günün tarihini getirir.
Console.WriteLine(DateTime.Now.Date);
Console.WriteLine(DateTime.Now.Day);
Console.WriteLine(DateTime.Now.Month);
Console.WriteLine(DateTime.Now.Year);
Console.WriteLine(DateTime.Now.Hour);
Console.WriteLine(DateTime.Now.Minute);
Console.WriteLine(DateTime.Now.Second);

Console.WriteLine(DateTime.Now.DayOfWeek);
Console.WriteLine(DateTime.Now.DayOfYear);

Console.WriteLine(DateTime.Now.ToLongDateString());
Console.WriteLine(DateTime.Now.ToShortDateString());
Console.WriteLine(DateTime.Now.ToLongTimeString());
Console.WriteLine(DateTime.Now.ToShortTimeString());

Console.WriteLine(DateTime.Now.AddDays(2));
Console.WriteLine(DateTime.Now.AddHours(3));
Console.WriteLine(DateTime.Now.AddSeconds(22));
Console.WriteLine(DateTime.Now.AddMonths(7));
Console.WriteLine(DateTime.Now.AddYears(11));
Console.WriteLine(DateTime.Now.AddMilliseconds(43));

//Datetime Format
Console.WriteLine(DateTime.Now.ToString("dd"));   //Günü getirir 12
Console.WriteLine(DateTime.Now.ToString("ddd"));  //Tue
Console.WriteLine(DateTime.Now.ToString("dddd")); //Tuesday

//Ay aynı şekilde

Console.WriteLine(DateTime.Now.ToString("yy"));   //22
Console.WriteLine(DateTime.Now.ToString("yyyy")); //2022

//Math Kütüphanesi
Console.WriteLine("Math Kütüphanesi");
Console.WriteLine(Math.Abs(-5)); //5
Console.WriteLine(Math.Sin(10));
Console.WriteLine(Math.Cos(10));
Console.WriteLine(Math.Tan(10));

Console.WriteLine(Math.Ceiling(32.5)); //33
Console.WriteLine(Math.Round(32.5)); //32 - En yakın olan tam sayıya yuvarlar
Console.WriteLine(Math.Floor(32.5)); //32

Console.WriteLine(Math.Max(2,6));
Console.WriteLine(Math.Min(2,6));

Console.WriteLine(Math.Pow(2,3)); // 2**3
Console.WriteLine(Math.Sqrt(9));  // karekök
Console.WriteLine(Math.Log(9));   // 9'un e tabanındaki log.
Console.WriteLine(Math.Exp(3));   // e üzeri 3'ü verir.
Console.WriteLine(Math.Log10(10));


string s = "07:05:45PM";
DateTime dt = DateTime.Parse(s);
string k = dt.ToString("HH:mm:ss");
Console.WriteLine(k);
