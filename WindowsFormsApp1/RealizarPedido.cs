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
    public partial class RealizarPedido : Form
    {
        public RealizarPedido(MenuPrincipal frm)
        {
            InitializeComponent();
        }

        private void bt_platillo1_Click(object sender, EventArgs e)
        {

        }

        private void bt_platillo2_Click(object sender, EventArgs e)
        {

        }

        private void bt_platillo3_Click(object sender, EventArgs e)
        {

        }

        private void bt_platillo4_Click(object sender, EventArgs e)
        {

        }

        private void bt_platillo5_Click(object sender, EventArgs e)
        {

        }

        private void bt_platillo6_Click(object sender, EventArgs e)
        {

        }

        private void bt_bebida2_Click(object sender, EventArgs e)
        {

        }

        private void bt_bebida3_Click(object sender, EventArgs e)
        {

        }

        private void bt_bebida4_Click(object sender, EventArgs e)
        {

        }

        private void bt_bebida5_Click(object sender, EventArgs e)
        {

        }

        private void bt_bebida6_Click(object sender, EventArgs e)
        {

        }

        private void bt_postre1_Click(object sender, EventArgs e)
        {

        }

        private void bt_postre2_Click(object sender, EventArgs e)
        {

        }

        private void bt_postre3_Click(object sender, EventArgs e)
        {

        }

        private void bt_postre4_Click(object sender, EventArgs e)
        {

        }

        private void bt_postre5_Click(object sender, EventArgs e)
        {

        }

        private void bt_postre6_Click(object sender, EventArgs e)
        {

        }

        private void bt_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_generar_cuenta_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cuenta generada con exito");
            lb_area.Visible = false;
            tx_area.Text = "";
            tx_area.Visible = false;
            lb_mesa.Visible = false;
            tx_mesa.Text = "";
            tx_mesa.Visible = false;
            bt_retroceder_sucursal.Visible = false;
            bt_retroceder_llevar.Visible = false;
            lb_telefono_cliente.Visible = false;
            tx_telefono_cliente.Text = "";
            tx_telefono_cliente.Visible = false;
            lb_direccion.Visible = false;
            tx_direccion.Text = "";
            tx_direccion.Visible = false;
            bt_retroceder_domicilio.Visible = false;
            rb_sucursal.Visible = true;
            rb_sucursal.Checked = false;
            rb_llevar.Visible = true;
            rb_llevar.Checked = false;
            rb_domicilio.Visible = true;
            rb_domicilio.Checked = false;
            bt_confirmar.Visible = true;
            bt_platillo1.Enabled = false;
            bt_platillo2.Enabled = false;
            bt_platillo3.Enabled = false;
            bt_platillo4.Enabled = false;
            bt_platillo5.Enabled = false;
            bt_platillo6.Enabled = false;
            bt_bebida1.Enabled = false;
            bt_bebida2.Enabled = false;
            bt_bebida3.Enabled = false;
            bt_bebida4.Enabled = false;
            bt_bebida5.Enabled = false;
            bt_bebida6.Enabled = false;
            bt_postre1.Enabled = false;
            bt_postre2.Enabled = false;
            bt_postre3.Enabled = false;
            bt_postre4.Enabled = false;
            bt_postre5.Enabled = false;
            bt_postre6.Enabled = false;
            bt_generar_cuenta.Enabled = false;
        }

        private void bt_confirmar_Click(object sender, EventArgs e)
        {
            if (rb_sucursal.Checked)
            {
                rb_sucursal.Visible = false;
                rb_llevar.Visible = false;
                rb_domicilio.Visible = false;
                bt_confirmar.Visible = false;
                lb_area.Visible = true;
                tx_area.Visible = true;
                lb_mesa.Visible = true;
                tx_mesa.Visible = true;
                bt_retroceder_sucursal.Visible = true;
                bt_generar_cuenta.Enabled = true;
            }
            else if (rb_llevar.Checked)
            {
                rb_sucursal.Visible = false;
                rb_llevar.Visible = false;
                rb_domicilio.Visible = false;
                bt_confirmar.Visible = false;
                bt_retroceder_llevar.Visible = true;
                bt_generar_cuenta.Enabled = true;
            }
            else if (rb_domicilio.Checked)
            {
                rb_sucursal.Visible = false;
                rb_llevar.Visible = false;
                rb_domicilio.Visible = false;
                bt_confirmar.Visible = false;
                lb_telefono_cliente.Visible = true;
                tx_telefono_cliente.Visible = true;
                lb_direccion.Visible = true;
                tx_direccion.Visible = true;
                bt_retroceder_domicilio.Visible = true;
                bt_generar_cuenta.Enabled = true;
            }
            bt_platillo1.Enabled = true;
            bt_platillo2.Enabled = true;
            bt_platillo3.Enabled = true;
            bt_platillo4.Enabled = true;
            bt_platillo5.Enabled = true;
            bt_platillo6.Enabled = true;
            bt_bebida1.Enabled = true;
            bt_bebida2.Enabled = true;
            bt_bebida3.Enabled = true;
            bt_bebida4.Enabled = true;
            bt_bebida5.Enabled = true;
            bt_bebida6.Enabled = true;
            bt_postre1.Enabled = true;
            bt_postre2.Enabled = true;
            bt_postre3.Enabled = true;
            bt_postre4.Enabled = true;
            bt_postre5.Enabled = true;
            bt_postre6.Enabled = true;
        }

        private void bt_retroceder_sucursal_Click(object sender, EventArgs e)
        {
            rb_sucursal.Visible = true;
            rb_llevar.Visible = true;
            rb_domicilio.Visible = true;
            lb_area.Visible = false;
            tx_area.Text = "";
            tx_area.Visible = false;
            lb_mesa.Visible = false;
            tx_mesa.Text = "";
            tx_mesa.Visible = false;
            bt_retroceder_sucursal.Visible = false;
            bt_confirmar.Visible = true;
            bt_generar_cuenta.Enabled = false;
            bt_platillo1.Enabled = false;
            bt_platillo2.Enabled = false;
            bt_platillo3.Enabled = false;
            bt_platillo4.Enabled = false;
            bt_platillo5.Enabled = false;
            bt_platillo6.Enabled = false;
            bt_bebida1.Enabled = false;
            bt_bebida2.Enabled = false;
            bt_bebida3.Enabled = false;
            bt_bebida4.Enabled = false;
            bt_bebida5.Enabled = false;
            bt_bebida6.Enabled = false;
            bt_postre1.Enabled = false;
            bt_postre2.Enabled = false;
            bt_postre3.Enabled = false;
            bt_postre4.Enabled = false;
            bt_postre5.Enabled = false;
            bt_postre6.Enabled = false;
        }

        private void bt_retroceder_llevar_Click(object sender, EventArgs e)
        {
            rb_sucursal.Visible = true;
            rb_llevar.Visible = true;
            rb_domicilio.Visible = true;
            bt_retroceder_llevar.Visible = false;
            bt_confirmar.Visible = true;
            bt_generar_cuenta.Enabled = false;
            bt_platillo1.Enabled = false;
            bt_platillo2.Enabled = false;
            bt_platillo3.Enabled = false;
            bt_platillo4.Enabled = false;
            bt_platillo5.Enabled = false;
            bt_platillo6.Enabled = false;
            bt_bebida1.Enabled = false;
            bt_bebida2.Enabled = false;
            bt_bebida3.Enabled = false;
            bt_bebida4.Enabled = false;
            bt_bebida5.Enabled = false;
            bt_bebida6.Enabled = false;
            bt_postre1.Enabled = false;
            bt_postre2.Enabled = false;
            bt_postre3.Enabled = false;
            bt_postre4.Enabled = false;
            bt_postre5.Enabled = false;
            bt_postre6.Enabled = false;
        }

        private void bt_retroceder_domicilio_Click(object sender, EventArgs e)
        {
            rb_sucursal.Visible = true;
            rb_llevar.Visible = true;
            rb_domicilio.Visible = true;
            lb_telefono_cliente.Visible = false;
            tx_telefono_cliente.Text = "";
            tx_telefono_cliente.Visible = false;
            lb_direccion.Visible = false;
            tx_direccion.Text = "";
            tx_direccion.Visible = false;
            bt_retroceder_domicilio.Visible = false;
            bt_confirmar.Visible = true;
            bt_generar_cuenta.Enabled = false;
            bt_platillo1.Enabled = false;
            bt_platillo2.Enabled = false;
            bt_platillo3.Enabled = false;
            bt_platillo4.Enabled = false;
            bt_platillo5.Enabled = false;
            bt_platillo6.Enabled = false;
            bt_bebida1.Enabled = false;
            bt_bebida2.Enabled = false;
            bt_bebida3.Enabled = false;
            bt_bebida4.Enabled = false;
            bt_bebida5.Enabled = false;
            bt_bebida6.Enabled = false;
            bt_postre1.Enabled = false;
            bt_postre2.Enabled = false;
            bt_postre3.Enabled = false;
            bt_postre4.Enabled = false;
            bt_postre5.Enabled = false;
            bt_postre6.Enabled = false;
        }
    }
}
