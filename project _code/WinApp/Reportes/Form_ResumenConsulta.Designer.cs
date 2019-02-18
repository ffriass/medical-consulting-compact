namespace WinApp
{
    partial class Form_ResumenConsulta
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
            this.rptvResumenConsulta = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ResumenConsultaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSetPrincipal = new WinApp.DataSetPrincipal();
            this.ResumenConsultaTableAdapter = new WinApp.DataSetPrincipalTableAdapters.ResumenConsultaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ResumenConsultaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetPrincipal)).BeginInit();
            this.SuspendLayout();
            // 
            // rptvResumenConsulta
            // 
            this.rptvResumenConsulta.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.ResumenConsultaBindingSource;
            this.rptvResumenConsulta.LocalReport.DataSources.Add(reportDataSource1);
            this.rptvResumenConsulta.LocalReport.ReportEmbeddedResource = "WinApp.Reportes.rptResumenConsulta.rdlc";
            this.rptvResumenConsulta.Location = new System.Drawing.Point(0, 0);
            this.rptvResumenConsulta.Name = "rptvResumenConsulta";
            this.rptvResumenConsulta.Size = new System.Drawing.Size(872, 591);
            this.rptvResumenConsulta.TabIndex = 0;
            this.rptvResumenConsulta.Load += new System.EventHandler(this.rptResumenConsulta_Load);
            // 
            // ResumenConsultaBindingSource
            // 
            this.ResumenConsultaBindingSource.DataMember = "ResumenConsulta";
            this.ResumenConsultaBindingSource.DataSource = this.DataSetPrincipal;
            // 
            // DataSetPrincipal
            // 
            this.DataSetPrincipal.DataSetName = "DataSetPrincipal";
            this.DataSetPrincipal.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ResumenConsultaTableAdapter
            // 
            this.ResumenConsultaTableAdapter.ClearBeforeFill = true;
            // 
            // Form_ResumenConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 591);
            this.Controls.Add(this.rptvResumenConsulta);
            this.Name = "Form_ResumenConsulta";
            this.Text = "Form_ResumenConsulta";
            this.Load += new System.EventHandler(this.Form_ResumenConsulta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ResumenConsultaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetPrincipal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rptvResumenConsulta;
        private System.Windows.Forms.BindingSource ResumenConsultaBindingSource;
        private DataSetPrincipal DataSetPrincipal;
        private DataSetPrincipalTableAdapters.ResumenConsultaTableAdapter ResumenConsultaTableAdapter;
    }
}