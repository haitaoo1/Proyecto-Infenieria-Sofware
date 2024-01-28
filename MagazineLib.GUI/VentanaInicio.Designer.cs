namespace MagazineLib.GUI
{
    partial class VentanaInicio
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
            this.InicioBox = new System.Windows.Forms.Button();
            this.RegistrarBox = new System.Windows.Forms.Button();
            this.ConsultarEjemplaresPublicados = new System.Windows.Forms.Button();
            this.Exit_Click = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // InicioBox
            // 
            this.InicioBox.Location = new System.Drawing.Point(364, 95);
            this.InicioBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.InicioBox.Name = "InicioBox";
            this.InicioBox.Size = new System.Drawing.Size(151, 94);
            this.InicioBox.TabIndex = 3;
            this.InicioBox.Text = "Iniciar Sesion";
            this.InicioBox.UseVisualStyleBackColor = true;
            this.InicioBox.Click += new System.EventHandler(this.InicioBox_Click);
            // 
            // RegistrarBox
            // 
            this.RegistrarBox.Location = new System.Drawing.Point(67, 95);
            this.RegistrarBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RegistrarBox.Name = "RegistrarBox";
            this.RegistrarBox.Size = new System.Drawing.Size(151, 94);
            this.RegistrarBox.TabIndex = 4;
            this.RegistrarBox.Text = "Registrar";
            this.RegistrarBox.UseVisualStyleBackColor = true;
            this.RegistrarBox.Click += new System.EventHandler(this.RegistrarBox_Click);
            // 
            // ConsultarEjemplaresPublicados
            // 
            this.ConsultarEjemplaresPublicados.Location = new System.Drawing.Point(193, 249);
            this.ConsultarEjemplaresPublicados.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ConsultarEjemplaresPublicados.Name = "ConsultarEjemplaresPublicados";
            this.ConsultarEjemplaresPublicados.Size = new System.Drawing.Size(200, 44);
            this.ConsultarEjemplaresPublicados.TabIndex = 5;
            this.ConsultarEjemplaresPublicados.Text = "Consultar ejemplares publicados";
            this.ConsultarEjemplaresPublicados.UseVisualStyleBackColor = true;
            this.ConsultarEjemplaresPublicados.Click += new System.EventHandler(this.ConsultarEjemplaresPublicados_Click);
            // 
            // Exit_Click
            // 
            this.Exit_Click.Location = new System.Drawing.Point(490, 323);
            this.Exit_Click.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Exit_Click.Name = "Exit_Click";
            this.Exit_Click.Size = new System.Drawing.Size(88, 39);
            this.Exit_Click.TabIndex = 5;
            this.Exit_Click.Text = "Exit";
            this.Exit_Click.UseVisualStyleBackColor = true;
            this.Exit_Click.Click += new System.EventHandler(this.Exit_Click_Click);
            // 
            // VentanaInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 374);
            this.Controls.Add(this.ConsultarEjemplaresPublicados);
            this.Controls.Add(this.Exit_Click);
            this.Controls.Add(this.RegistrarBox);
            this.Controls.Add(this.InicioBox);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "VentanaInicio";
            this.Text = "VentanaInicio";
            this.Load += new System.EventHandler(this.VentanaInicio_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button InicioBox;
        private System.Windows.Forms.Button RegistrarBox;
        private System.Windows.Forms.Button ConsultarEjemplaresPublicados;
        private System.Windows.Forms.Button Exit_Click;
    }
}