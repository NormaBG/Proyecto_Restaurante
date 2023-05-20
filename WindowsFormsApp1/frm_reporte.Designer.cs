namespace WindowsFormsApp1
{
    partial class frm_reporte
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.dataTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ds = new WindowsFormsApp1.Ds();
            this.dtp_fecha = new System.Windows.Forms.DateTimePicker();
            this.dtp_fecha2 = new System.Windows.Forms.DateTimePicker();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.txt_nom = new System.Windows.Forms.TextBox();
            this.dataTable1TableAdapter = new WindowsFormsApp1.DsTableAdapters.DataTable1TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).BeginInit();
            this.SuspendLayout();
            // 
            // dataTable1BindingSource
            // 
            this.dataTable1BindingSource.DataMember = "DataTable1";
            this.dataTable1BindingSource.DataSource = this.dsBindingSource;
            // 
            // dsBindingSource
            // 
            this.dsBindingSource.DataSource = this.ds;
            this.dsBindingSource.Position = 0;
            // 
            // ds
            // 
            this.ds.DataSetName = "Ds";
            this.ds.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dtp_fecha
            // 
            this.dtp_fecha.Location = new System.Drawing.Point(85, 25);
            this.dtp_fecha.Name = "dtp_fecha";
            this.dtp_fecha.Size = new System.Drawing.Size(198, 20);
            this.dtp_fecha.TabIndex = 10;
            this.dtp_fecha.Value = new System.DateTime(2023, 3, 26, 16, 46, 59, 0);
            // 
            // dtp_fecha2
            // 
            this.dtp_fecha2.Location = new System.Drawing.Point(387, 25);
            this.dtp_fecha2.Name = "dtp_fecha2";
            this.dtp_fecha2.Size = new System.Drawing.Size(198, 20);
            this.dtp_fecha2.TabIndex = 14;
            this.dtp_fecha2.Value = new System.DateTime(2023, 3, 26, 16, 46, 59, 0);
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.dataTable1BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WindowsFormsApp1.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(-1, -1);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(808, 456);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // txt_nom
            // 
            this.txt_nom.Location = new System.Drawing.Point(376, 52);
            this.txt_nom.Name = "txt_nom";
            this.txt_nom.Size = new System.Drawing.Size(100, 20);
            this.txt_nom.TabIndex = 15;
            // 
            // dataTable1TableAdapter
            // 
            this.dataTable1TableAdapter.ClearBeforeFill = true;
            // 
            // frm_reporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.dtp_fecha);
            this.Controls.Add(this.dtp_fecha2);
            this.Controls.Add(this.txt_nom);
            this.Name = "frm_reporte";
            this.Text = "frm_reporte";
            this.Load += new System.EventHandler(this.frm_reporte_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource dsBindingSource;
        private Ds ds;
        private System.Windows.Forms.BindingSource dataTable1BindingSource;
        private DsTableAdapters.DataTable1TableAdapter dataTable1TableAdapter;
        public System.Windows.Forms.DateTimePicker dtp_fecha;
        public System.Windows.Forms.DateTimePicker dtp_fecha2;
        public Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        public System.Windows.Forms.TextBox txt_nom;
    }
}