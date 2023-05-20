namespace WindowsFormsApp1
{
    partial class ControlClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ControlClientes));
            this.bt_eliminar = new System.Windows.Forms.Button();
            this.bt_agregar = new System.Windows.Forms.Button();
            this.bt_buscar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_Correo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_domicilio = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_telefono = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_apellidos = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_id_cliente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgw_Consultaclientes = new System.Windows.Forms.DataGridView();
            this.bt_salir = new System.Windows.Forms.Button();
            this.bt_modificar = new System.Windows.Forms.Button();
            this.btn_recargar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_Consultaclientes)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_eliminar
            // 
            this.bt_eliminar.BackColor = System.Drawing.Color.Gold;
            this.bt_eliminar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_eliminar.Image = ((System.Drawing.Image)(resources.GetObject("bt_eliminar.Image")));
            this.bt_eliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_eliminar.Location = new System.Drawing.Point(206, 174);
            this.bt_eliminar.Name = "bt_eliminar";
            this.bt_eliminar.Size = new System.Drawing.Size(111, 38);
            this.bt_eliminar.TabIndex = 17;
            this.bt_eliminar.Text = "Eliminar";
            this.bt_eliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_eliminar.UseVisualStyleBackColor = false;
            this.bt_eliminar.Click += new System.EventHandler(this.bt_eliminar_Click);
            // 
            // bt_agregar
            // 
            this.bt_agregar.BackColor = System.Drawing.Color.Gold;
            this.bt_agregar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_agregar.Image = ((System.Drawing.Image)(resources.GetObject("bt_agregar.Image")));
            this.bt_agregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_agregar.Location = new System.Drawing.Point(21, 174);
            this.bt_agregar.Name = "bt_agregar";
            this.bt_agregar.Size = new System.Drawing.Size(118, 38);
            this.bt_agregar.TabIndex = 16;
            this.bt_agregar.Text = "Agregar";
            this.bt_agregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_agregar.UseVisualStyleBackColor = false;
            this.bt_agregar.Click += new System.EventHandler(this.bt_agregar_Click);
            // 
            // bt_buscar
            // 
            this.bt_buscar.BackColor = System.Drawing.Color.Gold;
            this.bt_buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_buscar.Image = ((System.Drawing.Image)(resources.GetObject("bt_buscar.Image")));
            this.bt_buscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_buscar.Location = new System.Drawing.Point(564, 175);
            this.bt_buscar.Name = "bt_buscar";
            this.bt_buscar.Size = new System.Drawing.Size(99, 38);
            this.bt_buscar.TabIndex = 12;
            this.bt_buscar.Text = "Buscar";
            this.bt_buscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_buscar.UseVisualStyleBackColor = false;
            this.bt_buscar.Click += new System.EventHandler(this.bt_buscar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_Correo);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txt_domicilio);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txt_telefono);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_apellidos);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_nombre);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_id_cliente);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.Color.Gold;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(730, 156);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de clientes";
            // 
            // txt_Correo
            // 
            this.txt_Correo.Location = new System.Drawing.Point(568, 99);
            this.txt_Correo.Name = "txt_Correo";
            this.txt_Correo.Size = new System.Drawing.Size(155, 20);
            this.txt_Correo.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Gold;
            this.label6.Location = new System.Drawing.Point(495, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 21);
            this.label6.TabIndex = 12;
            this.label6.Text = "Correo:";
            // 
            // txt_domicilio
            // 
            this.txt_domicilio.Location = new System.Drawing.Point(354, 100);
            this.txt_domicilio.Name = "txt_domicilio";
            this.txt_domicilio.Size = new System.Drawing.Size(105, 20);
            this.txt_domicilio.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Gold;
            this.label5.Location = new System.Drawing.Point(262, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 21);
            this.label5.TabIndex = 10;
            this.label5.Text = "Domicilio:";
            // 
            // txt_telefono
            // 
            this.txt_telefono.Location = new System.Drawing.Point(124, 101);
            this.txt_telefono.Name = "txt_telefono";
            this.txt_telefono.Size = new System.Drawing.Size(100, 20);
            this.txt_telefono.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gold;
            this.label4.Location = new System.Drawing.Point(38, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 21);
            this.label4.TabIndex = 8;
            this.label4.Text = "Telefono:";
            // 
            // txt_apellidos
            // 
            this.txt_apellidos.Location = new System.Drawing.Point(568, 37);
            this.txt_apellidos.Name = "txt_apellidos";
            this.txt_apellidos.Size = new System.Drawing.Size(155, 20);
            this.txt_apellidos.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gold;
            this.label3.Location = new System.Drawing.Point(478, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "Apellidos:";
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(326, 38);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(133, 20);
            this.txt_nombre.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gold;
            this.label2.Location = new System.Drawing.Point(243, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nombre:";
            // 
            // txt_id_cliente
            // 
            this.txt_id_cliente.Location = new System.Drawing.Point(124, 39);
            this.txt_id_cliente.Name = "txt_id_cliente";
            this.txt_id_cliente.Size = new System.Drawing.Size(100, 20);
            this.txt_id_cliente.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(5, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID de cliente:";
            // 
            // dgw_Consultaclientes
            // 
            this.dgw_Consultaclientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_Consultaclientes.Location = new System.Drawing.Point(12, 218);
            this.dgw_Consultaclientes.Name = "dgw_Consultaclientes";
            this.dgw_Consultaclientes.ReadOnly = true;
            this.dgw_Consultaclientes.Size = new System.Drawing.Size(730, 213);
            this.dgw_Consultaclientes.TabIndex = 13;
            this.dgw_Consultaclientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgw_Consultaclientes_CellContentClick);
            // 
            // bt_salir
            // 
            this.bt_salir.BackColor = System.Drawing.Color.Gold;
            this.bt_salir.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_salir.Image = ((System.Drawing.Image)(resources.GetObject("bt_salir.Image")));
            this.bt_salir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_salir.Location = new System.Drawing.Point(349, 437);
            this.bt_salir.Name = "bt_salir";
            this.bt_salir.Size = new System.Drawing.Size(78, 38);
            this.bt_salir.TabIndex = 18;
            this.bt_salir.Text = "Salir";
            this.bt_salir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_salir.UseVisualStyleBackColor = false;
            this.bt_salir.Click += new System.EventHandler(this.bt_salir_Click);
            // 
            // bt_modificar
            // 
            this.bt_modificar.BackColor = System.Drawing.Color.Gold;
            this.bt_modificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_modificar.Image = ((System.Drawing.Image)(resources.GetObject("bt_modificar.Image")));
            this.bt_modificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_modificar.Location = new System.Drawing.Point(389, 174);
            this.bt_modificar.Name = "bt_modificar";
            this.bt_modificar.Size = new System.Drawing.Size(111, 38);
            this.bt_modificar.TabIndex = 19;
            this.bt_modificar.Text = "Modificar";
            this.bt_modificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_modificar.UseVisualStyleBackColor = false;
            this.bt_modificar.Click += new System.EventHandler(this.bt_modificar_Click);
            // 
            // btn_recargar
            // 
            this.btn_recargar.BackColor = System.Drawing.Color.Gold;
            this.btn_recargar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_recargar.Image = ((System.Drawing.Image)(resources.GetObject("btn_recargar.Image")));
            this.btn_recargar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_recargar.Location = new System.Drawing.Point(702, 175);
            this.btn_recargar.Name = "btn_recargar";
            this.btn_recargar.Size = new System.Drawing.Size(40, 42);
            this.btn_recargar.TabIndex = 21;
            this.btn_recargar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_recargar.UseVisualStyleBackColor = false;
            this.btn_recargar.Click += new System.EventHandler(this.btn_recargar_Click);
            // 
            // ControlClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(26)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(759, 486);
            this.Controls.Add(this.btn_recargar);
            this.Controls.Add(this.bt_modificar);
            this.Controls.Add(this.bt_salir);
            this.Controls.Add(this.bt_eliminar);
            this.Controls.Add(this.bt_agregar);
            this.Controls.Add(this.bt_buscar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgw_Consultaclientes);
            this.Name = "ControlClientes";
            this.Text = "ControlClientes";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_Consultaclientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_eliminar;
        private System.Windows.Forms.Button bt_agregar;
        private System.Windows.Forms.Button bt_buscar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgw_Consultaclientes;
        private System.Windows.Forms.TextBox txt_domicilio;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_telefono;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_apellidos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_id_cliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_salir;
        private System.Windows.Forms.Button bt_modificar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_Correo;
        private System.Windows.Forms.Button btn_recargar;
    }
}