namespace UI
{
    partial class MenuPrincipal
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
            this.buttonCuentas = new System.Windows.Forms.Button();
            this.buttonAsientos = new System.Windows.Forms.Button();
            this.buttonEmpresa = new System.Windows.Forms.Button();
            this.buttonReportes = new System.Windows.Forms.Button();
            this.buttonCerrarSesion = new System.Windows.Forms.Button();
            this.buttonCierre = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonAgregarPeriodoContable = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonCuentas
            // 
            this.buttonCuentas.AccessibleName = "";
            this.buttonCuentas.Location = new System.Drawing.Point(58, 50);
            this.buttonCuentas.Name = "buttonCuentas";
            this.buttonCuentas.Size = new System.Drawing.Size(140, 65);
            this.buttonCuentas.TabIndex = 0;
            this.buttonCuentas.Text = "Crear Cuentas";
            this.buttonCuentas.UseVisualStyleBackColor = true;
            this.buttonCuentas.Click += new System.EventHandler(this.buttonCuentas_Click);
            // 
            // buttonAsientos
            // 
            this.buttonAsientos.Location = new System.Drawing.Point(302, 50);
            this.buttonAsientos.Name = "buttonAsientos";
            this.buttonAsientos.Size = new System.Drawing.Size(140, 65);
            this.buttonAsientos.TabIndex = 1;
            this.buttonAsientos.Text = "Crear Asientos";
            this.buttonAsientos.UseVisualStyleBackColor = true;
            this.buttonAsientos.Click += new System.EventHandler(this.buttonAsientos_Click);
            // 
            // buttonEmpresa
            // 
            this.buttonEmpresa.Location = new System.Drawing.Point(58, 144);
            this.buttonEmpresa.Name = "buttonEmpresa";
            this.buttonEmpresa.Size = new System.Drawing.Size(140, 62);
            this.buttonEmpresa.TabIndex = 2;
            this.buttonEmpresa.Text = "Crear Empresa";
            this.buttonEmpresa.UseVisualStyleBackColor = true;
            this.buttonEmpresa.Click += new System.EventHandler(this.buttonEmpresa_Click);
            // 
            // buttonReportes
            // 
            this.buttonReportes.Location = new System.Drawing.Point(302, 144);
            this.buttonReportes.Name = "buttonReportes";
            this.buttonReportes.Size = new System.Drawing.Size(140, 64);
            this.buttonReportes.TabIndex = 3;
            this.buttonReportes.Text = "Reportes y Consultas";
            this.buttonReportes.UseVisualStyleBackColor = true;
            // 
            // buttonCerrarSesion
            // 
            this.buttonCerrarSesion.Location = new System.Drawing.Point(379, 332);
            this.buttonCerrarSesion.Name = "buttonCerrarSesion";
            this.buttonCerrarSesion.Size = new System.Drawing.Size(103, 23);
            this.buttonCerrarSesion.TabIndex = 4;
            this.buttonCerrarSesion.Text = "Cerrar Sesión";
            this.buttonCerrarSesion.UseVisualStyleBackColor = true;
            this.buttonCerrarSesion.Click += new System.EventHandler(this.buttonCerrarSesion_Click);
            // 
            // buttonCierre
            // 
            this.buttonCierre.Location = new System.Drawing.Point(58, 245);
            this.buttonCierre.Name = "buttonCierre";
            this.buttonCierre.Size = new System.Drawing.Size(140, 62);
            this.buttonCierre.TabIndex = 5;
            this.buttonCierre.Text = "Realizar Cierre";
            this.buttonCierre.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.5F);
            this.label1.Location = new System.Drawing.Point(174, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Menú Principal";
            // 
            // buttonAgregarPeriodoContable
            // 
            this.buttonAgregarPeriodoContable.Location = new System.Drawing.Point(302, 245);
            this.buttonAgregarPeriodoContable.Name = "buttonAgregarPeriodoContable";
            this.buttonAgregarPeriodoContable.Size = new System.Drawing.Size(140, 62);
            this.buttonAgregarPeriodoContable.TabIndex = 7;
            this.buttonAgregarPeriodoContable.Text = "Agregar Periodo Contable";
            this.buttonAgregarPeriodoContable.UseVisualStyleBackColor = true;
            this.buttonAgregarPeriodoContable.Click += new System.EventHandler(this.buttonAgregarPeriodoContable_Click);
            // 
            // MenuPrincipal
            // 
            this.AccessibleName = "buttonCuentas";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 367);
            this.Controls.Add(this.buttonAgregarPeriodoContable);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonCierre);
            this.Controls.Add(this.buttonCerrarSesion);
            this.Controls.Add(this.buttonReportes);
            this.Controls.Add(this.buttonEmpresa);
            this.Controls.Add(this.buttonAsientos);
            this.Controls.Add(this.buttonCuentas);
            this.Name = "MenuPrincipal";
            this.Text = "MenuPrincipal";
            this.Load += new System.EventHandler(this.MenuPrincipal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCuentas;
        private System.Windows.Forms.Button buttonAsientos;
        private System.Windows.Forms.Button buttonEmpresa;
        private System.Windows.Forms.Button buttonReportes;
        private System.Windows.Forms.Button buttonCerrarSesion;
        private System.Windows.Forms.Button buttonCierre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonAgregarPeriodoContable;
    }
}