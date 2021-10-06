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
        DALObjetivos DALObjetivos = new DALObjetivos();

        
        public Form1()
        {
            InitializeComponent();

            EstrategiaLanzamiento = new List<Arma>();
            EstrategiaLanzamiento.Add(new CañonDeCortoAlcance());
            EstrategiaLanzamiento.Add(new CañonUltrasónico());
            EstrategiaLanzamiento.Add(new RayoLaserDestructorBionico());

            this.comboArmas.DataSource = EstrategiaLanzamiento;

           
            Radar = DALObjetivos.ListarObjetivos();

            this.comboRadar.DataSource = Radar;

            /* DALLanzamiento DALLanzamiento = new DALLanzamiento();
             LLanzamientos = DALLanzamiento.ListarLanzamientos();

             this.dataGridView1.DataSource = LLanzamientos
             */
            ObtenerLanzamientos();


            if (Militar == null)
            {
                Disparar.Visible=false;
                ArmaAdecuadaBoton.Visible = false;
            }
            

        }



        private void ArmaAdecuadaBoton_Click(object sender, EventArgs e)
        {
            if (Militar != null)
            {
                Disparar.Show();
                ArmaAdecuadaBoton.Show();
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
            if (Militar.Arma != null)
            {
                Lanzamiento = new Lanzamiento();

                Random random = new Random();
                int value = random.Next(2);
                Objetivo Obje = (Objetivo)this.comboRadar.SelectedItem;
                //  Lanzamiento.Arma = Militar.Arma;
                Lanzamiento.Militar = Militar.Nombre;
               // Lanzamiento.Objetivo = (Objetivo)this.comboRadar.SelectedItem;
                Lanzamiento.NombreArma = this.comboArmas.SelectedItem.ToString();
                Lanzamiento.ObjYDistancia = this.comboRadar.SelectedItem.ToString();
                Lanzamiento.Eliminado = value;
                Lanzamiento.Id_objetivo = Obje.Id_objetivo;

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
            Disparar.Visible = true;
            ArmaAdecuadaBoton.Visible = true;
        }

        private void RecargarRadar_Click(object sender, EventArgs e)
        {
            bool resultado;
            resultado = DALObjetivos.Eliminar_Objetivos();
            Radar = DALObjetivos.ListarObjetivos();

            this.comboRadar.DataSource = Radar;

            MessageBox.Show("Se recargó correctamente el radar");
        }
    }
}
