namespace WindowsFormsApp1
{
    partial class ConfirmarReservacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfirmarReservacion));
            this.bt_salir = new System.Windows.Forms.Button();
            this.txt_qr = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_telefono = new System.Windows.Forms.TextBox();
            this.bt_confirmar_telefono = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // bt_salir
            // 
            this.bt_salir.BackColor = System.Drawing.Color.Gold;
            this.bt_salir.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_salir.Image = ((System.Drawing.Image)(resources.GetObject("bt_salir.Image")));
            this.bt_salir.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.bt_salir.Location = new System.Drawing.Point(192, 334);
            this.bt_salir.Name = "bt_salir";
            this.bt_salir.Size = new System.Drawing.Size(75, 35);
            this.bt_salir.TabIndex = 5;
            this.bt_salir.Text = "Salir";
            this.bt_salir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_salir.UseVisualStyleBackColor = false;
            this.bt_salir.Click += new System.EventHandler(this.bt_salir_Click);
            // 
            // txt_qr
            // 
            this.txt_qr.Location = new System.Drawing.Point(149, 68);
            this.txt_qr.Name = "txt_qr";
            this.txt_qr.Size = new System.Drawing.Size(128, 20);
            this.txt_qr.TabIndex = 0;
            this.txt_qr.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_qr_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gold;
            this.label2.Location = new System.Drawing.Point(6, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(239, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ó ingresar numero telefonico:";
            // 
            // txt_telefono
            // 
            this.txt_telefono.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_telefono.Location = new System.Drawing.Point(251, 21);
            this.txt_telefono.MaxLength = 10;
            this.txt_telefono.Name = "txt_telefono";
            this.txt_telefono.Size = new System.Drawing.Size(165, 26);
            this.txt_telefono.TabIndex = 2;
            this.txt_telefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_telefono_KeyPress);
            // 
            // bt_confirmar_telefono
            // 
            this.bt_confirmar_telefono.BackColor = System.Drawing.Color.Gold;
            this.bt_confirmar_telefono.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_confirmar_telefono.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bt_confirmar_telefono.Image = ((System.Drawing.Image)(resources.GetObject("bt_confirmar_telefono.Image")));
            this.bt_confirmar_telefono.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_confirmar_telefono.Location = new System.Drawing.Point(153, 67);
            this.bt_confirmar_telefono.Name = "bt_confirmar_telefono";
            this.bt_confirmar_telefono.Size = new System.Drawing.Size(124, 38);
            this.bt_confirmar_telefono.TabIndex = 4;
            this.bt_confirmar_telefono.Text = "Confirmar";
            this.bt_confirmar_telefono.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_confirmar_telefono.UseVisualStyleBackColor = false;
            this.bt_confirmar_telefono.Click += new System.EventHandler(this.bt_confirmar_telefono_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bt_confirmar_telefono);
            this.groupBox1.Controls.Add(this.txt_telefono);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 217);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(425, 111);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txt_qr);
            this.groupBox2.Location = new System.Drawing.Point(12, 41);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(425, 127);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(149, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Escanear QR:";
            // 
            // ConfirmarReservacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(26)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(451, 381);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.bt_salir);
            this.Controls.Add(this.groupBox1);
            this.Name = "ConfirmarReservacion";
            this.Text = "ConfirmarReservacion";
            this.Load += new System.EventHandler(this.ConfirmarReservacion_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button bt_salir;
        private System.Windows.Forms.TextBox txt_qr;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_telefono;
        private System.Windows.Forms.Button bt_confirmar_telefono;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
    }
}