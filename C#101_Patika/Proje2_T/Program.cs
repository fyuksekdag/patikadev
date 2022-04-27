List<Kart> toDo = new List<Kart>();
List<Kart> inProgress = new List<Kart>();
List<Kart> done = new List<Kart>();

Dictionary<int, string> employees = new Dictionary<int, string>()
{
    {1,"Ali Alpaslan Şah"},
    {2,"Mert Kara"},
    {3,"Cankut Ayder"}
};
Kart kart1 = new Kart();
kart1.Title = "Veritabanı";
kart1.Content = "Veritabanı güncellemesi";
kart1.PersonID = employees[2];
kart1.Size = Buyukluk.XL;

Kart kart2 = new Kart();
kart2.Title = "Code Refactoring";
kart2.Content = "Kod iyileştirmesi";
kart2.PersonID = employees[1];
kart2.Size = Buyukluk.M;

Kart kart3 = new Kart();
kart3.Title = "Code Debug";
kart3.Content = "Code Debug Description";
kart3.PersonID = employees[3];
kart3.Size = Buyukluk.S;

toDo.Add(kart1);
toDo.Add(kart2);
toDo.Add(kart3);

AnaMenu();

void AnaMenu()
{
    string[] islemler = { "Board Listele", "Boarda Kart Ekle", "Boarddan Kart Sil", "Kart Taşımak"};
    Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçin:");
    for (int i = 0; i < islemler.Length; i++)
    {
        Console.WriteLine($"({i+1}) {islemler[i]}");
    }
    switch (int.Parse(Console.ReadLine()))
    {
        case 1:
            ListBoard();
            break;
        case 2:
            KartEkle();
            break;
        case 3:
            KartSil();
            break;
        case 4:
            KartTasi();
            break;
    }
}


void ListBoard()
{
    Console.WriteLine("ToDo");
    Console.WriteLine("*****************************");
    foreach (var item in toDo)
    {
        Console.WriteLine("Başlık: {0}", item.Title);
        Console.WriteLine("İçerik: {0}", item.Content);
        Console.WriteLine("Çalışan: {0}", item.PersonID);
        Console.WriteLine("Büyüklük: {0}", item.Size);
        Console.WriteLine("------------------------");
    }
    Console.WriteLine("InProgress");
    Console.WriteLine("*****************************");
    foreach (var item in inProgress)
    {
        Console.WriteLine("Başlık: {0}", item.Title);
        Console.WriteLine("İçerik: {0}", item.Content);
        Console.WriteLine("Çalışan: {0}", item.PersonID);
        Console.WriteLine("Büyüklük: {0}", item.Size);
        Console.WriteLine("------------------------");
    }
    Console.WriteLine("Done");
    Console.WriteLine("*****************************");
    if(done.Count == 0)
        Console.WriteLine("BOŞ");
    else
    {
        foreach (var item in done)
        {
            Console.WriteLine("Başlık: {0}", item.Title);
            Console.WriteLine("İçerik: {0}", item.Content);
            Console.WriteLine("Çalışan: {0}", item.PersonID);
            Console.WriteLine("Büyüklük: {0}", item.Size);
            Console.WriteLine("------------------------");
        }
    }
    AnaMenu();
}

void KartEkle()
{
   Kart kart = new Kart();
   Console.WriteLine("Başlık girin: ");
    kart.Title = Console.ReadLine();
    Console.WriteLine("İçeriği girin: ");
    kart.Content = Console.ReadLine();
    Console.WriteLine("Büyüklük seçin -> XS(1),S(2),M(3),L(4),XL(5) :");
    int a = int.Parse(Console.ReadLine());
    switch (a)
    {
        case 1:
            kart.Size = Buyukluk.XS;
            break;
        case 2:
            kart.Size = Buyukluk.S;
            break;
        case 3:
            kart.Size = Buyukluk.M;
            break;
        case 4:
            kart.Size = Buyukluk.L;
            break;
        case 5:
            kart.Size = Buyukluk.XL;
            break;
    }
    Console.WriteLine("Kişi Seçiniz :");
    int b = int.Parse(Console.ReadLine());
    if (!employees.ContainsKey(b))
    {
        Console.WriteLine("Geçersiz giriş. Tekrar deneyin!");
        KartEkle();
    }
    else
    {
        kart.PersonID = employees[b];
    }
    toDo.Add(kart);
    foreach (var item in toDo)
    {
        Console.WriteLine("Başlık : " + item.Title);
        Console.WriteLine("İçerik : " + item.Content);
        Console.WriteLine("Çalışan : " + item.PersonID);
        Console.WriteLine("Büyüklük : " + item.Size);
        Console.WriteLine("---------------");
    }
    AnaMenu();
}

