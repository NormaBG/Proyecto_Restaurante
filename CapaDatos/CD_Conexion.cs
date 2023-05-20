using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using static CapaDatos.CD_Conexion;
using System.Collections.Concurrent;
using System.Windows.Forms;
using Microsoft.Win32;


namespace CapaDatos
{
    public class CD_Conexion
    {
        public class ConexionBD : IDisposable
        {
            public SqlConnection conexion;

            public ConexionBD()
            {
                string cadenaConexion = "server=LAPTOP-NPNG2RBL;database=restaurante;Uid=sa;password=admin;";
                conexion = new SqlConnection(cadenaConexion);
            }

            public void AbrirConexion()
            {
                if (conexion.State == ConnectionState.Closed)
                {
                    conexion.Open();
                }
            }

            public void CerrarConexion()
            {
                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
            }

            public SqlConnection GetConexion()
            {
                return conexion;
            }

            public void Dispose()
            {
                conexion.Dispose();
            }

            public static void CargarDatosEnDataGridView(DataGridView dataGridView, string consulta)
            {
                using (ConexionBD conexion = new ConexionBD())
                {
                    conexion.AbrirConexion();

                    SqlCommand comando = new SqlCommand(consulta, conexion.GetConexion());
                    SqlDataReader reader = comando.ExecuteReader();

                    DataTable table = new DataTable();
                    table.Load(reader);

                    dataGridView.DataSource = table;

                    reader.Close();
                    conexion.CerrarConexion();
                }
            }
            public int AgregarRegistro(string ConsultaSQL, string nombre,string apellido,string telefono,string domicilio,string correo)
            {//controlclientes
                int filasAfectadas = 0;
               
                using (SqlCommand comando = new SqlCommand(ConsultaSQL, conexion))
                {
                    comando.Parameters.AddWithValue("@nombre", nombre);
                    comando.Parameters.AddWithValue("@apellido", apellido);
                    comando.Parameters.AddWithValue("@telefono", telefono);
                    comando.Parameters.AddWithValue("@domicilio", domicilio);
                    comando.Parameters.AddWithValue("@correo", correo);
                    try
                    {
                        conexion.Open();
                        filasAfectadas = comando.ExecuteNonQuery();
                    }
                    catch (SqlException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    finally
                    {
                        conexion.Close();
                    }
                }
                return filasAfectadas;
            }

            public int AgregarRegistro2(string ConsultaSQL, string nombre, string apellido, string telefono, string domicilio, string contrasena)
            {//controlempleados

                int filasAfectadas = 0;
                using (SqlCommand comando = new SqlCommand(ConsultaSQL, conexion))
                {
                    comando.Parameters.AddWithValue("@Nombre", nombre);
                    comando.Parameters.AddWithValue("@Apellidos", apellido);
                    comando.Parameters.AddWithValue("@Telefono", telefono);
                    comando.Parameters.AddWithValue("@Domicilio", domicilio);
                    comando.Parameters.AddWithValue("@Contrasena", contrasena);
                    try
                    {
                        conexion.Open();
                        filasAfectadas = comando.ExecuteNonQuery();
                    }
                    catch (SqlException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    finally
                    {
                        conexion.Close();
                    }
                }
                return filasAfectadas;
            }



            public int EliminarRegistro(string id,string ConsultaSQL)
            {//controlclientes, control empleados
                int filasAfectadas = 0;
                using (SqlCommand comando = new SqlCommand(ConsultaSQL, conexion))
                {
                    comando.Parameters.AddWithValue("@idc", id);
                    try
                    {
                        conexion.Open();
                        filasAfectadas = comando.ExecuteNonQuery();
                    }
                    catch (SqlException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    finally
                    {
                        conexion.Close();
                    }
                }
                return filasAfectadas;
            }

            public int Modificar(string consulta,int idCliente, string nombre, string apellido, string telefono, string domicilio, string correo)
            {//controlclientes
                int filasModificadas = 0;

                using (SqlCommand cmd = new SqlCommand(consulta, conexion))
                {
                    cmd.Parameters.AddWithValue("@idc", idCliente);
                    cmd.Parameters.AddWithValue("@nombre", nombre);
                    cmd.Parameters.AddWithValue("@apellido", apellido);
                    cmd.Parameters.AddWithValue("@telefono", telefono);
                    cmd.Parameters.AddWithValue("@domicilio", domicilio);
                    cmd.Parameters.AddWithValue("@correo", correo);
                    try
                    {
                        conexion.Open();
                        filasModificadas = cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                    finally
                    {
                        conexion.Close();
                    }
                }
                return filasModificadas;
            }

            public int Modificar2(string consulta, int ide, string nombre, string apellido, string telefono, string domicilio, string contrasena)
            {//controlempleados
                
                int filasModificadas = 0;
                using (SqlCommand cmd = new SqlCommand(consulta, conexion))
                {
                    cmd.Parameters.AddWithValue("@ide", ide);
                    cmd.Parameters.AddWithValue("@nombre", nombre);
                    cmd.Parameters.AddWithValue("@apellido", apellido);
                    cmd.Parameters.AddWithValue("@telefono", telefono);
                    cmd.Parameters.AddWithValue("@domicilio", domicilio);
                    cmd.Parameters.AddWithValue("@contrasena", contrasena);
                    try
                    {
                        conexion.Open();
                        filasModificadas = cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                    finally
                    {
                        conexion.Close();
                    }
                }
                return filasModificadas;
            }

            public SqlDataReader BuscarRegistro(string consulta,string id,string nombre) //controlclientes y empleados
            {
                SqlCommand comando = new SqlCommand(consulta, conexion);
                SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);
                comando.Parameters.AddWithValue("@id", id);
                comando.Parameters.AddWithValue("@nombre", nombre);
                SqlDataReader reader = comando.ExecuteReader();
                return reader;
            }

            public SqlDataReader BuscarRegistro(string consulta, string id, string idc, string fecha_r,string fecha_reservacion, string estatus) //reservaciones
            {
                SqlCommand comando = new SqlCommand(consulta, conexion);
                comando.Parameters.AddWithValue("@id", id);
                comando.Parameters.AddWithValue("@idc", idc);
                comando.Parameters.AddWithValue("@fecha_r",fecha_r);
                comando.Parameters.AddWithValue("@fecha_reservacion", fecha_reservacion);
                comando.Parameters.AddWithValue("@estatus", estatus);   
                SqlDataReader reader = comando.ExecuteReader();
                return reader;
            }

        }

    }


}
