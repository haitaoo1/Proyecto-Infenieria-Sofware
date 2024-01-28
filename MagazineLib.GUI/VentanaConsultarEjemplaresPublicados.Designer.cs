namespace MagazineLib.GUI
{
    partial class VentanaConsultarEjemplaresPublicados
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
            this.tablaEjemplares = new System.Windows.Forms.DataGridView();
            this.titulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Autores = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exit = new System.Windows.Forms.Button();
            this.MostrarEjemplar = new System.Windows.Forms.Button();
            this.NumEjemplar = new System.Windows.Forms.TextBox();
            this.errorNumEjemplar = new System.Windows.Forms.Label();
            this.TextoPrecio = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tablaEjemplares)).BeginInit();
            this.SuspendLayout();
            // 
            // tablaEjemplares
            // 
            this.tablaEjemplares.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaEjemplares.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.titulo,
            this.Autores});
            this.tablaEjemplares.Location = new System.Drawing.Point(12, 12);
            this.tablaEjemplares.Name = "tablaEjemplares";
            this.tablaEjemplares.RowHeadersWidth = 51;
            this.tablaEjemplares.Size = new System.Drawing.Size(390, 178);
            this.tablaEjemplares.TabIndex = 0;
            this.tablaEjemplares.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tabla_CellContentClick);
            // 
            // titulo
            // 
            this.titulo.HeaderText = "Titulo";
            this.titulo.MinimumWidth = 6;
            this.titulo.Name = "titulo";
            this.titulo.Width = 150;
            // 
            // Autores
            // 
            this.Autores.HeaderText = "Autores";
            this.Autores.MinimumWidth = 6;
            this.Autores.Name = "Autores";
            this.Autores.Width = 200;
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(548, 167);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(75, 23);
            this.exit.TabIndex = 1;
            this.exit.Text = "Return";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // MostrarEjemplar
            // 
            this.MostrarEjemplar.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.MostrarEjemplar.Location = new System.Drawing.Point(415, 68);
            this.MostrarEjemplar.Name = "MostrarEjemplar";
            this.MostrarEjemplar.Size = new System.Drawing.Size(75, 23);
            this.MostrarEjemplar.TabIndex = 2;
            this.MostrarEjemplar.Text = "Mostrar";
            this.MostrarEjemplar.UseVisualStyleBackColor = true;
            this.MostrarEjemplar.Click += new System.EventHandler(this.MostrarEjemplar_Click);
            // 
            // NumEjemplar
            // 
            this.NumEjemplar.ForeColor = System.Drawing.SystemColors.InfoText;
            this.NumEjemplar.Location = new System.Drawing.Point(415, 42);
            this.NumEjemplar.Name = "NumEjemplar";
            this.NumEjemplar.Size = new System.Drawing.Size(125, 20);
            this.NumEjemplar.TabIndex = 4;
            this.NumEjemplar.Text = "ej: 1111";
            this.NumEjemplar.TextChanged += new System.EventHandler(this.NumEjemplar_TextChanged);
            // 
            // errorNumEjemplar
            // 
            this.errorNumEjemplar.AutoSize = true;
            this.errorNumEjemplar.ForeColor = System.Drawing.Color.Red;
            this.errorNumEjemplar.Location = new System.Drawing.Point(412, 9);
            this.errorNumEjemplar.Name = "errorNumEjemplar";
            this.errorNumEjemplar.Size = new System.Drawing.Size(169, 13);
            this.errorNumEjemplar.TabIndex = 5;
            this.errorNumEjemplar.Text = "El ejemplar seleccionado no existe";
            this.errorNumEjemplar.Visible = false;
            // 
            // TextoPrecio
            // 
            this.TextoPrecio.AutoSize = true;
            this.TextoPrecio.Location = new System.Drawing.Point(412, 114);
            this.TextoPrecio.Name = "TextoPrecio";
            this.TextoPrecio.Size = new System.Drawing.Size(139, 13);
            this.TextoPrecio.TabIndex = 6;
            this.TextoPrecio.Text = "El precio del ejemplar es de ";
            this.TextoPrecio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TextoPrecio.Visible = false;
            this.TextoPrecio.Click += new System.EventHandler(this.TextoPrecio_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(412, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Introducir numero de ejemplar";
            // 
            // VentanaConsultarEjemplaresPublicados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 205);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextoPrecio);
            this.Controls.Add(this.errorNumEjemplar);
            this.Controls.Add(this.NumEjemplar);
            this.Controls.Add(this.MostrarEjemplar);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.tablaEjemplares);
            this.Name = "VentanaConsultarEjemplaresPublicados";
            this.Text = "VentanaConsultarEjemplaresPublicados";
            ((System.ComponentModel.ISupportInitialize)(this.tablaEjemplares)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tablaEjemplares;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button MostrarEjemplar;
        private System.Windows.Forms.TextBox NumEjemplar;
        private System.Windows.Forms.Label errorNumEjemplar;
        private System.Windows.Forms.DataGridViewTextBoxColumn titulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Autores;
        private System.Windows.Forms.Label TextoPrecio;
        private System.Windows.Forms.Label label1;
    }
}