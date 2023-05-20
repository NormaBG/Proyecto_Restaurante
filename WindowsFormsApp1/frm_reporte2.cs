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
    public partial class frm_reporte2 : Form
    {
        public frm_reporte2()
        {
            InitializeComponent();
        }

        private void frm_reporte2_Load(object sender, EventArgs e)
        {
            string fecha1 = dtp_fecha1.Value.ToString("yyyy-MM-dd");
            string fecha2 = dtp_fecha2.Value.ToString("yyyy-MM-dd");
            // TODO: esta línea de código carga datos en la tabla 'ds.DataTable1' Puede moverla o quitarla según sea necesario.
            this.dataTable2TableAdapter.Fill(this.ds.DataTable2,fecha1,fecha2);
            this.reportViewer2.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
