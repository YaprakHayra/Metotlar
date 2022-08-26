using Metotlar;


internal class Program
{




    public static void Main(string[] args)
    {
        Urun urun1 = new Urun();
       
        urun1.Adi = "Elma";
        urun1.Fiyati = 15;
        urun1.Aciklama = "amasya elması";

        Urun urun2 = new Urun();
        
        urun2.Adi = "çilek";
        urun2.Fiyati = 20;
        urun2.Aciklama = "Tatlı çilek";

        Urun urun3 = new Urun();
        
        urun3.Adi = "karpuz";
        urun3.Fiyati = 80;
        urun3.Aciklama = "Diyarbakır karpuzu";

        Urun[] urunler = new Urun[] {urun1,urun2,urun3 };

        foreach (Urun x in urunler)
        {
            Console.WriteLine(x.Adi);
            Console.WriteLine(x.Fiyati);
            Console.WriteLine(x.Aciklama);
            Console.WriteLine("----");
        }
        Console.WriteLine("----METOTLAR----");
        

        //instance - örnek
        //encapsulation
        SepetManager sepetManager = new SepetManager();
        sepetManager.Ekle(urun1);
        sepetManager.Ekle(urun2);
        sepetManager.Ekle(urun3);

      //  sepetManager.Ekle2("armut","yeşil armut",12,5);
     //   sepetManager.Ekle2("elma", "Amasya Elması", 12,23);
        //sepetManager.Ekle2("KArpuz", "Diyarbakır", 12,44);

    }
    }
    
    
