
namespace gestorLollapalooza.presLayer.ReportPres
{
    partial class frmReporteUsuarios
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
            this.reportViewerUsuarios = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnConsultar = new gestorLollapalooza.BotonFacha();
            this.cmbPerfil = new System.Windows.Forms.ComboBox();
            this.cbxTraerTodos = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // reportViewerUsuarios
            // 
            this.reportViewerUsuarios.LocalReport.ReportEmbeddedResource = "gestorLollapalooza.ReportLayer.ReportUsuarios.rdlc";
            this.reportViewerUsuarios.Location = new System.Drawing.Point(12, 57);
            this.reportViewerUsuarios.Name = "reportViewerUsuarios";
            this.reportViewerUsuarios.ServerReport.BearerToken = null;
            this.reportViewerUsuarios.Size = new System.Drawing.Size(1105, 466);
            this.reportViewerUsuarios.TabIndex = 0;
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
            this.btnConsultar.Location = new System.Drawing.Point(638, 11);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(150, 40);
            this.btnConsultar.TabIndex = 1;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.TextColor = System.Drawing.Color.White;
            this.btnConsultar.UseVisualStyleBackColor = false;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // cmbPerfil
            // 
            this.cmbPerfil.FormattingEnabled = true;
            this.cmbPerfil.Location = new System.Drawing.Point(54, 22);
            this.cmbPerfil.Name = "cmbPerfil";
            this.cmbPerfil.Size = new System.Drawing.Size(121, 21);
            this.cmbPerfil.TabIndex = 2;
            // 
            // cbxTraerTodos
            // 
            this.cbxTraerTodos.AutoSize = true;
            this.cbxTraerTodos.Location = new System.Drawing.Point(181, 24);
            this.cbxTraerTodos.Name = "cbxTraerTodos";
            this.cbxTraerTodos.Size = new System.Drawing.Size(80, 17);
            this.cbxTraerTodos.TabIndex = 3;
            this.cbxTraerTodos.Text = "Traer todos";
            this.cbxTraerTodos.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Perfil: ";
            // 
            // frmReporteUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1129, 535);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxTraerTodos);
            this.Controls.Add(this.cmbPerfil);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.reportViewerUsuarios);
            this.Name = "frmReporteUsuarios";
            this.Text = "frmReporteUsuarios";
            this.Load += new System.EventHandler(this.frmReporteUsuarios_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewerUsuarios;
        private BotonFacha btnConsultar;
        private System.Windows.Forms.ComboBox cmbPerfil;
        private System.Windows.Forms.CheckBox cbxTraerTodos;
        private System.Windows.Forms.Label label1;
    }
}