namespace WindowsFormsApp1
{
    partial class frm_reporte2
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
            this.dataTable2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ds = new WindowsFormsApp1.Ds();
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dataTable2TableAdapter = new WindowsFormsApp1.DsTableAdapters.DataTable2TableAdapter();
            this.dtp_fecha1 = new System.Windows.Forms.DateTimePicker();
            this.dtp_fecha2 = new System.Windows.Forms.DateTimePicker();
            this.dataTable2BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataTable2BindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataTable2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable2BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable2BindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataTable2BindingSource
            // 
            this.dataTable2BindingSource.DataMember = "DataTable2";
            this.dataTable2BindingSource.DataSource = this.dsBindingSource;
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
            // reportViewer2
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.dataTable2BindingSource2;
            this.reportViewer2.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer2.LocalReport.ReportEmbeddedResource = "WindowsFormsApp1.Report2.rdlc";
            this.reportViewer2.Location = new System.Drawing.Point(-1, 1);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.ServerReport.BearerToken = null;
            this.reportViewer2.Size = new System.Drawing.Size(801, 449);
            this.reportViewer2.TabIndex = 0;
            this.reportViewer2.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // dataTable2TableAdapter
            // 
            this.dataTable2TableAdapter.ClearBeforeFill = true;
            // 
            // dtp_fecha1
            // 
            this.dtp_fecha1.Location = new System.Drawing.Point(128, 26);
            this.dtp_fecha1.Name = "dtp_fecha1";
            this.dtp_fecha1.Size = new System.Drawing.Size(198, 20);
            this.dtp_fecha1.TabIndex = 11;
            this.dtp_fecha1.Value = new System.DateTime(2023, 3, 26, 16, 46, 59, 0);
            // 
            // dtp_fecha2
            // 
            this.dtp_fecha2.Location = new System.Drawing.Point(463, 26);
            this.dtp_fecha2.Name = "dtp_fecha2";
            this.dtp_fecha2.Size = new System.Drawing.Size(198, 20);
            this.dtp_fecha2.TabIndex = 12;
            this.dtp_fecha2.Value = new System.DateTime(2023, 3, 26, 16, 46, 59, 0);
            // 
            // dataTable2BindingSource1
            // 
            this.dataTable2BindingSource1.DataMember = "DataTable2";
            this.dataTable2BindingSource1.DataSource = this.dsBindingSource;
            // 
            // dataTable2BindingSource2
            // 
            this.dataTable2BindingSource2.DataMember = "DataTable2";
            this.dataTable2BindingSource2.DataSource = this.dsBindingSource;
            // 
            // frm_reporte2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer2);
            this.Controls.Add(this.dtp_fecha1);
            this.Controls.Add(this.dtp_fecha2);
            this.Name = "frm_reporte2";
            this.Text = "frm_reporte2";
            this.Load += new System.EventHandler(this.frm_reporte2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataTable2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable2BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable2BindingSource2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
        private System.Windows.Forms.BindingSource dsBindingSource;
        private Ds ds;
        private System.Windows.Forms.BindingSource dataTable2BindingSource;
        private DsTableAdapters.DataTable2TableAdapter dataTable2TableAdapter;
        public System.Windows.Forms.DateTimePicker dtp_fecha1;
        public System.Windows.Forms.DateTimePicker dtp_fecha2;
        private System.Windows.Forms.BindingSource dataTable2BindingSource1;
        private System.Windows.Forms.BindingSource dataTable2BindingSource2;
    }
}