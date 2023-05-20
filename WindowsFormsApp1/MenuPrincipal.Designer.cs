namespace WindowsFormsApp1
{
    partial class MenuPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipal));
            this.bt_cerrar_sesion = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.pedidosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.realizarPedidoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaDePedidosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verMesasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estadoDeMesasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaDeVentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reservacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.confirmarReservacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaDeReservacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.empleadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.controlDeEmpleadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.controlDeClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generarFacturaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lb_fecha = new System.Windows.Forms.Label();
            this.lb_hora = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_cerrar_sesion
            // 
            this.bt_cerrar_sesion.BackColor = System.Drawing.Color.Gold;
            this.bt_cerrar_sesion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bt_cerrar_sesion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_cerrar_sesion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(26)))), ((int)(((byte)(36)))));
            this.bt_cerrar_sesion.Image = ((System.Drawing.Image)(resources.GetObject("bt_cerrar_sesion.Image")));
            this.bt_cerrar_sesion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_cerrar_sesion.Location = new System.Drawing.Point(559, 399);
            this.bt_cerrar_sesion.Name = "bt_cerrar_sesion";
            this.bt_cerrar_sesion.Size = new System.Drawing.Size(148, 40);
            this.bt_cerrar_sesion.TabIndex = 9;
            this.bt_cerrar_sesion.Text = "Cerrar sesion";
            this.bt_cerrar_sesion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_cerrar_sesion.UseVisualStyleBackColor = false;
            this.bt_cerrar_sesion.Click += new System.EventHandler(this.bt_cerrar_sesion_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(172, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 24);
            this.label1.TabIndex = 10;
            this.label1.Text = "Bienvenid@: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gold;
            this.label2.Location = new System.Drawing.Point(332, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 24);
            this.label2.TabIndex = 11;
            this.label2.Text = "---";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Gold;
            this.menuStrip1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pedidosToolStripMenuItem,
            this.comedoresToolStripMenuItem,
            this.ventasToolStripMenuItem,
            this.reservacionesToolStripMenuItem,
            this.empleadosToolStripMenuItem,
            this.clientesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(719, 28);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // pedidosToolStripMenuItem
            // 
            this.pedidosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.realizarPedidoToolStripMenuItem,
            this.consultaDePedidosToolStripMenuItem});
            this.pedidosToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(26)))), ((int)(((byte)(36)))));
            this.pedidosToolStripMenuItem.Name = "pedidosToolStripMenuItem";
            this.pedidosToolStripMenuItem.Size = new System.Drawing.Size(79, 24);
            this.pedidosToolStripMenuItem.Text = "Pedidos";
            // 
            // realizarPedidoToolStripMenuItem
            // 
            this.realizarPedidoToolStripMenuItem.BackColor = System.Drawing.Color.Gold;
            this.realizarPedidoToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(26)))), ((int)(((byte)(36)))));
            this.realizarPedidoToolStripMenuItem.Name = "realizarPedidoToolStripMenuItem";
            this.realizarPedidoToolStripMenuItem.Size = new System.Drawing.Size(229, 24);
            this.realizarPedidoToolStripMenuItem.Text = "Realizar pedido";
            this.realizarPedidoToolStripMenuItem.Click += new System.EventHandler(this.realizarPedidoToolStripMenuItem_Click);
            // 
            // consultaDePedidosToolStripMenuItem
            // 
            this.consultaDePedidosToolStripMenuItem.BackColor = System.Drawing.Color.Gold;
            this.consultaDePedidosToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(26)))), ((int)(((byte)(36)))));
            this.consultaDePedidosToolStripMenuItem.Name = "consultaDePedidosToolStripMenuItem";
            this.consultaDePedidosToolStripMenuItem.Size = new System.Drawing.Size(229, 24);
            this.consultaDePedidosToolStripMenuItem.Text = "Consulta de pedidos";
            this.consultaDePedidosToolStripMenuItem.Click += new System.EventHandler(this.consultaDePedidosToolStripMenuItem_Click);
            // 
            // comedoresToolStripMenuItem
            // 
            this.comedoresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verMesasToolStripMenuItem,
            this.estadoDeMesasToolStripMenuItem});
            this.comedoresToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(26)))), ((int)(((byte)(36)))));
            this.comedoresToolStripMenuItem.Name = "comedoresToolStripMenuItem";
            this.comedoresToolStripMenuItem.Size = new System.Drawing.Size(107, 24);
            this.comedoresToolStripMenuItem.Text = "Comedores";
            // 
            // verMesasToolStripMenuItem
            // 
            this.verMesasToolStripMenuItem.BackColor = System.Drawing.Color.Gold;
            this.verMesasToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(26)))), ((int)(((byte)(36)))));
            this.verMesasToolStripMenuItem.Name = "verMesasToolStripMenuItem";
            this.verMesasToolStripMenuItem.Size = new System.Drawing.Size(200, 24);
            this.verMesasToolStripMenuItem.Text = "Ver mesas";
            this.verMesasToolStripMenuItem.Click += new System.EventHandler(this.verMesasToolStripMenuItem_Click);
            // 
            // estadoDeMesasToolStripMenuItem
            // 
            this.estadoDeMesasToolStripMenuItem.BackColor = System.Drawing.Color.Gold;
            this.estadoDeMesasToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(26)))), ((int)(((byte)(36)))));
            this.estadoDeMesasToolStripMenuItem.Name = "estadoDeMesasToolStripMenuItem";
            this.estadoDeMesasToolStripMenuItem.Size = new System.Drawing.Size(200, 24);
            this.estadoDeMesasToolStripMenuItem.Text = "Estado de mesas";
            this.estadoDeMesasToolStripMenuItem.Click += new System.EventHandler(this.estadoDeMesasToolStripMenuItem_Click);
            // 
            // ventasToolStripMenuItem
            // 
            this.ventasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultaDeVentasToolStripMenuItem});
            this.ventasToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(26)))), ((int)(((byte)(36)))));
            this.ventasToolStripMenuItem.Name = "ventasToolStripMenuItem";
            this.ventasToolStripMenuItem.Size = new System.Drawing.Size(72, 24);
            this.ventasToolStripMenuItem.Text = "Ventas";
            // 
            // consultaDeVentasToolStripMenuItem
            // 
            this.consultaDeVentasToolStripMenuItem.BackColor = System.Drawing.Color.Gold;
            this.consultaDeVentasToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(26)))), ((int)(((byte)(36)))));
            this.consultaDeVentasToolStripMenuItem.Name = "consultaDeVentasToolStripMenuItem";
            this.consultaDeVentasToolStripMenuItem.Size = new System.Drawing.Size(220, 24);
            this.consultaDeVentasToolStripMenuItem.Text = "Consulta de ventas";
            this.consultaDeVentasToolStripMenuItem.Click += new System.EventHandler(this.consultaDeVentasToolStripMenuItem_Click);
            // 
            // reservacionesToolStripMenuItem
            // 
            this.reservacionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.confirmarReservacionToolStripMenuItem,
            this.consultaDeReservacionesToolStripMenuItem});
            this.reservacionesToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(26)))), ((int)(((byte)(36)))));
            this.reservacionesToolStripMenuItem.Name = "reservacionesToolStripMenuItem";
            this.reservacionesToolStripMenuItem.Size = new System.Drawing.Size(129, 24);
            this.reservacionesToolStripMenuItem.Text = "Reservaciones";
            // 
            // confirmarReservacionToolStripMenuItem
            // 
            this.confirmarReservacionToolStripMenuItem.BackColor = System.Drawing.Color.Gold;
            this.confirmarReservacionToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(26)))), ((int)(((byte)(36)))));
            this.confirmarReservacionToolStripMenuItem.Name = "confirmarReservacionToolStripMenuItem";
            this.confirmarReservacionToolStripMenuItem.Size = new System.Drawing.Size(274, 24);
            this.confirmarReservacionToolStripMenuItem.Text = "Confirmar reservacion";
            this.confirmarReservacionToolStripMenuItem.Click += new System.EventHandler(this.confirmarReservacionToolStripMenuItem_Click);
            // 
            // consultaDeReservacionesToolStripMenuItem
            // 
            this.consultaDeReservacionesToolStripMenuItem.BackColor = System.Drawing.Color.Gold;
            this.consultaDeReservacionesToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(26)))), ((int)(((byte)(36)))));
            this.consultaDeReservacionesToolStripMenuItem.Name = "consultaDeReservacionesToolStripMenuItem";
            this.consultaDeReservacionesToolStripMenuItem.Size = new System.Drawing.Size(274, 24);
            this.consultaDeReservacionesToolStripMenuItem.Text = "Consulta de reservaciones";
            this.consultaDeReservacionesToolStripMenuItem.Click += new System.EventHandler(this.consultaDeReservacionesToolStripMenuItem_Click);
            // 
            // empleadosToolStripMenuItem
            // 
            this.empleadosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.controlDeEmpleadosToolStripMenuItem});
            this.empleadosToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(26)))), ((int)(((byte)(36)))));
            this.empleadosToolStripMenuItem.Name = "empleadosToolStripMenuItem";
            this.empleadosToolStripMenuItem.Size = new System.Drawing.Size(101, 24);
            this.empleadosToolStripMenuItem.Text = "Empleados";
            // 
            // controlDeEmpleadosToolStripMenuItem
            // 
            this.controlDeEmpleadosToolStripMenuItem.BackColor = System.Drawing.Color.Gold;
            this.controlDeEmpleadosToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(26)))), ((int)(((byte)(36)))));
            this.controlDeEmpleadosToolStripMenuItem.Name = "controlDeEmpleadosToolStripMenuItem";
            this.controlDeEmpleadosToolStripMenuItem.Size = new System.Drawing.Size(242, 24);
            this.controlDeEmpleadosToolStripMenuItem.Text = "Control de empleados";
            this.controlDeEmpleadosToolStripMenuItem.Click += new System.EventHandler(this.controlDeEmpleadosToolStripMenuItem_Click);
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.controlDeClientesToolStripMenuItem,
            this.generarFacturaToolStripMenuItem});
            this.clientesToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(26)))), ((int)(((byte)(36)))));
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(79, 24);
            this.clientesToolStripMenuItem.Text = "Clientes";
            // 
            // controlDeClientesToolStripMenuItem
            // 
            this.controlDeClientesToolStripMenuItem.BackColor = System.Drawing.Color.Gold;
            this.controlDeClientesToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(26)))), ((int)(((byte)(36)))));
            this.controlDeClientesToolStripMenuItem.Name = "controlDeClientesToolStripMenuItem";
            this.controlDeClientesToolStripMenuItem.Size = new System.Drawing.Size(216, 24);
            this.controlDeClientesToolStripMenuItem.Text = "Control de clientes";
            this.controlDeClientesToolStripMenuItem.Click += new System.EventHandler(this.controlDeClientesToolStripMenuItem_Click);
            // 
            // generarFacturaToolStripMenuItem
            // 
            this.generarFacturaToolStripMenuItem.BackColor = System.Drawing.Color.Gold;
            this.generarFacturaToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(26)))), ((int)(((byte)(36)))));
            this.generarFacturaToolStripMenuItem.Name = "generarFacturaToolStripMenuItem";
            this.generarFacturaToolStripMenuItem.Size = new System.Drawing.Size(216, 24);
            this.generarFacturaToolStripMenuItem.Text = "Generar factura";
            this.generarFacturaToolStripMenuItem.Click += new System.EventHandler(this.generarFacturaToolStripMenuItem_Click);
            // 
            // lb_fecha
            // 
            this.lb_fecha.AutoSize = true;
            this.lb_fecha.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_fecha.ForeColor = System.Drawing.Color.Gold;
            this.lb_fecha.Location = new System.Drawing.Point(12, 423);
            this.lb_fecha.Name = "lb_fecha";
            this.lb_fecha.Size = new System.Drawing.Size(19, 16);
            this.lb_fecha.TabIndex = 14;
            this.lb_fecha.Text = "---";
            // 
            // lb_hora
            // 
            this.lb_hora.AutoSize = true;
            this.lb_hora.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_hora.ForeColor = System.Drawing.Color.Gold;
            this.lb_hora.Location = new System.Drawing.Point(187, 423);
            this.lb_hora.Name = "lb_hora";
            this.lb_hora.Size = new System.Drawing.Size(19, 16);
            this.lb_hora.TabIndex = 15;
            this.lb_hora.Text = "---";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(165, 73);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(369, 331);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(26)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(719, 448);
            this.Controls.Add(this.lb_hora);
            this.Controls.Add(this.lb_fecha);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_cerrar_sesion);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pictureBox1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MenuPrincipal";
            this.Text = "Menu principal";
            this.Load += new System.EventHandler(this.MenuPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button bt_cerrar_sesion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem pedidosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reservacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem confirmarReservacionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estadoDeMesasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem realizarPedidoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem empleadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem controlDeEmpleadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaDePedidosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaDeVentasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaDeReservacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem controlDeClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generarFacturaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verMesasToolStripMenuItem;
        private System.Windows.Forms.Label lb_fecha;
        private System.Windows.Forms.Label lb_hora;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}