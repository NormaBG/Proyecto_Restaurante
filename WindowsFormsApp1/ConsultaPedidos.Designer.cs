namespace WindowsFormsApp1
{
    partial class ConsultaPedidos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultaPedidos));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_buscar = new System.Windows.Forms.Button();
            this.bt_salir = new System.Windows.Forms.Button();
            this.tx_id_pedido = new System.Windows.Forms.TextBox();
            this.tx_id_empleado = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tx_id_cliente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.tx_monto = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cb_tipo_entrega = new System.Windows.Forms.ComboBox();
            this.tx_id_comida = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tx_id_bebida = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cb_estatus = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.bt_actualizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 218);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(730, 213);
            this.dataGridView1.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cb_estatus);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.tx_id_bebida);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.tx_id_comida);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.cb_tipo_entrega);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.tx_monto);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tx_id_cliente);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tx_id_empleado);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tx_id_pedido);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.Color.Gold;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(730, 156);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de pedido";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(15, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID de pedido:";
            // 
            // bt_buscar
            // 
            this.bt_buscar.BackColor = System.Drawing.Color.Gold;
            this.bt_buscar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_buscar.Image = ((System.Drawing.Image)(resources.GetObject("bt_buscar.Image")));
            this.bt_buscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_buscar.Location = new System.Drawing.Point(463, 174);
            this.bt_buscar.Name = "bt_buscar";
            this.bt_buscar.Size = new System.Drawing.Size(101, 38);
            this.bt_buscar.TabIndex = 1;
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
            this.bt_salir.Location = new System.Drawing.Point(346, 437);
            this.bt_salir.Name = "bt_salir";
            this.bt_salir.Size = new System.Drawing.Size(78, 38);
            this.bt_salir.TabIndex = 5;
            this.bt_salir.Text = "Salir";
            this.bt_salir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_salir.UseVisualStyleBackColor = false;
            this.bt_salir.Click += new System.EventHandler(this.bt_salir_Click);
            // 
            // tx_id_pedido
            // 
            this.tx_id_pedido.Location = new System.Drawing.Point(137, 19);
            this.tx_id_pedido.Name = "tx_id_pedido";
            this.tx_id_pedido.Size = new System.Drawing.Size(100, 20);
            this.tx_id_pedido.TabIndex = 1;
            // 
            // tx_id_empleado
            // 
            this.tx_id_empleado.Location = new System.Drawing.Point(390, 19);
            this.tx_id_empleado.Name = "tx_id_empleado";
            this.tx_id_empleado.Size = new System.Drawing.Size(100, 20);
            this.tx_id_empleado.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gold;
            this.label2.Location = new System.Drawing.Point(243, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "ID de empleado:";
            // 
            // tx_id_cliente
            // 
            this.tx_id_cliente.Location = new System.Drawing.Point(615, 19);
            this.tx_id_cliente.Name = "tx_id_cliente";
            this.tx_id_cliente.Size = new System.Drawing.Size(100, 20);
            this.tx_id_cliente.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gold;
            this.label3.Location = new System.Drawing.Point(496, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "ID de cliente:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gold;
            this.label4.Location = new System.Drawing.Point(7, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "Fecha:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(76, 67);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(198, 20);
            this.dateTimePicker1.TabIndex = 7;
            this.dateTimePicker1.Value = new System.DateTime(2023, 3, 26, 16, 46, 59, 0);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Gold;
            this.label5.Location = new System.Drawing.Point(280, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 21);
            this.label5.TabIndex = 8;
            this.label5.Text = "Monto:";
            // 
            // tx_monto
            // 
            this.tx_monto.Location = new System.Drawing.Point(352, 67);
            this.tx_monto.Name = "tx_monto";
            this.tx_monto.Size = new System.Drawing.Size(100, 20);
            this.tx_monto.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Gold;
            this.label6.Location = new System.Drawing.Point(458, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(139, 21);
            this.label6.TabIndex = 10;
            this.label6.Text = "Tipo de entrega:";
            // 
            // cb_tipo_entrega
            // 
            this.cb_tipo_entrega.FormattingEnabled = true;
            this.cb_tipo_entrega.Items.AddRange(new object[] {
            "En sucursal",
            "Para llevar",
            "A domicilio"});
            this.cb_tipo_entrega.Location = new System.Drawing.Point(603, 66);
            this.cb_tipo_entrega.Name = "cb_tipo_entrega";
            this.cb_tipo_entrega.Size = new System.Drawing.Size(121, 21);
            this.cb_tipo_entrega.TabIndex = 11;
            // 
            // tx_id_comida
            // 
            this.tx_id_comida.Location = new System.Drawing.Point(160, 115);
            this.tx_id_comida.Name = "tx_id_comida";
            this.tx_id_comida.Size = new System.Drawing.Size(100, 20);
            this.tx_id_comida.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Gold;
            this.label7.Location = new System.Drawing.Point(38, 115);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 21);
            this.label7.TabIndex = 12;
            this.label7.Text = "ID de comida:";
            // 
            // tx_id_bebida
            // 
            this.tx_id_bebida.Location = new System.Drawing.Point(390, 116);
            this.tx_id_bebida.Name = "tx_id_bebida";
            this.tx_id_bebida.Size = new System.Drawing.Size(100, 20);
            this.tx_id_bebida.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Gold;
            this.label8.Location = new System.Drawing.Point(267, 115);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 21);
            this.label8.TabIndex = 14;
            this.label8.Text = "ID de bebida:";
            // 
            // cb_estatus
            // 
            this.cb_estatus.FormattingEnabled = true;
            this.cb_estatus.Items.AddRange(new object[] {
            "En progreso",
            "Entregada",
            "Cancelada"});
            this.cb_estatus.Location = new System.Drawing.Point(572, 114);
            this.cb_estatus.Name = "cb_estatus";
            this.cb_estatus.Size = new System.Drawing.Size(121, 21);
            this.cb_estatus.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Gold;
            this.label9.Location = new System.Drawing.Point(496, 115);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 21);
            this.label9.TabIndex = 16;
            this.label9.Text = "Estatus:";
            // 
            // bt_actualizar
            // 
            this.bt_actualizar.BackColor = System.Drawing.Color.Gold;
            this.bt_actualizar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_actualizar.Image = ((System.Drawing.Image)(resources.GetObject("bt_actualizar.Image")));
            this.bt_actualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_actualizar.Location = new System.Drawing.Point(194, 174);
            this.bt_actualizar.Name = "bt_actualizar";
            this.bt_actualizar.Size = new System.Drawing.Size(131, 38);
            this.bt_actualizar.TabIndex = 6;
            this.bt_actualizar.Text = "Actualizar";
            this.bt_actualizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_actualizar.UseVisualStyleBackColor = false;
            this.bt_actualizar.Click += new System.EventHandler(this.bt_actualizar_Click);
            // 
            // ConsultaPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(26)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(752, 484);
            this.Controls.Add(this.bt_actualizar);
            this.Controls.Add(this.bt_salir);
            this.Controls.Add(this.bt_buscar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ConsultaPedidos";
            this.Text = "Consulta pedidos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_buscar;
        private System.Windows.Forms.Button bt_salir;
        private System.Windows.Forms.ComboBox cb_estatus;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tx_id_bebida;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tx_id_comida;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cb_tipo_entrega;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tx_monto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tx_id_cliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tx_id_empleado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tx_id_pedido;
        private System.Windows.Forms.Button bt_actualizar;
    }
}