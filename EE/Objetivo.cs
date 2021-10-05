using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EE
{
    public class Objetivo
    {
        public int Id_objetivo { get; set; }
        public int Distancia { get; set; }

        public override string ToString()
        {
            return base.GetType().Name + Id_objetivo + " - " + " Distancia " + Distancia;
        }
    }
}
