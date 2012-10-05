namespace UI
{
    partial class VisualizarAsientos
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
            this.dateTimePickerInicio = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerFinal = new System.Windows.Forms.DateTimePicker();
            this.botonConsultarAsientos = new System.Windows.Forms.Button();
            this.botonCambiarFecha = new System.Windows.Forms.Button();
            this.dataGridViewAsientos = new System.Windows.Forms.DataGridView();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodigoAsiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipoasiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreCuenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Moneda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Debe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Haber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DebeSistema = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HaberSistema = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAsientos)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePickerInicio
            // 
            this.dateTimePickerInicio.Location = new System.Drawing.Point(12, 23);
            this.dateTimePickerInicio.Name = "dateTimePickerInicio";
            this.dateTimePickerInicio.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerInicio.TabIndex = 0;
            // 
            // dateTimePickerFinal
            // 
            this.dateTimePickerFinal.Location = new System.Drawing.Point(634, 26);
            this.dateTimePickerFinal.Name = "dateTimePickerFinal";
            this.dateTimePickerFinal.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerFinal.TabIndex = 1;
            // 
            // botonConsultarAsientos
            // 
            this.botonConsultarAsientos.Location = new System.Drawing.Point(434, 24);
            this.botonConsultarAsientos.Name = "botonConsultarAsientos";
            this.botonConsultarAsientos.Size = new System.Drawing.Size(138, 23);
            this.botonConsultarAsientos.TabIndex = 2;
            this.botonConsultarAsientos.Text = "Consultar Asientos";
            this.botonConsultarAsientos.UseVisualStyleBackColor = true;
            this.botonConsultarAsientos.Click += new System.EventHandler(this.botonConsultarAsientos_Click);
            // 
            // botonCambiarFecha
            // 
            this.botonCambiarFecha.Location = new System.Drawing.Point(241, 23);
            this.botonCambiarFecha.Name = "botonCambiarFecha";
            this.botonCambiarFecha.Size = new System.Drawing.Size(142, 23);
            this.botonCambiarFecha.TabIndex = 4;
            this.botonCambiarFecha.Text = "Cambiar Fecha";
            this.botonCambiarFecha.UseVisualStyleBackColor = true;
            this.botonCambiarFecha.Click += new System.EventHandler(this.botonCambiarFecha_Click);
            // 
            // dataGridViewAsientos
            // 
            this.dataGridViewAsientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAsientos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Fecha,
            this.CodigoAsiento,
            this.Tipoasiento,
            this.NombreCuenta,
            this.Moneda,
            this.Debe,
            this.Haber,
            this.DebeSistema,
            this.HaberSistema});
            this.dataGridViewAsientos.Location = new System.Drawing.Point(1, 53);
            this.dataGridViewAsientos.Name = "dataGridViewAsientos";
            this.dataGridViewAsientos.ReadOnly = true;
            this.dataGridViewAsientos.Size = new System.Drawing.Size(948, 406);
            this.dataGridViewAsientos.TabIndex = 5;
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha Contabilizada";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            // 
            // CodigoAsiento
            // 
            this.CodigoAsiento.HeaderText = "Codigo Asiento";
            this.CodigoAsiento.Name = "CodigoAsiento";
            this.CodigoAsiento.ReadOnly = true;
            // 
            // Tipoasiento
            // 
            this.Tipoasiento.HeaderText = "Tipo Asiento";
            this.Tipoasiento.Name = "Tipoasiento";
            this.Tipoasiento.ReadOnly = true;
            // 
            // NombreCuenta
            // 
            this.NombreCuenta.HeaderText = "Nombre Cuenta";
            this.NombreCuenta.Name = "NombreCuenta";
            this.NombreCuenta.ReadOnly = true;
            // 
            // Moneda
            // 
            this.Moneda.HeaderText = "Moneda";
            this.Moneda.Name = "Moneda";
            this.Moneda.ReadOnly = true;
            // 
            // Debe
            // 
            this.Debe.HeaderText = "Débito (Local)";
            this.Debe.Name = "Debe";
            this.Debe.ReadOnly = true;
            // 
            // Haber
            // 
            this.Haber.HeaderText = "Crédito (Local)";
            this.Haber.Name = "Haber";
            this.Haber.ReadOnly = true;
            // 
            // DebeSistema
            // 
            this.DebeSistema.HeaderText = "Débito (Sistema)";
            this.DebeSistema.Name = "DebeSistema";
            this.DebeSistema.ReadOnly = true;
            // 
            // HaberSistema
            // 
            this.HaberSistema.HeaderText = "Crédito (Sistema)";
            this.HaberSistema.Name = "HaberSistema";
            this.HaberSistema.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Fecha Documento Inicial";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(680, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Fecha Documento Final";
            // 
            // VisualizarAsientos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 489);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewAsientos);
            this.Controls.Add(this.botonCambiarFecha);
            this.Controls.Add(this.botonConsultarAsientos);
            this.Controls.Add(this.dateTimePickerFinal);
            this.Controls.Add(this.dateTimePickerInicio);
            this.Name = "VisualizarAsientos";
            this.Text = "VisualizarAsientos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAsientos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePickerInicio;
        private System.Windows.Forms.DateTimePicker dateTimePickerFinal;
        private System.Windows.Forms.Button botonConsultarAsientos;
        private System.Windows.Forms.Button botonCambiarFecha;
        private System.Windows.Forms.DataGridView dataGridViewAsientos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoAsiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipoasiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreCuenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Moneda;
        private System.Windows.Forms.DataGridViewTextBoxColumn Debe;
        private System.Windows.Forms.DataGridViewTextBoxColumn Haber;
        private System.Windows.Forms.DataGridViewTextBoxColumn DebeSistema;
        private System.Windows.Forms.DataGridViewTextBoxColumn HaberSistema;
    }
}