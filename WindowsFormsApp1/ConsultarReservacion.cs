using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static CapaDatos.CD_Conexion;


namespace WindowsFormsApp1
{
    public partial class ConsultarReservacion : Form
    {
        ConexionBD conexion = new ConexionBD();

        public ConsultarReservacion(MenuPrincipal frm)
        {
            InitializeComponent();
            ConexionBD.CargarDatosEnDataGridView(dgv_reservaciones, "Select * From Reservaciones");
            this.dgv_reservaciones.CellClick += new DataGridViewCellEventHandler(this.dgv_reservaciones_CellContentClick);
        }

        private void bt_buscar_Click_1(object sender, EventArgs e)
        {
            string consulta = "SELECT * FROM reservaciones WHERE id_Reservacion = @id OR id_cliente = @idc OR Fecha_Realizada = @fecha_r or Fecha_Reservacion = @fecha_reservacion or estatus = @estatus";
            string id = tx_id_reservacion.Text;
            string idc = tx_id_cliente.Text;
            string fecha_r = dtp_fecha_realizada.Text;
            string fecha_reservacion = dtp_fecha_reservacion.Text;
            string estatus = cb_estatus.Text;

            conexion.AbrirConexion();
            SqlDataReader reader = conexion.BuscarRegistro(consulta, id, idc, fecha_r, fecha_reservacion,estatus);

            string consulta2 = "";
            if (tx_id_reservacion.Text != "")
            {
                consulta2 = "SELECT * FROM reservaciones WHERE id_Reservacion = " + tx_id_reservacion.Text;
            }
            else if (tx_id_cliente.Text != "")
            {
                consulta2 = "select reservaciones.*, clientes.Nombre as nombre_cliente from reservaciones inner join clientes on reservaciones.id_cliente = clientes.id_cliente where reservaciones.id_cliente = " + idc;
            }
            else if (cb_estatus.Text == "1.- Realizada")
            {
                consulta2 = "SELECT * FROM reservaciones where estatus = '1.- Realizada' ";
            }
            else if (cb_estatus.Text == "2.- Cancelada")
            {
                consulta2 = "SELECT * FROM reservaciones where estatus = '2.- Cancelada' ";
            }
            else if (dtp_fecha_realizada.Checked)
            {
                consulta2 = "SELECT * FROM reservaciones WHERE Fecha_Realizada = CONVERT(date, '" + dtp_fecha_realizada.Value.ToString("yyyy-MM-dd") + "', 120)";
            }else if(dtp_fecha_reservacion.Checked)
            {
                consulta2 = "SELECT * FROM reservaciones WHERE Fecha_Reservacion = CONVERT(date, '" + dtp_fecha_reservacion.Value.ToString("yyyy-MM-dd") + "', 120)";
            
            }

            MessageBox.Show("Consulta 2: " + consulta2 );

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    tx_id_cliente.Text = reader["ID_Cliente"].ToString();
                    tx_id_reservacion.Text = reader["ID_Reservacion"].ToString();
                    tx_hora.Text = reader["Hora"].ToString();
                    cb_estatus.Text = reader["estatus"].ToString();
                    dtp_fecha_realizada.Text = reader["Fecha_Realizada"].ToString();
                    dtp_fecha_reservacion.Text = reader["Fecha_Reservacion"].ToString();
                }

                MessageBox.Show("Se encontró el registro");
                ConexionBD.CargarDatosEnDataGridView(dgv_reservaciones, consulta2);
            }
            else
            {
                MessageBox.Show("No se encontró el registro");
                

            }
            reader.Close();
            conexion.CerrarConexion();
        }

        private void bt_actualizar_Click(object sender, EventArgs e)
        {
            tx_id_cliente.Text = "";
            tx_id_reservacion.Text = "";
            dtp_fecha_realizada.Value = DateTime.Now;
            dtp_fecha_reservacion.Value = DateTime.Now;
            cb_estatus.ResetText();
            
            ConexionBD.CargarDatosEnDataGridView(dgv_reservaciones, "Select * From Reservaciones");
        }
        
        private void bt_salir_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgv_reservaciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgv_reservaciones.Rows[e.RowIndex];

                // Obtener los valores de las celdas seleccionadas
                string id = row.Cells["ID_Reservacion"].Value.ToString();
                string idc = row.Cells["ID_Cliente"].Value.ToString();
                string fr = row.Cells["Fecha_Realizada"].Value.ToString();
                string fr2 = row.Cells["Fecha_Reservacion"].Value.ToString();
                string hora = row.Cells["Hora"].Value.ToString();
                string estatus = row.Cells["estatus"].Value.ToString();

                // Mostrar los valores en los TextBox correspondientes
                tx_id_reservacion.Text = id;
                tx_id_cliente.Text = idc;
                dtp_fecha_realizada.Text = fr;
                dtp_fecha_reservacion.Text = fr2;
                tx_hora.Text = hora;
                cb_estatus.Text = estatus;
             

            }
        }

        private void btn_reporteReservacion_Click(object sender, EventArgs e)
        {
            frm_reporte2 reporte = new frm_reporte2();

            reporte.dtp_fecha1.Text = this.dtp_fecha_realizada.Text;
            reporte.dtp_fecha2.Text = this.dtp_fecha_reservacion.Text;

            reporte.Show();


        }
    }
}
