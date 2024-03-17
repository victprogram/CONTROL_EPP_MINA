namespace PjtControlEPP.Formularios
{
    partial class FrmReporteAutorizacionPorEmpleado
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
            this.reporteAutorizacionPorEmpleadoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportes = new PjtControlEPP.Reportes();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.reporteAutorizacionPorEmpleadoTableAdapter = new PjtControlEPP.ReportesTableAdapters.ReporteAutorizacionPorEmpleadoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.reporteAutorizacionPorEmpleadoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportes)).BeginInit();
            this.SuspendLayout();
            // 
            // reporteAutorizacionPorEmpleadoBindingSource
            // 
            this.reporteAutorizacionPorEmpleadoBindingSource.DataMember = "ReporteAutorizacionPorEmpleado";
            this.reporteAutorizacionPorEmpleadoBindingSource.DataSource = this.reportes;
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
            reportDataSource1.Value = this.reporteAutorizacionPorEmpleadoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "PjtControlEPP.Formularios.ReporteAutorizacionEmpleado.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1008, 561);
            this.reportViewer1.TabIndex = 0;
            // 
            // reporteAutorizacionPorEmpleadoTableAdapter
            // 
            this.reporteAutorizacionPorEmpleadoTableAdapter.ClearBeforeFill = true;
            // 
            // FrmReporteAutorizacionPorEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 561);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmReporteAutorizacionPorEmpleado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmReporteAutorizacionPorEmpleado";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmReporteAutorizacionPorEmpleado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.reporteAutorizacionPorEmpleadoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private Reportes reportes;
        private System.Windows.Forms.BindingSource reporteAutorizacionPorEmpleadoBindingSource;
        private ReportesTableAdapters.ReporteAutorizacionPorEmpleadoTableAdapter reporteAutorizacionPorEmpleadoTableAdapter;
    }
}