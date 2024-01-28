using Magazine.Entities;
using Magazine.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MagazineLib.GUI
{
    public partial class VentanaConsultarEjemplaresPublicados : Form
    {
        private IMagazineService service;
        public VentanaConsultarEjemplaresPublicados(IMagazineService service)
        {
            InitializeComponent();
            this.service = service;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void NumEjemplar_TextChanged(object sender, EventArgs e)
        {

        }

        private void MostrarEjemplar_Click(object sender, EventArgs e)
        {
            int NumEj = Int32.Parse(NumEjemplar.Text);
            if (service.existeEjemplar(NumEj)) {
                
                List<Paper> ListaTodosArticulos = service.TodosArticulosDelEjemplar(NumEj);
                foreach (Paper P in ListaTodosArticulos)
                {

                    int idArtFila = P.Id;
                    String tituloTabla = service.TítuloDeArticulo(idArtFila);
                    String autoresTabla = service.AutoresDelArticulo(idArtFila);

                    int n = tablaEjemplares.Rows.Add();

                    tablaEjemplares.Rows[n].Cells[0].Value = tituloTabla;
                    tablaEjemplares.Rows[n].Cells[1].Value = autoresTabla;

                }//insertar el precio tmb
                String precioEj = service.PrecioEjemplar(NumEj).ToString();
                TextoPrecio.Text = "El precio del ejemplar es de " + precioEj + "€";
                TextoPrecio.Visible = true;

            }
            else { errorNumEjemplar.Visible = true; }
        }

        private void tabla_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void TextoPrecio_Click(object sender, EventArgs e)
        {

        }

        private void exit_Click(object sender, EventArgs e)
        {
            VentanaInicio home = new VentanaInicio(service);
            home.Show();
            this.Hide();
        }
    }
}
