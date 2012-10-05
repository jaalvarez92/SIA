using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Entidades;
using Logica;

namespace UI
{
    public partial class CrearCuenta : Form
    {
        #region Atributos
        private Entities _Tipos;
        private Entities _Monedas;
        private Entities _Cuentas;
        #endregion

        #region Propiedades
        public String NombreCuenta
        {
            get { return textBoxNombreCuenta.Text; }
            set { textBoxNombreCuenta.Text = value; }
        }

        public String NombreCuentaExtranjera
        {
            get { return textBoxNombreCuentaExtranjera.Text; }
            set { textBoxNombreCuentaExtranjera.Text = value; }
        }

        public String Codigo
        {
            get { return TipoCuenta+"-"+textBoxCodigo.Text; }
            set { textBoxCodigo.Text = value; }
        }

        public int Moneda
        {
            get {
                int codigo;
                if (comboBoxMoneda.Text.Equals("")) codigo = 0;
                else
                {
                    Entity moneda = _Monedas.Get("simbolo", comboBoxMoneda.Text);
                    codigo = (int)moneda.Get("idmoneda");
                }
                return codigo;
            }
        }

        public int IdTipoCuenta
        {
            get
            {
                Entity tipoCambio = _Tipos.Get("nombre", comboBoxTipoCuenta.Text);
                int codigo = (int)tipoCambio.Get("idtipocuenta");
                return codigo;
            }
        }

        public int TipoCuenta
        {
            get
            {
                Entity tipoCambio = _Tipos.Get("nombre", comboBoxTipoCuenta.Text);
                int codigo = (int)tipoCambio.Get("numerotipocuenta");
                return codigo;
            }
        }

        public int CuentaPadre
        {
            get
            {
                int codigo;
                if (comboBoxCuentaPadre.Text.Equals("")) codigo = 0;
                else
                {
                    Entity cuenta = _Cuentas.Get("nombre", comboBoxCuentaPadre.Text);
                    codigo = (int)cuenta.Get("idcuenta");
                }
                return codigo;
            }
        }

        public Boolean CuentaTitulo
        {
            get
            {
                return checkBoxCuentaTitulo.Checked;
            }
        }
    #endregion

        #region Constructor

        public CrearCuenta()
        {
            InitializeComponent();
            LlenarComboBoxTiposCuenta();
            LlenarComboBoxMonedas();
            LlenarComboBoxCuentas();
        }
        #endregion

        #region Métodos

        public void LlenarComboBoxTiposCuenta()
        {
            comboBoxTipoCuenta.Items.Clear();
            _Tipos = CuentaLogica.ObtenerTiposCuenta();
            foreach (Entity tipo in _Tipos)
            {
                comboBoxTipoCuenta.Items.Add(tipo.Get("nombre"));
            }

        }

        public void LlenarComboBoxMonedas()
        {
            comboBoxMoneda.Items.Clear();
            _Monedas = MonedaLogica.ObtenerMonedas();
            foreach (Entity moneda in _Monedas)
            {
                comboBoxMoneda.Items.Add(moneda.Get("simbolo"));
            }
        }

        public void LlenarComboBoxCuentas()
        {
            comboBoxCuentaPadre.Items.Clear();
            _Cuentas = CuentaLogica.ObtenerCuentas();
            foreach (Entity cuenta in _Cuentas)
            {
                comboBoxCuentaPadre.Items.Add(cuenta.Get("nombre"));
            }
        }

        public Boolean ValidarCampos()
        {
            return (!NombreCuenta.Equals("") && !NombreCuentaExtranjera.Equals("") && !Codigo.Equals("")
                    && !comboBoxTipoCuenta.Text.Equals(""));
            
        }

        public void LimpiarCampos()
        {
            NombreCuenta = "";
            NombreCuentaExtranjera = "";
            Codigo = "";
        }
        #endregion 

        #region Eventos

        private void buttonAtras_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Owner.Refresh();
            this.Close();
        }

        private void botonCrearCuenta_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                if (CuentaLogica.CrearCuenta(Codigo, NombreCuenta, NombreCuentaExtranjera, CuentaTitulo, IdTipoCuenta, CuentaPadre, Moneda))
                {
                    MessageBox.Show("Creación exitosa de cuenta.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCampos();
                    LlenarComboBoxCuentas();
                }
                else
                {
                    MessageBox.Show("Creación de cuenta no pudo ser completada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Creación de cuenta no pudo ser completada. Faltan datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void checkBoxCuentaTitulo_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxCuentaTitulo.Checked)
            {
                comboBoxMoneda.SelectedItem = null;
                comboBoxMoneda.Enabled = false;
            }
            else
            {
                comboBoxMoneda.Enabled = true;
            }

        }
        #endregion

    }
}
