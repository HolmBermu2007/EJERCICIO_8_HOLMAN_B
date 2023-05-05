using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIO_8_HOLMAN_B
{
    internal class estudio
    {
        string nom;
        string direc;

        public string Produce()
        {
            return ToString();
        }

        public estudio(string nom, string direc)
        {
            this.Nom = nom;
            this.Direc = direc;
        }

        public string Nom { get => nom; set => nom = value; }
        public string Direc { get => direc; set => direc = value; }

       
    }
}