void KartSil()
{
    Console.WriteLine(" Lütfen kart başlığını yazınız:  ");
    String name = Console.ReadLine();

    toDo.RemoveAll(i => i.Title.ToLower() == name.ToLower());
    inProgress.RemoveAll(i => i.Title.ToLower() == name.ToLower());
    done.RemoveAll(i => i.Title.ToLower() == name.ToLower());

    foreach (var item in toDo)
        {
            Console.WriteLine("Başlık : " + item.Title);
            Console.WriteLine("İçerik : " + item.Content);
            Console.WriteLine("Çalışan : " + item.PersonID);
            Console.WriteLine("Büyüklük : " + item.Size);
            Console.WriteLine("---------------");
        }
        bool a = toDo.Any(i => i.Title.ToLower() != name.ToLower());
        if (a)
        {
            Console.WriteLine(" Aradığınız krtiterlere uygun kart board'da bulunamadı. Lütfen bir seçim yapınız :");
            Console.WriteLine("Silmeyi sonlandırmak için: (1)");
            Console.WriteLine("Yeniden denemek için: (2)");
            int n = int.Parse(Console.ReadLine());
            if (n == 2)
            {
                KartSil();
            }
        }
    
}

void KartTasi()
{
    Console.WriteLine("Kart başlığını girin :");
    string kartBasligi = Console.ReadLine();

    var titlesTodo = toDo.Where(i => i.Title.ToLower() == kartBasligi.ToLower()).ToList();
    var titlesInprogress = inProgress.Where(i => i.Title.ToLower() == kartBasligi.ToLower()).ToList();
    var titlesDone = done.Where(i => i.Title.ToLower() == kartBasligi.ToLower()).ToList();

    foreach (var item in titlesTodo)
    {
        Console.WriteLine("Kart bilgileri :");
        Console.WriteLine("********************");
        Console.WriteLine("Başlık : " + item.Title);
        Console.WriteLine("İçerik : " + item.Content);
        Console.WriteLine("Çalışan : " + item.PersonID);
        Console.WriteLine("Büyüklük : " + item.Size);
        Console.WriteLine("---------------\n");
    }

    foreach (var item in titlesInprogress)
    {
        Console.WriteLine("Kart bilgileri :");
        Console.WriteLine("********************");
        Console.WriteLine("Başlık : " + item.Title);
        Console.WriteLine("İçerik : " + item.Content);
        Console.WriteLine("Çalışan : " + item.PersonID);
        Console.WriteLine("Büyüklük : " + item.Size);
        Console.WriteLine("---------------\n");
    }

    foreach (var item in titlesDone)
    {
        Console.WriteLine("Kart bilgileri :");
        Console.WriteLine("********************");
        Console.WriteLine("Başlık : " + item.Title);
        Console.WriteLine("İçerik : " + item.Content);
        Console.WriteLine("Çalışan : " + item.PersonID);
        Console.WriteLine("Büyüklük : " + item.Size);
        Console.WriteLine("---------------\n");
    }

    Console.WriteLine("Hareket ettirmek istediğiniz bölümü seçin :");
    Console.WriteLine("(1)TODO (2)INPROGRESS (3)DONE");
    int n = int.Parse(Console.ReadLine());

    if (n == 1)
    {
        titlesInprogress.ForEach(i => inProgress.Remove(i));
        titlesDone.ForEach(i => done.Remove(i));
        titlesDone.ForEach(i => toDo.Add(i));
        titlesInprogress.ForEach(i => toDo.Add(i));
    }
    else if (n == 2)
    {
        titlesTodo.ForEach(i => toDo.Remove(i));
        titlesDone.ForEach(i => done.Remove(i));
        titlesDone.ForEach(i => inProgress.Add(i));
        titlesTodo.ForEach(i => inProgress.Add(i));
        foreach (var item in inProgress)
        {
            Console.WriteLine("Başlık : " + item.Title);
            Console.WriteLine("İçerik : " + item.Content);
            Console.WriteLine("Çalışan : " + item.PersonID);
            Console.WriteLine("Büyüklük : " + item.Size);
            Console.WriteLine("---------------\n");
        }
    }
    else if (n == 3)
    {
        titlesInprogress.ForEach(i => inProgress.Remove(i));
        titlesTodo.ForEach(i => toDo.Remove(i));
        titlesInprogress.ForEach(i => done.Add(i));
        titlesTodo.ForEach(i => done.Add(i));
    }
    bool a = toDo.Any(i => i.Title.ToLower() != kartBasligi.ToLower());
    if (a)
    {
        Console.WriteLine("Aradığınız krtiterlere uygun kart board'da bulunamadı. Lütfen bir seçim yapınız :");
        Console.WriteLine("Silmeyi sonlandırmak için (1)");
        Console.WriteLine("Yeniden denemek için (2)");
        int b = int.Parse(Console.ReadLine());
        if (b == 2)
        {
            KartTasi();
        }
    }
}