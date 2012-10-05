namespace UI
{
    partial class CrearCuenta
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
            this.labelCodigo = new System.Windows.Forms.Label();
            this.textBoxCodigo = new System.Windows.Forms.TextBox();
            this.labelNombreCuentaExtranjera = new System.Windows.Forms.Label();
            this.textBoxNombreCuentaExtranjera = new System.Windows.Forms.TextBox();
            this.botonCrearCuenta = new System.Windows.Forms.Button();
            this.labelCuentaPadre = new System.Windows.Forms.Label();
            this.labelTipoCuenta = new System.Windows.Forms.Label();
            this.labelNombreCuenta = new System.Windows.Forms.Label();
            this.labelMonedaCuenta = new System.Windows.Forms.Label();
            this.comboBoxTipoCuenta = new System.Windows.Forms.ComboBox();
            this.comboBoxMoneda = new System.Windows.Forms.ComboBox();
            this.textBoxNombreCuenta = new System.Windows.Forms.TextBox();
            this.comboBoxCuentaPadre = new System.Windows.Forms.ComboBox();
            this.checkBoxCuentaTitulo = new System.Windows.Forms.CheckBox();
            this.labelCreacionCuentas = new System.Windows.Forms.Label();
            this.buttonAtras = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.treeViewCuentas = new System.Windows.Forms.TreeView();
            this.checkBoxEliminarCuentas = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelCodigo
            // 
            this.labelCodigo.AutoSize = true;
            this.labelCodigo.Location = new System.Drawing.Point(47, 76);
            this.labelCodigo.Name = "labelCodigo";
            this.labelCodigo.Size = new System.Drawing.Size(40, 13);
            this.labelCodigo.TabIndex = 29;
            this.labelCodigo.Text = "Código";
            // 
            // textBoxCodigo
            // 
            this.textBoxCodigo.Location = new System.Drawing.Point(15, 107);
            this.textBoxCodigo.Name = "textBoxCodigo";
            this.textBoxCodigo.Size = new System.Drawing.Size(100, 20);
            this.textBoxCodigo.TabIndex = 28;
            // 
            // labelNombreCuentaExtranjera
            // 
            this.labelNombreCuentaExtranjera.AutoSize = true;
            this.labelNombreCuentaExtranjera.Location = new System.Drawing.Point(262, 138);
            this.labelNombreCuentaExtranjera.Name = "labelNombreCuentaExtranjera";
            this.labelNombreCuentaExtranjera.Size = new System.Drawing.Size(131, 13);
            this.labelNombreCuentaExtranjera.TabIndex = 27;
            this.labelNombreCuentaExtranjera.Text = "Nombre Cuenta Extranjera";
            // 
            // textBoxNombreCuentaExtranjera
            // 
            this.textBoxNombreCuentaExtranjera.Location = new System.Drawing.Point(186, 154);
            this.textBoxNombreCuentaExtranjera.Name = "textBoxNombreCuentaExtranjera";
            this.textBoxNombreCuentaExtranjera.Size = new System.Drawing.Size(296, 20);
            this.textBoxNombreCuentaExtranjera.TabIndex = 26;
            // 
            // botonCrearCuenta
            // 
            this.botonCrearCuenta.Location = new System.Drawing.Point(196, 278);
            this.botonCrearCuenta.Name = "botonCrearCuenta";
            this.botonCrearCuenta.Size = new System.Drawing.Size(75, 23);
            this.botonCrearCuenta.TabIndex = 25;
            this.botonCrearCuenta.Text = "Crear Cuenta";
            this.botonCrearCuenta.UseVisualStyleBackColor = true;
            this.botonCrearCuenta.Click += new System.EventHandler(this.botonCrearCuenta_Click);
            // 
            // labelCuentaPadre
            // 
            this.labelCuentaPadre.AutoSize = true;
            this.labelCuentaPadre.Location = new System.Drawing.Point(293, 196);
            this.labelCuentaPadre.Name = "labelCuentaPadre";
            this.labelCuentaPadre.Size = new System.Drawing.Size(72, 13);
            this.labelCuentaPadre.TabIndex = 24;
            this.labelCuentaPadre.Text = "Cuenta Padre";
            // 
            // labelTipoCuenta
            // 
            this.labelTipoCuenta.AutoSize = true;
            this.labelTipoCuenta.Location = new System.Drawing.Point(42, 137);
            this.labelTipoCuenta.Name = "labelTipoCuenta";
            this.labelTipoCuenta.Size = new System.Drawing.Size(65, 13);
            this.labelTipoCuenta.TabIndex = 23;
            this.labelTipoCuenta.Text = "Tipo Cuenta";
            // 
            // labelNombreCuenta
            // 
            this.labelNombreCuenta.AutoSize = true;
            this.labelNombreCuenta.Location = new System.Drawing.Point(284, 76);
            this.labelNombreCuenta.Name = "labelNombreCuenta";
            this.labelNombreCuenta.Size = new System.Drawing.Size(81, 13);
            this.labelNombreCuenta.TabIndex = 22;
            this.labelNombreCuenta.Text = "Nombre Cuenta";
            // 
            // labelMonedaCuenta
            // 
            this.labelMonedaCuenta.AutoSize = true;
            this.labelMonedaCuenta.Location = new System.Drawing.Point(134, 76);
            this.labelMonedaCuenta.Name = "labelMonedaCuenta";
            this.labelMonedaCuenta.Size = new System.Drawing.Size(46, 13);
            this.labelMonedaCuenta.TabIndex = 21;
            this.labelMonedaCuenta.Text = "Moneda";
            // 
            // comboBoxTipoCuenta
            // 
            this.comboBoxTipoCuenta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTipoCuenta.FormattingEnabled = true;
            this.comboBoxTipoCuenta.Location = new System.Drawing.Point(15, 153);
            this.comboBoxTipoCuenta.Name = "comboBoxTipoCuenta";
            this.comboBoxTipoCuenta.Size = new System.Drawing.Size(165, 21);
            this.comboBoxTipoCuenta.TabIndex = 20;
            // 
            // comboBoxMoneda
            // 
            this.comboBoxMoneda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMoneda.FormattingEnabled = true;
            this.comboBoxMoneda.Location = new System.Drawing.Point(123, 107);
            this.comboBoxMoneda.Name = "comboBoxMoneda";
            this.comboBoxMoneda.Size = new System.Drawing.Size(57, 21);
            this.comboBoxMoneda.TabIndex = 19;
            // 
            // textBoxNombreCuenta
            // 
            this.textBoxNombreCuenta.Location = new System.Drawing.Point(186, 108);
            this.textBoxNombreCuenta.Name = "textBoxNombreCuenta";
            this.textBoxNombreCuenta.Size = new System.Drawing.Size(296, 20);
            this.textBoxNombreCuenta.TabIndex = 18;
            // 
            // comboBoxCuentaPadre
            // 
            this.comboBoxCuentaPadre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCuentaPadre.FormattingEnabled = true;
            this.comboBoxCuentaPadre.Location = new System.Drawing.Point(186, 212);
            this.comboBoxCuentaPadre.Name = "comboBoxCuentaPadre";
            this.comboBoxCuentaPadre.Size = new System.Drawing.Size(296, 21);
            this.comboBoxCuentaPadre.TabIndex = 17;
            // 
            // checkBoxCuentaTitulo
            // 
            this.checkBoxCuentaTitulo.AutoSize = true;
            this.checkBoxCuentaTitulo.Location = new System.Drawing.Point(35, 214);
            this.checkBoxCuentaTitulo.Name = "checkBoxCuentaTitulo";
            this.checkBoxCuentaTitulo.Size = new System.Drawing.Size(89, 17);
            this.checkBoxCuentaTitulo.TabIndex = 16;
            this.checkBoxCuentaTitulo.Text = "Cuenta Titulo";
            this.checkBoxCuentaTitulo.UseVisualStyleBackColor = true;
            this.checkBoxCuentaTitulo.CheckedChanged += new System.EventHandler(this.checkBoxCuentaTitulo_CheckedChanged);
            // 
            // labelCreacionCuentas
            // 
            this.labelCreacionCuentas.AutoSize = true;
            this.labelCreacionCuentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCreacionCuentas.Location = new System.Drawing.Point(77, 9);
            this.labelCreacionCuentas.Name = "labelCreacionCuentas";
            this.labelCreacionCuentas.Size = new System.Drawing.Size(307, 33);
            this.labelCreacionCuentas.TabIndex = 15;
            this.labelCreacionCuentas.Text = "Creación de Cuentas";
            // 
            // buttonAtras
            // 
            this.buttonAtras.Location = new System.Drawing.Point(407, 332);
            this.buttonAtras.Name = "buttonAtras";
            this.buttonAtras.Size = new System.Drawing.Size(75, 23);
            this.buttonAtras.TabIndex = 32;
            this.buttonAtras.Text = "Atrás";
            this.buttonAtras.UseVisualStyleBackColor = true;
            this.buttonAtras.Click += new System.EventHandler(this.buttonAtras_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.checkBoxEliminarCuentas);
            this.panel1.Controls.Add(this.treeViewCuentas);
            this.panel1.Location = new System.Drawing.Point(503, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(265, 366);
            this.panel1.TabIndex = 33;
            // 
            // treeViewCuentas
            // 
            this.treeViewCuentas.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.treeViewCuentas.Enabled = false;
            this.treeViewCuentas.Location = new System.Drawing.Point(3, 28);
            this.treeViewCuentas.Name = "treeViewCuentas";
            this.treeViewCuentas.Size = new System.Drawing.Size(257, 335);
            this.treeViewCuentas.TabIndex = 0;
            this.treeViewCuentas.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewCuentas_AfterSelect);
            // 
            // checkBoxEliminarCuentas
            // 
            this.checkBoxEliminarCuentas.AutoSize = true;
            this.checkBoxEliminarCuentas.Location = new System.Drawing.Point(80, 4);
            this.checkBoxEliminarCuentas.Name = "checkBoxEliminarCuentas";
            this.checkBoxEliminarCuentas.Size = new System.Drawing.Size(104, 17);
            this.checkBoxEliminarCuentas.TabIndex = 1;
            this.checkBoxEliminarCuentas.Text = "Eliminar Cuentas";
            this.checkBoxEliminarCuentas.UseVisualStyleBackColor = true;
            this.checkBoxEliminarCuentas.CheckedChanged += new System.EventHandler(this.checkBoxEliminarCuentas_CheckedChanged);
            // 
            // CrearCuenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 367);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonAtras);
            this.Controls.Add(this.labelCodigo);
            this.Controls.Add(this.textBoxCodigo);
            this.Controls.Add(this.labelNombreCuentaExtranjera);
            this.Controls.Add(this.textBoxNombreCuentaExtranjera);
            this.Controls.Add(this.botonCrearCuenta);
            this.Controls.Add(this.labelCuentaPadre);
            this.Controls.Add(this.labelTipoCuenta);
            this.Controls.Add(this.labelNombreCuenta);
            this.Controls.Add(this.labelMonedaCuenta);
            this.Controls.Add(this.comboBoxTipoCuenta);
            this.Controls.Add(this.comboBoxMoneda);
            this.Controls.Add(this.textBoxNombreCuenta);
            this.Controls.Add(this.comboBoxCuentaPadre);
            this.Controls.Add(this.checkBoxCuentaTitulo);
            this.Controls.Add(this.labelCreacionCuentas);
            this.Name = "CrearCuenta";
            this.Text = "CrearCuenta";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCodigo;
        private System.Windows.Forms.TextBox textBoxCodigo;
        private System.Windows.Forms.Label labelNombreCuentaExtranjera;
        private System.Windows.Forms.TextBox textBoxNombreCuentaExtranjera;
        private System.Windows.Forms.Button botonCrearCuenta;
        private System.Windows.Forms.Label labelCuentaPadre;
        private System.Windows.Forms.Label labelTipoCuenta;
        private System.Windows.Forms.Label labelNombreCuenta;
        private System.Windows.Forms.Label labelMonedaCuenta;
        private System.Windows.Forms.ComboBox comboBoxTipoCuenta;
        private System.Windows.Forms.ComboBox comboBoxMoneda;
        private System.Windows.Forms.TextBox textBoxNombreCuenta;
        private System.Windows.Forms.ComboBox comboBoxCuentaPadre;
        private System.Windows.Forms.CheckBox checkBoxCuentaTitulo;
        private System.Windows.Forms.Label labelCreacionCuentas;
        private System.Windows.Forms.Button buttonAtras;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TreeView treeViewCuentas;
        private System.Windows.Forms.CheckBox checkBoxEliminarCuentas;

    }
}