using CapaDatos;
using Microsoft.Reporting.WinForms;
using Microsoft.ReportingServices.Diagnostics.Internal;
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
using static WindowsFormsApp1.Form1;
namespace WindowsFormsApp1
{
    public partial class MenuPrincipal : Form
    {

        public MenuPrincipal(Form1 form)
        {
            InitializeComponent();
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lb_hora.Text = DateTime.Now.ToString("hh:mm:ss");
            lb_fecha.Text = DateTime.Now.ToLongDateString();
        }

        private void realizarPedidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RealizarPedido frm = new RealizarPedido(this);
            frm.Show();
        }

        private void consultaDePedidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultaPedidos frm = new ConsultaPedidos(this);
            frm.Show();
        }
        
        private void verMesasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mesas frm = new Mesas(this);
            frm.Show();
        }

        private void estadoDeMesasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EstadoMesas frm = new EstadoMesas(this);
            frm.Show();
        }

        private void consultaDeVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultaVentas frm = new ConsultaVentas(this);
            frm.Show();
        }

        private void confirmarReservacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConfirmarReservacion frm = new ConfirmarReservacion(this);
            frm.Show();
        }

        private void consultaDeReservacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultarReservacion frm = new ConsultarReservacion(this);
            frm.Show();
        }

        private void controlDeEmpleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ControlEmpleados frm = new ControlEmpleados(this);
            frm.Show();
        }

        private void controlDeClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ControlClientes frm = new ControlClientes(this);
            frm.Show();
        }

        private void generarFacturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Facturas frm = new Facturas(this);
            frm.Show();
        }

        private void bt_cerrar_sesion_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 frm = new Form1();
            frm.Show();
        }


    }
}
