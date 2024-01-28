using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Magazine.Services;

namespace MagazineLib.GUI
{
    public partial class VentanaHome : Form
    {
        private IMagazineService service;

        public VentanaHome(IMagazineService service)

        {
            InitializeComponent();
            this.service = service;
            if (service.esChiefEditor()) { //si es jefe
                ConfeccionarEjemplarBox.Visible = true;
                ListadoArticulosBox.Visible = true;
            }
            
            if (service.esEditorArea()) //si es editor jefe
            {
               
                EvaluarArticuloBox.Visible = true;
            }
            if(service.esUsuario()) //no es absolutamente nada, es una mierda
            {
                EnviarArticuloBox.Visible=true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void ListadoArticulosBox_Click(object sender, EventArgs e)
        {
            VentanaListadoArticulos listArt = new VentanaListadoArticulos(service);
            listArt.Show();
            this.Hide();
        }

        private void EnviarArticuloBox_Click(object sender, EventArgs e)
        {
            VentanaEnviarArticulo envArt = new VentanaEnviarArticulo(service);
            envArt.Show();
            this.Hide();
        }

        private void EvaluarArticuloBox_Click(object sender, EventArgs e)
        {
            Form1 for1 = new Form1(service);
            for1.Show();
            //EvaluarArticuloBox evArt = new EvaluarArticuloBox(service);
            //evArt.Show();
            this.Hide();
        }

        private void ConfeccionarEjemplarBox_Click(object sender, EventArgs e)
        {
            ConfeccionarEjemplar confecArt = new ConfeccionarEjemplar(service);
            confecArt.Show();
            this.Hide();
           


        }

        private void ExitBox_Click(object sender, EventArgs e)
        {
            VentanaInicioSesion volverHome= new VentanaInicioSesion(service);
            volverHome.Show();
            this.Hide();
        }

        private void VentanaHome_Load(object sender, EventArgs e)
        {

        }

        private void ComprarEjemplar_Click(object sender, EventArgs e)
        {
            VentanaComprarEjemplaresPub VComprarEjemplar = new VentanaComprarEjemplaresPub(service);
            VComprarEjemplar.Show();
            this.Hide();
        }
    }
}
