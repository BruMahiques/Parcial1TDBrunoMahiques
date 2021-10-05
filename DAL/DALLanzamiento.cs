using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Collections;
using System.Text.RegularExpressions;
using EE;
using Datos;

namespace DAL
{
    public class DALLanzamiento
    {
            public bool Guardar_Lanzamientos(Lanzamiento Lanzamiento)
            {
                Acceso Datos = new Acceso();
                Hashtable Hdatos = new Hashtable();
                bool Resultado;
                string consulta = "SP_Lanzamientos";

                Hdatos.Add("@Arma", Lanzamiento.NombreArma);
                Hdatos.Add("@Militar", Lanzamiento.Militar);
                Hdatos.Add("@Objetivo", Lanzamiento.ObjYDistancia);
                Hdatos.Add("@Eliminado", Lanzamiento.Eliminado);

                Resultado = Datos.Escribir(consulta, Hdatos);
                return Resultado;
            }
        public List<Lanzamiento> ListarLanzamientos()
        {
            Acceso Datos = new Acceso();
            DataSet ds = new DataSet();

            List<Lanzamiento> LLanzamiento = new List<Lanzamiento>();

            ds = Datos.Leer("SP_Lanzamientos_Listar", null);

            if (ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow fila in ds.Tables[0].Rows)
                {
                    Lanzamiento Lanzamiento = new Lanzamiento();
                    Lanzamiento.NombreArma = fila["Arma"].ToString();
                    Lanzamiento.Militar = fila["Militar"].ToString();
                    Lanzamiento.ObjYDistancia = fila["Objetivo_Distancia"].ToString();
                    Lanzamiento.Eliminado = Convert.ToInt16(fila["Eliminado"]);
                    LLanzamiento.Add(Lanzamiento);

                }
            }

            return LLanzamiento;

        }
    }
}
