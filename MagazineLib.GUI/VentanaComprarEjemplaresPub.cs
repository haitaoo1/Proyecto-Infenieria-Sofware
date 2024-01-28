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
    public partial class VentanaComprarEjemplaresPub : Form
    {
        private IMagazineService service;
        public VentanaComprarEjemplaresPub(IMagazineService service)
        {
            InitializeComponent();
            this.service = service;
            //enseñamos en la tabla todos los issues de la magazine con su numero su precio y su descuento
            List<Issue> Issues = service.GetIssues();
            foreach (Issue I in Issues)
            {
                int NumIssue = I.Number;
                String NumeroTabla = service.NumeroDelEjemplar(NumIssue);
                String PrecioTabla = service.PrecioDelEjemplar(NumIssue).ToString();
                String DescuentoTabla = service.DescuentoDelEjemplar(NumIssue).ToString();

                int n = ListaEjemplares.Rows.Add();

                ListaEjemplares.Rows[n].Cells[0].Value = NumeroTabla; //añadimos la información de una columna 0 de la fila n de la tabla
                ListaEjemplares.Rows[n].Cells[1].Value = PrecioTabla;
                ListaEjemplares.Rows[n].Cells[2].Value = DescuentoTabla;
            }
        }
        public bool CestaNoVacia = false;
        private void ListaEjemplares_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        
        private void AñadirALaCesta_Click(object sender, EventArgs e)
        {//cogemos el numero q nos han pasado y lo añadimos a la cesta de la compra

            //comprobamos que el texto introducido es un int
            int EjemplarElegido;
            if (int.TryParse(NumEjemplar.Text, out EjemplarElegido))
            {
                //int EjemplarElegido = Int16.Parse(NumEjemplar.Text);

                //comprobamos que el ejemplar existe
                if (service.existeEjemplar(EjemplarElegido))
                {

                    String NumeroTabla = service.NumeroDelEjemplar(EjemplarElegido);
                    String PrecioTabla = service.PrecioDelEjemplar(EjemplarElegido).ToString();
                    String DescuentoTabla = service.DescuentoDelEjemplar(EjemplarElegido).ToString();

                    int n = CestaCompra.Rows.Add();

                    CestaCompra.Rows[n].Cells[0].Value = NumeroTabla; //añadimos la información de una columna 0 de la fila n de la tabla
                    CestaCompra.Rows[n].Cells[1].Value = PrecioTabla;
                    CestaCompra.Rows[n].Cells[2].Value = DescuentoTabla;

                    ConfirmarCesta.Visible = true;
                    CestaNoVacia = true;//la cesta ya no está vacía

                    //calcula el total de la compra
                    if (CestaNoVacia)
                    {
                        int numFilas = CestaCompra.Rows.Count;
                        int precioT = 0;

                        for (int i = 0; i < numFilas - 1; i++)
                        {
                            //DataGridViewRow row = CestaCompra.Rows[i];
                            //String numeroEjemplar = row.Cells[0].Value.ToString();
                            //String precioEjemplar = row.Cells[1].Value.ToString();
                            //String DescuentoEjemplar = row.Cells[2].Value.ToString();

                            object precioEjemplar = (object)CestaCompra.Rows[i].Cells[1].Value;
                            object DescuentoEjemplar = (object)CestaCompra.Rows[i].Cells[2].Value;

                            if (service.tieneDescuento())
                            {
                                precioT += Int16.Parse((string)precioEjemplar) - (Int16.Parse((string)precioEjemplar) * (Int16.Parse((string)DescuentoEjemplar) / 100) ); // en porcentaje
                                //precioT += precioEjemplar - (precioEjemplar * (DescuentoEjemplar/100)) ;
                            }
                            else
                            {
                                precioT += Int16.Parse((string)precioEjemplar);
                                //precioT += precioEjemplar;
                            }
                        }
                        TotalPrecioMuestra.Text = precioT.ToString();
                        TotalPrecioMuestra.Visible = true;
                        TextoSuma.Visible = true;
                        
                        ErrorCestaVacia.Visible = false;
                        
                    }
                    else { ErrorCestaVacia.Visible = true; }
                }

            }
            else { ejemplarNoExiste.Visible = true; }


        }

        private void ejemplarNoExiste_Click(object sender, EventArgs e)
        {

        }

        private void ConfirmarCesta_Click(object sender, EventArgs e)
        {
            cestaConfirmada.Visible = true;

            MessageBox.Show("Compra realizada!", "Confirmacion Compra", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Hide();
            VentanaComprarEjemplaresPub comprarEjem = new VentanaComprarEjemplaresPub(service);
            comprarEjem.Show();

            //List<Control> controlsToHide = new List<Control> { ejemplarNoExiste, TextoSuma , TotalPrecioMuestra , cestaConfirmada };

            //foreach (Control control in controlsToHide)
            //{
            //    control.Visible = false;
            //}

            //CestaCompra.Clear();

            //calculamos el precio y luego lo mostramos por pantalla
            //if (CestaNoVacia) {
            //    int numFilas = CestaCompra.Rows.Count;
            //    int precioT = 0;

            //    for (int i = 0; i < numFilas-1; i++) {
            //        //DataGridViewRow row = CestaCompra.Rows[i];
            //        //String numeroEjemplar = row.Cells[0].Value.ToString();
            //        //String precioEjemplar = row.Cells[1].Value.ToString();
            //        //String DescuentoEjemplar = row.Cells[2].Value.ToString();

            //        object precioEjemplar = (object)CestaCompra.Rows[i].Cells[1].Value;
            //        object DescuentoEjemplar = (object)CestaCompra.Rows[i].Cells[2].Value;

            //        if (service.tieneDescuento())
            //        {
            //            precioT += Int16.Parse((string)precioEjemplar) - Int16.Parse((string)DescuentoEjemplar);
            //            //precioT += precioEjemplar - DescuentoEjemplar;
            //        }
            //        else
            //        {
            //            precioT += Int16.Parse((string)precioEjemplar);
            //            //precioT += precioEjemplar;
            //        }
            //    }
            //    TotalPrecioMuestra.Text = precioT.ToString();
            //    TotalPrecioMuestra.Visible = true;
            //    TextoSuma.Visible = true;
            //    RealizarCompra.Visible = true;
            //    ErrorCestaVacia.Visible = false;
            //    cestaConfirmada.Visible = true;
            //}
            //else {ErrorCestaVacia.Visible=true; }
        }


        private void ReturnClick_Click(object sender, EventArgs e)
        {
            VentanaHome home = new VentanaHome(service);
            home.Show();
            this.Hide();
        }
      
        private void CestaCompra_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //CestaCompra.RowsRemoved += new DataGridViewRowsRemovedEventHandler(dataGridView1_RowsRemoved);



            //intento de actualizar el valor de la cesta al deletear una fila
            //if (e.RowIndex != -1)
            //{
            //    AñadirALaCesta_Click(sender, e);
            //}

        }

        //private void dataGridView1_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        //{
        //    AñadirALaCesta_Click(sender,e);
        //}

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void TotalPrecioMuestra_Click(object sender, EventArgs e)
        {

        }
    }
}
