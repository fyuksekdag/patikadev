RehberIslemleri islemler = new RehberIslemleri();
int secim = 0;
while(secim!=6)
{
    islemler.KarsilamaEkrani();
    secim = int.Parse(Console.ReadLine());
    switch (secim)
    {
        case 1:
            Console.WriteLine("Lütfen isim giriniz: ");
            string isim = Console.ReadLine();
            Console.WriteLine("Lütfen soyisim giriniz: ");
            string soyisim = Console.ReadLine();
            Console.WriteLine("Lütfen telefon numarası giriniz: ");
            string numara = Console.ReadLine();
            islemler.numaraKaydet(isim,soyisim,numara);
            break;
        case 2:
            Console.WriteLine("Lütfen numarasını silmek istediğiniz kişinin adını ve soyadını giriniz..");
            islemler.numaraSil(Console.ReadLine());
            break;
        case 3:
            Console.WriteLine("Lütfen numarasını güncellemek istediğiniz kişinin adını ve soyadını giriniz:");
            islemler.numaraGuncelle(Console.ReadLine());
            break;
        case 4:
            Console.WriteLine("(1) A-Z \n(2) Z-A \n Lütfen seçim yapınız...");
            int sira = int.Parse(Console.ReadLine());
            if(sira == 1)
                islemler.siraliRehberListele();
            else if (sira == 2)
                islemler.reversedRehberListele();
            break;
        case 5:
            Console.WriteLine(" Arama yapmak istediğiniz tipi seçiniz.\n********************************************** \nİsim veya soyisime göre arama yapmak için: (1) \nTelefon numarasına göre arama yapmak için: (2)");
            int chose = int.Parse(Console.ReadLine());
            if(chose == 1)
            {    
                Console.WriteLine("Aramak istediğiniz isimi veya soyisimi giriniz..");
                islemler.searchByName(Console.ReadLine());
            }
            else if(chose == 2)
            {
                Console.WriteLine("Aramak istediğiniz numarayı giriniz..");
                islemler.searchByNumber(Console.ReadLine());
            }
            break;
    }
}
public class RehberIslemleri
{
    Dictionary<string, string> phoneBook = new Dictionary<string, string>();
    public RehberIslemleri()
    {
        phoneBook.Add("Lewis Hamilton", "15348180044");
        phoneBook.Add("Fernando Alonso", "15330498489");
        phoneBook.Add("Valtteri Bottas", "15548680744");
        phoneBook.Add("Sebastian Vettel", "15744180546");
        phoneBook.Add("George Russell", "18347746364");
    }
    public void KarsilamaEkrani()
    {
        Console.WriteLine("1. Telefon Numarası Kaydet \n2. Telefon Numarası Sil \n3. Telefon Numarası Güncelle \n4. Rehber Listeleme (A-Z, Z-A seçimli) \n5. Rehberde Arama \n6. Çıkış");
        Console.WriteLine("Lütfen bir seçim yapınız..");
    }
    public void numaraKaydet(string isim, string soyisim, string numara)
    {
        phoneBook.Add(isim + " " + soyisim, numara);
        Console.WriteLine("Rehbere kayıt edildi...\nDevam etmek için bir tuşa basınız...");
        Console.ReadLine();
    }
    public void numaraSil(string isimsoyisim)
    {
        bool ifade = phoneBook.Remove(isimsoyisim);
        if (ifade)
        {
            Console.WriteLine("Silme tamamlandı.. Devam etmek için bir tuşa basınız..");
            Console.ReadLine();
        }
        else
        {
            Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız. \n* Silmeyi sonlandırmak için : (1) \n* Yeniden denemek için      : (2)");
            int choose = int.Parse(Console.ReadLine());
            if(choose == 2)
            {
                Console.WriteLine("Lütfen numarasını silmek istediğiniz kişinin adını ve soyadını tekrar giriniz..");
                numaraSil(Console.ReadLine());
                Console.WriteLine("Devam etmek için bir tuşa basınız..");
                Console.ReadLine();
            }
        }
    }
    public void numaraGuncelle(string isimsoyisim)
    {
            try
            {
                foreach (string item in phoneBook.Values)
                {
                    if (phoneBook[isimsoyisim] == item)
                    {
                        Console.WriteLine("Kişi bulundu. Numarayı giriniz..");
                        phoneBook[isimsoyisim] = Console.ReadLine();
                    }
                }
            }
            catch (System.Exception)
            {
                
                Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız. \n* Güncellemeyi sonlandırmak için    : (1) \n* Yeniden denemek için              : (2)");
                int sec = int.Parse(Console.ReadLine());
                if(sec == 2)
                {
                    Console.WriteLine("Lütfen numarasını güncellemek istediğiniz kişinin adını ya da soyadını giriniz:");
                    numaraGuncelle(Console.ReadLine());
                    Console.WriteLine("Devam etmek için bir tuşa basınız..");
                    Console.ReadLine();
                }
            }

    }
    public void siraliRehberListele()
    {
        Console.WriteLine("Telefon Rehberi Listeleniyor \n********************************");
        foreach (var item in phoneBook.OrderBy(x => x.Key))
        {
            Console.WriteLine($"isim: {item.Key.Split(' ')[0]} \nsoyisim: {item.Key.Split(' ')[1]} \nnumara: {item.Value}");
        }
        Console.WriteLine("Devam etmek için bir tuşa basınız...");
        Console.ReadLine();
    }
    public void reversedRehberListele()
    {
        var reversedDictionary = phoneBook.Reverse();
        Console.WriteLine("Telefon Rehberi Listeleniyor \n********************************");
        foreach (var item in reversedDictionary.OrderByDescending(x => x.Key))
        {
            Console.WriteLine($"isim: {item.Key.Split(' ')[0]} \nsoyisim: {item.Key.Split(' ')[1]} \nnumara: {item.Value}");
        }
        Console.WriteLine("Devam etmek için bir tuşa basınız...");
        Console.ReadLine();
    }

    public void searchByName(string value)
    {
        bool flag = false;
        foreach (var item in phoneBook)
        {
            if(item.Key.Split(' ')[0] == value || item.Key.Split(' ')[1] == value)
            {
                flag = true;
                Console.WriteLine("Aradığınız kişi bulundu..");
                Console.WriteLine($"isim: {item.Key.Split(' ')[0]} \nsoyisim: {item.Key.Split(' ')[1]} \nnumara: {item.Value}");
                Console.WriteLine("Devam etmek için bir tuşa basınız..");
                Console.ReadLine();
            }
        }
        if(flag == false)
            Console.WriteLine("Aradığınız kişi bulunamadı..");
            Console.WriteLine("Devam etmek için bir tuşa basınız..");
            Console.ReadLine();
    }
    public void searchByNumber(string value)
    {
        bool flag = false;
        foreach (var item in phoneBook)
        {
            if(item.Value == value)
            {
                flag = true;
                Console.WriteLine("Aradığınız kişi bulundu..");
                Console.WriteLine($"isim: {item.Key.Split(' ')[0]} \nsoyisim: {item.Key.Split(' ')[1]} \nnumara: {item.Value}");
                Console.WriteLine("Devam etmek için bir tuşa basınız..");
                Console.ReadLine();
            }
        }
        if(flag == false)
        {
            Console.WriteLine("Aradığınız kişi bulunamadı..");
            Console.WriteLine("Devam etmek için bir tuşa basınız..");
            Console.ReadLine();        
        }
    }
}