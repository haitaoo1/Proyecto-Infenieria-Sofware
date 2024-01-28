namespace MagazineLib.GUI
{
    partial class VentanaListadoArticulos
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
            this.components = new System.ComponentModel.Container();
            this.MostrarListado = new System.Windows.Forms.Button();
            this.papersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.magazineDBDataSet = new MagazineLib.GUI.MagazineDBDataSet();
            this.papersTableAdapter = new MagazineLib.GUI.MagazineDBDataSetTableAdapters.PapersTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.tablaInfo = new System.Windows.Forms.DataGridView();
            this.titulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreAutores = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.magazineDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.papersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.NombreDelArticulo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tituloErroneoMsg = new System.Windows.Forms.Label();
            this.ReturnClick = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.papersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.magazineDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.magazineDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.papersBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // MostrarListado
            // 
            this.MostrarListado.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.MostrarListado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MostrarListado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.MostrarListado.Location = new System.Drawing.Point(412, 297);
            this.MostrarListado.Name = "MostrarListado";
            this.MostrarListado.Size = new System.Drawing.Size(133, 46);
            this.MostrarListado.TabIndex = 3;
            this.MostrarListado.Text = "Mostrar Info";
            this.MostrarListado.UseVisualStyleBackColor = false;
            this.MostrarListado.Click += new System.EventHandler(this.MostrarListado_Click);
            // 
            // papersBindingSource
            // 
            this.papersBindingSource.DataMember = "Papers";
            this.papersBindingSource.DataSource = this.magazineDBDataSet;
            // 
            // magazineDBDataSet
            // 
            this.magazineDBDataSet.DataSetName = "MagazineDBDataSet";
            this.magazineDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // papersTableAdapter
            // 
            this.papersTableAdapter.ClearBeforeFill = true;
            // 
            // SeleccionarNumArtComboBox
            // 
            //this.SeleccionarNumArtComboBox.DataSource = this.papersBindingSource;
            //this.SeleccionarNumArtComboBox.FormattingEnabled = true;
            //this.SeleccionarNumArtComboBox.Location = new System.Drawing.Point(225, 366);
            //this.SeleccionarNumArtComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            //this.SeleccionarNumArtComboBox.Name = "SeleccionarNumArtComboBox";
            //this.SeleccionarNumArtComboBox.Size = new System.Drawing.Size(173, 24);
            //this.SeleccionarNumArtComboBox.TabIndex = 7;
            //this.SeleccionarNumArtComboBox.Visible = false;
            //this.SeleccionarNumArtComboBox.SelectedIndexChanged += new System.EventHandler(this.SeleccionarNumArtComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 300);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Artículos a mostrar";
            // 
            // tablaInfo
            // 
            this.tablaInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.titulo,
            this.nombreAutores,
            this.estado});
            this.tablaInfo.Location = new System.Drawing.Point(52, 25);
            this.tablaInfo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tablaInfo.Name = "tablaInfo";
            this.tablaInfo.RowHeadersWidth = 82;
            this.tablaInfo.RowTemplate.Height = 33;
            this.tablaInfo.Size = new System.Drawing.Size(493, 255);
            this.tablaInfo.TabIndex = 10;
            this.tablaInfo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablaInfoDataGridView1_CellContentClick);
            // 
            // titulo
            // 
            this.titulo.HeaderText = "Titulo";
            this.titulo.MinimumWidth = 10;
            this.titulo.Name = "titulo";
            // 
            // nombreAutores
            // 
            this.nombreAutores.HeaderText = "Nombre de los Autores";
            this.nombreAutores.MinimumWidth = 10;
            this.nombreAutores.Name = "nombreAutores";
            this.nombreAutores.Width = 200;
            // 
            // estado
            // 
            this.estado.HeaderText = "Estado";
            this.estado.MinimumWidth = 10;
            this.estado.Name = "estado";
            this.estado.Width = 150;
            // 
            // magazineDBDataSetBindingSource
            // 
            this.magazineDBDataSetBindingSource.DataSource = this.magazineDBDataSet;
            this.magazineDBDataSetBindingSource.Position = 0;
            // 
            // papersBindingSource1
            // 
            this.papersBindingSource1.DataMember = "Papers";
            this.papersBindingSource1.DataSource = this.magazineDBDataSet;
            // 
            // NombreDelArticulo
            // 
            this.NombreDelArticulo.Location = new System.Drawing.Point(149, 293);
            this.NombreDelArticulo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.NombreDelArticulo.Name = "NombreDelArticulo";
            this.NombreDelArticulo.Size = new System.Drawing.Size(76, 20);
            this.NombreDelArticulo.TabIndex = 11;
            this.NombreDelArticulo.Text = "pej: Prueba1";
            this.NombreDelArticulo.TextChanged += new System.EventHandler(this.NombreDelArticulo_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(49, 330);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(310, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Para conseguir la info de todos los artículos introducir \"TODOS\"";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // tituloErroneoMsg
            // 
            this.tituloErroneoMsg.AutoSize = true;
            this.tituloErroneoMsg.ForeColor = System.Drawing.Color.Red;
            this.tituloErroneoMsg.Location = new System.Drawing.Point(49, 317);
            this.tituloErroneoMsg.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.tituloErroneoMsg.Name = "tituloErroneoMsg";
            this.tituloErroneoMsg.Size = new System.Drawing.Size(217, 13);
            this.tituloErroneoMsg.TabIndex = 13;
            this.tituloErroneoMsg.Text = "Título erróneo, pruebe a volver a introducirlo";
            this.tituloErroneoMsg.Visible = false;
            this.tituloErroneoMsg.Click += new System.EventHandler(this.tituloErroneoMsg_Click);
            // 
            // ReturnClick
            // 
            this.ReturnClick.Location = new System.Drawing.Point(521, 358);
            this.ReturnClick.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ReturnClick.Name = "ReturnClick";
            this.ReturnClick.Size = new System.Drawing.Size(62, 20);
            this.ReturnClick.TabIndex = 32;
            this.ReturnClick.Text = "Return";
            this.ReturnClick.UseVisualStyleBackColor = true;
            this.ReturnClick.Click += new System.EventHandler(this.ReturnClick_Click);
            // 
            // VentanaListadoArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 388);
            this.Controls.Add(this.ReturnClick);
            this.Controls.Add(this.tituloErroneoMsg);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NombreDelArticulo);
            this.Controls.Add(this.tablaInfo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MostrarListado);
            this.Name = "VentanaListadoArticulos";
            this.Text = "Lista Info de Artículos";
            this.Load += new System.EventHandler(this.VentanaListadoArticulos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.papersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.magazineDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.magazineDBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.papersBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button MostrarListado;
        private MagazineDBDataSet magazineDBDataSet;
        private System.Windows.Forms.BindingSource papersBindingSource;
        private MagazineDBDataSetTableAdapters.PapersTableAdapter papersTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView tablaInfo;
        private System.Windows.Forms.BindingSource magazineDBDataSetBindingSource;
        private System.Windows.Forms.BindingSource papersBindingSource1;
        private System.Windows.Forms.TextBox NombreDelArticulo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn titulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreAutores;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
        private System.Windows.Forms.Button ReturnClick;
        private System.Windows.Forms.Label tituloErroneoMsg;
    }
}