
namespace gestorLollapalooza.pressLayer.Usuario
{
    partial class frmConsultaUsuario
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gbxFiltros = new System.Windows.Forms.GroupBox();
            this.lblAclaracion = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtbNombre = new System.Windows.Forms.TextBox();
            this.txtbApellido = new System.Windows.Forms.TextBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gbxFiltros.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(531, 426);
            this.dataGridView1.TabIndex = 0;
            // 
            // gbxFiltros
            // 
            this.gbxFiltros.Controls.Add(this.txtbApellido);
            this.gbxFiltros.Controls.Add(this.lblAclaracion);
            this.gbxFiltros.Controls.Add(this.txtbNombre);
            this.gbxFiltros.Controls.Add(this.lblApellido);
            this.gbxFiltros.Controls.Add(this.txtUsuario);
            this.gbxFiltros.Controls.Add(this.lblNombre);
            this.gbxFiltros.Controls.Add(this.lblUsuario);
            this.gbxFiltros.Location = new System.Drawing.Point(549, 12);
            this.gbxFiltros.Name = "gbxFiltros";
            this.gbxFiltros.Size = new System.Drawing.Size(239, 192);
            this.gbxFiltros.TabIndex = 1;
            this.gbxFiltros.TabStop = false;
            this.gbxFiltros.Text = "Filtros";
            // 
            // lblAclaracion
            // 
            this.lblAclaracion.AutoSize = true;
            this.lblAclaracion.Location = new System.Drawing.Point(7, 40);
            this.lblAclaracion.Name = "lblAclaracion";
            this.lblAclaracion.Size = new System.Drawing.Size(67, 13);
            this.lblAclaracion.TabIndex = 2;
            this.lblAclaracion.Text = "Busacar por:";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(28, 80);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(46, 13);
            this.lblUsuario.TabIndex = 3;
            this.lblUsuario.Text = "Usuario:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(27, 113);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 4;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(27, 146);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(47, 13);
            this.lblApellido.TabIndex = 5;
            this.lblApellido.Text = "Apellido:";
            this.lblApellido.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(80, 77);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(100, 20);
            this.txtUsuario.TabIndex = 2;
            // 
            // txtbNombre
            // 
            this.txtbNombre.Location = new System.Drawing.Point(80, 110);
            this.txtbNombre.Name = "txtbNombre";
            this.txtbNombre.Size = new System.Drawing.Size(100, 20);
            this.txtbNombre.TabIndex = 3;
            // 
            // txtbApellido
            // 
            this.txtbApellido.Location = new System.Drawing.Point(80, 143);
            this.txtbApellido.Name = "txtbApellido";
            this.txtbApellido.Size = new System.Drawing.Size(100, 20);
            this.txtbApellido.TabIndex = 4;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(559, 415);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(713, 415);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(75, 23);
            this.btnConsultar.TabIndex = 3;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            // 
            // frmConsultaUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.gbxFiltros);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmConsultaUsuario";
            this.Text = "frmConsultaUsuario";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gbxFiltros.ResumeLayout(false);
            this.gbxFiltros.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox gbxFiltros;
        private System.Windows.Forms.Label lblAclaracion;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox txtbApellido;
        private System.Windows.Forms.TextBox txtbNombre;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnConsultar;
    }
}