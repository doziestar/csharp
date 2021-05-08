using System;

namespace csharp
{
    class Test
    {
        static void Main(string[] args)
        {
            int x = 20 * 30;
            Console.WriteLine(FeetOfToes(20) * x);
            Console.WriteLine(FeetOfToes(30) * x);
        }
        static int FeetOfToes(int feet){
            int inches = feet * 12;
            return inches;
        }
    }
}