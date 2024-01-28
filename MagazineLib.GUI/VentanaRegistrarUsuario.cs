using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Magazine.Entities;
using Magazine.Services;

namespace MagazineLib.GUI
{
    public partial class VentanaRegistrarUsuario : Form
    {
        private IMagazineService service;
        public VentanaRegistrarUsuario(IMagazineService service)
        {
            InitializeComponent();
            this.service = service;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void BotonIniciarSesion_Click(object sender, EventArgs e)
        {

        }

        private void BotonRegistrar_Click(object sender, EventArgs e)
        {
            try
            {

                bool suscrit = false;
                if (suscribirse.Checked == true) { suscrit = true; } // en caso de activarse el boton se pone true
                service.RegistrarUsuario(IdBox.Text, NameBox.Text, SurnameBox.Text, EmailBox.Text, AreasOfInterestBox.Text, LoginBox.Text, PasswordBox.Text, suscrit);
                VentanaInicioSesion InicioSesion = new VentanaInicioSesion(service);
                InicioSesion.Show();
                this.Hide();
                UsuarioExist.Visible = false;
            } catch(ServiceException ex) {
                UsuarioExist.Visible = true;

            }
        }

        private void VentanaRegistrarUsuario_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void IdBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void NameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void SurnameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void EmailBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void AreasOfInterestBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void PasswordBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void suscribirse_CheckedChanged(object sender, EventArgs e)
        {
            
        }
    }
}
