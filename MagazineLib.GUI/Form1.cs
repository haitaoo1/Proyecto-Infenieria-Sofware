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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MagazineLib.GUI
{
    public partial class Form1 : Form
    {
        private IMagazineService service;
        public Form1(IMagazineService service)
        {
            InitializeComponent( );
            this.service = service;
            LoadData();
            errorSeleccion.Visible = false;
            evaluacionCorrecta.Visible = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        public void LoadData() {

            List<Area> areas = service.AllAreas();

            foreach(var area in areas){

                List<Paper> data = service.MostrarPendEvaluarArea(area.Name);
                foreach (Paper p in data)
                {
                    if (p.EvaluationPendingArea != null)
                    {
                        dataGridView1.Rows.Add(p.Id, p.Title, p.CoAuthors?.FirstOrDefault()?.Name, p.UploadDate);
                    }
                }
            }

            
        }
        private void aceptarBoton_Click(object sender, EventArgs e)
        {

            //
            DateTime fechaSeleccionada = dateTimePicker1.Value;
           
            Boolean res = bool.Parse(resultadoEvaluarArticuloBox.Text);
        
            string comment = comentariosBox.Text;
            
            //cogemos los valores de la fila seleccionada en el gridview
            DataGridViewRow filaSeleccionada = dataGridView1.CurrentRow;
            //si hemos selecionado una fila
            if (filaSeleccionada != null)
            {
                //obtenemos el segundo elemento de la fila seleccionada, es decir, el titulo del paper
                string PaperTitle = filaSeleccionada.Cells[1].Value.ToString();
                //crear un metodo que pasando un paper se agrege una evaluacion
                service.AddEvaluationP(PaperTitle, res, comment,fechaSeleccionada);

                //si se ha selecionado una fila
                if (dataGridView1.SelectedRows.Count > 0)
                {   //obtener el indice de la fila seleccionada
                    int indiceFilaSeleccionada = dataGridView1.SelectedRows[0].Index;
                    //eliminar fila selecionada
                    dataGridView1.Rows.RemoveAt(indiceFilaSeleccionada);
                }

                service.DeletePaperFromEP(PaperTitle);
            }
        }

        private void evaluacionCorrecta_Click(object sender, EventArgs e)
        {

        }

        private void cancelarBoton_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void ReturnHome_Click(object sender, EventArgs e)
        {
            VentanaHome home = new VentanaHome(service);
            home.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void resultadoEvaluarArticuloBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Boolean res = bool.Parse(resultadoEvaluarArticuloBox.Text);
                FormatoTF.Visible = false;
                aceptarBoton.Visible = true;
            }
            catch (FormatException ex)
            {

                aceptarBoton.Focus();
                FormatoTF.Visible = true;
                aceptarBoton.Visible = false;

            }

        }
    }
}
