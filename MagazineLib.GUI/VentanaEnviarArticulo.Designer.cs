namespace MagazineLib.GUI
{
    partial class VentanaEnviarArticulo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.tituloArtLabel = new System.Windows.Forms.Label();
            this.NombreAreaBox = new System.Windows.Forms.TextBox();
            this.TituloArticuloBox = new System.Windows.Forms.TextBox();
            this.tituloAutores = new System.Windows.Forms.Label();
            this.nombreAutores = new System.Windows.Forms.Label();
            this.apellidoAutores = new System.Windows.Forms.Label();
            this.NombreAutorBox1 = new System.Windows.Forms.TextBox();
            this.ApellidoAutorBox1 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.enviarArticulo = new System.Windows.Forms.Button();
            this.AnyadirAutor = new System.Windows.Forms.Button();
            this.areaNoExiste = new System.Windows.Forms.Label();
            this.articuloEnviado = new System.Windows.Forms.Label();
            this.NoMasAutores = new System.Windows.Forms.Label();
            this.ComprobarArea = new System.Windows.Forms.Button();
            this.IntroducirTitulo = new System.Windows.Forms.Button();
            this.anyadidoConExito = new System.Windows.Forms.Label();
            this.NoExistePersonaBox1 = new System.Windows.Forms.Label();
            this.ReturnClick = new System.Windows.Forms.Button();
            this.ErrorArtExiste = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre de Area";
            // 
            // tituloArtLabel
            // 
            this.tituloArtLabel.AutoSize = true;
            this.tituloArtLabel.Location = new System.Drawing.Point(28, 227);
            this.tituloArtLabel.Name = "tituloArtLabel";
            this.tituloArtLabel.Size = new System.Drawing.Size(109, 16);
            this.tituloArtLabel.TabIndex = 1;
            this.tituloArtLabel.Text = "Titulo del Articulo";
            this.tituloArtLabel.Visible = false;
            this.tituloArtLabel.Click += new System.EventHandler(this.tituloArtLabel_Click);
            // 
            // NombreAreaBox
            // 
            this.NombreAreaBox.Location = new System.Drawing.Point(180, 122);
            this.NombreAreaBox.Name = "NombreAreaBox";
            this.NombreAreaBox.Size = new System.Drawing.Size(164, 22);
            this.NombreAreaBox.TabIndex = 2;
            this.NombreAreaBox.TextChanged += new System.EventHandler(this.NombreAreaBox_TextChanged);
            // 
            // TituloArticuloBox
            // 
            this.TituloArticuloBox.Location = new System.Drawing.Point(180, 221);
            this.TituloArticuloBox.Name = "TituloArticuloBox";
            this.TituloArticuloBox.Size = new System.Drawing.Size(164, 22);
            this.TituloArticuloBox.TabIndex = 3;
            this.TituloArticuloBox.Visible = false;
            this.TituloArticuloBox.TextChanged += new System.EventHandler(this.TituloArticuloBox_TextChanged);
            // 
            // tituloAutores
            // 
            this.tituloAutores.AutoSize = true;
            this.tituloAutores.Location = new System.Drawing.Point(610, 70);
            this.tituloAutores.Name = "tituloAutores";
            this.tituloAutores.Size = new System.Drawing.Size(53, 16);
            this.tituloAutores.TabIndex = 4;
            this.tituloAutores.Text = "Autores";
            this.tituloAutores.Visible = false;
            // 
            // nombreAutores
            // 
            this.nombreAutores.AutoSize = true;
            this.nombreAutores.Location = new System.Drawing.Point(425, 123);
            this.nombreAutores.Name = "nombreAutores";
            this.nombreAutores.Size = new System.Drawing.Size(56, 16);
            this.nombreAutores.TabIndex = 5;
            this.nombreAutores.Text = "Nombre";
            this.nombreAutores.Visible = false;
            this.nombreAutores.Click += new System.EventHandler(this.nombreAutores_Click);
            // 
            // apellidoAutores
            // 
            this.apellidoAutores.AutoSize = true;
            this.apellidoAutores.Location = new System.Drawing.Point(632, 120);
            this.apellidoAutores.Name = "apellidoAutores";
            this.apellidoAutores.Size = new System.Drawing.Size(57, 16);
            this.apellidoAutores.TabIndex = 6;
            this.apellidoAutores.Text = "Apellido";
            this.apellidoAutores.Visible = false;
            this.apellidoAutores.Click += new System.EventHandler(this.apellidoAutores_Click);
            // 
            // NombreAutorBox1
            // 
            this.NombreAutorBox1.Location = new System.Drawing.Point(510, 120);
            this.NombreAutorBox1.Name = "NombreAutorBox1";
            this.NombreAutorBox1.Size = new System.Drawing.Size(88, 22);
            this.NombreAutorBox1.TabIndex = 7;
            this.NombreAutorBox1.Visible = false;
            this.NombreAutorBox1.TextChanged += new System.EventHandler(this.NombreAutorBox1_TextChanged);
            // 
            // ApellidoAutorBox1
            // 
            this.ApellidoAutorBox1.Location = new System.Drawing.Point(700, 117);
            this.ApellidoAutorBox1.Name = "ApellidoAutorBox1";
            this.ApellidoAutorBox1.Size = new System.Drawing.Size(88, 22);
            this.ApellidoAutorBox1.TabIndex = 8;
            this.ApellidoAutorBox1.Visible = false;
            this.ApellidoAutorBox1.TextChanged += new System.EventHandler(this.ApellidoAutorBox1_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(142, 68);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(51, 16);
            this.label12.TabIndex = 21;
            this.label12.Text = "Articulo";
            // 
            // enviarArticulo
            // 
            this.enviarArticulo.Location = new System.Drawing.Point(315, 362);
            this.enviarArticulo.Name = "enviarArticulo";
            this.enviarArticulo.Size = new System.Drawing.Size(193, 48);
            this.enviarArticulo.TabIndex = 22;
            this.enviarArticulo.Text = "Enviar Articulo";
            this.enviarArticulo.UseVisualStyleBackColor = true;
            this.enviarArticulo.Visible = false;
            this.enviarArticulo.Click += new System.EventHandler(this.enviarArticulo_Click);
            // 
            // AnyadirAutor
            // 
            this.AnyadirAutor.Location = new System.Drawing.Point(683, 189);
            this.AnyadirAutor.Name = "AnyadirAutor";
            this.AnyadirAutor.Size = new System.Drawing.Size(105, 27);
            this.AnyadirAutor.TabIndex = 23;
            this.AnyadirAutor.Text = "Añadir Autor";
            this.AnyadirAutor.UseVisualStyleBackColor = true;
            this.AnyadirAutor.Visible = false;
            this.AnyadirAutor.Click += new System.EventHandler(this.AnyadirAutor_Click);
            // 
            // areaNoExiste
            // 
            this.areaNoExiste.AutoSize = true;
            this.areaNoExiste.ForeColor = System.Drawing.Color.Red;
            this.areaNoExiste.Location = new System.Drawing.Point(238, 177);
            this.areaNoExiste.Name = "areaNoExiste";
            this.areaNoExiste.Size = new System.Drawing.Size(106, 16);
            this.areaNoExiste.TabIndex = 24;
            this.areaNoExiste.Text = "El area no existe";
            this.areaNoExiste.Visible = false;
            this.areaNoExiste.Click += new System.EventHandler(this.areaNoExiste_Click);
            // 
            // articuloEnviado
            // 
            this.articuloEnviado.AutoSize = true;
            this.articuloEnviado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.articuloEnviado.Location = new System.Drawing.Point(331, 343);
            this.articuloEnviado.Name = "articuloEnviado";
            this.articuloEnviado.Size = new System.Drawing.Size(164, 16);
            this.articuloEnviado.TabIndex = 25;
            this.articuloEnviado.Text = "El articulo ha sido enviado";
            this.articuloEnviado.Visible = false;
            // 
            // NoMasAutores
            // 
            this.NoMasAutores.AutoSize = true;
            this.NoMasAutores.ForeColor = System.Drawing.Color.Red;
            this.NoMasAutores.Location = new System.Drawing.Point(578, 233);
            this.NoMasAutores.Name = "NoMasAutores";
            this.NoMasAutores.Size = new System.Drawing.Size(210, 16);
            this.NoMasAutores.TabIndex = 26;
            this.NoMasAutores.Text = "No se pueden añadir mas autores";
            this.NoMasAutores.Visible = false;
            this.NoMasAutores.Click += new System.EventHandler(this.NoMasAutores_Click);
            // 
            // ComprobarArea
            // 
            this.ComprobarArea.Location = new System.Drawing.Point(229, 150);
            this.ComprobarArea.Name = "ComprobarArea";
            this.ComprobarArea.Size = new System.Drawing.Size(115, 24);
            this.ComprobarArea.TabIndex = 27;
            this.ComprobarArea.Text = "Comprobar Area";
            this.ComprobarArea.UseVisualStyleBackColor = true;
            this.ComprobarArea.Click += new System.EventHandler(this.ComprobarArea_Click);
            // 
            // IntroducirTitulo
            // 
            this.IntroducirTitulo.Location = new System.Drawing.Point(229, 249);
            this.IntroducirTitulo.Name = "IntroducirTitulo";
            this.IntroducirTitulo.Size = new System.Drawing.Size(115, 24);
            this.IntroducirTitulo.TabIndex = 28;
            this.IntroducirTitulo.Text = "Introducir Titulo";
            this.IntroducirTitulo.UseVisualStyleBackColor = true;
            this.IntroducirTitulo.Visible = false;
            this.IntroducirTitulo.Click += new System.EventHandler(this.IntroducirTitulo_Click);
            // 
            // anyadidoConExito
            // 
            this.anyadidoConExito.AutoSize = true;
            this.anyadidoConExito.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.anyadidoConExito.Location = new System.Drawing.Point(641, 170);
            this.anyadidoConExito.Name = "anyadidoConExito";
            this.anyadidoConExito.Size = new System.Drawing.Size(147, 16);
            this.anyadidoConExito.TabIndex = 29;
            this.anyadidoConExito.Text = "Autor añadido con éxito";
            this.anyadidoConExito.Visible = false;
            // 
            // NoExistePersonaBox1
            // 
            this.NoExistePersonaBox1.AutoSize = true;
            this.NoExistePersonaBox1.ForeColor = System.Drawing.Color.Red;
            this.NoExistePersonaBox1.Location = new System.Drawing.Point(658, 227);
            this.NoExistePersonaBox1.Name = "NoExistePersonaBox1";
            this.NoExistePersonaBox1.Size = new System.Drawing.Size(130, 16);
            this.NoExistePersonaBox1.TabIndex = 30;
            this.NoExistePersonaBox1.Text = "No existe la persona";
            this.NoExistePersonaBox1.Visible = false;
            // 
            // ReturnClick
            // 
            this.ReturnClick.Location = new System.Drawing.Point(700, 385);
            this.ReturnClick.Name = "ReturnClick";
            this.ReturnClick.Size = new System.Drawing.Size(88, 25);
            this.ReturnClick.TabIndex = 31;
            this.ReturnClick.Text = "Return";
            this.ReturnClick.UseVisualStyleBackColor = true;
            this.ReturnClick.Click += new System.EventHandler(this.ReturnClick_Click);
            // 
            // ErrorArtExiste
            // 
            this.ErrorArtExiste.AutoSize = true;
            this.ErrorArtExiste.ForeColor = System.Drawing.Color.Red;
            this.ErrorArtExiste.Location = new System.Drawing.Point(360, 343);
            this.ErrorArtExiste.Name = "ErrorArtExiste";
            this.ErrorArtExiste.Size = new System.Drawing.Size(121, 16);
            this.ErrorArtExiste.TabIndex = 32;
            this.ErrorArtExiste.Text = "El articulo ya existe";
            this.ErrorArtExiste.Visible = false;
            this.ErrorArtExiste.Click += new System.EventHandler(this.ErrorArtExiste_Click);
            // 
            // VentanaEnviarArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 422);
            this.Controls.Add(this.ErrorArtExiste);
            this.Controls.Add(this.ReturnClick);
            this.Controls.Add(this.NoExistePersonaBox1);
            this.Controls.Add(this.anyadidoConExito);
            this.Controls.Add(this.IntroducirTitulo);
            this.Controls.Add(this.ComprobarArea);
            this.Controls.Add(this.NoMasAutores);
            this.Controls.Add(this.articuloEnviado);
            this.Controls.Add(this.areaNoExiste);
            this.Controls.Add(this.AnyadirAutor);
            this.Controls.Add(this.enviarArticulo);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.ApellidoAutorBox1);
            this.Controls.Add(this.NombreAutorBox1);
            this.Controls.Add(this.apellidoAutores);
            this.Controls.Add(this.nombreAutores);
            this.Controls.Add(this.tituloAutores);
            this.Controls.Add(this.TituloArticuloBox);
            this.Controls.Add(this.NombreAreaBox);
            this.Controls.Add(this.tituloArtLabel);
            this.Controls.Add(this.label1);
            this.Name = "VentanaEnviarArticulo";
            this.Text = "VentanaEnviarArticulo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label tituloArtLabel;
        private System.Windows.Forms.TextBox NombreAreaBox;
        private System.Windows.Forms.TextBox TituloArticuloBox;
        private System.Windows.Forms.Label tituloAutores;
        private System.Windows.Forms.Label nombreAutores;
        private System.Windows.Forms.Label apellidoAutores;
        private System.Windows.Forms.TextBox NombreAutorBox1;
        private System.Windows.Forms.TextBox ApellidoAutorBox1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button enviarArticulo;
        private System.Windows.Forms.Button AnyadirAutor;
        private System.Windows.Forms.Label areaNoExiste;
        private System.Windows.Forms.Label articuloEnviado;
        private System.Windows.Forms.Label NoMasAutores;
        private System.Windows.Forms.Button ComprobarArea;
        private System.Windows.Forms.Button IntroducirTitulo;
        private System.Windows.Forms.Label anyadidoConExito;
        private System.Windows.Forms.Label NoExistePersonaBox1;
        private System.Windows.Forms.Button ReturnClick;
        private System.Windows.Forms.Label ErrorArtExiste;
    }
}