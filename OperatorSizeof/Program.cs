using System;

namespace CSharp.TipoviOperatori
{
    struct MojaStruktura
    {
        decimal a;
        double b;
    }

    struct MojaSloženaStruktura
    {
        public void IspišiSe()
        {
            Console.WriteLine(this.ToString());
        }

        decimal a;
        double b;
    }

    class MojaKlasa
    {
        public void IspišiSe()
        {
            Console.WriteLine(this.ToString());
        }

        decimal a;
        double b;
    }

    class Program
    {
        static void Main(string[] args)
        {
            // ispisati duljinu tipa decimal
            Console.WriteLine(sizeof(decimal));

            // ispisati duljinu tipa double
            Console.WriteLine(sizeof(double));

            // ispisati duljinu tipa MojaStruktura            
            Console.WriteLine(System.Runtime.InteropServices.Marshal.SizeOf(typeof(MojaStruktura)));

            // ispisati duljinu tipa MojaSloženaStruktura
            Console.WriteLine(System.Runtime.InteropServices.Marshal.SizeOf(typeof(MojaSloženaStruktura)));

            // ispisati duljinu tipa MojaKlasa
            //Console.WriteLine(System.Runtime.InteropServices.Marshal.SizeOf((MojaKlasa));

            Console.ReadKey();
        }
    }
}
