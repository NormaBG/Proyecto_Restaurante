using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.DsTableAdapters;

namespace WindowsFormsApp1
{
    public partial class frm_reporte : Form
    {
        public frm_reporte()
        {
            InitializeComponent();
        }

        private void frm_reporte_Load(object sender, EventArgs e)
        {
            string fecha1 = dtp_fecha.Value.ToString("yyyy-MM-dd");
            string fecha2 = dtp_fecha2.Value.ToString("yyyy-MM-dd");
            string nom = txt_nom.Text;
            // TODO: esta línea de código carga datos en la tabla 'ds.DataTable1' Puede moverla o quitarla según sea necesario.
            this.dataTable1TableAdapter.Fill(this.ds.DataTable1, fecha1, fecha2,nom);
            this.reportViewer1.RefreshReport();
        
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
