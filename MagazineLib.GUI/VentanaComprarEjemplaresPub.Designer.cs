namespace MagazineLib.GUI
{
    partial class VentanaComprarEjemplaresPub
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
            this.ListaEjemplares = new System.Windows.Forms.DataGridView();
            this.Numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descuento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CestaCompra = new System.Windows.Forms.DataGridView();
            this.NumeroCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescuentoCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AñadirALaCesta = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NumEjemplar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ejemplarNoExiste = new System.Windows.Forms.Label();
            this.TextoSuma = new System.Windows.Forms.Label();
            this.TotalPrecioMuestra = new System.Windows.Forms.Label();
            this.ConfirmarCesta = new System.Windows.Forms.Button();
            this.ErrorCestaVacia = new System.Windows.Forms.Label();
            this.ReturnClick = new System.Windows.Forms.Button();
            this.cestaConfirmada = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ListaEjemplares)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CestaCompra)).BeginInit();
            this.SuspendLayout();
            // 
            // ListaEjemplares
            // 
            this.ListaEjemplares.AllowUserToDeleteRows = false;
            this.ListaEjemplares.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListaEjemplares.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Numero,
            this.Precio,
            this.Descuento});
            this.ListaEjemplares.Location = new System.Drawing.Point(21, 65);
            this.ListaEjemplares.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.ListaEjemplares.Name = "ListaEjemplares";
            this.ListaEjemplares.ReadOnly = true;
            this.ListaEjemplares.RowHeadersWidth = 51;
            this.ListaEjemplares.Size = new System.Drawing.Size(455, 340);
            this.ListaEjemplares.TabIndex = 0;
            this.ListaEjemplares.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ListaEjemplares_CellContentClick);
            // 
            // Numero
            // 
            this.Numero.HeaderText = "Numero";
            this.Numero.MinimumWidth = 6;
            this.Numero.Name = "Numero";
            this.Numero.ReadOnly = true;
            this.Numero.Width = 125;
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.MinimumWidth = 6;
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            this.Precio.Width = 125;
            // 
            // Descuento
            // 
            this.Descuento.HeaderText = "Descuento";
            this.Descuento.MinimumWidth = 6;
            this.Descuento.Name = "Descuento";
            this.Descuento.ReadOnly = true;
            this.Descuento.Width = 125;
            // 
            // CestaCompra
            // 
            this.CestaCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CestaCompra.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumeroCC,
            this.PrecioCC,
            this.DescuentoCC});
            this.CestaCompra.Location = new System.Drawing.Point(563, 65);
            this.CestaCompra.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.CestaCompra.Name = "CestaCompra";
            this.CestaCompra.ReadOnly = true;
            this.CestaCompra.RowHeadersWidth = 51;
            this.CestaCompra.Size = new System.Drawing.Size(455, 340);
            this.CestaCompra.TabIndex = 1;
            this.CestaCompra.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CestaCompra_CellContentClick);
            // 
            // NumeroCC
            // 
            this.NumeroCC.HeaderText = "Numero";
            this.NumeroCC.MinimumWidth = 6;
            this.NumeroCC.Name = "NumeroCC";
            this.NumeroCC.ReadOnly = true;
            this.NumeroCC.Width = 125;
            // 
            // PrecioCC
            // 
            this.PrecioCC.HeaderText = "Precio";
            this.PrecioCC.MinimumWidth = 6;
            this.PrecioCC.Name = "PrecioCC";
            this.PrecioCC.ReadOnly = true;
            this.PrecioCC.Width = 125;
            // 
            // DescuentoCC
            // 
            this.DescuentoCC.HeaderText = "Descuento";
            this.DescuentoCC.MinimumWidth = 6;
            this.DescuentoCC.Name = "DescuentoCC";
            this.DescuentoCC.ReadOnly = true;
            this.DescuentoCC.Width = 125;
            // 
            // AñadirALaCesta
            // 
            this.AñadirALaCesta.Location = new System.Drawing.Point(328, 461);
            this.AñadirALaCesta.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.AñadirALaCesta.Name = "AñadirALaCesta";
            this.AñadirALaCesta.Size = new System.Drawing.Size(133, 28);
            this.AñadirALaCesta.TabIndex = 2;
            this.AñadirALaCesta.Text = "Añadir a la cesta";
            this.AñadirALaCesta.UseVisualStyleBackColor = true;
            this.AñadirALaCesta.Click += new System.EventHandler(this.AñadirALaCesta_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(732, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Cesta de la compra";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(171, 33);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Lista de ejemplares";
            // 
            // NumEjemplar
            // 
            this.NumEjemplar.Location = new System.Drawing.Point(328, 421);
            this.NumEjemplar.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.NumEjemplar.Name = "NumEjemplar";
            this.NumEjemplar.Size = new System.Drawing.Size(132, 22);
            this.NumEjemplar.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(140, 425);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Numero de ejemplar a añadir:";
            // 
            // ejemplarNoExiste
            // 
            this.ejemplarNoExiste.AutoSize = true;
            this.ejemplarNoExiste.ForeColor = System.Drawing.Color.Red;
            this.ejemplarNoExiste.Location = new System.Drawing.Point(295, 494);
            this.ejemplarNoExiste.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ejemplarNoExiste.Name = "ejemplarNoExiste";
            this.ejemplarNoExiste.Size = new System.Drawing.Size(166, 16);
            this.ejemplarNoExiste.TabIndex = 8;
            this.ejemplarNoExiste.Text = "Ejemplar elegido no existe";
            this.ejemplarNoExiste.Visible = false;
            this.ejemplarNoExiste.Click += new System.EventHandler(this.ejemplarNoExiste_Click);
            // 
            // TextoSuma
            // 
            this.TextoSuma.AutoSize = true;
            this.TextoSuma.Location = new System.Drawing.Point(560, 421);
            this.TextoSuma.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TextoSuma.Name = "TextoSuma";
            this.TextoSuma.Size = new System.Drawing.Size(227, 16);
            this.TextoSuma.TabIndex = 9;
            this.TextoSuma.Text = "El total de la compra se te queda en: ";
            this.TextoSuma.Visible = false;
            // 
            // TotalPrecioMuestra
            // 
            this.TotalPrecioMuestra.AutoSize = true;
            this.TotalPrecioMuestra.Location = new System.Drawing.Point(812, 421);
            this.TotalPrecioMuestra.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TotalPrecioMuestra.Name = "TotalPrecioMuestra";
            this.TotalPrecioMuestra.Size = new System.Drawing.Size(44, 16);
            this.TotalPrecioMuestra.TabIndex = 10;
            this.TotalPrecioMuestra.Text = "label5";
            this.TotalPrecioMuestra.Visible = false;
            this.TotalPrecioMuestra.Click += new System.EventHandler(this.TotalPrecioMuestra_Click);
            // 
            // ConfirmarCesta
            // 
            this.ConfirmarCesta.Location = new System.Drawing.Point(874, 473);
            this.ConfirmarCesta.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.ConfirmarCesta.Name = "ConfirmarCesta";
            this.ConfirmarCesta.Size = new System.Drawing.Size(144, 43);
            this.ConfirmarCesta.TabIndex = 11;
            this.ConfirmarCesta.Text = "Confirmar Cesta";
            this.ConfirmarCesta.UseVisualStyleBackColor = true;
            this.ConfirmarCesta.Visible = false;
            this.ConfirmarCesta.Click += new System.EventHandler(this.ConfirmarCesta_Click);
            // 
            // ErrorCestaVacia
            // 
            this.ErrorCestaVacia.AutoSize = true;
            this.ErrorCestaVacia.ForeColor = System.Drawing.Color.Red;
            this.ErrorCestaVacia.Location = new System.Drawing.Point(892, 448);
            this.ErrorCestaVacia.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ErrorCestaVacia.Name = "ErrorCestaVacia";
            this.ErrorCestaVacia.Size = new System.Drawing.Size(123, 16);
            this.ErrorCestaVacia.TabIndex = 12;
            this.ErrorCestaVacia.Text = "La cesta está vacía";
            this.ErrorCestaVacia.Visible = false;
            // 
            // ReturnClick
            // 
            this.ReturnClick.Location = new System.Drawing.Point(16, 482);
            this.ReturnClick.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ReturnClick.Name = "ReturnClick";
            this.ReturnClick.Size = new System.Drawing.Size(88, 25);
            this.ReturnClick.TabIndex = 32;
            this.ReturnClick.Text = "Return";
            this.ReturnClick.UseVisualStyleBackColor = true;
            this.ReturnClick.Click += new System.EventHandler(this.ReturnClick_Click);
            // 
            // cestaConfirmada
            // 
            this.cestaConfirmada.AutoSize = true;
            this.cestaConfirmada.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.cestaConfirmada.Location = new System.Drawing.Point(892, 448);
            this.cestaConfirmada.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cestaConfirmada.Name = "cestaConfirmada";
            this.cestaConfirmada.Size = new System.Drawing.Size(115, 16);
            this.cestaConfirmada.TabIndex = 33;
            this.cestaConfirmada.Text = "Cesta confirmada!";
            this.cestaConfirmada.Visible = false;
            // 
            // VentanaComprarEjemplaresPub
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 525);
            this.Controls.Add(this.cestaConfirmada);
            this.Controls.Add(this.ReturnClick);
            this.Controls.Add(this.ErrorCestaVacia);
            this.Controls.Add(this.ConfirmarCesta);
            this.Controls.Add(this.TotalPrecioMuestra);
            this.Controls.Add(this.TextoSuma);
            this.Controls.Add(this.ejemplarNoExiste);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NumEjemplar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AñadirALaCesta);
            this.Controls.Add(this.CestaCompra);
            this.Controls.Add(this.ListaEjemplares);
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "VentanaComprarEjemplaresPub";
            this.Text = "VentanaComprarEjemplaresPub";
            ((System.ComponentModel.ISupportInitialize)(this.ListaEjemplares)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CestaCompra)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ListaEjemplares;
        private System.Windows.Forms.DataGridView CestaCompra;
        private System.Windows.Forms.Button AñadirALaCesta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descuento;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescuentoCC;
        private System.Windows.Forms.TextBox NumEjemplar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label ejemplarNoExiste;
        private System.Windows.Forms.Label TextoSuma;
        private System.Windows.Forms.Label TotalPrecioMuestra;
        private System.Windows.Forms.Button ConfirmarCesta;
        private System.Windows.Forms.Label ErrorCestaVacia;
        private System.Windows.Forms.Button ReturnClick;
        private System.Windows.Forms.Label cestaConfirmada;
    }
}