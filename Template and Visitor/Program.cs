using System;

namespace Template_and_Visitor
{
    abstract class Alisveris
    {
        protected string UrunAdi;
        void Baslat() => Console.WriteLine("Alisveris Basladi.");
        void Bitir() => Console.WriteLine($"Alisveris bitti.{UrunAdi} Magazadan alinmistir.");
        abstract public void Urun();
        public void TemplateMethod()
        {
            Baslat();
            Urun();
            Bitir();
        }
    }
    class Televizor : Alisveris
    {
        public override void Urun()
        {
            UrunAdi = "Televizor";
        }
    }

    class Soyuducu : Alisveris
    {
        public override void Urun()
        {
            UrunAdi = "Soyuducu";
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {

            Televizor televizor= new Televizor();
            televizor.TemplateMethod();

            Console.WriteLine();
            Console.WriteLine();

            Soyuducu soyuducu=new Soyuducu();
            soyuducu.TemplateMethod();

            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
