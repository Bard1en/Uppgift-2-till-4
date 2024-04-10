using System;
namespace ConsoleApp35
{
    class Program
    {
        static void Main(string[] args)
        {
            
            person p = new person();
            p.metod1();
            p.metod3();
            Console.WriteLine("Hur lång är du?");
            p.mymetod = int.Parse(Console.ReadLine());
            Console.WriteLine("Hur mycket väger du?");
            p.mymetod2 = int.Parse(Console.ReadLine());
            p.Mymetod3();
        }
    }
}