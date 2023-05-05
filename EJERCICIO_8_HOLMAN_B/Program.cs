using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIO_8_HOLMAN_B
{
    internal class Program
    {
        static void Main(string[] args)
        {
            pelicula peli = new pelicula("un masaya en la unan", 2024);
            actor act = new actor("holman", "bermudez");
            act.Actuar();
            estudio est = new estudio("holiwood", "usa");
            est.Produce();
            Console.ReadKey();

        }
    }
}
