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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public void CargarLista(List<string> lista)
        {
            listaHistorialModal.Clear();
            foreach (string item in lista)
            {
                listaHistorialModal.Items.Add(item);
            }
        }
    }
}
