
namespace gestorLollapalooza.presLayer.ReportPres
{
    partial class frmReporteGM
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
            this.reportViewerGM = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dataSetGruposMusicales = new gestorLollapalooza.ReportLayer.DataSetGruposMusicales();
            this.dataTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataSetGruposMusicales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewerGM
            // 
            this.reportViewerGM.LocalReport.ReportEmbeddedResource = "gestorLollapalooza.ReportLayer.ReportGruposMusicales.rdlc";
            this.reportViewerGM.Location = new System.Drawing.Point(12, 12);
            this.reportViewerGM.Name = "reportViewerGM";
            this.reportViewerGM.ServerReport.BearerToken = null;
            this.reportViewerGM.Size = new System.Drawing.Size(776, 426);
            this.reportViewerGM.TabIndex = 0;
            // 
            // dataSetGruposMusicales
            // 
            this.dataSetGruposMusicales.DataSetName = "DataSetGruposMusicales";
            this.dataSetGruposMusicales.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataTable1BindingSource
            // 
            this.dataTable1BindingSource.DataMember = "DataTable1";
            this.dataTable1BindingSource.DataSource = this.dataSetGruposMusicales;
            // 
            // ReporteGM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewerGM);
            this.Name = "ReporteGM";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSetGruposMusicales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewerGM;
        private System.Windows.Forms.BindingSource dataTable1BindingSource;
        private ReportLayer.DataSetGruposMusicales dataSetGruposMusicales;
    }
}