
namespace gestorLollapalooza.presLayer.ReportPres
{
    partial class frmReporteFestival
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
            this.rvFestival = new Microsoft.Reporting.WinForms.ReportViewer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chTodos = new System.Windows.Forms.CheckBox();
            this.cbVigentes = new System.Windows.Forms.CheckBox();
            this.btnConsultar = new gestorLollapalooza.BotonFacha();
            this.label2 = new System.Windows.Forms.Label();
            this.numa = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.numHasta = new System.Windows.Forms.NumericUpDown();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHasta)).BeginInit();
            this.SuspendLayout();
            // 
            // rvFestival
            // 
            this.rvFestival.LocalReport.ReportEmbeddedResource = "gestorLollapalooza.ReportLayer.ReportFestival.rdlc";
            this.rvFestival.Location = new System.Drawing.Point(44, 201);
            this.rvFestival.Name = "rvFestival";
            this.rvFestival.ServerReport.BearerToken = null;
            this.rvFestival.Size = new System.Drawing.Size(923, 435);
            this.rvFestival.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnConsultar);
            this.groupBox1.Controls.Add(this.numHasta);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.numa);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.chTodos);
            this.groupBox1.Controls.Add(this.cbVigentes);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(159)))), ((int)(((byte)(161)))));
            this.groupBox1.Location = new System.Drawing.Point(179, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(654, 136);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros";
            // 
            // chTodos
            // 
            this.chTodos.AutoSize = true;
            this.chTodos.Location = new System.Drawing.Point(276, 57);
            this.chTodos.Name = "chTodos";
            this.chTodos.Size = new System.Drawing.Size(117, 17);
            this.chTodos.TabIndex = 43;
            this.chTodos.Text = "Todos los exitentes";
            this.chTodos.UseVisualStyleBackColor = true;
            // 
            // cbVigentes
            // 
            this.cbVigentes.AutoSize = true;
            this.cbVigentes.Location = new System.Drawing.Point(276, 34);
            this.cbVigentes.Name = "cbVigentes";
            this.cbVigentes.Size = new System.Drawing.Size(90, 17);
            this.cbVigentes.TabIndex = 40;
            this.cbVigentes.Text = "Solo vigentes";
            this.cbVigentes.UseVisualStyleBackColor = true;
            // 
            // btnConsultar
            // 
            this.btnConsultar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(154)))));
            this.btnConsultar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(154)))));
            this.btnConsultar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnConsultar.BorderRadius = 20;
            this.btnConsultar.BorderSize = 0;
            this.btnConsultar.FlatAppearance.BorderSize = 0;
            this.btnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultar.ForeColor = System.Drawing.Color.White;
            this.btnConsultar.Location = new System.Drawing.Point(505, 38);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(117, 49);
            this.btnConsultar.TabIndex = 8;
            this.btnConsultar.Text = "Generar Reporte";
            this.btnConsultar.TextColor = System.Drawing.Color.White;
            this.btnConsultar.UseVisualStyleBackColor = false;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 46;
            this.label2.Text = "Apartir del año:";
            // 
            // numa
            // 
            this.numa.Location = new System.Drawing.Point(129, 36);
            this.numa.Maximum = new decimal(new int[] {
            2100,
            0,
            0,
            0});
            this.numa.Minimum = new decimal(new int[] {
            1950,
            0,
            0,
            0});
            this.numa.Name = "numa";
            this.numa.Size = new System.Drawing.Size(120, 20);
            this.numa.TabIndex = 47;
            this.numa.Value = new decimal(new int[] {
            2021,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 48;
            this.label1.Text = "Hasta el año:";
            // 
            // numHasta
            // 
            this.numHasta.Location = new System.Drawing.Point(129, 74);
            this.numHasta.Maximum = new decimal(new int[] {
            2100,
            0,
            0,
            0});
            this.numHasta.Minimum = new decimal(new int[] {
            1950,
            0,
            0,
            0});
            this.numHasta.Name = "numHasta";
            this.numHasta.Size = new System.Drawing.Size(120, 20);
            this.numHasta.TabIndex = 49;
            this.numHasta.Value = new decimal(new int[] {
            2050,
            0,
            0,
            0});
            // 
            // frmReporteFestival
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(47)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(1005, 662);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.rvFestival);
            this.Name = "frmReporteFestival";
            this.Text = "frmReporte";
            this.Load += new System.EventHandler(this.frmReporteFestival_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHasta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rvFestival;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cbVigentes;
        private System.Windows.Forms.CheckBox chTodos;
        private BotonFacha btnConsultar;
        private System.Windows.Forms.NumericUpDown numa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numHasta;
        private System.Windows.Forms.Label label1;
    }
}