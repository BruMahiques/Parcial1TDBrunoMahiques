using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EE;
using DAL;

namespace Parcial1TDBrunoMahiques
{
    public partial class Form1 : Form
    {
        List<Arma> EstrategiaLanzamiento;
        Militar Militar;
        Lanzamiento Lanzamiento;
        List<Objetivo> Radar;
        List<Lanzamiento> LLanzamientos;
        

        public Form1()
        {
            InitializeComponent();

            EstrategiaLanzamiento = new List<Arma>();
            EstrategiaLanzamiento.Add(new CañonDeCortoAlcance());
            EstrategiaLanzamiento.Add(new CañonUltrasónico());
            EstrategiaLanzamiento.Add(new RayoLaserDestructorBionico());

            this.comboArmas.DataSource = EstrategiaLanzamiento;

            DALObjetivos DALObjetivos = new DALObjetivos();
            Radar = DALObjetivos.ListarObjetivos();

            this.comboRadar.DataSource = Radar;

            /* DALLanzamiento DALLanzamiento = new DALLanzamiento();
             LLanzamientos = DALLanzamiento.ListarLanzamientos();

             this.dataGridView1.DataSource = LLanzamientos
             */
            ObtenerLanzamientos();




        }



        private void ArmaAdecuadaBoton_Click(object sender, EventArgs e)
        {
            if (Militar != null)
            { 
                
            Objetivo ObjetivoSeleccionado = (Objetivo)this.comboRadar.SelectedItem;

            if (ObjetivoSeleccionado.Distancia < 10000)
            {
                this.comboArmas.Text = "CañonDeCortoAlcance";
                
            }
            else
            {
                if (ObjetivoSeleccionado.Distancia >= 10000 && ObjetivoSeleccionado.Distancia < 50000)
                {
                    this.comboArmas.Text = "CañonUltrasónico";
                    
                }
                else
                {
                    this.comboArmas.Text = "RayoLaserDestructorBionico";
                   
                }
            }

            Arma arma = (Arma)this.comboArmas.SelectedItem;
            Militar.CambiarEstrategia(arma);
            }

        }

        private void Disparar_Click(object sender, EventArgs e)
        {
            if (Militar != null)
            {
                Lanzamiento = new Lanzamiento();
                
                var Tick = Environment.TickCount;
                var random = new Random(Tick);
                var value = random.Next(0, 1);

              //  Lanzamiento.Arma = Militar.Arma;
                Lanzamiento.Militar = Militar.Nombre;
               // Lanzamiento.Objetivo = (Objetivo)this.comboRadar.SelectedItem;
                Lanzamiento.NombreArma = this.comboArmas.SelectedItem.ToString();
                Lanzamiento.ObjYDistancia = this.comboRadar.SelectedItem.ToString();
                Lanzamiento.Eliminado = value;

                DALLanzamiento DALLanzamiento = new DALLanzamiento();
                DALLanzamiento.Guardar_Lanzamientos(Lanzamiento);

                ObtenerLanzamientos();

                
                }

            MessageBox.Show(Militar.Disparar());
        }

        private void ObtenerLanzamientos()
        {
                            

            DALLanzamiento DALLanzamiento = new DALLanzamiento();
            LLanzamientos = DALLanzamiento.ListarLanzamientos();

            this.dataGridView1.DataSource = null;
            this.dataGridView1.DataSource = LLanzamientos;
        }


        private void MiliNombre_Click(object sender, EventArgs e)
        {
            Militar = new Militar();
            Militar.Nombre = textBox1.Text;
            label6.Text = Militar.Nombre;
        }
    }
}
