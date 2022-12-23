using Cotizaciones;
using EspacioPresentador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Cotizador
{
    /// <summary>
    /// La clase Form1 contiene los controles visuales y la lógica del comportamiento visual
    /// </summary>
    public partial class Form1 : Form
    {
       
        Vista _vista;
        public Form1()
        {
            InitializeComponent();
            _vista = new Vista();

        }

        private void btnNuevoVendedor_Click(object sender, EventArgs e)
        {

            lblId.Text              = _vista.CrearVendedor(txtNombre.Text,txtApellido.Text).ToString();
            lblHistorial.Text       = _vista.MostrarIdHistorialVendedor();
            txtNombre.Text          = _vista.Nombre;
            txtApellido.Text        = _vista.Apellido;

            //Lógica visual para los objetos afectados por la acción
            panelCotizador.Enabled      = true;
            btnHistorial.Enabled        = true;

            panelVendedor.Enabled       = false;
            btnNuevoVendedor.Visible    = false;
        }

        private void btnCrearTienda_Click(object sender, EventArgs e)
        {
            _vista.CrearTienda(txtNombreTienda.Text, txtDireccionTienda.Text);
            lblNombreTienda.Text    = _vista.NombreTienda;
            lblDireccionTienda.Text = _vista.DireccionTienda;

            //Lógica visual para los objetos afectados por la acción
            btnVerStock.Enabled         = true;
            panelTienda.Visible         = false;
            panelDatosTienda.Visible    = true;
        }

        private void btnVerStock_Click(object sender, EventArgs e)
        {
            RefrescarPrendas();
        }

        private void RefrescarPrendas()
        {
            listaStock.Clear();
            foreach (string item in _vista.MostrarPrendas())
            {
                listaStock.Items.Add(item);
            }
        }
        private void btnCotizar_Click(object sender, EventArgs e)
        {

            int _tipoprenda = radioCamisa.Checked   ? 1 : 2;
            int _calidad = radioStandard.Checked     ? 1 : 2;

            //Caso Camisas
            int _manga =  radioMangaCorta.Checked   ? 1 : 2;
            int _cuello =  radioCuelloComun.Checked ? 1 : 2;

            //Caso pantalones
            int _estilo =  !chkChupin.Checked  ? 1 : 2;

            txtCantidad.Text = txtCantidad.Text == "" ? "0" : txtCantidad.Text;
            txtPrecioBase.Text = txtPrecioBase.Text == "" ? "0" : txtPrecioBase.Text;

            int _stock=0;
            float _preciocalculado = 0.0f;
            float _total = 0.0f;

            int _pudocotizar = _vista.Cotizar(ref _stock, ref _preciocalculado, ref _total, lblId.Text, _tipoprenda, _calidad, int.Parse(txtCantidad.Text), float.Parse(txtPrecioBase.Text), _estilo, _cuello, _manga);

            if(_pudocotizar> 0)
            {
                lblPrecioCalculado.Text = _preciocalculado.ToString();
                lblStockDisponible.Text = _stock.ToString();
                lblTotalCotizado.Text   = _total.ToString();
                RefrescarPrendas();
            }
            else
            {
                if (_pudocotizar != -1)
                    MessageBox.Show("La cantidad a cotizar es mayor al stock existente");
            }

        }

        private void btnHistorial_Click(object sender, EventArgs e)
        {
            Form2 formularioHistorial = new Form2();

            formularioHistorial.CargarLista(_vista.MostrarHistorial());
            formularioHistorial.ShowDialog();

            
        }

        private void txtPrecioBase_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
               (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as System.Windows.Forms.TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

      
        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros enteros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
    }
}
