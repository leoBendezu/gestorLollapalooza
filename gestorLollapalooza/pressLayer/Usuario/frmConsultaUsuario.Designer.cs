
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
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.gbxFiltros = new System.Windows.Forms.GroupBox();
            this.lblAclaracion = new System.Windows.Forms.Label();
            this.lblPerfil = new System.Windows.Forms.Label();
            this.cbPerfil = new System.Windows.Forms.ComboBox();
            this.txtbUsuario = new gestorLollapalooza.frmTextBoxFacha();
            this.btnConsultar = new gestorLollapalooza.BotonFacha();
            this.btnSalir = new gestorLollapalooza.BotonFacha();
            this.txtbApelido = new gestorLollapalooza.frmTextBoxFacha();
            this.txtbNombre = new gestorLollapalooza.frmTextBoxFacha();
            this.clmIdUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmApellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPerfil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmContrasena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.gbxFiltros.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.AllowUserToAddRows = false;
            this.dgvUsuarios.AllowUserToDeleteRows = false;
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmIdUsuario,
            this.clmUsuario,
            this.clmNombre,
            this.clmApellido,
            this.clmPerfil,
            this.clmEmail,
            this.clmContrasena});
            this.dgvUsuarios.Location = new System.Drawing.Point(12, 12);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.ReadOnly = true;
            this.dgvUsuarios.Size = new System.Drawing.Size(580, 426);
            this.dgvUsuarios.TabIndex = 0;
            this.dgvUsuarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // gbxFiltros
            // 
            this.gbxFiltros.Controls.Add(this.txtbApelido);
            this.gbxFiltros.Controls.Add(this.txtbNombre);
            this.gbxFiltros.Controls.Add(this.txtbUsuario);
            this.gbxFiltros.Controls.Add(this.cbPerfil);
            this.gbxFiltros.Controls.Add(this.lblAclaracion);
            this.gbxFiltros.Controls.Add(this.lblPerfil);
            this.gbxFiltros.Location = new System.Drawing.Point(598, 12);
            this.gbxFiltros.Name = "gbxFiltros";
            this.gbxFiltros.Size = new System.Drawing.Size(190, 200);
            this.gbxFiltros.TabIndex = 1;
            this.gbxFiltros.TabStop = false;
            this.gbxFiltros.Text = "Filtros";
            // 
            // lblAclaracion
            // 
            this.lblAclaracion.AutoSize = true;
            this.lblAclaracion.Location = new System.Drawing.Point(10, 18);
            this.lblAclaracion.Name = "lblAclaracion";
            this.lblAclaracion.Size = new System.Drawing.Size(67, 13);
            this.lblAclaracion.TabIndex = 2;
            this.lblAclaracion.Text = "Busacar por:";
            // 
            // lblPerfil
            // 
            this.lblPerfil.AutoSize = true;
            this.lblPerfil.Location = new System.Drawing.Point(24, 170);
            this.lblPerfil.Name = "lblPerfil";
            this.lblPerfil.Size = new System.Drawing.Size(33, 13);
            this.lblPerfil.TabIndex = 5;
            this.lblPerfil.Text = "Perfil:";
            this.lblPerfil.Click += new System.EventHandler(this.label1_Click);
            // 
            // cbPerfil
            // 
            this.cbPerfil.FormattingEnabled = true;
            this.cbPerfil.Location = new System.Drawing.Point(63, 162);
            this.cbPerfil.Name = "cbPerfil";
            this.cbPerfil.Size = new System.Drawing.Size(121, 21);
            this.cbPerfil.TabIndex = 6;
            // 
            // txtbUsuario
            // 
            this.txtbUsuario.BackColor = System.Drawing.SystemColors.Window;
            this.txtbUsuario.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtbUsuario.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtbUsuario.BorderSize = 2;
            this.txtbUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbUsuario.ForeColor = System.Drawing.Color.DimGray;
            this.txtbUsuario.Location = new System.Drawing.Point(13, 46);
            this.txtbUsuario.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtbUsuario.Multiline = false;
            this.txtbUsuario.Name = "txtbUsuario";
            this.txtbUsuario.Padding = new System.Windows.Forms.Padding(7);
            this.txtbUsuario.PasswordChar = false;
            this.txtbUsuario.Size = new System.Drawing.Size(171, 31);
            this.txtbUsuario.TabIndex = 4;
            this.txtbUsuario.Texts = "Usuario";
            this.txtbUsuario.UnderlinedStyle = false;
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
            this.btnConsultar.Location = new System.Drawing.Point(671, 218);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(111, 40);
            this.btnConsultar.TabIndex = 3;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.TextColor = System.Drawing.Color.White;
            this.btnConsultar.UseVisualStyleBackColor = false;
            this.btnConsultar.Click += new System.EventHandler(this.botonFacha1_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnSalir.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnSalir.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnSalir.BorderRadius = 20;
            this.btnSalir.BorderSize = 0;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Location = new System.Drawing.Point(677, 398);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(111, 40);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextColor = System.Drawing.Color.White;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click_1);
            // 
            // txtbApelido
            // 
            this.txtbApelido.BackColor = System.Drawing.SystemColors.Window;
            this.txtbApelido.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtbApelido.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtbApelido.BorderSize = 2;
            this.txtbApelido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbApelido.ForeColor = System.Drawing.Color.DimGray;
            this.txtbApelido.Location = new System.Drawing.Point(13, 124);
            this.txtbApelido.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtbApelido.Multiline = false;
            this.txtbApelido.Name = "txtbApelido";
            this.txtbApelido.Padding = new System.Windows.Forms.Padding(7);
            this.txtbApelido.PasswordChar = false;
            this.txtbApelido.Size = new System.Drawing.Size(171, 31);
            this.txtbApelido.TabIndex = 19;
            this.txtbApelido.Texts = "Apellido";
            this.txtbApelido.UnderlinedStyle = false;
            // 
            // txtbNombre
            // 
            this.txtbNombre.BackColor = System.Drawing.SystemColors.Window;
            this.txtbNombre.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtbNombre.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtbNombre.BorderSize = 2;
            this.txtbNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbNombre.ForeColor = System.Drawing.Color.DimGray;
            this.txtbNombre.Location = new System.Drawing.Point(13, 85);
            this.txtbNombre.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtbNombre.Multiline = false;
            this.txtbNombre.Name = "txtbNombre";
            this.txtbNombre.Padding = new System.Windows.Forms.Padding(7);
            this.txtbNombre.PasswordChar = false;
            this.txtbNombre.Size = new System.Drawing.Size(171, 31);
            this.txtbNombre.TabIndex = 18;
            this.txtbNombre.Texts = "Nombre";
            this.txtbNombre.UnderlinedStyle = false;
            // 
            // clmIdUsuario
            // 
            this.clmIdUsuario.HeaderText = "ID Usuario";
            this.clmIdUsuario.Name = "clmIdUsuario";
            this.clmIdUsuario.ReadOnly = true;
            this.clmIdUsuario.Width = 50;
            // 
            // clmUsuario
            // 
            this.clmUsuario.HeaderText = "Usuario";
            this.clmUsuario.Name = "clmUsuario";
            this.clmUsuario.ReadOnly = true;
            // 
            // clmNombre
            // 
            this.clmNombre.HeaderText = "Nombre";
            this.clmNombre.Name = "clmNombre";
            this.clmNombre.ReadOnly = true;
            // 
            // clmApellido
            // 
            this.clmApellido.HeaderText = "Apellido";
            this.clmApellido.Name = "clmApellido";
            this.clmApellido.ReadOnly = true;
            // 
            // clmPerfil
            // 
            this.clmPerfil.HeaderText = "Perfil";
            this.clmPerfil.Name = "clmPerfil";
            this.clmPerfil.ReadOnly = true;
            this.clmPerfil.Width = 80;
            // 
            // clmEmail
            // 
            this.clmEmail.HeaderText = "Email";
            this.clmEmail.Name = "clmEmail";
            this.clmEmail.ReadOnly = true;
            // 
            // clmContrasena
            // 
            this.clmContrasena.HeaderText = "Contraseña";
            this.clmContrasena.Name = "clmContrasena";
            this.clmContrasena.ReadOnly = true;
            this.clmContrasena.Width = 80;
            // 
            // frmConsultaUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.gbxFiltros);
            this.Controls.Add(this.dgvUsuarios);
            this.Name = "frmConsultaUsuario";
            this.Text = "frmConsultaUsuario";
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.gbxFiltros.ResumeLayout(false);
            this.gbxFiltros.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.GroupBox gbxFiltros;
        private System.Windows.Forms.Label lblAclaracion;
        private System.Windows.Forms.Label lblPerfil;
        private System.Windows.Forms.ComboBox cbPerfil;
        private frmTextBoxFacha txtbUsuario;
        private BotonFacha btnConsultar;
        private BotonFacha btnSalir;
        private frmTextBoxFacha txtbApelido;
        private frmTextBoxFacha txtbNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmIdUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmApellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPerfil;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmContrasena;
    }
}