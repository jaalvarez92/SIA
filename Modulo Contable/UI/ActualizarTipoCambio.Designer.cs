namespace UI
{
    partial class ActualizarTipoCambio
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
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxMonedaBase = new System.Windows.Forms.ComboBox();
            this.comboBoxMonedaCambio = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxValor = new System.Windows.Forms.TextBox();
            this.groupBoxWS = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.Location = new System.Drawing.Point(193, 260);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(75, 23);
            this.buttonGuardar.TabIndex = 0;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.UseVisualStyleBackColor = true;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(297, 260);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelar.TabIndex = 1;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Moneda Base: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Moneda Cambio: ";
            // 
            // comboBoxMonedaBase
            // 
            this.comboBoxMonedaBase.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMonedaBase.FormattingEnabled = true;
            this.comboBoxMonedaBase.Location = new System.Drawing.Point(139, 52);
            this.comboBoxMonedaBase.Name = "comboBoxMonedaBase";
            this.comboBoxMonedaBase.Size = new System.Drawing.Size(121, 21);
            this.comboBoxMonedaBase.TabIndex = 4;
            // 
            // comboBoxMonedaCambio
            // 
            this.comboBoxMonedaCambio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMonedaCambio.FormattingEnabled = true;
            this.comboBoxMonedaCambio.Location = new System.Drawing.Point(139, 132);
            this.comboBoxMonedaCambio.Name = "comboBoxMonedaCambio";
            this.comboBoxMonedaCambio.Size = new System.Drawing.Size(121, 21);
            this.comboBoxMonedaCambio.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(99, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Valor:";
            // 
            // textBoxValor
            // 
            this.textBoxValor.Location = new System.Drawing.Point(139, 198);
            this.textBoxValor.Name = "textBoxValor";
            this.textBoxValor.Size = new System.Drawing.Size(121, 20);
            this.textBoxValor.TabIndex = 7;
            // 
            // groupBoxWS
            // 
            this.groupBoxWS.Location = new System.Drawing.Point(297, 48);
            this.groupBoxWS.Name = "groupBoxWS";
            this.groupBoxWS.Size = new System.Drawing.Size(203, 183);
            this.groupBoxWS.TabIndex = 8;
            this.groupBoxWS.TabStop = false;
            this.groupBoxWS.Text = "Web Service BCCR";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(211, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Actualizar Tipo de Cambio";
            // 
            // ActualizarTipoCambio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 309);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBoxWS);
            this.Controls.Add(this.textBoxValor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxMonedaCambio);
            this.Controls.Add(this.comboBoxMonedaBase);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonGuardar);
            this.Name = "ActualizarTipoCambio";
            this.Text = "ActualizarTipoCambio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxValor;
        private System.Windows.Forms.GroupBox groupBoxWS;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.ComboBox comboBoxMonedaBase;
        public System.Windows.Forms.ComboBox comboBoxMonedaCambio;
    }
}