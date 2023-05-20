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
    public partial class ReservacionConfirmada : Form
    {
        ConexionBD ConexionBD = new ConexionBD();
        public string id;
        public string telefono;

        public ReservacionConfirmada(string id,string telefono)
        {
            this.id = id;
            this.telefono = telefono;
        }

        public ReservacionConfirmada(ConfirmarReservacion frm, string id,string telefono)
        {
            InitializeComponent();
            this.id = id;
            this.telefono = telefono;

            lbl_ID.Text = id;
            lbl_telefono.Text = telefono;
            
            //string consultasql = "SELECT * FROM Reservaciones WHERE ID_Reservacion = " + id

            string consultasql = "SELECT r.ID_Reservacion, c.ID_Cliente , c.Nombre ,r.Fecha_Reservacion, r.Hora, c.telefono From Reservaciones as r join clientes as c on r.ID_Cliente = c.ID_Cliente where r.ID_Reservacion = " + lbl_ID.Text + " OR c.telefono = '" + lbl_telefono.Text + "'";

            ConexionBD.AbrirConexion();
            SqlCommand cmd = new SqlCommand(consultasql, ConexionBD.conexion);

            if (lbl_telefono.Text != "")
            {
                cmd.Parameters.AddWithValue("@telefono", telefono);
                SqlDataReader leer = cmd.ExecuteReader();

                if (leer.HasRows)
                {
                    while (leer.Read())
                    {
                        // Asignar los valores a los labels correspondientes
                        lbl_ID.Text = leer["ID_Reservacion"].ToString();
                        lbl_nombre.Text = leer["Nombre"].ToString();
                        lbl_fecha.Text = leer["Fecha_Reservacion"].ToString();
                        lbl_telefono.Text = leer["Telefono"].ToString();
                        lbl_hora.Text = leer["hora"].ToString();

                    }
                }
            }
            else if(lbl_ID.Text != ""){
                cmd.Parameters.AddWithValue("@ID_Reservacion", id);
                SqlDataReader leer = cmd.ExecuteReader();

                if (leer.HasRows)
                {
                    while (leer.Read())
                    {
                        // Asignar los valores a los labels correspondientes
                        lbl_ID.Text = leer["ID_Reservacion"].ToString();
                        lbl_nombre.Text = leer["Nombre"].ToString();
                        lbl_fecha.Text = leer["Fecha_Reservacion"].ToString();
                        lbl_telefono.Text = leer["Telefono"].ToString();
                        lbl_hora.Text = leer["hora"].ToString();

                    }
                }

            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
