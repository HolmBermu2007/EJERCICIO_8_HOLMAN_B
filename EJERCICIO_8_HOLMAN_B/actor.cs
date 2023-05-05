using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIO_8_HOLMAN_B
{
    internal class actor
    {
        string nom;
        string apellido;

        public string Actuar()
        {
            return ToString();
        }
        public actor(string nom, string apellido)
        {
            this.Nom = nom;
            this.Apellido = apellido;
        }

        public string Nom { get => nom; set => nom = value; }
        public string Apellido { get => apellido; set => apellido = value; }

       
    }
}
