namespace MagazineLib.GUI
{
    partial class ConfeccionarEjemplar
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
            this.MostrarB = new System.Windows.Forms.Button();
            this.AreaIntro = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Area = new System.Windows.Forms.Label();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.MoverPendEv = new System.Windows.Forms.Button();
            this.MoverPendPub = new System.Windows.Forms.Button();
            this.Calendario = new System.Windows.Forms.MonthCalendar();
            this.ArticuloPub = new System.Windows.Forms.Label();
            this.AddPrecioTxt = new System.Windows.Forms.TextBox();
            this.AddDescTxt = new System.Windows.Forms.TextBox();
            this.PrecioNoIntr = new System.Windows.Forms.Label();
            this.PublicarPrecio = new System.Windows.Forms.Button();
            this.ReturnClick = new System.Windows.Forms.Button();
            this.BotonReiniciar = new System.Windows.Forms.Button();
            this.AreaNoexiste = new System.Windows.Forms.Label();
            this.numIssue = new System.Windows.Forms.TextBox();
            this.Precio = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.errorNumIssue = new System.Windows.Forms.Label();
            this.errorPendPubli = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // MostrarB
            // 
            this.MostrarB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MostrarB.Location = new System.Drawing.Point(257, 26);
            this.MostrarB.Name = "MostrarB";
            this.MostrarB.Size = new System.Drawing.Size(112, 36);
            this.MostrarB.TabIndex = 0;
            this.MostrarB.Text = "Mostrar ";
            this.MostrarB.UseVisualStyleBackColor = true;
            this.MostrarB.Click += new System.EventHandler(this.MostrarB_Click);
            // 
            // AreaIntro
            // 
            this.AreaIntro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AreaIntro.Location = new System.Drawing.Point(82, 30);
            this.AreaIntro.Name = "AreaIntro";
            this.AreaIntro.Size = new System.Drawing.Size(157, 28);
            this.AreaIntro.TabIndex = 2;
            this.AreaIntro.TextChanged += new System.EventHandler(this.AreaIntro_TextChanged);
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(14, 127);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(215, 244);
            this.listBox1.TabIndex = 3;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(248, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "Articulos Pendiente a publicar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(280, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(244, 22);
            this.label3.TabIndex = 7;
            this.label3.Text = "Articulos Pendiente a evaluar";
            // 
            // Area
            // 
            this.Area.AutoSize = true;
            this.Area.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Area.Location = new System.Drawing.Point(12, 30);
            this.Area.Name = "Area";
            this.Area.Size = new System.Drawing.Size(54, 25);
            this.Area.TabIndex = 9;
            this.Area.Text = "Area";
            // 
            // listBox2
            // 
            this.listBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 20;
            this.listBox2.Location = new System.Drawing.Point(284, 127);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(209, 244);
            this.listBox2.TabIndex = 10;
            // 
            // MoverPendEv
            // 
            this.MoverPendEv.Location = new System.Drawing.Point(14, 379);
            this.MoverPendEv.Name = "MoverPendEv";
            this.MoverPendEv.Size = new System.Drawing.Size(215, 39);
            this.MoverPendEv.TabIndex = 11;
            this.MoverPendEv.Text = "Mover a Pendiente Evaluar";
            this.MoverPendEv.UseVisualStyleBackColor = true;
            this.MoverPendEv.Click += new System.EventHandler(this.MoverPendEv_Click);
            // 
            // MoverPendPub
            // 
            this.MoverPendPub.Location = new System.Drawing.Point(284, 379);
            this.MoverPendPub.Name = "MoverPendPub";
            this.MoverPendPub.Size = new System.Drawing.Size(209, 39);
            this.MoverPendPub.TabIndex = 12;
            this.MoverPendPub.Text = "Mover a Pendiente Publicar";
            this.MoverPendPub.UseVisualStyleBackColor = true;
            this.MoverPendPub.Click += new System.EventHandler(this.MoverPendPub_Click);
            // 
            // Calendario
            // 
            this.Calendario.Location = new System.Drawing.Point(551, 63);
            this.Calendario.Name = "Calendario";
            this.Calendario.TabIndex = 13;
            this.Calendario.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.Calendario_DateChanged);
            // 
            // ArticuloPub
            // 
            this.ArticuloPub.AutoSize = true;
            this.ArticuloPub.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ArticuloPub.ForeColor = System.Drawing.Color.Blue;
            this.ArticuloPub.Location = new System.Drawing.Point(702, 425);
            this.ArticuloPub.Name = "ArticuloPub";
            this.ArticuloPub.Size = new System.Drawing.Size(124, 18);
            this.ArticuloPub.TabIndex = 15;
            this.ArticuloPub.Text = "Articulo publicado";
            this.ArticuloPub.Visible = false;
            // 
            // AddPrecioTxt
            // 
            this.AddPrecioTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddPrecioTxt.Location = new System.Drawing.Point(520, 330);
            this.AddPrecioTxt.Name = "AddPrecioTxt";
            this.AddPrecioTxt.Size = new System.Drawing.Size(113, 27);
            this.AddPrecioTxt.TabIndex = 23;
            this.AddPrecioTxt.Text = "0.0";
            this.AddPrecioTxt.TextChanged += new System.EventHandler(this.AddPrecioTxt_TextChanged);
            // 
            // AddDescTxt
            // 
            this.AddDescTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddDescTxt.Location = new System.Drawing.Point(658, 330);
            this.AddDescTxt.Name = "AddDescTxt";
            this.AddDescTxt.Size = new System.Drawing.Size(113, 27);
            this.AddDescTxt.TabIndex = 24;
            this.AddDescTxt.Text = "0.0";
            this.AddDescTxt.TextChanged += new System.EventHandler(this.AddDescTxt_TextChanged);
            // 
            // PrecioNoIntr
            // 
            this.PrecioNoIntr.AutoSize = true;
            this.PrecioNoIntr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.PrecioNoIntr.Location = new System.Drawing.Point(517, 407);
            this.PrecioNoIntr.Name = "PrecioNoIntr";
            this.PrecioNoIntr.Size = new System.Drawing.Size(304, 16);
            this.PrecioNoIntr.TabIndex = 27;
            this.PrecioNoIntr.Text = "Porfavor introduzca un precio y deceuento validos";
            this.PrecioNoIntr.Visible = false;
            this.PrecioNoIntr.Click += new System.EventHandler(this.PrecioNoIntr_Click);
            // 
            // PublicarPrecio
            // 
            this.PublicarPrecio.Enabled = false;
            this.PublicarPrecio.Location = new System.Drawing.Point(658, 363);
            this.PublicarPrecio.Name = "PublicarPrecio";
            this.PublicarPrecio.Size = new System.Drawing.Size(163, 41);
            this.PublicarPrecio.TabIndex = 26;
            this.PublicarPrecio.Text = "Publicar Articulo";
            this.PublicarPrecio.UseVisualStyleBackColor = true;
            this.PublicarPrecio.Click += new System.EventHandler(this.PublicarPrecio_Click);
            // 
            // ReturnClick
            // 
            this.ReturnClick.Location = new System.Drawing.Point(744, 456);
            this.ReturnClick.Name = "ReturnClick";
            this.ReturnClick.Size = new System.Drawing.Size(82, 25);
            this.ReturnClick.TabIndex = 33;
            this.ReturnClick.Text = "Return";
            this.ReturnClick.UseVisualStyleBackColor = true;
            this.ReturnClick.Click += new System.EventHandler(this.ReturnClick_Click);
            // 
            // BotonReiniciar
            // 
            this.BotonReiniciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonReiniciar.Location = new System.Drawing.Point(394, 26);
            this.BotonReiniciar.Name = "BotonReiniciar";
            this.BotonReiniciar.Size = new System.Drawing.Size(99, 36);
            this.BotonReiniciar.TabIndex = 34;
            this.BotonReiniciar.Text = "Reiniciar";
            this.BotonReiniciar.UseVisualStyleBackColor = true;
            this.BotonReiniciar.Click += new System.EventHandler(this.BotonReiniciar_Click);
            // 
            // AreaNoexiste
            // 
            this.AreaNoexiste.AutoSize = true;
            this.AreaNoexiste.ForeColor = System.Drawing.Color.Red;
            this.AreaNoexiste.Location = new System.Drawing.Point(79, 63);
            this.AreaNoexiste.Name = "AreaNoexiste";
            this.AreaNoexiste.Size = new System.Drawing.Size(161, 16);
            this.AreaNoexiste.TabIndex = 35;
            this.AreaNoexiste.Text = "Area Introducida no existe";
            this.AreaNoexiste.Visible = false;
            this.AreaNoexiste.Click += new System.EventHandler(this.AreaNoexiste_Click);
            // 
            // numIssue
            // 
            this.numIssue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numIssue.Location = new System.Drawing.Point(520, 377);
            this.numIssue.Name = "numIssue";
            this.numIssue.Size = new System.Drawing.Size(100, 27);
            this.numIssue.TabIndex = 36;
            this.numIssue.Text = "Nº Issue";
            this.numIssue.TextChanged += new System.EventHandler(this.numIssue_TextChanged);
            // 
            // Precio
            // 
            this.Precio.AutoSize = true;
            this.Precio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Precio.Location = new System.Drawing.Point(516, 304);
            this.Precio.Name = "Precio";
            this.Precio.Size = new System.Drawing.Size(57, 20);
            this.Precio.TabIndex = 37;
            this.Precio.Text = "Precio";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(654, 304);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 20);
            this.label4.TabIndex = 38;
            this.label4.Text = "Descuento";
            // 
            // errorNumIssue
            // 
            this.errorNumIssue.AutoSize = true;
            this.errorNumIssue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.errorNumIssue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.errorNumIssue.Location = new System.Drawing.Point(517, 407);
            this.errorNumIssue.Name = "errorNumIssue";
            this.errorNumIssue.Size = new System.Drawing.Size(235, 16);
            this.errorNumIssue.TabIndex = 39;
            this.errorNumIssue.Text = "Porfavor introduca un numero de issue";
            this.errorNumIssue.Visible = false;
            this.errorNumIssue.Click += new System.EventHandler(this.errorNumIssue_Click);
            // 
            // errorPendPubli
            // 
            this.errorPendPubli.AutoSize = true;
            this.errorPendPubli.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.errorPendPubli.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.errorPendPubli.Location = new System.Drawing.Point(400, 427);
            this.errorPendPubli.Name = "errorPendPubli";
            this.errorPendPubli.Size = new System.Drawing.Size(352, 16);
            this.errorPendPubli.TabIndex = 40;
            this.errorPendPubli.Text = "Compruebe que ha seleccionado un articulo para publicar";
            this.errorPendPubli.Visible = false;
            this.errorPendPubli.Click += new System.EventHandler(this.errorPendPubli_Click);
            // 
            // ConfeccionarEjemplar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 516);
            this.Controls.Add(this.errorPendPubli);
            this.Controls.Add(this.errorNumIssue);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Precio);
            this.Controls.Add(this.numIssue);
            this.Controls.Add(this.AreaNoexiste);
            this.Controls.Add(this.BotonReiniciar);
            this.Controls.Add(this.PrecioNoIntr);
            this.Controls.Add(this.PublicarPrecio);
            this.Controls.Add(this.AddDescTxt);
            this.Controls.Add(this.AddPrecioTxt);
            this.Controls.Add(this.ReturnClick);
            this.Controls.Add(this.ArticuloPub);
            this.Controls.Add(this.Calendario);
            this.Controls.Add(this.MoverPendPub);
            this.Controls.Add(this.MoverPendEv);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.Area);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.AreaIntro);
            this.Controls.Add(this.MostrarB);
            this.Name = "ConfeccionarEjemplar";
            this.Text = "ConfeccionarEjemplar";
            this.Load += new System.EventHandler(this.ConfeccionarEjemplar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button MostrarB;
        private System.Windows.Forms.TextBox AreaIntro;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Area;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button MoverPendEv;
        private System.Windows.Forms.Button MoverPendPub;
        private System.Windows.Forms.MonthCalendar Calendario;
        private System.Windows.Forms.Label ArticuloPub;
        private System.Windows.Forms.TextBox AddPrecioTxt;
        private System.Windows.Forms.TextBox AddDescTxt;
        private System.Windows.Forms.Label PrecioNoIntr;
        private System.Windows.Forms.Button PublicarPrecio;
        private System.Windows.Forms.Button ReturnClick;
        private System.Windows.Forms.Button BotonReiniciar;
        private System.Windows.Forms.Label AreaNoexiste;
        private System.Windows.Forms.TextBox numIssue;
        private System.Windows.Forms.Label Precio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label errorNumIssue;
        private System.Windows.Forms.Label errorPendPubli;
    }
}