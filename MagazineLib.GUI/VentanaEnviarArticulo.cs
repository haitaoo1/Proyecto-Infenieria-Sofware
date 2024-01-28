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
    public partial class VentanaEnviarArticulo : Form
    {
        private IMagazineService service;
        public VentanaEnviarArticulo(IMagazineService service)
        {
            InitializeComponent();
            this.service = service;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void ComprobarArea_Click(object sender, EventArgs e)
        {

            if (service.existeArea(NombreAreaBox.Text))
            {
                tituloArtLabel.Visible = true;
                TituloArticuloBox.Visible = true;
                IntroducirTitulo.Visible = true;
                areaNoExiste.Visible = false;
                IntroducirTitulo.Visible = true;

            }
            else {
                areaNoExiste.Visible = true;
                tituloArtLabel.Visible = false;
                TituloArticuloBox.Visible = false;
                IntroducirTitulo.Visible = false;

            }
        }

        private void tituloArtLabel_Click(object sender, EventArgs e)
        {

        }

        private void TituloArticuloBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void IntroducirTitulo_Click(object sender, EventArgs e)
        {
            
            //Metodo
            //TituloArticuloBox

            if (TituloArticuloBox.Text != null) {
                nombreAutores.Visible=true;
                NombreAutorBox1.Visible = true;
                apellidoAutores.Visible = true;
                ApellidoAutorBox1.Visible=true;
                AnyadirAutor.Visible=true;
                enviarArticulo.Visible=true;
                tituloAutores.Visible=true;

            }
        }

        private void areaNoExiste_Click(object sender, EventArgs e)
        {

        }
        //String listaNombreApll = "";
        int IdParaAutoresNuevos = 4568;//partimos de este id q es el último que hemos añadido en la BD
        List<Person> CoAutoresCreados= new List<Person>();
        private void AnyadirAutor_Click(object sender, EventArgs e)
        {
            if (service.ExisteAutor(NombreAutorBox1.Text, ApellidoAutorBox1.Text))//comprueba q exista nombre y apellido en la BD
            {//añadimos en BD
                Person coAutor = new Person(IdParaAutoresNuevos.ToString(), NombreAutorBox1.Text, ApellidoAutorBox1.Text);
                service.AddPerson(coAutor);
                CoAutoresCreados.Add(coAutor);

                anyadidoConExito.Visible = true;
                NoExistePersonaBox1.Visible = false;
                
                IdParaAutoresNuevos++;//para que el siguiente autor tenga un id único tmb
                NombreAutorBox1.Clear();
                ApellidoAutorBox1.Clear();
            }
            else NoExistePersonaBox1.Visible = true;
            
        }

        private void NoMasAutores_Click(object sender, EventArgs e)
        {

        }

        private void ApellidoAutorBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void NombreAutorBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void apellidoAutores_Click(object sender, EventArgs e)
        {

        }

        private void nombreAutores_Click(object sender, EventArgs e)
        {

        }

        private void enviarArticulo_Click(object sender, EventArgs e)
        {
          

            if (!service.existePaper(TituloArticuloBox.Text))
            {
                service.enviarPaper(NombreAreaBox.Text, TituloArticuloBox.Text, CoAutoresCreados);

                articuloEnviado.Visible = true;
                MessageBox.Show("Articulo enviado correctamente!", "Articulo Enviado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                List<Control> controlsToHide = new List<Control> { AnyadirAutor, anyadidoConExito, NoMasAutores, ApellidoAutorBox1, apellidoAutores, NombreAutorBox1, nombreAutores,
                                                                tituloAutores, IntroducirTitulo, TituloArticuloBox, tituloArtLabel, areaNoExiste, articuloEnviado};

                foreach (Control control in controlsToHide)
                {
                    control.Visible = false;
                }
                NombreAreaBox.Clear();
            }
            else { ErrorArtExiste.Visible = true; }
        }


        private void NombreAreaBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ReturnClick_Click(object sender, EventArgs e)
        {
            
            VentanaHome home = new VentanaHome(service);
            home.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ErrorArtExiste_Click(object sender, EventArgs e)
        {

        }
    }
}
