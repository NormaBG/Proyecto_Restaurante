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
    public partial class ConfirmarReservacion : Form
    {
        ConexionBD conexion = new ConexionBD();
        public string id;
        public string telefono;
        public ConfirmarReservacion(MenuPrincipal frm)
        {
            InitializeComponent();
        }

        private void bt_confirmar_telefono_Click(object sender, EventArgs e)
        {
            ReservacionConfirmada frm = new ReservacionConfirmada(this, id, telefono);
            frm.Show();
        }

        private void bt_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_escanear_Click(object sender, EventArgs e)
        {
        }

        private void txt_qr_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                conexion.AbrirConexion();
                SqlCommand cmd = new SqlCommand("Select * From Reservaciones WHERE ID_Reservacion = " + txt_qr.Text, conexion.conexion);
                cmd.Parameters.AddWithValue("@ID_Reservacion", txt_qr.Text);
                SqlDataReader leer = cmd.ExecuteReader();

                if (leer.Read())
                {
                    MessageBox.Show("Reservacion encontrada");
                    string id = txt_qr.Text;
                    ReservacionConfirmada frm = new ReservacionConfirmada(this, id,id);
                    frm.Show();
                }
                else
                {
                    MessageBox.Show("Reservacion No Encontrada");
                }

                leer.Close();
                conexion.CerrarConexion();
            }
        }

        private void ConfirmarReservacion_Load(object sender, EventArgs e)
        {
        }

        private void txt_telefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                conexion.AbrirConexion();
                SqlCommand cmd = new SqlCommand("SELECT r.ID_Reservacion, c.Nombre, r.fecha_reservacion, r.hora, c.telefono from reservaciones as r join clientes as c on r.ID_Cliente = c.ID_Cliente where telefono = '" + txt_telefono.Text + "'", conexion.conexion);
                cmd.Parameters.AddWithValue("@telefono", txt_telefono.Text);
                SqlDataReader leer = cmd.ExecuteReader();

                if (leer.Read())
                {
                    MessageBox.Show("Reservacion encontrada");
                    string telefono = txt_telefono.Text;
                    ReservacionConfirmada frm = new ReservacionConfirmada(this, telefono, telefono);
                    frm.Show();
                }
                else
                {
                    MessageBox.Show("Reservacion No Encontrada");
                }

                leer.Close();
                conexion.CerrarConexion();
            }
        }
    }
}