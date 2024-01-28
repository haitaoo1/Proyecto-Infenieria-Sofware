namespace MagazineLib.GUI
{
    partial class VentanaHome
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
            this.EnviarArticuloBox = new System.Windows.Forms.Button();
            this.EvaluarArticuloBox = new System.Windows.Forms.Button();
            this.ConfeccionarEjemplarBox = new System.Windows.Forms.Button();
            this.ListadoArticulosBox = new System.Windows.Forms.Button();
            this.ExitBox = new System.Windows.Forms.Button();
            this.ComprarEjemplar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EnviarArticuloBox
            // 
            this.EnviarArticuloBox.Location = new System.Drawing.Point(11, 91);
            this.EnviarArticuloBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.EnviarArticuloBox.Name = "EnviarArticuloBox";
            this.EnviarArticuloBox.Size = new System.Drawing.Size(134, 61);
            this.EnviarArticuloBox.TabIndex = 0;
            this.EnviarArticuloBox.Text = "Enviar Articulo";
            this.EnviarArticuloBox.UseVisualStyleBackColor = true;
            this.EnviarArticuloBox.Visible = false;
            this.EnviarArticuloBox.Click += new System.EventHandler(this.EnviarArticuloBox_Click);
            // 
            // EvaluarArticuloBox
            // 
            this.EvaluarArticuloBox.Location = new System.Drawing.Point(11, 171);
            this.EvaluarArticuloBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.EvaluarArticuloBox.Name = "EvaluarArticuloBox";
            this.EvaluarArticuloBox.Size = new System.Drawing.Size(134, 61);
            this.EvaluarArticuloBox.TabIndex = 1;
            this.EvaluarArticuloBox.Text = "Evaluar Articulo";
            this.EvaluarArticuloBox.UseVisualStyleBackColor = true;
            this.EvaluarArticuloBox.Visible = false;
            this.EvaluarArticuloBox.Click += new System.EventHandler(this.EvaluarArticuloBox_Click);
            // 
            // ConfeccionarEjemplarBox
            // 
            this.ConfeccionarEjemplarBox.Location = new System.Drawing.Point(11, 249);
            this.ConfeccionarEjemplarBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ConfeccionarEjemplarBox.Name = "ConfeccionarEjemplarBox";
            this.ConfeccionarEjemplarBox.Size = new System.Drawing.Size(134, 61);
            this.ConfeccionarEjemplarBox.TabIndex = 2;
            this.ConfeccionarEjemplarBox.Text = "ConfeccionarEjemplar";
            this.ConfeccionarEjemplarBox.UseVisualStyleBackColor = true;
            this.ConfeccionarEjemplarBox.Visible = false;
            this.ConfeccionarEjemplarBox.Click += new System.EventHandler(this.ConfeccionarEjemplarBox_Click);
            // 
            // ListadoArticulosBox
            // 
            this.ListadoArticulosBox.Location = new System.Drawing.Point(11, 11);
            this.ListadoArticulosBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ListadoArticulosBox.Name = "ListadoArticulosBox";
            this.ListadoArticulosBox.Size = new System.Drawing.Size(134, 61);
            this.ListadoArticulosBox.TabIndex = 3;
            this.ListadoArticulosBox.Text = "Listado Articulos";
            this.ListadoArticulosBox.UseVisualStyleBackColor = true;
            this.ListadoArticulosBox.Visible = false;
            this.ListadoArticulosBox.Click += new System.EventHandler(this.ListadoArticulosBox_Click);
            // 
            // ExitBox
            // 
            this.ExitBox.Location = new System.Drawing.Point(228, 403);
            this.ExitBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ExitBox.Name = "ExitBox";
            this.ExitBox.Size = new System.Drawing.Size(71, 21);
            this.ExitBox.TabIndex = 4;
            this.ExitBox.Text = "Exit";
            this.ExitBox.UseVisualStyleBackColor = true;
            this.ExitBox.Click += new System.EventHandler(this.ExitBox_Click);
            // 
            // ComprarEjemplar
            // 
            this.ComprarEjemplar.Location = new System.Drawing.Point(12, 328);
            this.ComprarEjemplar.Name = "ComprarEjemplar";
            this.ComprarEjemplar.Size = new System.Drawing.Size(134, 61);
            this.ComprarEjemplar.TabIndex = 5;
            this.ComprarEjemplar.Text = "Comprar Ejemplar";
            this.ComprarEjemplar.UseVisualStyleBackColor = true;
            this.ComprarEjemplar.Click += new System.EventHandler(this.ComprarEjemplar_Click);
            // 
            // VentanaHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 435);
            this.Controls.Add(this.ComprarEjemplar);
            this.Controls.Add(this.ExitBox);
            this.Controls.Add(this.ListadoArticulosBox);
            this.Controls.Add(this.ConfeccionarEjemplarBox);
            this.Controls.Add(this.EvaluarArticuloBox);
            this.Controls.Add(this.EnviarArticuloBox);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "VentanaHome";
            this.Text = "VentanaHome";
            this.Load += new System.EventHandler(this.VentanaHome_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button EnviarArticuloBox;
        private System.Windows.Forms.Button EvaluarArticuloBox;
        private System.Windows.Forms.Button ConfeccionarEjemplarBox;
        private System.Windows.Forms.Button ListadoArticulosBox;
        private System.Windows.Forms.Button ExitBox;
        private System.Windows.Forms.Button ComprarEjemplar;
    }
}