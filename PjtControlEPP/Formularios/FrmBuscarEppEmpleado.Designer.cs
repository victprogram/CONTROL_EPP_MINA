﻿namespace PjtControlEPP.Formularios
{
    partial class FrmBuscarEppEmpleado
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
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn1 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.radGroupBox2 = new Telerik.WinControls.UI.RadGroupBox();
            this.dtgEmpleado = new Telerik.WinControls.UI.RadGridView();
            this.filtroempleadoeppBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.consultas = new PjtControlEPP.Consultas();
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.DtpFinal = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.DtpInicio = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.filtroempleadoeppTableAdapter = new PjtControlEPP.ConsultasTableAdapters.filtroempleadoeppTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox2)).BeginInit();
            this.radGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgEmpleado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgEmpleado.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filtroempleadoeppBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Verdana", 10F);
            this.btnGuardar.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnGuardar.Location = new System.Drawing.Point(330, 477);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(181, 37);
            this.btnGuardar.TabIndex = 195;
            this.btnGuardar.Text = "Aceptar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Verdana", 10F);
            this.btnCancelar.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnCancelar.Location = new System.Drawing.Point(517, 477);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(180, 37);
            this.btnCancelar.TabIndex = 196;
            this.btnCancelar.Text = "Cerrar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // radGroupBox2
            // 
            this.radGroupBox2.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox2.Controls.Add(this.dtgEmpleado);
            this.radGroupBox2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radGroupBox2.HeaderText = "SELECCIONE EL EMPLEADO";
            this.radGroupBox2.Location = new System.Drawing.Point(194, 144);
            this.radGroupBox2.Name = "radGroupBox2";
            this.radGroupBox2.Size = new System.Drawing.Size(602, 327);
            this.radGroupBox2.TabIndex = 194;
            this.radGroupBox2.Text = "SELECCIONE EL EMPLEADO";
            // 
            // dtgEmpleado
            // 
            this.dtgEmpleado.Location = new System.Drawing.Point(6, 28);
            // 
            // 
            // 
            gridViewDecimalColumn1.DataType = typeof(int);
            gridViewDecimalColumn1.FieldName = "idempleado";
            gridViewDecimalColumn1.HeaderText = "NO";
            gridViewDecimalColumn1.IsAutoGenerated = true;
            gridViewDecimalColumn1.Name = "idempleado";
            gridViewDecimalColumn1.Width = 110;
            gridViewTextBoxColumn1.FieldName = "NombreEmpleado";
            gridViewTextBoxColumn1.HeaderText = "NOMBRE";
            gridViewTextBoxColumn1.IsAutoGenerated = true;
            gridViewTextBoxColumn1.Name = "NombreEmpleado";
            gridViewTextBoxColumn1.Width = 350;
            gridViewTextBoxColumn2.FieldName = "Cedula";
            gridViewTextBoxColumn2.HeaderText = "CEDULA";
            gridViewTextBoxColumn2.IsAutoGenerated = true;
            gridViewTextBoxColumn2.Name = "Cedula";
            gridViewTextBoxColumn2.Width = 110;
            this.dtgEmpleado.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewDecimalColumn1,
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2});
            this.dtgEmpleado.MasterTemplate.DataSource = this.filtroempleadoeppBindingSource;
            this.dtgEmpleado.MasterTemplate.EnableFiltering = true;
            this.dtgEmpleado.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.dtgEmpleado.Name = "dtgEmpleado";
            this.dtgEmpleado.ReadOnly = true;
            this.dtgEmpleado.Size = new System.Drawing.Size(591, 284);
            this.dtgEmpleado.TabIndex = 198;
            // 
            // filtroempleadoeppBindingSource
            // 
            this.filtroempleadoeppBindingSource.DataMember = "filtroempleadoepp";
            this.filtroempleadoeppBindingSource.DataSource = this.consultas;
            // 
            // consultas
            // 
            this.consultas.DataSetName = "Consultas";
            this.consultas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Controls.Add(this.DtpFinal);
            this.radGroupBox1.Controls.Add(this.label3);
            this.radGroupBox1.Controls.Add(this.DtpInicio);
            this.radGroupBox1.Controls.Add(this.label5);
            this.radGroupBox1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radGroupBox1.HeaderText = "SELECCIONE UN RANGO DE FECHA ";
            this.radGroupBox1.Location = new System.Drawing.Point(194, 50);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Size = new System.Drawing.Size(602, 88);
            this.radGroupBox1.TabIndex = 193;
            this.radGroupBox1.Text = "SELECCIONE UN RANGO DE FECHA ";
            // 
            // DtpFinal
            // 
            this.DtpFinal.CalendarTitleForeColor = System.Drawing.Color.SteelBlue;
            this.DtpFinal.Font = new System.Drawing.Font("Verdana", 9F);
            this.DtpFinal.Location = new System.Drawing.Point(117, 56);
            this.DtpFinal.Name = "DtpFinal";
            this.DtpFinal.Size = new System.Drawing.Size(261, 22);
            this.DtpFinal.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 18);
            this.label3.TabIndex = 8;
            this.label3.Text = "Fecha inicio";
            // 
            // DtpInicio
            // 
            this.DtpInicio.CalendarTitleForeColor = System.Drawing.Color.SteelBlue;
            this.DtpInicio.Font = new System.Drawing.Font("Verdana", 9F);
            this.DtpInicio.Location = new System.Drawing.Point(117, 28);
            this.DtpInicio.Name = "DtpInicio";
            this.DtpInicio.Size = new System.Drawing.Size(261, 22);
            this.DtpInicio.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 18);
            this.label5.TabIndex = 9;
            this.label5.Text = "Fecha final";
            // 
            // txtTitle
            // 
            this.txtTitle.BackColor = System.Drawing.Color.LightSkyBlue;
            this.txtTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtTitle.Enabled = false;
            this.txtTitle.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitle.ForeColor = System.Drawing.Color.Black;
            this.txtTitle.Location = new System.Drawing.Point(0, 0);
            this.txtTitle.Multiline = true;
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.ReadOnly = true;
            this.txtTitle.Size = new System.Drawing.Size(1024, 20);
            this.txtTitle.TabIndex = 197;
            this.txtTitle.Text = "Listado de empleados para consultar";
            // 
            // filtroempleadoeppTableAdapter
            // 
            this.filtroempleadoeppTableAdapter.ClearBeforeFill = true;
            // 
            // FrmBuscarEppEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(1024, 600);
            this.ControlBox = false;
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.radGroupBox2);
            this.Controls.Add(this.radGroupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmBuscarEppEmpleado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmBuscarEppEmpleado";
            this.Load += new System.EventHandler(this.FrmBuscarEppEmpleado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox2)).EndInit();
            this.radGroupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgEmpleado.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgEmpleado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filtroempleadoeppBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            this.radGroupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox2;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private System.Windows.Forms.DateTimePicker DtpFinal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker DtpInicio;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTitle;
        private Telerik.WinControls.UI.RadGridView dtgEmpleado;
        private Consultas consultas;
        private System.Windows.Forms.BindingSource filtroempleadoeppBindingSource;
        private ConsultasTableAdapters.filtroempleadoeppTableAdapter filtroempleadoeppTableAdapter;

    }
}