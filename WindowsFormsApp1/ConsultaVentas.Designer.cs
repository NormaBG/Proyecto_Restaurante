namespace WindowsFormsApp1
{
    partial class ConsultaVentas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultaVentas));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cb_tiporeporte = new System.Windows.Forms.ComboBox();
            this.dtp_fecha2 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_monto = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtp_fecha = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_id_EmpleadoV = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_id_venta = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgv_consultaventas = new System.Windows.Forms.DataGridView();
            this.bt_buscar = new System.Windows.Forms.Button();
            this.bt_salir = new System.Windows.Forms.Button();
            this.btn_reporte = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_consultaventas)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cb_tiporeporte);
            this.groupBox1.Controls.Add(this.dtp_fecha2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_monto);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.dtp_fecha);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_id_EmpleadoV);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_id_venta);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.ForeColor = System.Drawing.Color.Gold;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(730, 156);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de venta";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Gold;
            this.label6.Location = new System.Drawing.Point(413, 115);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 21);
            this.label6.TabIndex = 13;
            this.label6.Text = "Tipo de reporte:";
            // 
            // cb_tiporeporte
            // 
            this.cb_tiporeporte.FormattingEnabled = true;
            this.cb_tiporeporte.Items.AddRange(new object[] {
            "Empleados",
            "Fechas"});
            this.cb_tiporeporte.Location = new System.Drawing.Point(584, 118);
            this.cb_tiporeporte.Name = "cb_tiporeporte";
            this.cb_tiporeporte.Size = new System.Drawing.Size(88, 21);
            this.cb_tiporeporte.TabIndex = 15;
            // 
            // dtp_fecha2
            // 
            this.dtp_fecha2.Location = new System.Drawing.Point(444, 69);
            this.dtp_fecha2.Name = "dtp_fecha2";
            this.dtp_fecha2.Size = new System.Drawing.Size(198, 20);
            this.dtp_fecha2.TabIndex = 13;
            this.dtp_fecha2.Value = new System.DateTime(2023, 3, 26, 16, 46, 59, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gold;
            this.label3.Location = new System.Drawing.Point(375, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 21);
            this.label3.TabIndex = 12;
            this.label3.Text = "Fecha:";
            // 
            // txt_monto
            // 
            this.txt_monto.Location = new System.Drawing.Point(216, 119);
            this.txt_monto.Name = "txt_monto";
            this.txt_monto.Size = new System.Drawing.Size(100, 20);
            this.txt_monto.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Gold;
            this.label5.Location = new System.Drawing.Point(144, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 21);
            this.label5.TabIndex = 10;
            this.label5.Text = "Monto:";
            // 
            // dtp_fecha
            // 
            this.dtp_fecha.Location = new System.Drawing.Point(132, 69);
            this.dtp_fecha.Name = "dtp_fecha";
            this.dtp_fecha.Size = new System.Drawing.Size(198, 20);
            this.dtp_fecha.TabIndex = 9;
            this.dtp_fecha.Value = new System.DateTime(2023, 3, 26, 16, 46, 59, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gold;
            this.label4.Location = new System.Drawing.Point(40, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 21);
            this.label4.TabIndex = 8;
            this.label4.Text = "Fecha:";
            // 
            // txt_id_EmpleadoV
            // 
            this.txt_id_EmpleadoV.Location = new System.Drawing.Point(542, 26);
            this.txt_id_EmpleadoV.Name = "txt_id_EmpleadoV";
            this.txt_id_EmpleadoV.Size = new System.Drawing.Size(130, 20);
            this.txt_id_EmpleadoV.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(349, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nombre de empleado:";
            // 
            // txt_id_venta
            // 
            this.txt_id_venta.Location = new System.Drawing.Point(180, 27);
            this.txt_id_venta.Name = "txt_id_venta";
            this.txt_id_venta.Size = new System.Drawing.Size(100, 20);
            this.txt_id_venta.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gold;
            this.label2.Location = new System.Drawing.Point(66, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "ID de venta:";
            // 
            // dgv_consultaventas
            // 
            this.dgv_consultaventas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_consultaventas.Location = new System.Drawing.Point(12, 218);
            this.dgv_consultaventas.Name = "dgv_consultaventas";
            this.dgv_consultaventas.Size = new System.Drawing.Size(730, 204);
            this.dgv_consultaventas.TabIndex = 7;
            this.dgv_consultaventas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_consultaventas_CellContentClick);
            // 
            // bt_buscar
            // 
            this.bt_buscar.BackColor = System.Drawing.Color.Gold;
            this.bt_buscar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_buscar.Image = ((System.Drawing.Image)(resources.GetObject("bt_buscar.Image")));
            this.bt_buscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_buscar.Location = new System.Drawing.Point(328, 174);
            this.bt_buscar.Name = "bt_buscar";
            this.bt_buscar.Size = new System.Drawing.Size(101, 38);
            this.bt_buscar.TabIndex = 10;
            this.bt_buscar.Text = "Buscar";
            this.bt_buscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_buscar.UseVisualStyleBackColor = false;
            this.bt_buscar.Click += new System.EventHandler(this.bt_buscar_Click);
            // 
            // bt_salir
            // 
            this.bt_salir.BackColor = System.Drawing.Color.Gold;
            this.bt_salir.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_salir.Image = ((System.Drawing.Image)(resources.GetObject("bt_salir.Image")));
            this.bt_salir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_salir.Location = new System.Drawing.Point(340, 437);
            this.bt_salir.Name = "bt_salir";
            this.bt_salir.Size = new System.Drawing.Size(78, 38);
            this.bt_salir.TabIndex = 11;
            this.bt_salir.Text = "Salir";
            this.bt_salir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_salir.UseVisualStyleBackColor = false;
            this.bt_salir.Click += new System.EventHandler(this.bt_salir_Click);
            // 
            // btn_reporte
            // 
            this.btn_reporte.BackColor = System.Drawing.Color.Gold;
            this.btn_reporte.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reporte.Image = ((System.Drawing.Image)(resources.GetObject("btn_reporte.Image")));
            this.btn_reporte.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_reporte.Location = new System.Drawing.Point(507, 174);
            this.btn_reporte.Name = "btn_reporte";
            this.btn_reporte.Size = new System.Drawing.Size(101, 38);
            this.btn_reporte.TabIndex = 12;
            this.btn_reporte.Text = "Reporte";
            this.btn_reporte.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_reporte.UseVisualStyleBackColor = false;
            this.btn_reporte.Click += new System.EventHandler(this.btn_reporte_Click);
            // 
            // ConsultaVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(26)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(753, 483);
            this.Controls.Add(this.btn_reporte);
            this.Controls.Add(this.bt_salir);
            this.Controls.Add(this.bt_buscar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgv_consultaventas);
            this.Name = "ConsultaVentas";
            this.Text = "ConsultaVentas";
            this.Load += new System.EventHandler(this.ConsultaVentas_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_consultaventas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgv_consultaventas;
        private System.Windows.Forms.TextBox txt_id_venta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_id_EmpleadoV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtp_fecha;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_monto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button bt_buscar;
        private System.Windows.Forms.Button bt_salir;
        private System.Windows.Forms.DateTimePicker dtp_fecha2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_reporte;
        private System.Windows.Forms.ComboBox cb_tiporeporte;
        private System.Windows.Forms.Label label6;
    }
}