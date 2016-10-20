using System;

namespace CSharp.UgrađeniBrojčaniTipovi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(int.MaxValue);
            Console.WriteLine(int.MinValue);

            int i = int.MaxValue;
            Console.WriteLine(i+1);

            int j = int.MinValue;
            Console.WriteLine(j-1);

            Console.WriteLine(double.MaxValue);
            Console.WriteLine(double.MinValue);

            Console.WriteLine(3.14/0);
            Console.WriteLine(-3.14 / 0);

            double var = 0;
            Console.WriteLine(var / 0);

            Console.ReadKey();
        }
    }
}
