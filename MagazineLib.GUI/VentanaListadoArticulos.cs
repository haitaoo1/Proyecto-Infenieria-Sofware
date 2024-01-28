using Magazine.Entities;
using Magazine.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MagazineLib.GUI
{
    public partial class VentanaListadoArticulos : Form
    {

        private IMagazineService service;
        public VentanaListadoArticulos(IMagazineService service)
        {
            InitializeComponent();
            this.service = service;
        }

        private void VentanaListadoArticulos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'magazineDBDataSet.Papers' Puede moverla o quitarla según sea necesario.
          //  this.papersTableAdapter.Fill(this.magazineDBDataSet.Papers);

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void SeleccionarNumArtComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void MostrarListado_Click(object sender, EventArgs e)
        {
            //hay que hacer un clear de la tabla pero no se como aún

            if (NombreDelArticulo.Text == "TODOS") //primero crear una lista con todos los papers, luego uno a uno en esa lista añadir en cada columna el titulo y todo...
                                                   //vamos recorriendo la lista uno a uno añadiendo filas y la info de cada una
            {
                List<Paper> ListaTodosArticulos = service.TodosArtículosConEstado();
                foreach (Paper P in ListaTodosArticulos)
                {
                    int idArtFila = P.Id;
                    String tituloTabla = service.TítuloDeArticulo(idArtFila);
                    String autoresTabla = service.AutoresDelArticulo(idArtFila);
                    String estadoTabla = service.EstadoDelArtículo(idArtFila);

                    int n = tablaInfo.Rows.Add();

                    tablaInfo.Rows[n].Cells[0].Value = tituloTabla; //añadimos la información de una columna 0 de la fila n de la tabla
                    tablaInfo.Rows[n].Cells[1].Value = autoresTabla;
                    tablaInfo.Rows[n].Cells[2].Value = estadoTabla;
                }
            }
            else //obtenemos el id del combobox e insertamos en la tabla la info de este
            { //el id del artículo, pasándolo a Int
                if (service.existeArticuloAMostrar(NombreDelArticulo.Text))
                {
                    int idArtAMostrar = service.idArticuloPasado(NombreDelArticulo.Text);

                    String tituloTabla = service.TítuloDeArticulo(idArtAMostrar); //crea la variable con el titulo q devuelve el método que hemos creado

                    String autoresTabla = service.AutoresDelArticulo(idArtAMostrar);

                    String estadoTabla = service.EstadoDelArtículo(idArtAMostrar);//RELLENAR

                    int n = tablaInfo.Rows.Add(); //creamos una nueva fila de datos en la tabla
                    tablaInfo.Rows[n].Cells[0].Value = tituloTabla; //añadimos la información de una columna 0 de la fila n de la tabla
                    tablaInfo.Rows[n].Cells[1].Value = autoresTabla;
                    tablaInfo.Rows[n].Cells[2].Value = estadoTabla;
                }
                else { tituloErroneoMsg.Visible = true;}
            }



        }

        private void tablaInfoDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ReturnClick_Click(object sender, EventArgs e)
        {
            VentanaHome home = new VentanaHome(service);
            home.Show();
            this.Hide();
        }

        private void NombreDelArticulo_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tituloErroneoMsg_Click(object sender, EventArgs e)
        {

        }
    }
}
