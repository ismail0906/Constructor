namespace _3_Constructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ogrenci ogr = new Ogrenci("aaa");
            

            Ogrenci ogr1 = new Ogrenci();
            ogr1.Adi = "bbb";

            Ogrenci ogr2 = new Ogrenci();
            ogr2.Adi = "ccc";

            Console.WriteLine(ogr2.Adi);

            Console.ReadKey();
        }
    }
}