using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Facturas : Form
    {
        public Facturas(MenuPrincipal frm)
        {
            InitializeComponent();
        }

        private void bt_generar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Factura generada con exito");
        }

        private void bt_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
