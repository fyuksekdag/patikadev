int month = DateTime.Now.Month;



// Expression 
switch (month)
{
    case 1:
        Console.WriteLine("Ocak");
        break;
    case 2:
        Console.WriteLine("Şubat");
        break;
    case 4:
        Console.WriteLine("Nisan");
        break;
    case 3:
        Console.WriteLine("Mart");
        break;
    
    default: // hiç bir koşula uymazsa default
        Console.WriteLine("Yanlış veri girdiniz!");
    break;
}
switch (month)
{
    case 12:
    case 1:
    case 2:
        Console.WriteLine("Kış Ayındasınız!");
        break;

    case 3:
    case 4:
    case 5:
        Console.WriteLine("İlkbahar Ayındasınız!");
        break;
    default:
    break;
}
