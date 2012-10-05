namespace UI
{
    partial class CrearEmpresa
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
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxMonedaSistema = new System.Windows.Forms.ComboBox();
            this.comboBoxMonedaLocal = new System.Windows.Forms.ComboBox();
            this.labelSchema = new System.Windows.Forms.Label();
            this.textBoxCedulaJuridica = new System.Windows.Forms.TextBox();
            this.botonRutaArchivo = new System.Windows.Forms.Button();
            this.textBoxLogotipo = new System.Windows.Forms.TextBox();
            this.labelLogotipo = new System.Windows.Forms.Label();
            this.textBoxEsquema = new System.Windows.Forms.TextBox();
            this.labelCedulaJuridica = new System.Windows.Forms.Label();
            this.labelNombreEmpresa = new System.Windows.Forms.Label();
            this.textBoxNombreEmpresa = new System.Windows.Forms.TextBox();
            this.botonCrearEmpresa = new System.Windows.Forms.Button();
            this.buttonAtras = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "Moneda de Sistema:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "MonedaLocal:";
            // 
            // comboBoxMonedaSistema
            // 
            this.comboBoxMonedaSistema.FormattingEnabled = true;
            this.comboBoxMonedaSistema.Location = new System.Drawing.Point(136, 215);
            this.comboBoxMonedaSistema.Name = "comboBoxMonedaSistema";
            this.comboBoxMonedaSistema.Size = new System.Drawing.Size(171, 21);
            this.comboBoxMonedaSistema.TabIndex = 27;
            // 
            // comboBoxMonedaLocal
            // 
            this.comboBoxMonedaLocal.FormattingEnabled = true;
            this.comboBoxMonedaLocal.Location = new System.Drawing.Point(136, 188);
            this.comboBoxMonedaLocal.Name = "comboBoxMonedaLocal";
            this.comboBoxMonedaLocal.Size = new System.Drawing.Size(171, 21);
            this.comboBoxMonedaLocal.TabIndex = 26;
            // 
            // labelSchema
            // 
            this.labelSchema.AutoSize = true;
            this.labelSchema.Location = new System.Drawing.Point(68, 111);
            this.labelSchema.Name = "labelSchema";
            this.labelSchema.Size = new System.Drawing.Size(54, 13);
            this.labelSchema.TabIndex = 25;
            this.labelSchema.Text = "Esquema:";
            // 
            // textBoxCedulaJuridica
            // 
            this.textBoxCedulaJuridica.Location = new System.Drawing.Point(136, 157);
            this.textBoxCedulaJuridica.Name = "textBoxCedulaJuridica";
            this.textBoxCedulaJuridica.Size = new System.Drawing.Size(171, 20);
            this.textBoxCedulaJuridica.TabIndex = 24;
            // 
            // botonRutaArchivo
            // 
            this.botonRutaArchivo.Location = new System.Drawing.Point(313, 133);
            this.botonRutaArchivo.Name = "botonRutaArchivo";
            this.botonRutaArchivo.Size = new System.Drawing.Size(158, 23);
            this.botonRutaArchivo.TabIndex = 23;
            this.botonRutaArchivo.Text = "Seleccionar Ruta Archivo";
            this.botonRutaArchivo.UseVisualStyleBackColor = true;
            this.botonRutaArchivo.Click += new System.EventHandler(this.botonRutaArchivo_Click);
            // 
            // textBoxLogotipo
            // 
            this.textBoxLogotipo.Enabled = false;
            this.textBoxLogotipo.Location = new System.Drawing.Point(136, 133);
            this.textBoxLogotipo.Name = "textBoxLogotipo";
            this.textBoxLogotipo.Size = new System.Drawing.Size(171, 20);
            this.textBoxLogotipo.TabIndex = 22;
            // 
            // labelLogotipo
            // 
            this.labelLogotipo.AutoSize = true;
            this.labelLogotipo.Location = new System.Drawing.Point(71, 133);
            this.labelLogotipo.Name = "labelLogotipo";
            this.labelLogotipo.Size = new System.Drawing.Size(51, 13);
            this.labelLogotipo.TabIndex = 21;
            this.labelLogotipo.Text = "Logotipo:";
            // 
            // textBoxEsquema
            // 
            this.textBoxEsquema.Location = new System.Drawing.Point(136, 107);
            this.textBoxEsquema.Name = "textBoxEsquema";
            this.textBoxEsquema.Size = new System.Drawing.Size(171, 20);
            this.textBoxEsquema.TabIndex = 20;
            // 
            // labelCedulaJuridica
            // 
            this.labelCedulaJuridica.AutoSize = true;
            this.labelCedulaJuridica.Location = new System.Drawing.Point(52, 160);
            this.labelCedulaJuridica.Name = "labelCedulaJuridica";
            this.labelCedulaJuridica.Size = new System.Drawing.Size(73, 13);
            this.labelCedulaJuridica.TabIndex = 19;
            this.labelCedulaJuridica.Text = "Ced. Jurídica:";
            // 
            // labelNombreEmpresa
            // 
            this.labelNombreEmpresa.AutoSize = true;
            this.labelNombreEmpresa.Location = new System.Drawing.Point(75, 85);
            this.labelNombreEmpresa.Name = "labelNombreEmpresa";
            this.labelNombreEmpresa.Size = new System.Drawing.Size(47, 13);
            this.labelNombreEmpresa.TabIndex = 18;
            this.labelNombreEmpresa.Text = "Nombre:";
            // 
            // textBoxNombreEmpresa
            // 
            this.textBoxNombreEmpresa.Location = new System.Drawing.Point(136, 82);
            this.textBoxNombreEmpresa.Name = "textBoxNombreEmpresa";
            this.textBoxNombreEmpresa.Size = new System.Drawing.Size(171, 20);
            this.textBoxNombreEmpresa.TabIndex = 17;
            // 
            // botonCrearEmpresa
            // 
            this.botonCrearEmpresa.Location = new System.Drawing.Point(136, 242);
            this.botonCrearEmpresa.Name = "botonCrearEmpresa";
            this.botonCrearEmpresa.Size = new System.Drawing.Size(171, 23);
            this.botonCrearEmpresa.TabIndex = 30;
            this.botonCrearEmpresa.Text = "Crear Empresa";
            this.botonCrearEmpresa.UseVisualStyleBackColor = true;
            this.botonCrearEmpresa.Click += new System.EventHandler(this.botonCrearEmpresa_Click);
            // 
            // buttonAtras
            // 
            this.buttonAtras.Location = new System.Drawing.Point(396, 330);
            this.buttonAtras.Name = "buttonAtras";
            this.buttonAtras.Size = new System.Drawing.Size(75, 23);
            this.buttonAtras.TabIndex = 31;
            this.buttonAtras.Text = "Atrás";
            this.buttonAtras.UseVisualStyleBackColor = true;
            this.buttonAtras.Click += new System.EventHandler(this.buttonAtras_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // CrearEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 367);
            this.Controls.Add(this.buttonAtras);
            this.Controls.Add(this.botonCrearEmpresa);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBoxMonedaSistema);
            this.Controls.Add(this.comboBoxMonedaLocal);
            this.Controls.Add(this.labelSchema);
            this.Controls.Add(this.textBoxCedulaJuridica);
            this.Controls.Add(this.botonRutaArchivo);
            this.Controls.Add(this.textBoxLogotipo);
            this.Controls.Add(this.labelLogotipo);
            this.Controls.Add(this.textBoxEsquema);
            this.Controls.Add(this.labelCedulaJuridica);
            this.Controls.Add(this.labelNombreEmpresa);
            this.Controls.Add(this.textBoxNombreEmpresa);
            this.Name = "CrearEmpresa";
            this.Text = "CrearEmpresa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxMonedaSistema;
        private System.Windows.Forms.ComboBox comboBoxMonedaLocal;
        private System.Windows.Forms.Label labelSchema;
        private System.Windows.Forms.TextBox textBoxCedulaJuridica;
        private System.Windows.Forms.Button botonRutaArchivo;
        private System.Windows.Forms.TextBox textBoxLogotipo;
        private System.Windows.Forms.Label labelLogotipo;
        private System.Windows.Forms.TextBox textBoxEsquema;
        private System.Windows.Forms.Label labelCedulaJuridica;
        private System.Windows.Forms.Label labelNombreEmpresa;
        private System.Windows.Forms.TextBox textBoxNombreEmpresa;
        private System.Windows.Forms.Button botonCrearEmpresa;
        private System.Windows.Forms.Button buttonAtras;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}