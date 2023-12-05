internal class Program
{
    private static void Main(string[] args) //Burasi programin giris noktasi
    {
        //ilk tanimlar yapiliyor

        #region ilk ornek

        ////string degisken tanimlayalim
        //string eyup = ""; //bellekte string veri tipinde bir eyup isimli ve su an icinde bosluk degeri olan bir degisken yarattim

        //string eyupDesc;

        //string EyupDesc;

        //string Description;


        //// Deger atama
        //eyup = "Eyup Sultan";

        //eyupDesc = "My Name :";

        //EyupDesc = "your name";

        ////simdi bunlari ekrana yazdiralim

        //Console.WriteLine(eyup); 
        //Console.WriteLine(eyupDesc + eyup + "\n\n\n\n"); //Dinamik yazdirma degiskenli
        //Console.WriteLine("4 satir atladım"); //Bos satir statik


     

        #endregion

        #region degiskenlere devam
           //tam sayi ve icindeki degeri 100 olan sayi adinda bir degisken tanimlayiz 

           int sayi = 100;

        const string programAd = "Personel Takip Programi v1.0"; //programin basindan sonuna degeri hic degismeyecek
        //programAd = "xxx"; //calismaz kirmiziyla isaretlemis altini ztn

        int a;
        int b;
        int c;

        int d=5, e=10, f=50;  //tek

        a=5; b=6; c=7; d=8; e=9; f=10;
        Console.WriteLine("d nin degeri = " + d);
        Console.WriteLine("f nin degeri = " +f);
        Console.WriteLine("e nin degeri = " + e);

        Console.WriteLine("Degerlerin toplami = " +a+ b + c + d + e + f);

        int toplam = a + b+c+d+e+f;

        Console.WriteLine("Degerlerin toplami = " + toplam);
       
        
       
        
        
        #endregion
     







        Console.ReadKey();

    }
}   
