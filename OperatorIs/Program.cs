using System;

namespace CSharp.TipoviOperatori
{
    class Osoba { }

    class Student : Osoba { }

    class Program
    {
        static void Main(string[] args)
        {
            Osoba janko = new Student();

            Console.WriteLine(janko is Osoba);
            Console.WriteLine(janko is Student);

            Osoba osoba = new Osoba();

            Console.WriteLine(osoba is Osoba);
            Console.WriteLine(osoba is Student);
            
            Console.ReadKey();
        }
    }
}
