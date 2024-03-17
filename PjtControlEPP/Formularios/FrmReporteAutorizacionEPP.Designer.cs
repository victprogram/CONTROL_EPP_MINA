namespace PjtControlEPP.Formularios
{
    partial class FrmReporteAutorizacionEPP
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
            this.reporteAutorizacionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportes = new PjtControlEPP.Reportes();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.reporteAutorizacionTableAdapter = new PjtControlEPP.ReportesTableAdapters.ReporteAutorizacionTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.reporteAutorizacionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportes)).BeginInit();
            this.SuspendLayout();
            // 
            // reporteAutorizacionBindingSource
            // 
            this.reporteAutorizacionBindingSource.DataMember = "ReporteAutorizacion";
            this.reporteAutorizacionBindingSource.DataSource = this.reportes;
            // 
            // reportes
            // 
            this.reportes.DataSetName = "Reportes";
            this.reportes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.reporteAutorizacionBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "PjtControlEPP.Formularios.ReporteAutorizacion.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1008, 561);
            this.reportViewer1.TabIndex = 0;
            // 
            // reporteAutorizacionTableAdapter
            // 
            this.reporteAutorizacionTableAdapter.ClearBeforeFill = true;
            // 
            // FrmReporteAutorizacionEPP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 561);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmReporteAutorizacionEPP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmReporteAutorizacionPoliza";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmReporteAutorizacionPoliza_Load);
            ((System.ComponentModel.ISupportInitialize)(this.reporteAutorizacionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private Reportes reportes;
        private System.Windows.Forms.BindingSource reporteAutorizacionBindingSource;
        private ReportesTableAdapters.ReporteAutorizacionTableAdapter reporteAutorizacionTableAdapter;
    }
}