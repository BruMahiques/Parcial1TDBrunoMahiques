using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EE
{
    public class Lanzamiento
    {
        public int Id_lanza { get; set; }
       // public Arma Arma { get; set; }

        public string NombreArma { get; set; }
        public string Militar { get; set; }
       // public Objetivo Objetivo { get; set; }

        public string ObjYDistancia { get; set; }
        public int Eliminado { get; set; }
    }
}
