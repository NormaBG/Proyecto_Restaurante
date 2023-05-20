using CapaDatos;
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
    public partial class ControlEmpleados : Form
    {
        ConexionBD operaciones = new ConexionBD();
        ConexionBD conexion = new ConexionBD();
        public ControlEmpleados(MenuPrincipal frm)
        {
            InitializeComponent();
            ConexionBD.CargarDatosEnDataGridView(dgv_controlempleados, "Select * from empleados");
            this.dgv_controlempleados.CellClick += new DataGridViewCellEventHandler(this.dgv_controlempleados_CellContentClick);

        }

        private void bt_agregar_Click(object sender, EventArgs e)
        {
            string ConsultaSQL = "Insert Into empleados(Nombre,Apellidos,Telefono,Domicilio,Contrasena) values (@nombre,@apellidos,@telefono,@domicilio,@Contrasena)";
            string nombre = txt_nombre.Text;
            string apellido = txt_apellidos.Text;
            string telefono = txt_telefono.Text;
            string domicilio = txt_domicilio.Text;
            string Contrasena = txt_contrasena.Text;
           
            int filasAfectadas =  operaciones.AgregarRegistro2(ConsultaSQL, nombre, apellido, telefono, domicilio, Contrasena);
            if (filasAfectadas > 0)
            {
                MessageBox.Show("Registro agregado correctamente");
            }
            else
            {
                MessageBox.Show("No se pudo agregar el registro");
            }

            ConexionBD.CargarDatosEnDataGridView(dgv_controlempleados, "Select * From Empleados");
        }

        private void bt_eliminar_Click(object sender, EventArgs e)
        {
            string ConsultaSQL = "DELETE from Empleados Where ID_Empleado = @idc";
            string id = txt_id_empleado.Text;

            int filasAfectadas = operaciones.EliminarRegistro(id, ConsultaSQL);
            if (filasAfectadas > 0)
            {
                MessageBox.Show("Empleado eliminado correctamente");
            }
            else
            {
                MessageBox.Show("No se pudo Eliminar el cliente");
            }

            ConexionBD.CargarDatosEnDataGridView(dgv_controlempleados, "Select * From Empleados");
        }
        
        private void bt_modificar_Click(object sender, EventArgs e)
        {
            string consulta = "UPDATE empleados SET Nombre = @nombre, Apellidos = @apellido, Telefono = @telefono, Domicilio = @domicilio, Contrasena = @contrasena WHERE ID_Empleado = @ide";
            
            int ide = Convert.ToInt32(txt_id_empleado.Text);
            string nombre = txt_nombre.Text;
            string apellido = txt_apellidos.Text;
            string telefono = txt_telefono.Text;
            string domicilio = txt_domicilio.Text;
            string contrasena = txt_contrasena.Text;


            int filasModificadas = operaciones.Modificar2(consulta, ide, nombre, apellido, telefono, domicilio, contrasena);

            if (filasModificadas > 0)
            {
                MessageBox.Show("Se modificó el empleado correctamente");
                ConexionBD.CargarDatosEnDataGridView(dgv_controlempleados, "Select * From Empleados where ID_Empleado = " + ide);
            }
            else
            {
                MessageBox.Show("No se encontró ningún empleado para modificar");
            }
        }

        private void bt_buscar_Click(object sender, EventArgs e)
        {
            string consulta = "SELECT * FROM empleados WHERE id_empleado = @id OR Nombre = @nombre";
            string id = txt_id_empleado.Text;
            string nombre = txt_nombre.Text;

            conexion.AbrirConexion();
            SqlDataReader reader = conexion.BuscarRegistro(consulta, id, nombre);

            if (txt_id_empleado.Text != "")
            {
                if (reader.HasRows)
                {
                    ConexionBD.CargarDatosEnDataGridView(dgv_controlempleados, "Select * From empleados where id_empleado = " + id);
                    while (reader.Read())
                    {
                        MessageBox.Show("Se encontro el cliente");

                        txt_nombre.Text = reader["nombre"].ToString();
                        txt_apellidos.Text = reader["apellidos"].ToString();
                        txt_telefono.Text = reader["telefono"].ToString();
                        txt_domicilio.Text = reader["domicilio"].ToString();
                        txt_contrasena.Text = reader["contrasena"].ToString();
                    }
                }
            }else if (txt_nombre.Text != "")
            {
                if (reader.HasRows)
                {
                    ConexionBD.CargarDatosEnDataGridView(dgv_controlempleados, "Select * From empleados where nombre = " + nombre);
                    while (reader.Read())
                    {
                        MessageBox.Show("Se encontro el cliente");

                        txt_nombre.Text = reader["nombre"].ToString();
                        txt_apellidos.Text = reader["apellidos"].ToString();
                        txt_telefono.Text = reader["telefono"].ToString();
                        txt_domicilio.Text = reader["domicilio"].ToString();
                        txt_contrasena.Text = reader["contrasena"].ToString();
                    }
                }
            }
            else
            {
                MessageBox.Show("No se encontró el cliente");
            }

            reader.Close();
            conexion.CerrarConexion();
        }

        private void bt_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_recargar_Click(object sender, EventArgs e)
        {
            ConexionBD.CargarDatosEnDataGridView(dgv_controlempleados, "Select * From Empleados");
            txt_id_empleado.Text = "";
            txt_nombre.Text = "";
            txt_apellidos.Text = "";
            txt_telefono.Text = "";
            txt_domicilio.Text = "";
            txt_contrasena.Text = "";
        }

        private void dgv_controlempleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgv_controlempleados.Rows[e.RowIndex];

                // Obtener los valores de las celdas seleccionadas
                string id_empleado = row.Cells["ID_Empleado"].Value.ToString();
                string nombre = row.Cells["nombre"].Value.ToString();
                string apellido = row.Cells["apellidos"].Value.ToString();
                string telefono = row.Cells["telefono"].Value.ToString();
                string domicilio = row.Cells["domicilio"].Value.ToString();
                string contrasena = row.Cells["contrasena"].Value.ToString();

                // Mostrar los valores en los TextBox correspondientes
                txt_id_empleado.Text = id_empleado;
                txt_nombre.Text = nombre;
                txt_apellidos.Text = apellido;
                txt_telefono.Text = telefono;
                txt_domicilio.Text = domicilio;
                txt_contrasena.Text = contrasena;

            }
        }
    }
}
