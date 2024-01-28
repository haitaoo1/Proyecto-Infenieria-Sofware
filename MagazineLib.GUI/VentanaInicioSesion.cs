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
using Magazine.Persistence;
using Magazine.Services;

namespace MagazineLib.GUI
{
    public partial class VentanaInicioSesion : Form
    {
        public static User Usuario = null;
        private IMagazineService service;
        public VentanaInicioSesion(IMagazineService service)
        {
            InitializeComponent();
            this.service = service;
            
        }

        private void VentanaInicioSesion_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ////Cuando apretas el boton registrar te lleva a la interfaz de registrar usuario(Registrarse)
            VentanaRegistrarUsuario registrar = new VentanaRegistrarUsuario(service);
            registrar.Show();
            this.Hide();
        }

        private void UserBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void BotonInicio_Click(object sender, EventArgs e)
        {
#pragma warning disable CS0168 // La variable 'exception' se ha declarado pero nunca se usa
            try
            {
                Usuario = service.IniciarSesion(UserBox.Text, PasswordBox.Text);
                VentanaHome home = new VentanaHome(service);
                home.Show();
                this.Hide();


            }
            catch (Exception exception)
            {
                UsuarioNoExisteText.Visible = true;
                //ErrorTxt.Visible = true;
                //ErrorTxt.Text = exception.Message;
            }
#pragma warning restore CS0168 // La variable 'exception' se ha declarado pero nunca se usa
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void UsuarioNoExisteText_Click(object sender, EventArgs e)
        {

        }

        private void returnHome_Click(object sender, EventArgs e)
        {

        }

        private void home_Click(object sender, EventArgs e)
        {
            VentanaInicio home=new VentanaInicio(service);
            home.Show();
            this.Hide();
        }
    }
}
