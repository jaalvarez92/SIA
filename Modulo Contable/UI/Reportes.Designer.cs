namespace UI
{
    partial class Reportes
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
            this.button4 = new System.Windows.Forms.Button();
            this.btnGenerarBalanceGeneral = new System.Windows.Forms.Button();
            this.btnGenerarEstadoResultados = new System.Windows.Forms.Button();
            this.btnGenerarBalanceComprobacion = new System.Windows.Forms.Button();
            this.labelReportes = new System.Windows.Forms.Label();
            this.buttonAtras = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(320, 195);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(140, 67);
            this.button4.TabIndex = 9;
            this.button4.Text = "Observar Asientos";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnGenerarBalanceGeneral
            // 
            this.btnGenerarBalanceGeneral.Location = new System.Drawing.Point(35, 195);
            this.btnGenerarBalanceGeneral.Name = "btnGenerarBalanceGeneral";
            this.btnGenerarBalanceGeneral.Size = new System.Drawing.Size(140, 67);
            this.btnGenerarBalanceGeneral.TabIndex = 8;
            this.btnGenerarBalanceGeneral.Text = "Balance General";
            this.btnGenerarBalanceGeneral.UseVisualStyleBackColor = true;
            this.btnGenerarBalanceGeneral.Click += new System.EventHandler(this.btnGenerarBalanceGeneral_Click);
            // 
            // btnGenerarEstadoResultados
            // 
            this.btnGenerarEstadoResultados.Location = new System.Drawing.Point(320, 71);
            this.btnGenerarEstadoResultados.Name = "btnGenerarEstadoResultados";
            this.btnGenerarEstadoResultados.Size = new System.Drawing.Size(140, 67);
            this.btnGenerarEstadoResultados.TabIndex = 7;
            this.btnGenerarEstadoResultados.Text = "Estado de Resultados";
            this.btnGenerarEstadoResultados.UseVisualStyleBackColor = true;
            this.btnGenerarEstadoResultados.Click += new System.EventHandler(this.btnGenerarEstadoResultados_Click);
            // 
            // btnGenerarBalanceComprobacion
            // 
            this.btnGenerarBalanceComprobacion.Location = new System.Drawing.Point(35, 71);
            this.btnGenerarBalanceComprobacion.Name = "btnGenerarBalanceComprobacion";
            this.btnGenerarBalanceComprobacion.Size = new System.Drawing.Size(140, 67);
            this.btnGenerarBalanceComprobacion.TabIndex = 6;
            this.btnGenerarBalanceComprobacion.Text = "Balance de Comprobación";
            this.btnGenerarBalanceComprobacion.UseVisualStyleBackColor = true;
            this.btnGenerarBalanceComprobacion.Click += new System.EventHandler(this.btnGenerarBalanceComprobacion_Click);
            // 
            // labelReportes
            // 
            this.labelReportes.AutoSize = true;
            this.labelReportes.Location = new System.Drawing.Point(198, 20);
            this.labelReportes.Name = "labelReportes";
            this.labelReportes.Size = new System.Drawing.Size(107, 13);
            this.labelReportes.TabIndex = 5;
            this.labelReportes.Text = "Reportes y Consultas";
            // 
            // buttonAtras
            // 
            this.buttonAtras.Location = new System.Drawing.Point(385, 332);
            this.buttonAtras.Name = "buttonAtras";
            this.buttonAtras.Size = new System.Drawing.Size(75, 23);
            this.buttonAtras.TabIndex = 32;
            this.buttonAtras.Text = "Atrás";
            this.buttonAtras.UseVisualStyleBackColor = true;
            this.buttonAtras.Click += new System.EventHandler(this.buttonAtras_Click);
            // 
            // Reportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 367);
            this.Controls.Add(this.buttonAtras);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnGenerarBalanceGeneral);
            this.Controls.Add(this.btnGenerarEstadoResultados);
            this.Controls.Add(this.btnGenerarBalanceComprobacion);
            this.Controls.Add(this.labelReportes);
            this.Name = "Reportes";
            this.Text = "Reportes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnGenerarBalanceGeneral;
        private System.Windows.Forms.Button btnGenerarEstadoResultados;
        private System.Windows.Forms.Button btnGenerarBalanceComprobacion;
        private System.Windows.Forms.Label labelReportes;
        private System.Windows.Forms.Button buttonAtras;
    }
}