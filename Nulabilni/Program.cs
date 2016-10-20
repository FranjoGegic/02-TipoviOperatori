using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharp.TipoviOperatori
{
    class Program
    {
        static void Main(string[] args)
        {
            double? nulabilniDuplić = Math.PI;
            Console.WriteLine(nulabilniDuplić);

            double običniDuplic = Math.PI;

            nulabilniDuplić = null;
            Console.WriteLine(nulabilniDuplić);

            /*
            običniDuplic = null;
            Console.WriteLine(običniDuplic);
            */

            Nullable<double> nulabilniDouble = Math.PI;
            Console.WriteLine(nulabilniDouble);

            nulabilniDouble = null;
            Console.WriteLine(nulabilniDouble);

            Console.ReadKey();
        }
    }
}
