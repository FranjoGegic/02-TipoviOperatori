﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharp.TipoviOperatori
{
    /// <summary>
    ///     Ovo je samo moja vjezba pisanja komentara.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Kvadrat(5));
            Console.WriteLine(DuljinaDvijeRiječi("dva", "2"));
        }

        /// <summary>
        ///   Izračunava kvadrat broja.
        /// </summary>
        /// <param name="broj">
        ///   Broj čiji kvadrat treba izračunati.
        /// </param>
        /// <returns>
        ///   Zadani broj na kvadrat, tipa <c>double</c>.
        /// </returns>
        static double Kvadrat(double broj)
        {
            return broj * broj;
        }

        /// <summary>
        ///     Izracunava ukupnu duljinu dvije rijeci.
        /// </summary>
        /// <param name="prva">Prva rijec.</param>
        /// <param name="druga">Druga rijec.</param>
        /// <returns>Zbroj duljina.</returns>
        static int DuljinaDvijeRiječi(string prva, string druga)
        {
            return (prva + druga).Length;
        }
    }
}
