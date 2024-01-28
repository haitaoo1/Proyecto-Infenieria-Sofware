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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MagazineLib.GUI
{
    public partial class ConfeccionarEjemplar : Form
    {
        IMagazineService service;
        public ConfeccionarEjemplar(IMagazineService service)
        {
            InitializeComponent();
            this.service = service;
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SelectFecha_Click(object sender, EventArgs e)
        {
            DateTime fechaSeleccionada = Calendario.SelectionRange.Start;
            //Obetener los articulos selecionados
            //añadir en la lista published con las nuevas fechas
            //con los papers
        }

        private void MostrarB_Click(object sender, EventArgs e)
        {
            try
            { 
                service.comprabarArea(AreaIntro.Text);
                AreaNoexiste.Visible = false;
                // obtiene dos listas de objetos

                //obetenemos todos los articulos de publicationPending y EvaluationPending
                var PublicationList = service.SelectPublicationP(AreaIntro.Text);
                var EvaluationList = service.SelectEvaluationP(AreaIntro.Text);


                //if(PublicationList!= null ) { PublicarPrecio.Enabled = true; }//si hay un articulo en publicationPending muestra el boton para publicar

            //recorremos la lista y añadimos los articulos a las listbox correspondientes
                foreach (var publication in PublicationList)
                {
                    listBox1.Items.Add(publication.Title);

                }
                foreach (var evaluation in EvaluationList)
                {
                    listBox2.Items.Add(evaluation.Title);

                }
                MostrarB.Visible = false;
                 }
            catch (ServiceException) { AreaNoexiste.Visible = true; }
        }



        private void AreaIntro_TextChanged(object sender, EventArgs e)
        {

        }

        private void MoverPendEv_Click(object sender, EventArgs e)
        {

            var selectedItem = listBox1.SelectedItem;

            if (selectedItem != null)
            {
                listBox2.Items.Add(selectedItem);
                listBox1.Items.Remove(selectedItem);
                service.MoverPublicationAEvaluation(AreaIntro.Text, selectedItem.ToString());
            }  
        }
        private void MoverPendPub_Click(object sender, EventArgs e)
        {
            var selectedItem = listBox2.SelectedItem;

            if (selectedItem != null)
            {
                listBox2.Items.Remove(selectedItem);
                listBox1.Items.Add(selectedItem);
                service.MoverEvaluationAPublication(AreaIntro.Text, selectedItem.ToString());
                errorPendPubli.Visible = false;
               
            }
        }
        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void ConfeccionarEjemplar_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void ReturnClick_Click(object sender, EventArgs e)
        {
            VentanaHome home = new VentanaHome(service);
            home.Show();
            this.Hide();
        }

        private void BotonReiniciar_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear(); 
            MostrarB.Visible = true;
            AreaNoexiste.Visible = false;
            AreaIntro.Text = "";
        }

        private void AreaNoexiste_Click(object sender, EventArgs e)
        {

        }

        private void Calendario_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void PublicarPrecio_Click(object sender, EventArgs e)
        {   //obtener los valores de los textfields de precio y descuento

            var selectedItem = listBox1.SelectedItem;

            if (float.Parse(AddPrecioTxt.Text) > 0 && float.TryParse(numIssue.Text, out float result) && int.Parse(numIssue.Text)>0 && float.Parse(AddDescTxt.Text) >= 0 && float.TryParse(numIssue.Text, out float _))
            {

                
                if (selectedItem != null)
                {

                    listBox1.Items.Remove(selectedItem);


                    DateTime fechaSeleccionada = Calendario.SelectionRange.Start;
                    float Precio = float.Parse(AddPrecioTxt.Text);
                    float Descuento = float.Parse(AddDescTxt.Text);
                    int numeroIssue = int.Parse(numIssue.Text);

                    service.AddIssueM(numeroIssue, Precio, Descuento, selectedItem.ToString(), fechaSeleccionada, AreaIntro.Text);

                    errorPendPubli.Visible = false;
                    PrecioNoIntr.Visible = false;
                    errorNumIssue.Visible = false;
                    ArticuloPub.Visible = true;
                    MessageBox.Show("Articulo publicado correctamente!", "Publicacion Aticulo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    ConfeccionarEjemplar comprarEjem = new ConfeccionarEjemplar(service);
                    comprarEjem.Show();
                }
                else { errorPendPubli.Visible = true; }
                

                //PrecioNoIntr.Visible = false;
                //errorNumIssue.Visible = false;
                //ArticuloPub.Visible = true;
                //MessageBox.Show("Articulo publicado correctamente!", "Publicacion Aticulo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //this.Hide();
                //ConfeccionarEjemplar comprarEjem = new ConfeccionarEjemplar(service);
                //comprarEjem.Show();
            }
            else if (float.Parse(AddPrecioTxt.Text) <= 0 || float.Parse(AddDescTxt.Text) < 0) { PrecioNoIntr.Visible = true; }
            else { errorNumIssue.Visible = true; }
        }

        private void AddDescTxt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double number = Convert.ToDouble(AddDescTxt.Text);
                PublicarPrecio.Enabled = true;
                PrecioNoIntr.Visible=false;
            }
            catch (FormatException)
            {
                //MessageBox.Show("El valor ingresado no es un número");
                AddDescTxt.Focus();
                PublicarPrecio.Enabled = false;
                PrecioNoIntr.Visible = true;
            }
        }

        private void AddPrecioTxt_TextChanged(object sender, EventArgs e)
        {

            try
            {
                double number = Convert.ToDouble(AddPrecioTxt.Text);
                PublicarPrecio.Enabled = true;
                PrecioNoIntr.Visible = false;
            }
            catch (FormatException)
            {
                //MessageBox.Show("El valor ingresado no es un número");
                AddPrecioTxt.Focus();
                PublicarPrecio.Enabled = false;
                PrecioNoIntr.Visible = true;
            }
            
        }

        private void numIssue_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double number = Convert.ToDouble(numIssue.Text);
                errorNumIssue.Visible = false;
            }
            catch (FormatException)
            {
                //MessageBox.Show("El valor ingresado no es un número");
                AddPrecioTxt.Focus();
            }
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void numIssueInvalido_Click(object sender, EventArgs e)
        {

        }

        private void errorNumIssue_Click(object sender, EventArgs e)
        {

        }

        private void PrecioNoIntr_Click(object sender, EventArgs e)
        {

        }

        private void errorPendPubli_Click(object sender, EventArgs e)
        {

        }
    }
}
