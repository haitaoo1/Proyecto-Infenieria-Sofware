using Magazine.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MagazineLib.GUI
{
    public partial class Home : Form
    {
        private IMagazineService service;

        public Home(IMagazineService service)
        {
            InitializeComponent();
            this.service = service;

            if () { 
            
            }
        }

        private void EnviarArticulo_Click(object sender, EventArgs e)
        {
            EnviarArticulo envArt = new EnviarArticulo(service);
            envArt.Show();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void EvaluarArticulo_Click(object sender, EventArgs e)
        {
            EvaluarArticulo evArt = new EvaluarArticulo(service);
            evArt.Show();
        }

        private void ConfeccionarEjemplar_Click(object sender, EventArgs e)
        {
            ConfeccionarEjemplar confecArt = new ConfeccionarEjemplar(service);
            confecArt.Show();
        }

        private void ListadoArticulos_Click(object sender, EventArgs e)
        {
            ListadoArticulos listaArt = new ListadoArticulos(service);
            listArt.Show();
        }
    }
}
