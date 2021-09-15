
namespace gestorLollapalooza.pressLayer.UsuarioPres
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultaUsuario));
            this.gbxFiltros = new System.Windows.Forms.GroupBox();
            this.chbTodos = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtbEmail = new gestorLollapalooza.frmTextBoxFacha();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbApellido = new gestorLollapalooza.frmTextBoxFacha();
            this.txtbNombre = new gestorLollapalooza.frmTextBoxFacha();
            this.txtbUsuario = new gestorLollapalooza.frmTextBoxFacha();
            this.cbPerfil = new System.Windows.Forms.ComboBox();
            this.lblPerfil = new System.Windows.Forms.Label();
            this.dvgUsuarios = new System.Windows.Forms.DataGridView();
            this.clmUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPerfil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmApellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSalir = new gestorLollapalooza.BotonFacha();
            this.btnConsultar = new gestorLollapalooza.BotonFacha();
            this.gbxFiltros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxFiltros
            // 
            this.gbxFiltros.Controls.Add(this.chbTodos);
            this.gbxFiltros.Controls.Add(this.label4);
            this.gbxFiltros.Controls.Add(this.txtbEmail);
            this.gbxFiltros.Controls.Add(this.label3);
            this.gbxFiltros.Controls.Add(this.label2);
            this.gbxFiltros.Controls.Add(this.label1);
            this.gbxFiltros.Controls.Add(this.txtbApellido);
            this.gbxFiltros.Controls.Add(this.txtbNombre);
            this.gbxFiltros.Controls.Add(this.txtbUsuario);
            this.gbxFiltros.Controls.Add(this.cbPerfil);
            this.gbxFiltros.Controls.Add(this.lblPerfil);
            this.gbxFiltros.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(159)))), ((int)(((byte)(161)))));
            this.gbxFiltros.Location = new System.Drawing.Point(26, 22);
            this.gbxFiltros.Margin = new System.Windows.Forms.Padding(4);
            this.gbxFiltros.Name = "gbxFiltros";
            this.gbxFiltros.Padding = new System.Windows.Forms.Padding(4);
            this.gbxFiltros.Size = new System.Drawing.Size(283, 426);
            this.gbxFiltros.TabIndex = 1;
            this.gbxFiltros.TabStop = false;
            this.gbxFiltros.Text = "Filtros";
            // 
            // chbTodos
            // 
            this.chbTodos.AutoSize = true;
            this.chbTodos.Location = new System.Drawing.Point(25, 378);
            this.chbTodos.Name = "chbTodos";
            this.chbTodos.Size = new System.Drawing.Size(130, 20);
            this.chbTodos.TabIndex = 25;
            this.chbTodos.Text = "Consultar Todos";
            this.chbTodos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chbTodos.UseVisualStyleBackColor = true;
            this.chbTodos.CheckedChanged += new System.EventHandler(this.chbTodos_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 249);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 16);
            this.label4.TabIndex = 24;
            this.label4.Text = "Email:";
            // 
            // txtbEmail
            // 
            this.txtbEmail.BackColor = System.Drawing.SystemColors.Window;
            this.txtbEmail.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(154)))));
            this.txtbEmail.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtbEmail.BorderSize = 2;
            this.txtbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbEmail.ForeColor = System.Drawing.Color.DimGray;
            this.txtbEmail.Location = new System.Drawing.Point(25, 270);
            this.txtbEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtbEmail.Multiline = false;
            this.txtbEmail.Name = "txtbEmail";
            this.txtbEmail.Padding = new System.Windows.Forms.Padding(9);
            this.txtbEmail.PasswordChar = false;
            this.txtbEmail.Size = new System.Drawing.Size(228, 35);
            this.txtbEmail.TabIndex = 23;
            this.txtbEmail.UnderlinedStyle = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 174);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 16);
            this.label3.TabIndex = 22;
            this.label3.Text = "Apellido:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 102);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 16);
            this.label2.TabIndex = 21;
            this.label2.Text = "Nombre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 16);
            this.label1.TabIndex = 20;
            this.label1.Text = "Usuario:";
            // 
            // txtbApellido
            // 
            this.txtbApellido.BackColor = System.Drawing.SystemColors.Window;
            this.txtbApellido.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(154)))));
            this.txtbApellido.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtbApellido.BorderSize = 2;
            this.txtbApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbApellido.ForeColor = System.Drawing.Color.DimGray;
            this.txtbApellido.Location = new System.Drawing.Point(25, 194);
            this.txtbApellido.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtbApellido.Multiline = false;
            this.txtbApellido.Name = "txtbApellido";
            this.txtbApellido.Padding = new System.Windows.Forms.Padding(9);
            this.txtbApellido.PasswordChar = false;
            this.txtbApellido.Size = new System.Drawing.Size(228, 35);
            this.txtbApellido.TabIndex = 19;
            this.txtbApellido.UnderlinedStyle = false;
            // 
            // txtbNombre
            // 
            this.txtbNombre.BackColor = System.Drawing.SystemColors.Window;
            this.txtbNombre.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(154)))));
            this.txtbNombre.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtbNombre.BorderSize = 2;
            this.txtbNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbNombre.ForeColor = System.Drawing.Color.DimGray;
            this.txtbNombre.Location = new System.Drawing.Point(25, 123);
            this.txtbNombre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtbNombre.Multiline = false;
            this.txtbNombre.Name = "txtbNombre";
            this.txtbNombre.Padding = new System.Windows.Forms.Padding(9);
            this.txtbNombre.PasswordChar = false;
            this.txtbNombre.Size = new System.Drawing.Size(228, 35);
            this.txtbNombre.TabIndex = 18;
            this.txtbNombre.UnderlinedStyle = false;
            // 
            // txtbUsuario
            // 
            this.txtbUsuario.BackColor = System.Drawing.SystemColors.Window;
            this.txtbUsuario.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(154)))));
            this.txtbUsuario.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtbUsuario.BorderSize = 2;
            this.txtbUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbUsuario.ForeColor = System.Drawing.Color.DimGray;
            this.txtbUsuario.Location = new System.Drawing.Point(25, 54);
            this.txtbUsuario.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtbUsuario.Multiline = false;
            this.txtbUsuario.Name = "txtbUsuario";
            this.txtbUsuario.Padding = new System.Windows.Forms.Padding(9);
            this.txtbUsuario.PasswordChar = false;
            this.txtbUsuario.Size = new System.Drawing.Size(228, 35);
            this.txtbUsuario.TabIndex = 4;
            this.txtbUsuario.UnderlinedStyle = false;
            // 
            // cbPerfil
            // 
            this.cbPerfil.FormattingEnabled = true;
            this.cbPerfil.Location = new System.Drawing.Point(93, 334);
            this.cbPerfil.Margin = new System.Windows.Forms.Padding(4);
            this.cbPerfil.Name = "cbPerfil";
            this.cbPerfil.Size = new System.Drawing.Size(160, 24);
            this.cbPerfil.TabIndex = 6;
            // 
            // lblPerfil
            // 
            this.lblPerfil.AutoSize = true;
            this.lblPerfil.Location = new System.Drawing.Point(21, 337);
            this.lblPerfil.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPerfil.Name = "lblPerfil";
            this.lblPerfil.Size = new System.Drawing.Size(44, 16);
            this.lblPerfil.TabIndex = 5;
            this.lblPerfil.Text = "Perfil:";
            // 
            // dvgUsuarios
            // 
            this.dvgUsuarios.AllowUserToAddRows = false;
            this.dvgUsuarios.AllowUserToDeleteRows = false;
            this.dvgUsuarios.AllowUserToResizeColumns = false;
            this.dvgUsuarios.AllowUserToResizeRows = false;
            this.dvgUsuarios.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(47)))), ((int)(((byte)(50)))));
            this.dvgUsuarios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dvgUsuarios.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(47)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvgUsuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dvgUsuarios.ColumnHeadersHeight = 30;
            this.dvgUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dvgUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmUsuario,
            this.clmPerfil,
            this.clmNombre,
            this.clmApellido,
            this.clmEmail});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(47)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(159)))), ((int)(((byte)(161)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dvgUsuarios.DefaultCellStyle = dataGridViewCellStyle7;
            this.dvgUsuarios.EnableHeadersVisualStyles = false;
            this.dvgUsuarios.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(154)))));
            this.dvgUsuarios.Location = new System.Drawing.Point(346, 30);
            this.dvgUsuarios.Name = "dvgUsuarios";
            this.dvgUsuarios.ReadOnly = true;
            this.dvgUsuarios.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dvgUsuarios.RowHeadersVisible = false;
            this.dvgUsuarios.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dvgUsuarios.Size = new System.Drawing.Size(675, 475);
            this.dvgUsuarios.TabIndex = 5;
            // 
            // clmUsuario
            // 
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            this.clmUsuario.DefaultCellStyle = dataGridViewCellStyle2;
            this.clmUsuario.FillWeight = 120F;
            this.clmUsuario.HeaderText = "Usuario";
            this.clmUsuario.Name = "clmUsuario";
            this.clmUsuario.ReadOnly = true;
            // 
            // clmPerfil
            // 
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            this.clmPerfil.DefaultCellStyle = dataGridViewCellStyle3;
            this.clmPerfil.FillWeight = 120F;
            this.clmPerfil.HeaderText = "Perfil";
            this.clmPerfil.Name = "clmPerfil";
            this.clmPerfil.ReadOnly = true;
            this.clmPerfil.Width = 120;
            // 
            // clmNombre
            // 
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            this.clmNombre.DefaultCellStyle = dataGridViewCellStyle4;
            this.clmNombre.FillWeight = 120F;
            this.clmNombre.HeaderText = "Nombre";
            this.clmNombre.Name = "clmNombre";
            this.clmNombre.ReadOnly = true;
            // 
            // clmApellido
            // 
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            this.clmApellido.DefaultCellStyle = dataGridViewCellStyle5;
            this.clmApellido.FillWeight = 120F;
            this.clmApellido.HeaderText = "Apellido";
            this.clmApellido.Name = "clmApellido";
            this.clmApellido.ReadOnly = true;
            this.clmApellido.Width = 150;
            // 
            // clmEmail
            // 
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            this.clmEmail.DefaultCellStyle = dataGridViewCellStyle6;
            this.clmEmail.FillWeight = 120F;
            this.clmEmail.HeaderText = "Email";
            this.clmEmail.Name = "clmEmail";
            this.clmEmail.ReadOnly = true;
            this.clmEmail.Width = 250;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(154)))));
            this.btnSalir.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(154)))));
            this.btnSalir.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnSalir.BorderRadius = 20;
            this.btnSalir.BorderSize = 0;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Location = new System.Drawing.Point(26, 456);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(135, 49);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextColor = System.Drawing.Color.White;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click_1);
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
            this.btnConsultar.Location = new System.Drawing.Point(169, 456);
            this.btnConsultar.Margin = new System.Windows.Forms.Padding(4);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(140, 49);
            this.btnConsultar.TabIndex = 3;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.TextColor = System.Drawing.Color.White;
            this.btnConsultar.UseVisualStyleBackColor = false;
            this.btnConsultar.Click += new System.EventHandler(this.botonFacha1_Click);
            // 
            // frmConsultaUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(47)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(1033, 543);
            this.ControlBox = false;
            this.Controls.Add(this.dvgUsuarios);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.gbxFiltros);
            this.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(159)))), ((int)(((byte)(161)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmConsultaUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Consulta Usuario";
            this.gbxFiltros.ResumeLayout(false);
            this.gbxFiltros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgUsuarios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gbxFiltros;
        private System.Windows.Forms.Label lblPerfil;
        private System.Windows.Forms.ComboBox cbPerfil;
        private frmTextBoxFacha txtbUsuario;
        private BotonFacha btnConsultar;
        private BotonFacha btnSalir;
        private frmTextBoxFacha txtbApellido;
        private frmTextBoxFacha txtbNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private frmTextBoxFacha txtbEmail;
        private System.Windows.Forms.DataGridView dvgUsuarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPerfil;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmApellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmEmail;
        private System.Windows.Forms.CheckBox chbTodos;
    }
}