using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Magazine.Persistence;
using Magazine.Services;

namespace MagazineLib.GUI
{
    public partial class VentanaInicio : Form
    {
        private IMagazineService service;
        public VentanaInicio(IMagazineService service)
        {
            InitializeComponent();
            this.service = service;
            IDAL dal = new EntityFrameworkDAL(new MagazineDbContext());
            service = new MagazineService(dal);
            service.DBInitialization();
        }

      

        private void InicioBox_Click(object sender, EventArgs e)
        {
            VentanaInicioSesion InicioSesion = new VentanaInicioSesion(service);
            InicioSesion.Show();
            this.Hide();
        }

        private void RegistrarBox_Click(object sender, EventArgs e)
        {
            VentanaRegistrarUsuario ventanaRegistrar = new VentanaRegistrarUsuario(service);
            ventanaRegistrar.Show();
            this.Hide();
        }

        private void VentanaInicio_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Exit_Click_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ConsultarEjemplaresPublicados_Click(object sender, EventArgs e)
        {
            VentanaConsultarEjemplaresPublicados ventanaConsultarEjempPublic = new VentanaConsultarEjemplaresPublicados(service);
            ventanaConsultarEjempPublic.Show();
            this.Hide();
        }
    }
}
