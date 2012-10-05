namespace UI
{
    partial class Login
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.labelUsuario = new System.Windows.Forms.Label();
            this.labelContrasena = new System.Windows.Forms.Label();
            this.labelEmpresa = new System.Windows.Forms.Label();
            this.textBoxUsuario = new System.Windows.Forms.TextBox();
            this.textBoxcontrasena = new System.Windows.Forms.TextBox();
            this.comboBoxEmpresa = new System.Windows.Forms.ComboBox();
            this.botonIngresar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(87, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(485, 71);
            this.label1.TabIndex = 0;
            this.label1.Text = "Módulo Financiero";
            // 
            // labelUsuario
            // 
            this.labelUsuario.AutoSize = true;
            this.labelUsuario.Location = new System.Drawing.Point(193, 120);
            this.labelUsuario.Name = "labelUsuario";
            this.labelUsuario.Size = new System.Drawing.Size(46, 13);
            this.labelUsuario.TabIndex = 1;
            this.labelUsuario.Text = "Usuario:";
            // 
            // labelContrasena
            // 
            this.labelContrasena.AutoEllipsis = true;
            this.labelContrasena.AutoSize = true;
            this.labelContrasena.Location = new System.Drawing.Point(178, 185);
            this.labelContrasena.Name = "labelContrasena";
            this.labelContrasena.Size = new System.Drawing.Size(64, 13);
            this.labelContrasena.TabIndex = 2;
            this.labelContrasena.Text = "Contraseña:";
            // 
            // labelEmpresa
            // 
            this.labelEmpresa.AutoSize = true;
            this.labelEmpresa.Location = new System.Drawing.Point(188, 258);
            this.labelEmpresa.Name = "labelEmpresa";
            this.labelEmpresa.Size = new System.Drawing.Size(51, 13);
            this.labelEmpresa.TabIndex = 3;
            this.labelEmpresa.Text = "Empresa:";
            // 
            // textBoxUsuario
            // 
            this.textBoxUsuario.Location = new System.Drawing.Point(258, 120);
            this.textBoxUsuario.Name = "textBoxUsuario";
            this.textBoxUsuario.Size = new System.Drawing.Size(211, 20);
            this.textBoxUsuario.TabIndex = 4;
            // 
            // textBoxcontrasena
            // 
            this.textBoxcontrasena.Location = new System.Drawing.Point(258, 185);
            this.textBoxcontrasena.Name = "textBoxcontrasena";
            this.textBoxcontrasena.PasswordChar = '*';
            this.textBoxcontrasena.Size = new System.Drawing.Size(211, 20);
            this.textBoxcontrasena.TabIndex = 5;
            // 
            // comboBoxEmpresa
            // 
            this.comboBoxEmpresa.BackColor = System.Drawing.SystemColors.Window;
            this.comboBoxEmpresa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEmpresa.FormattingEnabled = true;
            this.comboBoxEmpresa.Location = new System.Drawing.Point(258, 250);
            this.comboBoxEmpresa.Name = "comboBoxEmpresa";
            this.comboBoxEmpresa.Size = new System.Drawing.Size(211, 21);
            this.comboBoxEmpresa.TabIndex = 6;
            this.comboBoxEmpresa.SelectedValueChanged += new System.EventHandler(this.comboBoxEmpresa_SelectedValueChanged);
            // 
            // botonIngresar
            // 
            this.botonIngresar.Location = new System.Drawing.Point(330, 323);
            this.botonIngresar.Name = "botonIngresar";
            this.botonIngresar.Size = new System.Drawing.Size(75, 23);
            this.botonIngresar.TabIndex = 7;
            this.botonIngresar.Text = "Ingresar";
            this.botonIngresar.UseVisualStyleBackColor = true;
            this.botonIngresar.Click += new System.EventHandler(this.botonIngresar_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 395);
            this.Controls.Add(this.botonIngresar);
            this.Controls.Add(this.comboBoxEmpresa);
            this.Controls.Add(this.textBoxcontrasena);
            this.Controls.Add(this.textBoxUsuario);
            this.Controls.Add(this.labelEmpresa);
            this.Controls.Add(this.labelContrasena);
            this.Controls.Add(this.labelUsuario);
            this.Controls.Add(this.label1);
            this.Name = "Login";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelUsuario;
        private System.Windows.Forms.Label labelContrasena;
        private System.Windows.Forms.Label labelEmpresa;
        private System.Windows.Forms.TextBox textBoxUsuario;
        private System.Windows.Forms.TextBox textBoxcontrasena;
        private System.Windows.Forms.ComboBox comboBoxEmpresa;
        private System.Windows.Forms.Button botonIngresar;
    }
}

