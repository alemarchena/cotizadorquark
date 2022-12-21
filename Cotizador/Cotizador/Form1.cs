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

            lblId.Text          =_vista.CrearVendedor(txtNombre.Text,txtApellido.Text).ToString();
            lblHistorial.Text   = _vista.MostrarIdHistorialVendedor();
            txtNombre.Text = _vista.Nombre;
            txtApellido.Text = _vista.Apellido;

            panelVendedor.Enabled = false;
            btnNuevoVendedor.Visible = false;
        }

        private void btnCrearTienda_Click(object sender, EventArgs e)
        {
            _vista.CrearTienda(txtNombreTienda.Text, txtDireccionTienda.Text);
            lblNombreTienda.Text = _vista.NombreTienda;
            lblDireccionTienda.Text = _vista.DireccionTienda;

            panelTienda.Visible = false;
            panelDatosTienda.Visible= true;
        }

        private void btnVerStock_Click(object sender, EventArgs e)
        {
            listaStock.Clear();
            foreach (string item in _vista.MostrarPrendas())
            {
                listaStock.Items.Add(item);
            }
        }

        private void btnCotizar_Click(object sender, EventArgs e)
        {

        }
    }
}
