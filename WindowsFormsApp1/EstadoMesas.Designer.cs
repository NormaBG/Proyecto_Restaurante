namespace WindowsFormsApp1
{
    partial class EstadoMesas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EstadoMesas));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tx_numero = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tx_area = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bt_buscar = new System.Windows.Forms.Button();
            this.bt_salir = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(26)))), ((int)(((byte)(36)))));
            this.groupBox1.Controls.Add(this.tx_numero);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tx_area);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.ForeColor = System.Drawing.Color.Gold;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(730, 156);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de mesa";
            // 
            // tx_numero
            // 
            this.tx_numero.Location = new System.Drawing.Point(467, 65);
            this.tx_numero.Name = "tx_numero";
            this.tx_numero.Size = new System.Drawing.Size(100, 20);
            this.tx_numero.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(385, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 21);
            this.label1.TabIndex = 12;
            this.label1.Text = "Numero:";
            // 
            // tx_area
            // 
            this.tx_area.Location = new System.Drawing.Point(203, 65);
            this.tx_area.Name = "tx_area";
            this.tx_area.Size = new System.Drawing.Size(100, 20);
            this.tx_area.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gold;
            this.label4.Location = new System.Drawing.Point(144, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 21);
            this.label4.TabIndex = 10;
            this.label4.Text = "Area:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 218);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(730, 213);
            this.dataGridView1.TabIndex = 7;
            // 
            // bt_buscar
            // 
            this.bt_buscar.BackColor = System.Drawing.Color.Gold;
            this.bt_buscar.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_buscar.Image = ((System.Drawing.Image)(resources.GetObject("bt_buscar.Image")));
            this.bt_buscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_buscar.Location = new System.Drawing.Point(330, 174);
            this.bt_buscar.Name = "bt_buscar";
            this.bt_buscar.Size = new System.Drawing.Size(99, 38);
            this.bt_buscar.TabIndex = 13;
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
            this.bt_salir.TabIndex = 19;
            this.bt_salir.Text = "Salir";
            this.bt_salir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_salir.UseVisualStyleBackColor = false;
            this.bt_salir.Click += new System.EventHandler(this.bt_salir_Click);
            // 
            // EstadoMesas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(26)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(752, 482);
            this.Controls.Add(this.bt_salir);
            this.Controls.Add(this.bt_buscar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "EstadoMesas";
            this.Text = "EstadoMesas";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox tx_numero;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tx_area;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bt_buscar;
        private System.Windows.Forms.Button bt_salir;
    }
}