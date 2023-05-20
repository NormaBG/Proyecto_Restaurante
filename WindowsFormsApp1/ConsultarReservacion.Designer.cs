namespace WindowsFormsApp1
{
    partial class ConsultarReservacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultarReservacion));
            this.bt_salir = new System.Windows.Forms.Button();
            this.bt_buscar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cb_estatus = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tx_hora = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtp_fecha_reservacion = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dtp_fecha_realizada = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.tx_id_cliente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tx_id_reservacion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_reservaciones = new System.Windows.Forms.DataGridView();
            this.bt_actualizar = new System.Windows.Forms.Button();
            this.btn_reporteReservacion = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_Telefono = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_reservaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_salir
            // 
            this.bt_salir.BackColor = System.Drawing.Color.Gold;
            this.bt_salir.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_salir.Image = ((System.Drawing.Image)(resources.GetObject("bt_salir.Image")));
            this.bt_salir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_salir.Location = new System.Drawing.Point(345, 435);
            this.bt_salir.Name = "bt_salir";
            this.bt_salir.Size = new System.Drawing.Size(78, 38);
            this.bt_salir.TabIndex = 9;
            this.bt_salir.Text = "Salir";
            this.bt_salir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_salir.UseVisualStyleBackColor = false;
            this.bt_salir.Click += new System.EventHandler(this.bt_salir_Click_1);
            // 
            // bt_buscar
            // 
            this.bt_buscar.BackColor = System.Drawing.Color.Gold;
            this.bt_buscar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_buscar.Image = ((System.Drawing.Image)(resources.GetObject("bt_buscar.Image")));
            this.bt_buscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_buscar.Location = new System.Drawing.Point(450, 172);
            this.bt_buscar.Name = "bt_buscar";
            this.bt_buscar.Size = new System.Drawing.Size(101, 38);
            this.bt_buscar.TabIndex = 6;
            this.bt_buscar.Text = "Buscar";
            this.bt_buscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_buscar.UseVisualStyleBackColor = false;
            this.bt_buscar.Click += new System.EventHandler(this.bt_buscar_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_Telefono);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cb_estatus);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.tx_hora);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.dtp_fecha_reservacion);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dtp_fecha_realizada);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tx_id_cliente);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tx_id_reservacion);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.Color.Gold;
            this.groupBox1.Location = new System.Drawing.Point(11, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(730, 156);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de reservacion";
            // 
            // cb_estatus
            // 
            this.cb_estatus.FormattingEnabled = true;
            this.cb_estatus.Items.AddRange(new object[] {
            "1.- Realizada",
            "2.- Cancelada"});
            this.cb_estatus.Location = new System.Drawing.Point(219, 114);
            this.cb_estatus.Name = "cb_estatus";
            this.cb_estatus.Size = new System.Drawing.Size(121, 21);
            this.cb_estatus.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Gold;
            this.label9.Location = new System.Drawing.Point(143, 115);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 21);
            this.label9.TabIndex = 18;
            this.label9.Text = "Estatus:";
            // 
            // tx_hora
            // 
            this.tx_hora.Location = new System.Drawing.Point(612, 33);
            this.tx_hora.Name = "tx_hora";
            this.tx_hora.Size = new System.Drawing.Size(100, 20);
            this.tx_hora.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Gold;
            this.label5.Location = new System.Drawing.Point(555, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 21);
            this.label5.TabIndex = 12;
            this.label5.Text = "Hora:";
            // 
            // dtp_fecha_reservacion
            // 
            this.dtp_fecha_reservacion.CustomFormat = "yyyy-MM-dd";
            this.dtp_fecha_reservacion.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_fecha_reservacion.Location = new System.Drawing.Point(526, 76);
            this.dtp_fecha_reservacion.Name = "dtp_fecha_reservacion";
            this.dtp_fecha_reservacion.Size = new System.Drawing.Size(198, 20);
            this.dtp_fecha_reservacion.TabIndex = 11;
            this.dtp_fecha_reservacion.Value = new System.DateTime(2023, 3, 26, 18, 5, 26, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gold;
            this.label3.Location = new System.Drawing.Point(346, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 21);
            this.label3.TabIndex = 10;
            this.label3.Text = "Fecha de reservacion:";
            // 
            // dtp_fecha_realizada
            // 
            this.dtp_fecha_realizada.CustomFormat = "yyyy-MM-dd";
            this.dtp_fecha_realizada.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_fecha_realizada.Location = new System.Drawing.Point(142, 76);
            this.dtp_fecha_realizada.Name = "dtp_fecha_realizada";
            this.dtp_fecha_realizada.Size = new System.Drawing.Size(198, 20);
            this.dtp_fecha_realizada.TabIndex = 9;
            this.dtp_fecha_realizada.Value = new System.DateTime(2023, 4, 12, 0, 0, 0, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gold;
            this.label4.Location = new System.Drawing.Point(6, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 21);
            this.label4.TabIndex = 8;
            this.label4.Text = "Fecha realizada:";
            // 
            // tx_id_cliente
            // 
            this.tx_id_cliente.Location = new System.Drawing.Point(429, 34);
            this.tx_id_cliente.Name = "tx_id_cliente";
            this.tx_id_cliente.Size = new System.Drawing.Size(100, 20);
            this.tx_id_cliente.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gold;
            this.label2.Location = new System.Drawing.Point(310, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "ID de cliente:";
            // 
            // tx_id_reservacion
            // 
            this.tx_id_reservacion.Location = new System.Drawing.Point(176, 33);
            this.tx_id_reservacion.Name = "tx_id_reservacion";
            this.tx_id_reservacion.Size = new System.Drawing.Size(100, 20);
            this.tx_id_reservacion.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(20, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID de reservacion:";
            // 
            // dgv_reservaciones
            // 
            this.dgv_reservaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_reservaciones.Location = new System.Drawing.Point(11, 216);
            this.dgv_reservaciones.Name = "dgv_reservaciones";
            this.dgv_reservaciones.Size = new System.Drawing.Size(730, 213);
            this.dgv_reservaciones.TabIndex = 7;
            this.dgv_reservaciones.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_reservaciones_CellContentClick);
            // 
            // bt_actualizar
            // 
            this.bt_actualizar.BackColor = System.Drawing.Color.Gold;
            this.bt_actualizar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_actualizar.Image = ((System.Drawing.Image)(resources.GetObject("bt_actualizar.Image")));
            this.bt_actualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_actualizar.Location = new System.Drawing.Point(196, 172);
            this.bt_actualizar.Name = "bt_actualizar";
            this.bt_actualizar.Size = new System.Drawing.Size(131, 38);
            this.bt_actualizar.TabIndex = 10;
            this.bt_actualizar.Text = "Actualizar";
            this.bt_actualizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_actualizar.UseVisualStyleBackColor = false;
            this.bt_actualizar.Click += new System.EventHandler(this.bt_actualizar_Click);
            // 
            // btn_reporteReservacion
            // 
            this.btn_reporteReservacion.BackColor = System.Drawing.Color.Gold;
            this.btn_reporteReservacion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reporteReservacion.Image = ((System.Drawing.Image)(resources.GetObject("btn_reporteReservacion.Image")));
            this.btn_reporteReservacion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_reporteReservacion.Location = new System.Drawing.Point(606, 172);
            this.btn_reporteReservacion.Name = "btn_reporteReservacion";
            this.btn_reporteReservacion.Size = new System.Drawing.Size(101, 38);
            this.btn_reporteReservacion.TabIndex = 11;
            this.btn_reporteReservacion.Text = "Reporte";
            this.btn_reporteReservacion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_reporteReservacion.UseVisualStyleBackColor = false;
            this.btn_reporteReservacion.Click += new System.EventHandler(this.btn_reporteReservacion_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Gold;
            this.label6.Location = new System.Drawing.Point(358, 115);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 21);
            this.label6.TabIndex = 20;
            this.label6.Text = "Telefono:";
            // 
            // txt_Telefono
            // 
            this.txt_Telefono.Location = new System.Drawing.Point(440, 114);
            this.txt_Telefono.Name = "txt_Telefono";
            this.txt_Telefono.Size = new System.Drawing.Size(174, 20);
            this.txt_Telefono.TabIndex = 21;
            // 
            // ConsultarReservacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(26)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(752, 483);
            this.Controls.Add(this.btn_reporteReservacion);
            this.Controls.Add(this.bt_actualizar);
            this.Controls.Add(this.bt_salir);
            this.Controls.Add(this.bt_buscar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgv_reservaciones);
            this.Name = "ConsultarReservacion";
            this.Text = "ConsultarReservacion";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_reservaciones)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_salir;
        private System.Windows.Forms.Button bt_buscar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_reservaciones;
        private System.Windows.Forms.TextBox tx_id_cliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tx_id_reservacion;
        private System.Windows.Forms.TextBox tx_hora;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtp_fecha_reservacion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtp_fecha_realizada;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bt_actualizar;
        private System.Windows.Forms.ComboBox cb_estatus;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_reporteReservacion;
        private System.Windows.Forms.TextBox txt_Telefono;
        private System.Windows.Forms.Label label6;
    }
}