using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EE
{
    public class Militar
    {
        public string Nombre { get; set; }

        public Arma Arma;
        public void CambiarEstrategia(Arma estrategia)
        {
            Arma = estrategia;
        }

        public string Disparar()
        {
            if (Arma == null)
                return "Cañon no disponible";
            return Arma.Lanzar();
        }
    }
}
