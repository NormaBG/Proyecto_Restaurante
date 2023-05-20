using CapaDatos;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static CapaDatos.CD_Conexion;

namespace WindowsFormsApp1
{
    public partial class ConsultaVentas : Form
    {
        ConexionBD conexion = new ConexionBD();
        public ConsultaVentas(MenuPrincipal frm)
        {
            InitializeComponent();
            ConexionBD.CargarDatosEnDataGridView(dgv_consultaventas, "Select * From ventas");
            this.dgv_consultaventas.CellClick += new DataGridViewCellEventHandler(this.dgv_consultaventas_CellContentClick);
        }

        private void bt_buscar_Click(object sender, EventArgs e)
        {
            string consulta = "SELECT * FROM ventas where ID_Venta = @id_venta OR ID_Empleado = @id_empleado OR Fecha = @fecha1 OR Monto = @monto";
            
            string id_venta = txt_id_venta.Text;
            string id_empleado = txt_id_EmpleadoV.Text;
            string fecha1 = dtp_fecha.Text;
            string monto = txt_monto.Text;

            conexion.AbrirConexion();
        }

        private void bt_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgv_consultaventas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgv_consultaventas.Rows[e.RowIndex];

                // Obtener los valores de las celdas seleccionadas
                string id_venta = row.Cells["ID_Venta"].Value.ToString();
                string id_empleado = row.Cells["ID_Empleado"].Value.ToString();
                string monto = row.Cells["Monto"].Value.ToString();
                string fecha = row.Cells["Fecha"].Value.ToString();

                // Mostrar los valores en los TextBox correspondientes
                txt_id_venta.Text = id_venta;
                txt_id_EmpleadoV.Text = id_empleado;
                txt_monto.Text = monto;
                dtp_fecha.Text = fecha;

            }
        }

        private void ConsultaVentas_Load(object sender, EventArgs e)
        {
       
        }

        private void btn_reporte_Click(object sender, EventArgs e)
        {
            frm_reporte formulario2 = new frm_reporte();
            string opcion = cb_tiporeporte.Text;

            switch (opcion)
            {
                case "Empleados":
                    formulario2.txt_nom.Text = this.txt_id_EmpleadoV.Text;
                    formulario2.Show();
                    break;
                case "Fechas":
                    formulario2.dtp_fecha.Text = this.dtp_fecha.Text;
                    formulario2.dtp_fecha2.Text = this.dtp_fecha2.Text;
                    formulario2.Show();
                    break;
            }





        }   
    }
}
