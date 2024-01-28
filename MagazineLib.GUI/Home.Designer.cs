namespace MagazineLib.GUI
{
    partial class Home
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
            this.EnviarArticulo = new System.Windows.Forms.Button();
            this.EvaluarArticulo = new System.Windows.Forms.Button();
            this.ConfeccionarEjemplar = new System.Windows.Forms.Button();
            this.ListadoArticulos = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EnviarArticulo
            // 
            this.EnviarArticulo.Location = new System.Drawing.Point(127, 106);
            this.EnviarArticulo.Name = "EnviarArticulo";
            this.EnviarArticulo.Size = new System.Drawing.Size(155, 64);
            this.EnviarArticulo.TabIndex = 0;
            this.EnviarArticulo.Text = "Enviar Artículo";
            this.EnviarArticulo.UseVisualStyleBackColor = true;
            this.EnviarArticulo.Click += new System.EventHandler(this.EnviarArticulo_Click);
            // 
            // EvaluarArticulo
            // 
            this.EvaluarArticulo.Location = new System.Drawing.Point(475, 106);
            this.EvaluarArticulo.Name = "EvaluarArticulo";
            this.EvaluarArticulo.Size = new System.Drawing.Size(155, 64);
            this.EvaluarArticulo.TabIndex = 1;
            this.EvaluarArticulo.Text = "Evaluar Artículo";
            this.EvaluarArticulo.UseVisualStyleBackColor = true;
            this.EvaluarArticulo.Click += new System.EventHandler(this.EvaluarArticulo_Click);
            // 
            // ConfeccionarEjemplar
            // 
            this.ConfeccionarEjemplar.Location = new System.Drawing.Point(127, 263);
            this.ConfeccionarEjemplar.Name = "ConfeccionarEjemplar";
            this.ConfeccionarEjemplar.Size = new System.Drawing.Size(155, 64);
            this.ConfeccionarEjemplar.TabIndex = 2;
            this.ConfeccionarEjemplar.Text = "Confeccionar Ejemplar";
            this.ConfeccionarEjemplar.UseVisualStyleBackColor = true;
            this.ConfeccionarEjemplar.Click += new System.EventHandler(this.ConfeccionarEjemplar_Click);
            // 
            // ListadoArticulos
            // 
            this.ListadoArticulos.Location = new System.Drawing.Point(475, 263);
            this.ListadoArticulos.Name = "ListadoArticulos";
            this.ListadoArticulos.Size = new System.Drawing.Size(155, 64);
            this.ListadoArticulos.TabIndex = 3;
            this.ListadoArticulos.Text = "Listado Artículos";
            this.ListadoArticulos.UseVisualStyleBackColor = true;
            this.ListadoArticulos.Click += new System.EventHandler(this.ListadoArticulos_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(682, 404);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(96, 34);
            this.button5.TabIndex = 4;
            this.button5.Text = "Exit";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.exit_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.ListadoArticulos);
            this.Controls.Add(this.ConfeccionarEjemplar);
            this.Controls.Add(this.EvaluarArticulo);
            this.Controls.Add(this.EnviarArticulo);
            this.Name = "Home";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button EnviarArticulo;
        private System.Windows.Forms.Button EvaluarArticulo;
        private System.Windows.Forms.Button ConfeccionarEjemplar;
        private System.Windows.Forms.Button ListadoArticulos;
        private System.Windows.Forms.Button button5;
    }
}