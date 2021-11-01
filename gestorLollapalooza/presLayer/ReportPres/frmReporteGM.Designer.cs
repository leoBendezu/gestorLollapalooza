
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
            this.dataSetGruposMusicales = new gestorLollapalooza.ReportLayer.DataSetLollaPalooza();
            this.dataTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.numCantIntegrantesMin = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numCantidadIntegrantesMax = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnConsultar = new gestorLollapalooza.BotonFacha();
            this.chbTraerTodos = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetGruposMusicales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCantIntegrantesMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCantidadIntegrantesMax)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // reportViewerGM
            // 
            this.reportViewerGM.LocalReport.ReportEmbeddedResource = "gestorLollapalooza.ReportLayer.ReportGruposMusicales.rdlc";
            this.reportViewerGM.Location = new System.Drawing.Point(12, 163);
            this.reportViewerGM.Name = "reportViewerGM";
            this.reportViewerGM.ServerReport.BearerToken = null;
            this.reportViewerGM.Size = new System.Drawing.Size(855, 411);
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
            // numCantIntegrantesMin
            // 
            this.numCantIntegrantesMin.Location = new System.Drawing.Point(197, 26);
            this.numCantIntegrantesMin.Name = "numCantIntegrantesMin";
            this.numCantIntegrantesMin.Size = new System.Drawing.Size(120, 20);
            this.numCantIntegrantesMin.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "cantidad de integrantes minima:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "cantidad de integrantes maxima: ";
            // 
            // numCantidadIntegrantesMax
            // 
            this.numCantidadIntegrantesMax.Location = new System.Drawing.Point(197, 55);
            this.numCantidadIntegrantesMax.Name = "numCantidadIntegrantesMax";
            this.numCantidadIntegrantesMax.Size = new System.Drawing.Size(120, 20);
            this.numCantidadIntegrantesMax.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chbTraerTodos);
            this.groupBox1.Controls.Add(this.numCantidadIntegrantesMax);
            this.groupBox1.Controls.Add(this.numCantIntegrantesMin);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(323, 125);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros";
            // 
            // btnConsultar
            // 
            this.btnConsultar.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnConsultar.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnConsultar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnConsultar.BorderRadius = 20;
            this.btnConsultar.BorderSize = 0;
            this.btnConsultar.FlatAppearance.BorderSize = 0;
            this.btnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultar.ForeColor = System.Drawing.Color.White;
            this.btnConsultar.Location = new System.Drawing.Point(717, 52);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(150, 40);
            this.btnConsultar.TabIndex = 7;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.TextColor = System.Drawing.Color.White;
            this.btnConsultar.UseVisualStyleBackColor = false;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // chbTraerTodos
            // 
            this.chbTraerTodos.AutoSize = true;
            this.chbTraerTodos.Location = new System.Drawing.Point(197, 102);
            this.chbTraerTodos.Name = "chbTraerTodos";
            this.chbTraerTodos.Size = new System.Drawing.Size(80, 17);
            this.chbTraerTodos.TabIndex = 8;
            this.chbTraerTodos.Text = "Traer todos";
            this.chbTraerTodos.UseVisualStyleBackColor = true;
            // 
            // frmReporteGM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 586);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.reportViewerGM);
            this.Name = "frmReporteGM";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSetGruposMusicales)).EndInit();
            //((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCantIntegrantesMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCantidadIntegrantesMax)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewerGM;
        private System.Windows.Forms.BindingSource dataTable1BindingSource;
        private ReportLayer.DataSetLollaPalooza dataSetGruposMusicales;
        private System.Windows.Forms.NumericUpDown numCantIntegrantesMin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numCantidadIntegrantesMax;
        private System.Windows.Forms.GroupBox groupBox1;
        private BotonFacha btnConsultar;
        private System.Windows.Forms.CheckBox chbTraerTodos;
    }
}