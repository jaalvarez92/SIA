using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Logica;
using Entidades;

namespace UI
{
    public partial class VisualizarAsientos : Form
    {
        #region Atributos
        private Entities _Asientos;
        #endregion
        #region Propiedades
        public DateTime FechaInicio
        {
           get { return dateTimePickerInicio.Value.Date; }
        }

        public DateTime FechaFinal
        {
            get { return dateTimePickerFinal.Value.Date; }
        }

        #endregion

        #region Metodos
        public VisualizarAsientos()
        {
            InitializeComponent();
            botonCambiarFecha.Enabled = false;
        }

        private void mostrarAsientos()
        {
            DataSet ds = new DataSet();
            /*_Asientos = ConsultarAsientoLogica.ObtenerAsientos(FechaInicio, FechaFinal);
            foreach (Entity asientos in _Asientos)
            {*/
                dataGridViewAsientos.DataSource = _Asientos;
            //}
        }

        #endregion

        #region Eventos
        private void botonConsultarAsientos_Click(object sender, EventArgs e)
        {
            botonConsultarAsientos.Enabled = false;
            botonCambiarFecha.Enabled = true;
            dateTimePickerFinal.Enabled = false;
            dateTimePickerInicio.Enabled = false;
            mostrarAsientos();
        }
        #endregion

        private void botonCambiarFecha_Click(object sender, EventArgs e)
        {
            dateTimePickerFinal.Enabled = true;
            dateTimePickerInicio.Enabled = true;
            botonConsultarAsientos.Enabled = true;
        }

    }
}
