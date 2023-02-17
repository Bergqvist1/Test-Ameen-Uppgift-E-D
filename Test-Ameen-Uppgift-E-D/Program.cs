using System;
namespace Uppgift_E_D
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in 2 heltal till en rektangel!");
            Console.WriteLine("Skriv in höjden:");
            int höjd = int.Parse(Console.ReadLine());
            Console.WriteLine("Skriv in bredden:");
            int bas = int.Parse(Console.ReadLine());
            Console.WriteLine("Rektangels area = " + Area(bas, höjd));
        }
        static int Area(int bas, int höjd)
        {
            
            int Arean = bas * höjd;
            return Arean;
      
        }
    }
}
