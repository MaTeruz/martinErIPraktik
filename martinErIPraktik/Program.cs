using System;

namespace martinErIPraktik
{
    class Program
    {
        static void Main(string[] args)
        {
            square firkant = new square(0.5578f);
            square garry = new square();

            

            Console.WriteLine(firkant.Side);
            Console.WriteLine(firkant.Perimitor());
            Console.WriteLine(garry.Side);
            Console.WriteLine(garry.Perimitor());
            Console.WriteLine(firkant.Area());
            Console.ReadKey();
        }
    }
}
