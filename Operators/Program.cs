internal class Program
{
    private static void Main(string[] args)
    {
        #region 1. Matematiksel Operatorler

        // % Operatoru (mod alma) kalani bulma
        int a = 5 % 2; //sonuc 1 5in 2ye gore modu 1
        Console.WriteLine("Mod sonucu 5 2 = " + a.ToString()); //tostring sayi degerini konsolda yazi karakterine cevirir 1 tostring "1"
        #endregion



        #region 1.1 Degisik bir durum

        //Eger islem yapilan her iki operand farkli veri tipindeyse islem sonucu daha buyuk turde tutulur
        float b = 5 / 2f; //burada 5 sayisi da float gibi davranmistir ve sonuc ondalikli cikmistir.
        Console.WriteLine("Islem sonucu = " + b .ToString());
        #endregion

        #region 1.2 Ancak.. durumu
        float c =  2 / 5 / 2f;
        Console.WriteLine(c.ToString());
        #endregion

        #region 1.3 Daha ilginci
        float d = 2f / 4 / 7 / 8 / 26 / 9 / 3 / 8 / 5 / 7 / 6 / 3 / 12 / 23 / 34;
        Console.WriteLine(d.ToString());
        #endregion

        #region 2. bir arttirma bir eksiltme operatorleri
        //en cok kullanilan
        //++sayi, sayi++, --sayi, sayi--
        //sayi=sayi+1--
        //sayi+=5 -- sayi=sayi + 5;

        int fonceki = 5;

        int fsonraki= ++fonceki;//prefix ..hem onceki degerini bir artiriyor..bu degeri tutuyor.. fsonraki degisgenine atiyor..
        Console.WriteLine(fonceki.ToString());

        int gonceki = 10;
        int gsonraki = gonceki++; //suffix ornegi 
        #endregion

      

        Console.ReadKey();
    } 




    
} 