using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static CapaDatos.CD_Conexion;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void bt_iniciar_sesion_Click(object sender, EventArgs e)
        {
 
            SqlConnection conn = new SqlConnection("Data source = LAPTOP-NPNG2RBL; Initial Catalog = restaurante; User Id = sa; Password = admin;");
            SqlCommand cmd = new SqlCommand("SELECT * FROM empleados WHERE ID_Empleado = @username AND Contrasena = @password", conn);
            
            cmd.Parameters.AddWithValue("@username", txt_idempleado.Text);
            cmd.Parameters.AddWithValue("@password",txt_contra.Text);

            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                MessageBox.Show("Bienvenido al sistema!");
                this.Hide();
                MenuPrincipal frm = new MenuPrincipal(this);
                frm.Show();
            }
            else
            {
                MessageBox.Show("Usuario o Contraseña Incorrecto");
            }

            conn.Close();
        }

        private void bt_salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
