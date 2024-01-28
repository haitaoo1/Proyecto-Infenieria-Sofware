namespace MagazineLib.GUI
{
    partial class Form1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Titulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Autor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.resultadoEvaluarArticuloBox = new System.Windows.Forms.TextBox();
            this.comentariosBox = new System.Windows.Forms.TextBox();
            this.aceptarBoton = new System.Windows.Forms.Button();
            this.errorSeleccion = new System.Windows.Forms.Label();
            this.evaluacionCorrecta = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.ReturnHome = new System.Windows.Forms.Button();
            this.TrueFalse = new System.Windows.Forms.Label();
            this.FormatoTF = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Titulo,
            this.Autor,
            this.Date});
            this.dataGridView1.Location = new System.Drawing.Point(74, 88);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(555, 150);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.Width = 125;
            // 
            // Titulo
            // 
            this.Titulo.HeaderText = "Titulo";
            this.Titulo.MinimumWidth = 6;
            this.Titulo.Name = "Titulo";
            this.Titulo.Width = 125;
            // 
            // Autor
            // 
            this.Autor.HeaderText = "Autor";
            this.Autor.MinimumWidth = 6;
            this.Autor.Name = "Autor";
            this.Autor.Width = 125;
            // 
            // Date
            // 
            this.Date.HeaderText = "Fecha envio";
            this.Date.MinimumWidth = 6;
            this.Date.Name = "Date";
            this.Date.Width = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Articulos Pendientes de Evaluar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 262);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Resultados";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(76, 298);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Comentarios";
            // 
            // resultadoEvaluarArticuloBox
            // 
            this.resultadoEvaluarArticuloBox.Location = new System.Drawing.Point(212, 262);
            this.resultadoEvaluarArticuloBox.Name = "resultadoEvaluarArticuloBox";
            this.resultadoEvaluarArticuloBox.Size = new System.Drawing.Size(100, 22);
            this.resultadoEvaluarArticuloBox.TabIndex = 4;
            this.resultadoEvaluarArticuloBox.TextChanged += new System.EventHandler(this.resultadoEvaluarArticuloBox_TextChanged);
            // 
            // comentariosBox
            // 
            this.comentariosBox.Location = new System.Drawing.Point(212, 298);
            this.comentariosBox.Name = "comentariosBox";
            this.comentariosBox.Size = new System.Drawing.Size(100, 22);
            this.comentariosBox.TabIndex = 5;
            // 
            // aceptarBoton
            // 
            this.aceptarBoton.Location = new System.Drawing.Point(363, 382);
            this.aceptarBoton.Name = "aceptarBoton";
            this.aceptarBoton.Size = new System.Drawing.Size(92, 28);
            this.aceptarBoton.TabIndex = 6;
            this.aceptarBoton.Text = "Aceptar";
            this.aceptarBoton.UseVisualStyleBackColor = true;
            this.aceptarBoton.Click += new System.EventHandler(this.aceptarBoton_Click);
            // 
            // errorSeleccion
            // 
            this.errorSeleccion.AutoSize = true;
            this.errorSeleccion.ForeColor = System.Drawing.Color.Red;
            this.errorSeleccion.Location = new System.Drawing.Point(489, 241);
            this.errorSeleccion.Name = "errorSeleccion";
            this.errorSeleccion.Size = new System.Drawing.Size(129, 16);
            this.errorSeleccion.TabIndex = 8;
            this.errorSeleccion.Text = "Error en la seleccion";
            this.errorSeleccion.Visible = false;
            // 
            // evaluacionCorrecta
            // 
            this.evaluacionCorrecta.AutoSize = true;
            this.evaluacionCorrecta.ForeColor = System.Drawing.Color.Green;
            this.evaluacionCorrecta.Location = new System.Drawing.Point(114, 382);
            this.evaluacionCorrecta.Name = "evaluacionCorrecta";
            this.evaluacionCorrecta.Size = new System.Drawing.Size(139, 16);
            this.evaluacionCorrecta.TabIndex = 9;
            this.evaluacionCorrecta.Text = "Evaluacion Realizada";
            this.evaluacionCorrecta.Visible = false;
            this.evaluacionCorrecta.Click += new System.EventHandler(this.evaluacionCorrecta_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(76, 328);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "Fecha";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(212, 328);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 14;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // ReturnHome
            // 
            this.ReturnHome.Location = new System.Drawing.Point(588, 382);
            this.ReturnHome.Margin = new System.Windows.Forms.Padding(4);
            this.ReturnHome.Name = "ReturnHome";
            this.ReturnHome.Size = new System.Drawing.Size(100, 28);
            this.ReturnHome.TabIndex = 15;
            this.ReturnHome.Text = "Return";
            this.ReturnHome.UseVisualStyleBackColor = true;
            this.ReturnHome.Click += new System.EventHandler(this.ReturnHome_Click);
            // 
            // TrueFalse
            // 
            this.TrueFalse.AutoSize = true;
            this.TrueFalse.Location = new System.Drawing.Point(332, 268);
            this.TrueFalse.Name = "TrueFalse";
            this.TrueFalse.Size = new System.Drawing.Size(80, 16);
            this.TrueFalse.TabIndex = 16;
            this.TrueFalse.Text = "(True,False)";
            // 
            // FormatoTF
            // 
            this.FormatoTF.AutoSize = true;
            this.FormatoTF.ForeColor = System.Drawing.Color.Red;
            this.FormatoTF.Location = new System.Drawing.Point(418, 268);
            this.FormatoTF.Name = "FormatoTF";
            this.FormatoTF.Size = new System.Drawing.Size(119, 16);
            this.FormatoTF.TabIndex = 17;
            this.FormatoTF.Text = "Formato Incorrecto";
            this.FormatoTF.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 427);
            this.Controls.Add(this.FormatoTF);
            this.Controls.Add(this.TrueFalse);
            this.Controls.Add(this.ReturnHome);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.evaluacionCorrecta);
            this.Controls.Add(this.errorSeleccion);
            this.Controls.Add(this.aceptarBoton);
            this.Controls.Add(this.comentariosBox);
            this.Controls.Add(this.resultadoEvaluarArticuloBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Evaluar Articulo";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Titulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Autor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox resultadoEvaluarArticuloBox;
        private System.Windows.Forms.TextBox comentariosBox;
        private System.Windows.Forms.Button aceptarBoton;
        private System.Windows.Forms.Label errorSeleccion;
        private System.Windows.Forms.Label evaluacionCorrecta;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button ReturnHome;
        private System.Windows.Forms.Label TrueFalse;
        private System.Windows.Forms.Label FormatoTF;
    }
}