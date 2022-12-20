using Cotizaciones;
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
            lblId.Text =_vista.CrearVendedor().ToString();
            
        }
    }
}
