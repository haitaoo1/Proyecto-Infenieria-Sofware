namespace MagazineLib.GUI
{
    partial class VentanaInicioSesion
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
            this.BotonInicio = new System.Windows.Forms.Button();
            this.BotonRegistrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.UserBox = new System.Windows.Forms.TextBox();
            this.PasswordBox = new System.Windows.Forms.TextBox();
            this.UsuarioNoExisteText = new System.Windows.Forms.Label();
            this.home = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BotonInicio
            // 
            this.BotonInicio.Location = new System.Drawing.Point(592, 284);
            this.BotonInicio.Name = "BotonInicio";
            this.BotonInicio.Size = new System.Drawing.Size(155, 54);
            this.BotonInicio.TabIndex = 0;
            this.BotonInicio.Text = "Iniciar Sesion";
            this.BotonInicio.UseVisualStyleBackColor = true;
            this.BotonInicio.Click += new System.EventHandler(this.BotonInicio_Click);
            // 
            // BotonRegistrar
            // 
            this.BotonRegistrar.Location = new System.Drawing.Point(167, 284);
            this.BotonRegistrar.Name = "BotonRegistrar";
            this.BotonRegistrar.Size = new System.Drawing.Size(118, 55);
            this.BotonRegistrar.TabIndex = 1;
            this.BotonRegistrar.Text = "Registrarse";
            this.BotonRegistrar.UseVisualStyleBackColor = true;
            this.BotonRegistrar.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(112, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Usuario";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(111, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Contraseña";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // UserBox
            // 
            this.UserBox.Location = new System.Drawing.Point(294, 73);
            this.UserBox.Name = "UserBox";
            this.UserBox.Size = new System.Drawing.Size(100, 22);
            this.UserBox.TabIndex = 4;
            this.UserBox.TextChanged += new System.EventHandler(this.UserBox_TextChanged);
            // 
            // PasswordBox
            // 
            this.PasswordBox.Location = new System.Drawing.Point(308, 186);
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.Size = new System.Drawing.Size(100, 22);
            this.PasswordBox.TabIndex = 5;
            this.PasswordBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // UsuarioNoExisteText
            // 
            this.UsuarioNoExisteText.AutoSize = true;
            this.UsuarioNoExisteText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.UsuarioNoExisteText.Location = new System.Drawing.Point(601, 264);
            this.UsuarioNoExisteText.Name = "UsuarioNoExisteText";
            this.UsuarioNoExisteText.Size = new System.Drawing.Size(122, 16);
            this.UsuarioNoExisteText.TabIndex = 6;
            this.UsuarioNoExisteText.Text = "El usuario no existe";
            this.UsuarioNoExisteText.Visible = false;
            this.UsuarioNoExisteText.Click += new System.EventHandler(this.UsuarioNoExisteText_Click);
            // 
            // home
            // 
            this.home.Location = new System.Drawing.Point(655, 369);
            this.home.Name = "home";
            this.home.Size = new System.Drawing.Size(97, 27);
            this.home.TabIndex = 8;
            this.home.Text = "Home";
            this.home.UseVisualStyleBackColor = true;
            this.home.Click += new System.EventHandler(this.home_Click);
            // 
            // VentanaInicioSesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 408);
            this.Controls.Add(this.home);
            this.Controls.Add(this.UsuarioNoExisteText);
            this.Controls.Add(this.PasswordBox);
            this.Controls.Add(this.UserBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BotonRegistrar);
            this.Controls.Add(this.BotonInicio);
            this.Name = "VentanaInicioSesion";
            this.Text = "VentanaInicioSesion";
            this.Load += new System.EventHandler(this.VentanaInicioSesion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BotonInicio;
        private System.Windows.Forms.Button BotonRegistrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox UserBox;
        private System.Windows.Forms.TextBox PasswordBox;
        private System.Windows.Forms.Label UsuarioNoExisteText;
        private System.Windows.Forms.Button home;
    }
}