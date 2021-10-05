using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data;
using System.Text.RegularExpressions;
using EE;
using Datos;

namespace DAL
{
    public class DALObjetivos
    {
        public List<Objetivo> ListarObjetivos()
        {
            Acceso Datos = new Acceso();
            DataSet ds = new DataSet();

            List<Objetivo> LObjetivos = new List<Objetivo>();

            ds = Datos.Leer("SP_Objetivos_Listar", null);

            if (ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow fila in ds.Tables[0].Rows)
                {
                    Objetivo Objetivo = new Objetivo();
                    Objetivo.Id_objetivo = Convert.ToInt16(fila["Id_objetivo"]);
                    Objetivo.Distancia = Convert.ToInt32(fila["Distancia"]);
                    LObjetivos.Add(Objetivo);

                }
            }

            return LObjetivos;

        }
    }
}
