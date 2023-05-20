namespace WindowsFormsApp1
{
    partial class RealizarPedido
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RealizarPedido));
            this.lb_mesa = new System.Windows.Forms.Label();
            this.tx_mesa = new System.Windows.Forms.TextBox();
            this.bt_platillo1 = new System.Windows.Forms.Button();
            this.bt_platillo2 = new System.Windows.Forms.Button();
            this.bt_platillo3 = new System.Windows.Forms.Button();
            this.bt_platillo4 = new System.Windows.Forms.Button();
            this.bt_platillo5 = new System.Windows.Forms.Button();
            this.bt_platillo6 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bt_bebida1 = new System.Windows.Forms.Button();
            this.bt_bebida2 = new System.Windows.Forms.Button();
            this.bt_bebida3 = new System.Windows.Forms.Button();
            this.bt_bebida4 = new System.Windows.Forms.Button();
            this.bt_bebida5 = new System.Windows.Forms.Button();
            this.bt_bebida6 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.bt_postre1 = new System.Windows.Forms.Button();
            this.bt_postre2 = new System.Windows.Forms.Button();
            this.bt_postre3 = new System.Windows.Forms.Button();
            this.bt_postre4 = new System.Windows.Forms.Button();
            this.bt_postre5 = new System.Windows.Forms.Button();
            this.bt_postre6 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.bt_generar_cuenta = new System.Windows.Forms.Button();
            this.lb_monto_total = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.bt_pagar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bt_salir = new System.Windows.Forms.Button();
            this.rb_sucursal = new System.Windows.Forms.RadioButton();
            this.rb_llevar = new System.Windows.Forms.RadioButton();
            this.rb_domicilio = new System.Windows.Forms.RadioButton();
            this.tx_area = new System.Windows.Forms.TextBox();
            this.lb_area = new System.Windows.Forms.Label();
            this.tx_telefono_cliente = new System.Windows.Forms.TextBox();
            this.lb_telefono_cliente = new System.Windows.Forms.Label();
            this.lb_direccion = new System.Windows.Forms.Label();
            this.tx_direccion = new System.Windows.Forms.TextBox();
            this.bt_confirmar = new System.Windows.Forms.Button();
            this.bt_retroceder_domicilio = new System.Windows.Forms.Button();
            this.bt_retroceder_sucursal = new System.Windows.Forms.Button();
            this.bt_retroceder_llevar = new System.Windows.Forms.Button();
            this.lb_id_empleado = new System.Windows.Forms.Label();
            this.tx_id_empleado = new System.Windows.Forms.TextBox();
            this.tx_id_cliente = new System.Windows.Forms.TextBox();
            this.lb_id_cliente = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_mesa
            // 
            this.lb_mesa.AutoSize = true;
            this.lb_mesa.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_mesa.ForeColor = System.Drawing.Color.Gold;
            this.lb_mesa.Location = new System.Drawing.Point(139, 55);
            this.lb_mesa.Name = "lb_mesa";
            this.lb_mesa.Size = new System.Drawing.Size(147, 21);
            this.lb_mesa.TabIndex = 0;
            this.lb_mesa.Text = "Numero de mesa:";
            this.lb_mesa.Visible = false;
            // 
            // tx_mesa
            // 
            this.tx_mesa.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tx_mesa.Location = new System.Drawing.Point(289, 54);
            this.tx_mesa.Name = "tx_mesa";
            this.tx_mesa.Size = new System.Drawing.Size(66, 26);
            this.tx_mesa.TabIndex = 1;
            this.tx_mesa.Visible = false;
            // 
            // bt_platillo1
            // 
            this.bt_platillo1.BackColor = System.Drawing.Color.Gold;
            this.bt_platillo1.Enabled = false;
            this.bt_platillo1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_platillo1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bt_platillo1.Location = new System.Drawing.Point(17, 31);
            this.bt_platillo1.Name = "bt_platillo1";
            this.bt_platillo1.Size = new System.Drawing.Size(100, 100);
            this.bt_platillo1.TabIndex = 2;
            this.bt_platillo1.Text = "Platillo 1";
            this.bt_platillo1.UseVisualStyleBackColor = false;
            this.bt_platillo1.Click += new System.EventHandler(this.bt_platillo1_Click);
            // 
            // bt_platillo2
            // 
            this.bt_platillo2.BackColor = System.Drawing.Color.Gold;
            this.bt_platillo2.Enabled = false;
            this.bt_platillo2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_platillo2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bt_platillo2.Location = new System.Drawing.Point(144, 31);
            this.bt_platillo2.Name = "bt_platillo2";
            this.bt_platillo2.Size = new System.Drawing.Size(100, 100);
            this.bt_platillo2.TabIndex = 3;
            this.bt_platillo2.Text = "Platillo 2";
            this.bt_platillo2.UseVisualStyleBackColor = false;
            this.bt_platillo2.Click += new System.EventHandler(this.bt_platillo2_Click);
            // 
            // bt_platillo3
            // 
            this.bt_platillo3.BackColor = System.Drawing.Color.Gold;
            this.bt_platillo3.Enabled = false;
            this.bt_platillo3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_platillo3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bt_platillo3.Location = new System.Drawing.Point(270, 31);
            this.bt_platillo3.Name = "bt_platillo3";
            this.bt_platillo3.Size = new System.Drawing.Size(100, 100);
            this.bt_platillo3.TabIndex = 4;
            this.bt_platillo3.Text = "Platillo 3";
            this.bt_platillo3.UseVisualStyleBackColor = false;
            this.bt_platillo3.Click += new System.EventHandler(this.bt_platillo3_Click);
            // 
            // bt_platillo4
            // 
            this.bt_platillo4.BackColor = System.Drawing.Color.Gold;
            this.bt_platillo4.Enabled = false;
            this.bt_platillo4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_platillo4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bt_platillo4.Location = new System.Drawing.Point(17, 165);
            this.bt_platillo4.Name = "bt_platillo4";
            this.bt_platillo4.Size = new System.Drawing.Size(100, 100);
            this.bt_platillo4.TabIndex = 5;
            this.bt_platillo4.Text = "Platillo 4";
            this.bt_platillo4.UseVisualStyleBackColor = false;
            this.bt_platillo4.Click += new System.EventHandler(this.bt_platillo4_Click);
            // 
            // bt_platillo5
            // 
            this.bt_platillo5.BackColor = System.Drawing.Color.Gold;
            this.bt_platillo5.Enabled = false;
            this.bt_platillo5.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_platillo5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bt_platillo5.Location = new System.Drawing.Point(144, 165);
            this.bt_platillo5.Name = "bt_platillo5";
            this.bt_platillo5.Size = new System.Drawing.Size(100, 100);
            this.bt_platillo5.TabIndex = 6;
            this.bt_platillo5.Text = "Platillo 5";
            this.bt_platillo5.UseVisualStyleBackColor = false;
            this.bt_platillo5.Click += new System.EventHandler(this.bt_platillo5_Click);
            // 
            // bt_platillo6
            // 
            this.bt_platillo6.BackColor = System.Drawing.Color.Gold;
            this.bt_platillo6.Enabled = false;
            this.bt_platillo6.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_platillo6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bt_platillo6.Location = new System.Drawing.Point(270, 165);
            this.bt_platillo6.Name = "bt_platillo6";
            this.bt_platillo6.Size = new System.Drawing.Size(100, 100);
            this.bt_platillo6.TabIndex = 7;
            this.bt_platillo6.Text = "Platillo 6";
            this.bt_platillo6.UseVisualStyleBackColor = false;
            this.bt_platillo6.Click += new System.EventHandler(this.bt_platillo6_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bt_platillo1);
            this.groupBox1.Controls.Add(this.bt_platillo2);
            this.groupBox1.Controls.Add(this.bt_platillo3);
            this.groupBox1.Controls.Add(this.bt_platillo4);
            this.groupBox1.Controls.Add(this.bt_platillo5);
            this.groupBox1.Controls.Add(this.bt_platillo6);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Gold;
            this.groupBox1.Location = new System.Drawing.Point(8, 94);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(387, 274);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Platillos";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bt_bebida1);
            this.groupBox2.Controls.Add(this.bt_bebida2);
            this.groupBox2.Controls.Add(this.bt_bebida3);
            this.groupBox2.Controls.Add(this.bt_bebida4);
            this.groupBox2.Controls.Add(this.bt_bebida5);
            this.groupBox2.Controls.Add(this.bt_bebida6);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(8, 374);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(387, 289);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Bebidas";
            // 
            // bt_bebida1
            // 
            this.bt_bebida1.BackColor = System.Drawing.Color.Gold;
            this.bt_bebida1.Enabled = false;
            this.bt_bebida1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_bebida1.Location = new System.Drawing.Point(17, 31);
            this.bt_bebida1.Name = "bt_bebida1";
            this.bt_bebida1.Size = new System.Drawing.Size(100, 100);
            this.bt_bebida1.TabIndex = 2;
            this.bt_bebida1.Text = "Bebida 1";
            this.bt_bebida1.UseVisualStyleBackColor = false;
            // 
            // bt_bebida2
            // 
            this.bt_bebida2.BackColor = System.Drawing.Color.Gold;
            this.bt_bebida2.Enabled = false;
            this.bt_bebida2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_bebida2.Location = new System.Drawing.Point(145, 31);
            this.bt_bebida2.Name = "bt_bebida2";
            this.bt_bebida2.Size = new System.Drawing.Size(100, 100);
            this.bt_bebida2.TabIndex = 3;
            this.bt_bebida2.Text = "Bebida 2";
            this.bt_bebida2.UseVisualStyleBackColor = false;
            this.bt_bebida2.Click += new System.EventHandler(this.bt_bebida2_Click);
            // 
            // bt_bebida3
            // 
            this.bt_bebida3.BackColor = System.Drawing.Color.Gold;
            this.bt_bebida3.Enabled = false;
            this.bt_bebida3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_bebida3.Location = new System.Drawing.Point(273, 31);
            this.bt_bebida3.Name = "bt_bebida3";
            this.bt_bebida3.Size = new System.Drawing.Size(100, 100);
            this.bt_bebida3.TabIndex = 4;
            this.bt_bebida3.Text = "Bebida 3";
            this.bt_bebida3.UseVisualStyleBackColor = false;
            this.bt_bebida3.Click += new System.EventHandler(this.bt_bebida3_Click);
            // 
            // bt_bebida4
            // 
            this.bt_bebida4.BackColor = System.Drawing.Color.Gold;
            this.bt_bebida4.Enabled = false;
            this.bt_bebida4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_bebida4.Location = new System.Drawing.Point(17, 165);
            this.bt_bebida4.Name = "bt_bebida4";
            this.bt_bebida4.Size = new System.Drawing.Size(100, 100);
            this.bt_bebida4.TabIndex = 5;
            this.bt_bebida4.Text = "Bebida 4";
            this.bt_bebida4.UseVisualStyleBackColor = false;
            this.bt_bebida4.Click += new System.EventHandler(this.bt_bebida4_Click);
            // 
            // bt_bebida5
            // 
            this.bt_bebida5.BackColor = System.Drawing.Color.Gold;
            this.bt_bebida5.Enabled = false;
            this.bt_bebida5.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_bebida5.Location = new System.Drawing.Point(145, 165);
            this.bt_bebida5.Name = "bt_bebida5";
            this.bt_bebida5.Size = new System.Drawing.Size(100, 100);
            this.bt_bebida5.TabIndex = 6;
            this.bt_bebida5.Text = "Bebida 5";
            this.bt_bebida5.UseVisualStyleBackColor = false;
            this.bt_bebida5.Click += new System.EventHandler(this.bt_bebida5_Click);
            // 
            // bt_bebida6
            // 
            this.bt_bebida6.BackColor = System.Drawing.Color.Gold;
            this.bt_bebida6.Enabled = false;
            this.bt_bebida6.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_bebida6.Location = new System.Drawing.Point(273, 165);
            this.bt_bebida6.Name = "bt_bebida6";
            this.bt_bebida6.Size = new System.Drawing.Size(100, 100);
            this.bt_bebida6.TabIndex = 7;
            this.bt_bebida6.Text = "Bebida 6";
            this.bt_bebida6.UseVisualStyleBackColor = false;
            this.bt_bebida6.Click += new System.EventHandler(this.bt_bebida6_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.bt_postre1);
            this.groupBox3.Controls.Add(this.bt_postre2);
            this.groupBox3.Controls.Add(this.bt_postre3);
            this.groupBox3.Controls.Add(this.bt_postre4);
            this.groupBox3.Controls.Add(this.bt_postre5);
            this.groupBox3.Controls.Add(this.bt_postre6);
            this.groupBox3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(774, 94);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(388, 285);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Postres";
            // 
            // bt_postre1
            // 
            this.bt_postre1.BackColor = System.Drawing.Color.Gold;
            this.bt_postre1.Enabled = false;
            this.bt_postre1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_postre1.Location = new System.Drawing.Point(17, 31);
            this.bt_postre1.Name = "bt_postre1";
            this.bt_postre1.Size = new System.Drawing.Size(100, 100);
            this.bt_postre1.TabIndex = 2;
            this.bt_postre1.Text = "Postre 1";
            this.bt_postre1.UseVisualStyleBackColor = false;
            this.bt_postre1.Click += new System.EventHandler(this.bt_postre1_Click);
            // 
            // bt_postre2
            // 
            this.bt_postre2.BackColor = System.Drawing.Color.Gold;
            this.bt_postre2.Enabled = false;
            this.bt_postre2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_postre2.Location = new System.Drawing.Point(149, 29);
            this.bt_postre2.Name = "bt_postre2";
            this.bt_postre2.Size = new System.Drawing.Size(100, 100);
            this.bt_postre2.TabIndex = 3;
            this.bt_postre2.Text = "Postre 2";
            this.bt_postre2.UseVisualStyleBackColor = false;
            this.bt_postre2.Click += new System.EventHandler(this.bt_postre2_Click);
            // 
            // bt_postre3
            // 
            this.bt_postre3.BackColor = System.Drawing.Color.Gold;
            this.bt_postre3.Enabled = false;
            this.bt_postre3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_postre3.Location = new System.Drawing.Point(277, 29);
            this.bt_postre3.Name = "bt_postre3";
            this.bt_postre3.Size = new System.Drawing.Size(100, 100);
            this.bt_postre3.TabIndex = 4;
            this.bt_postre3.Text = "Postre 3";
            this.bt_postre3.UseVisualStyleBackColor = false;
            this.bt_postre3.Click += new System.EventHandler(this.bt_postre3_Click);
            // 
            // bt_postre4
            // 
            this.bt_postre4.BackColor = System.Drawing.Color.Gold;
            this.bt_postre4.Enabled = false;
            this.bt_postre4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_postre4.Location = new System.Drawing.Point(17, 165);
            this.bt_postre4.Name = "bt_postre4";
            this.bt_postre4.Size = new System.Drawing.Size(100, 100);
            this.bt_postre4.TabIndex = 5;
            this.bt_postre4.Text = "Postre 4";
            this.bt_postre4.UseVisualStyleBackColor = false;
            this.bt_postre4.Click += new System.EventHandler(this.bt_postre4_Click);
            // 
            // bt_postre5
            // 
            this.bt_postre5.BackColor = System.Drawing.Color.Gold;
            this.bt_postre5.Enabled = false;
            this.bt_postre5.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_postre5.Location = new System.Drawing.Point(149, 163);
            this.bt_postre5.Name = "bt_postre5";
            this.bt_postre5.Size = new System.Drawing.Size(100, 100);
            this.bt_postre5.TabIndex = 6;
            this.bt_postre5.Text = "Postre 5";
            this.bt_postre5.UseVisualStyleBackColor = false;
            this.bt_postre5.Click += new System.EventHandler(this.bt_postre5_Click);
            // 
            // bt_postre6
            // 
            this.bt_postre6.BackColor = System.Drawing.Color.Gold;
            this.bt_postre6.Enabled = false;
            this.bt_postre6.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_postre6.Location = new System.Drawing.Point(277, 163);
            this.bt_postre6.Name = "bt_postre6";
            this.bt_postre6.Size = new System.Drawing.Size(100, 100);
            this.bt_postre6.TabIndex = 7;
            this.bt_postre6.Text = "Postre 6";
            this.bt_postre6.UseVisualStyleBackColor = false;
            this.bt_postre6.Click += new System.EventHandler(this.bt_postre6_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dataGridView1.Location = new System.Drawing.Point(10, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(351, 444);
            this.dataGridView1.TabIndex = 18;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Platillo / Bebida / Postre";
            this.Column1.Name = "Column1";
            this.Column1.Width = 200;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Precio";
            this.Column2.Name = "Column2";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.bt_generar_cuenta);
            this.groupBox4.Controls.Add(this.lb_monto_total);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.bt_pagar);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.dataGridView1);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(401, 94);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(367, 569);
            this.groupBox4.TabIndex = 19;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Pedido";
            // 
            // bt_generar_cuenta
            // 
            this.bt_generar_cuenta.BackColor = System.Drawing.Color.Gold;
            this.bt_generar_cuenta.Enabled = false;
            this.bt_generar_cuenta.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_generar_cuenta.Image = ((System.Drawing.Image)(resources.GetObject("bt_generar_cuenta.Image")));
            this.bt_generar_cuenta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_generar_cuenta.Location = new System.Drawing.Point(76, 525);
            this.bt_generar_cuenta.Name = "bt_generar_cuenta";
            this.bt_generar_cuenta.Size = new System.Drawing.Size(201, 38);
            this.bt_generar_cuenta.TabIndex = 25;
            this.bt_generar_cuenta.Text = "Generar cuenta";
            this.bt_generar_cuenta.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_generar_cuenta.UseVisualStyleBackColor = false;
            this.bt_generar_cuenta.Click += new System.EventHandler(this.bt_generar_cuenta_Click);
            // 
            // lb_monto_total
            // 
            this.lb_monto_total.AutoSize = true;
            this.lb_monto_total.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_monto_total.ForeColor = System.Drawing.Color.Gold;
            this.lb_monto_total.Location = new System.Drawing.Point(278, 486);
            this.lb_monto_total.Name = "lb_monto_total";
            this.lb_monto_total.Size = new System.Drawing.Size(25, 21);
            this.lb_monto_total.TabIndex = 24;
            this.lb_monto_total.Text = "---";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Gold;
            this.label5.Location = new System.Drawing.Point(164, 486);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 21);
            this.label5.TabIndex = 23;
            this.label5.Text = "Monto total:";
            // 
            // bt_pagar
            // 
            this.bt_pagar.Location = new System.Drawing.Point(141, 826);
            this.bt_pagar.Name = "bt_pagar";
            this.bt_pagar.Size = new System.Drawing.Size(100, 33);
            this.bt_pagar.TabIndex = 22;
            this.bt_pagar.Text = "Pagar";
            this.bt_pagar.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(281, 775);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 20);
            this.label4.TabIndex = 21;
            this.label4.Text = "---";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(257, 775);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 20);
            this.label3.TabIndex = 20;
            this.label3.Text = "$";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(158, 775);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 20);
            this.label2.TabIndex = 19;
            this.label2.Text = "Monto total:";
            // 
            // bt_salir
            // 
            this.bt_salir.BackColor = System.Drawing.Color.Gold;
            this.bt_salir.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_salir.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bt_salir.Image = ((System.Drawing.Image)(resources.GetObject("bt_salir.Image")));
            this.bt_salir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_salir.Location = new System.Drawing.Point(998, 12);
            this.bt_salir.Name = "bt_salir";
            this.bt_salir.Size = new System.Drawing.Size(89, 50);
            this.bt_salir.TabIndex = 23;
            this.bt_salir.Text = "Salir";
            this.bt_salir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_salir.UseVisualStyleBackColor = false;
            this.bt_salir.Click += new System.EventHandler(this.bt_salir_Click);
            // 
            // rb_sucursal
            // 
            this.rb_sucursal.AutoSize = true;
            this.rb_sucursal.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_sucursal.ForeColor = System.Drawing.Color.Gold;
            this.rb_sucursal.Location = new System.Drawing.Point(8, 53);
            this.rb_sucursal.Name = "rb_sucursal";
            this.rb_sucursal.Size = new System.Drawing.Size(112, 25);
            this.rb_sucursal.TabIndex = 24;
            this.rb_sucursal.TabStop = true;
            this.rb_sucursal.Text = "En sucursal";
            this.rb_sucursal.UseVisualStyleBackColor = true;
            // 
            // rb_llevar
            // 
            this.rb_llevar.AutoSize = true;
            this.rb_llevar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_llevar.ForeColor = System.Drawing.Color.Gold;
            this.rb_llevar.Location = new System.Drawing.Point(126, 53);
            this.rb_llevar.Name = "rb_llevar";
            this.rb_llevar.Size = new System.Drawing.Size(110, 25);
            this.rb_llevar.TabIndex = 25;
            this.rb_llevar.TabStop = true;
            this.rb_llevar.Text = "Para llevar";
            this.rb_llevar.UseVisualStyleBackColor = true;
            // 
            // rb_domicilio
            // 
            this.rb_domicilio.AutoSize = true;
            this.rb_domicilio.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_domicilio.ForeColor = System.Drawing.Color.Gold;
            this.rb_domicilio.Location = new System.Drawing.Point(242, 53);
            this.rb_domicilio.Name = "rb_domicilio";
            this.rb_domicilio.Size = new System.Drawing.Size(113, 25);
            this.rb_domicilio.TabIndex = 26;
            this.rb_domicilio.TabStop = true;
            this.rb_domicilio.Text = "A domicilio";
            this.rb_domicilio.UseVisualStyleBackColor = true;
            // 
            // tx_area
            // 
            this.tx_area.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tx_area.Location = new System.Drawing.Point(67, 54);
            this.tx_area.Name = "tx_area";
            this.tx_area.Size = new System.Drawing.Size(66, 26);
            this.tx_area.TabIndex = 28;
            this.tx_area.Visible = false;
            // 
            // lb_area
            // 
            this.lb_area.AutoSize = true;
            this.lb_area.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_area.ForeColor = System.Drawing.Color.Gold;
            this.lb_area.Location = new System.Drawing.Point(8, 55);
            this.lb_area.Name = "lb_area";
            this.lb_area.Size = new System.Drawing.Size(53, 21);
            this.lb_area.TabIndex = 27;
            this.lb_area.Text = "Area:";
            this.lb_area.Visible = false;
            // 
            // tx_telefono_cliente
            // 
            this.tx_telefono_cliente.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tx_telefono_cliente.Location = new System.Drawing.Point(176, 53);
            this.tx_telefono_cliente.Name = "tx_telefono_cliente";
            this.tx_telefono_cliente.Size = new System.Drawing.Size(151, 26);
            this.tx_telefono_cliente.TabIndex = 30;
            this.tx_telefono_cliente.Visible = false;
            // 
            // lb_telefono_cliente
            // 
            this.lb_telefono_cliente.AutoSize = true;
            this.lb_telefono_cliente.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_telefono_cliente.ForeColor = System.Drawing.Color.Gold;
            this.lb_telefono_cliente.Location = new System.Drawing.Point(8, 57);
            this.lb_telefono_cliente.Name = "lb_telefono_cliente";
            this.lb_telefono_cliente.Size = new System.Drawing.Size(162, 21);
            this.lb_telefono_cliente.TabIndex = 29;
            this.lb_telefono_cliente.Text = "Telefono de cliente:";
            this.lb_telefono_cliente.Visible = false;
            // 
            // lb_direccion
            // 
            this.lb_direccion.AutoSize = true;
            this.lb_direccion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_direccion.ForeColor = System.Drawing.Color.Gold;
            this.lb_direccion.Location = new System.Drawing.Point(333, 55);
            this.lb_direccion.Name = "lb_direccion";
            this.lb_direccion.Size = new System.Drawing.Size(87, 21);
            this.lb_direccion.TabIndex = 31;
            this.lb_direccion.Text = "Direccion:";
            this.lb_direccion.Visible = false;
            // 
            // tx_direccion
            // 
            this.tx_direccion.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tx_direccion.Location = new System.Drawing.Point(426, 52);
            this.tx_direccion.Name = "tx_direccion";
            this.tx_direccion.Size = new System.Drawing.Size(257, 26);
            this.tx_direccion.TabIndex = 32;
            this.tx_direccion.Visible = false;
            // 
            // bt_confirmar
            // 
            this.bt_confirmar.BackColor = System.Drawing.Color.Gold;
            this.bt_confirmar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_confirmar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bt_confirmar.Image = ((System.Drawing.Image)(resources.GetObject("bt_confirmar.Image")));
            this.bt_confirmar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_confirmar.Location = new System.Drawing.Point(361, 49);
            this.bt_confirmar.Name = "bt_confirmar";
            this.bt_confirmar.Size = new System.Drawing.Size(124, 33);
            this.bt_confirmar.TabIndex = 33;
            this.bt_confirmar.Text = "Confirmar";
            this.bt_confirmar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_confirmar.UseVisualStyleBackColor = false;
            this.bt_confirmar.Click += new System.EventHandler(this.bt_confirmar_Click);
            // 
            // bt_retroceder_domicilio
            // 
            this.bt_retroceder_domicilio.BackColor = System.Drawing.Color.Gold;
            this.bt_retroceder_domicilio.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_retroceder_domicilio.Image = ((System.Drawing.Image)(resources.GetObject("bt_retroceder_domicilio.Image")));
            this.bt_retroceder_domicilio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_retroceder_domicilio.Location = new System.Drawing.Point(689, 49);
            this.bt_retroceder_domicilio.Name = "bt_retroceder_domicilio";
            this.bt_retroceder_domicilio.Size = new System.Drawing.Size(133, 33);
            this.bt_retroceder_domicilio.TabIndex = 34;
            this.bt_retroceder_domicilio.Text = "Retroceder";
            this.bt_retroceder_domicilio.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_retroceder_domicilio.UseVisualStyleBackColor = false;
            this.bt_retroceder_domicilio.Visible = false;
            this.bt_retroceder_domicilio.Click += new System.EventHandler(this.bt_retroceder_domicilio_Click);
            // 
            // bt_retroceder_sucursal
            // 
            this.bt_retroceder_sucursal.BackColor = System.Drawing.Color.Gold;
            this.bt_retroceder_sucursal.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_retroceder_sucursal.Image = ((System.Drawing.Image)(resources.GetObject("bt_retroceder_sucursal.Image")));
            this.bt_retroceder_sucursal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_retroceder_sucursal.Location = new System.Drawing.Point(361, 49);
            this.bt_retroceder_sucursal.Name = "bt_retroceder_sucursal";
            this.bt_retroceder_sucursal.Size = new System.Drawing.Size(134, 33);
            this.bt_retroceder_sucursal.TabIndex = 35;
            this.bt_retroceder_sucursal.Text = "Retroceder";
            this.bt_retroceder_sucursal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_retroceder_sucursal.UseVisualStyleBackColor = false;
            this.bt_retroceder_sucursal.Visible = false;
            this.bt_retroceder_sucursal.Click += new System.EventHandler(this.bt_retroceder_sucursal_Click);
            // 
            // bt_retroceder_llevar
            // 
            this.bt_retroceder_llevar.BackColor = System.Drawing.Color.Gold;
            this.bt_retroceder_llevar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_retroceder_llevar.Image = ((System.Drawing.Image)(resources.GetObject("bt_retroceder_llevar.Image")));
            this.bt_retroceder_llevar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_retroceder_llevar.Location = new System.Drawing.Point(12, 49);
            this.bt_retroceder_llevar.Name = "bt_retroceder_llevar";
            this.bt_retroceder_llevar.Size = new System.Drawing.Size(137, 33);
            this.bt_retroceder_llevar.TabIndex = 36;
            this.bt_retroceder_llevar.Text = "Retroceder";
            this.bt_retroceder_llevar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_retroceder_llevar.UseVisualStyleBackColor = false;
            this.bt_retroceder_llevar.Visible = false;
            this.bt_retroceder_llevar.Click += new System.EventHandler(this.bt_retroceder_llevar_Click);
            // 
            // lb_id_empleado
            // 
            this.lb_id_empleado.AutoSize = true;
            this.lb_id_empleado.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_id_empleado.ForeColor = System.Drawing.Color.Gold;
            this.lb_id_empleado.Location = new System.Drawing.Point(11, 9);
            this.lb_id_empleado.Name = "lb_id_empleado";
            this.lb_id_empleado.Size = new System.Drawing.Size(141, 21);
            this.lb_id_empleado.TabIndex = 37;
            this.lb_id_empleado.Text = "ID de empleado:";
            // 
            // tx_id_empleado
            // 
            this.tx_id_empleado.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tx_id_empleado.Location = new System.Drawing.Point(153, 8);
            this.tx_id_empleado.Name = "tx_id_empleado";
            this.tx_id_empleado.Size = new System.Drawing.Size(119, 26);
            this.tx_id_empleado.TabIndex = 38;
            // 
            // tx_id_cliente
            // 
            this.tx_id_cliente.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tx_id_cliente.Location = new System.Drawing.Point(492, 8);
            this.tx_id_cliente.Name = "tx_id_cliente";
            this.tx_id_cliente.Size = new System.Drawing.Size(119, 26);
            this.tx_id_cliente.TabIndex = 40;
            // 
            // lb_id_cliente
            // 
            this.lb_id_cliente.AutoSize = true;
            this.lb_id_cliente.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_id_cliente.ForeColor = System.Drawing.Color.Gold;
            this.lb_id_cliente.Location = new System.Drawing.Point(285, 9);
            this.lb_id_cliente.Name = "lb_id_cliente";
            this.lb_id_cliente.Size = new System.Drawing.Size(201, 21);
            this.lb_id_cliente.TabIndex = 39;
            this.lb_id_cliente.Text = "ID de cliente (Opcional):";
            // 
            // RealizarPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(26)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(1175, 676);
            this.Controls.Add(this.tx_id_cliente);
            this.Controls.Add(this.lb_id_cliente);
            this.Controls.Add(this.tx_id_empleado);
            this.Controls.Add(this.lb_id_empleado);
            this.Controls.Add(this.bt_confirmar);
            this.Controls.Add(this.bt_retroceder_sucursal);
            this.Controls.Add(this.bt_retroceder_domicilio);
            this.Controls.Add(this.tx_area);
            this.Controls.Add(this.tx_direccion);
            this.Controls.Add(this.rb_domicilio);
            this.Controls.Add(this.tx_telefono_cliente);
            this.Controls.Add(this.lb_area);
            this.Controls.Add(this.rb_llevar);
            this.Controls.Add(this.lb_telefono_cliente);
            this.Controls.Add(this.tx_mesa);
            this.Controls.Add(this.lb_direccion);
            this.Controls.Add(this.lb_mesa);
            this.Controls.Add(this.bt_salir);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.rb_sucursal);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bt_retroceder_llevar);
            this.Name = "RealizarPedido";
            this.Text = "Realizar pedido";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_mesa;
        private System.Windows.Forms.TextBox tx_mesa;
        private System.Windows.Forms.Button bt_platillo1;
        private System.Windows.Forms.Button bt_platillo2;
        private System.Windows.Forms.Button bt_platillo3;
        private System.Windows.Forms.Button bt_platillo4;
        private System.Windows.Forms.Button bt_platillo5;
        private System.Windows.Forms.Button bt_platillo6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button bt_bebida1;
        private System.Windows.Forms.Button bt_bebida2;
        private System.Windows.Forms.Button bt_bebida3;
        private System.Windows.Forms.Button bt_bebida4;
        private System.Windows.Forms.Button bt_bebida5;
        private System.Windows.Forms.Button bt_bebida6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button bt_postre1;
        private System.Windows.Forms.Button bt_postre2;
        private System.Windows.Forms.Button bt_postre3;
        private System.Windows.Forms.Button bt_postre4;
        private System.Windows.Forms.Button bt_postre5;
        private System.Windows.Forms.Button bt_postre6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button bt_pagar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bt_salir;
        private System.Windows.Forms.Button bt_generar_cuenta;
        private System.Windows.Forms.Label lb_monto_total;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rb_sucursal;
        private System.Windows.Forms.RadioButton rb_llevar;
        private System.Windows.Forms.RadioButton rb_domicilio;
        private System.Windows.Forms.TextBox tx_area;
        private System.Windows.Forms.Label lb_area;
        private System.Windows.Forms.TextBox tx_telefono_cliente;
        private System.Windows.Forms.Label lb_telefono_cliente;
        private System.Windows.Forms.Label lb_direccion;
        private System.Windows.Forms.TextBox tx_direccion;
        private System.Windows.Forms.Button bt_confirmar;
        private System.Windows.Forms.Button bt_retroceder_domicilio;
        private System.Windows.Forms.Button bt_retroceder_sucursal;
        private System.Windows.Forms.Button bt_retroceder_llevar;
        private System.Windows.Forms.Label lb_id_empleado;
        private System.Windows.Forms.TextBox tx_id_empleado;
        private System.Windows.Forms.TextBox tx_id_cliente;
        private System.Windows.Forms.Label lb_id_cliente;
    }
}