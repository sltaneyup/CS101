internal class Program
{
    private static void Main(string[] args)
    {
        //Metinsel fonksiyonlar/metotlar
        string ns1, ns1_1;
        string ns2, ns2_2;

        ns1 = "eyup sultan";
        ns1_1 = ns1.ToUpper();
        ns2 = "RABIA SULTAN";
        ns2_2 = ns2.ToLower();

        Console.WriteLine(ns1 + " " + ns1_1 + "\n");
        Console.WriteLine(ns2 + " " + ns2_2 + "\n");

        //concat : stringleri birlestiriyor
        string.Concat(ns1_1, " - ", ns2, "Istanbulda yasiyoruz..");


        Console.ReadKey();
    }
} 