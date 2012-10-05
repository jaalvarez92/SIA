using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UI
{
    public partial class Reportes : Form
    {
        public Reportes()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new VisualizarAsientos().Show(this);
            this.Hide();
        }

        private void buttonAtras_Click(object sender, EventArgs e)
        {
            this.Owner.Show();	   
            this.Close();	   
        }
    }
}
