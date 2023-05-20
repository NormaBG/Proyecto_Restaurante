using CapaDatos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static CapaDatos.CD_Conexion;

namespace WindowsFormsApp1
{
    public partial class ControlClientes : Form
    {
        ConexionBD operaciones = new ConexionBD();
        ConexionBD conexion = new ConexionBD();

        public ControlClientes(MenuPrincipal frm)
        {
            //muestro el datagrid al abrirse la pantalla para tener una vista de los clientes desde el principio
            InitializeComponent();
            ConexionBD.CargarDatosEnDataGridView(dgw_Consultaclientes, "Select * From Clientes");
            this.dgw_Consultaclientes.CellClick += new DataGridViewCellEventHandler(this.dgw_Consultaclientes_CellContentClick);

        }
        private void bt_agregar_Click(object sender, EventArgs e)
        {
            string ConsultaSQL = "Insert Into Clientes(Nombre,Apellido,Telefono,Domicilio,Correo) values (@nombre,@apellido,@telefono,@domicilio,@correo)";
            string nombre = txt_nombre.Text;
            string apellido = txt_apellidos.Text;
            string telefono = txt_telefono.Text;
            string domicilio = txt_domicilio.Text;
            string correo = txt_Correo.Text;

            int filasAfectadas = operaciones.AgregarRegistro(ConsultaSQL, nombre,apellido,telefono,domicilio,correo);
            if (filasAfectadas > 0)
            {
                MessageBox.Show("Cliente agregado correctamente");
            }
            else
            {
                MessageBox.Show("No se pudo agregar al cliente");
            }

            ConexionBD.CargarDatosEnDataGridView(dgw_Consultaclientes, "Select * From Clientes");
        }

        private void bt_eliminar_Click(object sender, EventArgs e)
        {
            string ConsultaSQL = "DELETE from Clientes Where ID_Cliente = @idc";
            string id = txt_id_cliente.Text;

            int filasAfectadas = operaciones.EliminarRegistro(id,ConsultaSQL);
            if (filasAfectadas > 0)
            {
                MessageBox.Show("Cliente eliminado correctamente");
            }
            else
            {
                MessageBox.Show("No se pudo eliminar el cliente");
            }

            ConexionBD.CargarDatosEnDataGridView(dgw_Consultaclientes, "Select * From Clientes");
        }
        
        private void bt_modificar_Click(object sender, EventArgs e)
        {
            string consulta = "UPDATE Clientes SET Nombre = @nombre, Apellido = @apellido, telefono = @telefono, domicilio = @domicilio, correo = @correo WHERE ID_Cliente = @idc";
            int id = Convert.ToInt32(txt_id_cliente.Text);
            string nombre = txt_nombre.Text;
            string apellido = txt_apellidos.Text;
            string telefono = txt_telefono.Text;
            string domicilio = txt_domicilio.Text;
            string correo = txt_Correo.Text;

            int filasModificadas = conexion.Modificar(consulta,id, nombre, apellido, telefono, domicilio, correo);

            if (filasModificadas > 0)
            {
                MessageBox.Show("Se modificó el cliente correctamente");
                ConexionBD.CargarDatosEnDataGridView(dgw_Consultaclientes, "Select * From Clientes where ID_Cliente = " + id);
            }
            else
            {
                MessageBox.Show("No se encontró ningún cliente para modificar");
            }
        }

        private void bt_buscar_Click(object sender, EventArgs e)
        {
            string consulta = "SELECT * FROM clientes WHERE id_cliente = @id OR Nombre = @nombre";
            string id = txt_id_cliente.Text;
            string nombre = txt_nombre.Text;

            conexion.AbrirConexion();
            SqlDataReader reader = conexion.BuscarRegistro(consulta,id,nombre);

            string consulta2 = "";

            if (txt_id_cliente.Text != "")
            {
                consulta2 = "SELECT * FROM clientes where id_cliente = " + txt_id_cliente.Text;
            }else if (txt_nombre.Text != "")
            {
                consulta2 = "SELECT * FROM clientes where Nombre = '" + txt_nombre.Text + "'";
            }

            if (reader.HasRows)
            {
               
                while (reader.Read())
                {
                    txt_nombre.Text = reader["nombre"].ToString();
                    txt_apellidos.Text = reader["apellido"].ToString();
                    txt_telefono.Text = reader["telefono"].ToString();
                    txt_domicilio.Text = reader["domicilio"].ToString();
                    txt_Correo.Text = reader["correo"].ToString();
                }
                MessageBox.Show("Se encontro el cliente");
                ConexionBD.CargarDatosEnDataGridView(dgw_Consultaclientes, consulta2);
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

        private void dgw_Consultaclientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgw_Consultaclientes.Rows[e.RowIndex];

                // Obtener los valores de las celdas seleccionadas
                string idCliente = row.Cells["id_cliente"].Value.ToString();
                string nombre = row.Cells["nombre"].Value.ToString();
                string apellido = row.Cells["apellido"].Value.ToString();
                string telefono = row.Cells["telefono"].Value.ToString();
                string domicilio = row.Cells["domicilio"].Value.ToString();
                string correo = row.Cells["correo"].Value.ToString();

                // Mostrar los valores en los TextBox correspondientes
                txt_id_cliente.Text = idCliente;
                txt_nombre.Text = nombre;
                txt_apellidos.Text = apellido;
                txt_telefono.Text = telefono;
                txt_domicilio.Text = domicilio;
                txt_Correo.Text = correo;

            }
        }

        private void btn_recargar_Click(object sender, EventArgs e)
        {
            ConexionBD.CargarDatosEnDataGridView(dgw_Consultaclientes, "Select * From Clientes");
            txt_id_cliente.Text = "";
            txt_nombre.Text = "";
            txt_apellidos.Text = "";
            txt_telefono.Text = "";
            txt_domicilio.Text = "";
            txt_Correo.Text = "";
        }
    }
}
