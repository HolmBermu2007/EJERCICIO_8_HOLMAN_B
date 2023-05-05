using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIO_8_HOLMAN_B
{
    internal class pelicula
    {
        string nom;
        int año;
                public pelicula(string nom, int año)
        {
            this.Nom = nom;
            this.Año = año;
        }

       
        public string Nom { get => nom; set => nom = value; }
        public int Año { get => año; set => año = value; }

        
    }
}
