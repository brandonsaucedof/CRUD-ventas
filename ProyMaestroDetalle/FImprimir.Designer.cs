namespace ProyMaestroDetalle
{
    partial class FImprimir
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DVenta = new ProyMaestroDetalle.DVenta();
            this.DetalleVentaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DetalleVentaTableAdapter = new ProyMaestroDetalle.DVentaTableAdapters.DetalleVentaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DVenta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DetalleVentaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.DetalleVentaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ProyMaestroDetalle.RVentas3.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(526, 295);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // DVenta
            // 
            this.DVenta.DataSetName = "DVenta";
            this.DVenta.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DetalleVentaBindingSource
            // 
            this.DetalleVentaBindingSource.DataMember = "DetalleVenta";
            this.DetalleVentaBindingSource.DataSource = this.DVenta;
            // 
            // DetalleVentaTableAdapter
            // 
            this.DetalleVentaTableAdapter.ClearBeforeFill = true;
            // 
            // FImprimir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 295);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FImprimir";
            this.Text = "FImprimir";
            this.Load += new System.EventHandler(this.FImprimir_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DVenta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DetalleVentaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource DetalleVentaBindingSource;
        private DVenta DVenta;
        private DVentaTableAdapters.DetalleVentaTableAdapter DetalleVentaTableAdapter;
    }
}