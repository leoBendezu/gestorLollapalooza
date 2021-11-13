
namespace gestorLollapalooza.presLayer.UsuarioPres
{
    partial class frmGestionarUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGestionarUsuario));
            this.dvgUsuarios = new System.Windows.Forms.DataGridView();
            this.clmUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPerfil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmApellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.botonFacha4 = new gestorLollapalooza.BotonFacha();
            this.btnConsultar = new gestorLollapalooza.BotonFacha();
            this.botonFacha3 = new gestorLollapalooza.BotonFacha();
            this.btnModifcar = new gestorLollapalooza.BotonFacha();
            this.btnEliminar = new gestorLollapalooza.BotonFacha();
            this.btnSalir = new gestorLollapalooza.BotonFacha();
            ((System.ComponentModel.ISupportInitialize)(this.dvgUsuarios)).BeginInit();
            this.gbxFiltros.SuspendLayout();
            this.SuspendLayout();
            // 
            // dvgUsuarios
            // 
            this.dvgUsuarios.AllowUserToAddRows = false;
            this.dvgUsuarios.AllowUserToDeleteRows = false;
            this.dvgUsuarios.AllowUserToResizeColumns = false;
            this.dvgUsuarios.AllowUserToResizeRows = false;
            this.dvgUsuarios.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(47)))), ((int)(((byte)(50)))));
            this.dvgUsuarios.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(47)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
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
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(159)))), ((int)(((byte)(161)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dvgUsuarios.DefaultCellStyle = dataGridViewCellStyle7;
            this.dvgUsuarios.EnableHeadersVisualStyles = false;
            this.dvgUsuarios.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(154)))));
            this.dvgUsuarios.Location = new System.Drawing.Point(300, 15);
            this.dvgUsuarios.Name = "dvgUsuarios";
            this.dvgUsuarios.ReadOnly = true;
            this.dvgUsuarios.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dvgUsuarios.RowHeadersVisible = false;
            this.dvgUsuarios.RowHeadersWidth = 51;
            this.dvgUsuarios.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dvgUsuarios.Size = new System.Drawing.Size(723, 491);
            this.dvgUsuarios.TabIndex = 5;
            this.dvgUsuarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgUsuarios_CellClick);
            // 
            // clmUsuario
            // 
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            this.clmUsuario.DefaultCellStyle = dataGridViewCellStyle2;
            this.clmUsuario.FillWeight = 120F;
            this.clmUsuario.HeaderText = "Usuario";
            this.clmUsuario.MinimumWidth = 6;
            this.clmUsuario.Name = "clmUsuario";
            this.clmUsuario.ReadOnly = true;
            this.clmUsuario.Width = 125;
            // 
            // clmPerfil
            // 
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            this.clmPerfil.DefaultCellStyle = dataGridViewCellStyle3;
            this.clmPerfil.FillWeight = 120F;
            this.clmPerfil.HeaderText = "Perfil";
            this.clmPerfil.MinimumWidth = 6;
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
            this.clmNombre.MinimumWidth = 6;
            this.clmNombre.Name = "clmNombre";
            this.clmNombre.ReadOnly = true;
            this.clmNombre.Width = 125;
            // 
            // clmApellido
            // 
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            this.clmApellido.DefaultCellStyle = dataGridViewCellStyle5;
            this.clmApellido.FillWeight = 120F;
            this.clmApellido.HeaderText = "Apellido";
            this.clmApellido.MinimumWidth = 6;
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
            this.clmEmail.MinimumWidth = 6;
            this.clmEmail.Name = "clmEmail";
            this.clmEmail.ReadOnly = true;
            this.clmEmail.Width = 250;
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
            this.gbxFiltros.ForeColor = System.Drawing.Color.White;
            this.gbxFiltros.Location = new System.Drawing.Point(30, 15);
            this.gbxFiltros.Margin = new System.Windows.Forms.Padding(4);
            this.gbxFiltros.Name = "gbxFiltros";
            this.gbxFiltros.Padding = new System.Windows.Forms.Padding(4);
            this.gbxFiltros.Size = new System.Drawing.Size(243, 426);
            this.gbxFiltros.TabIndex = 1;
            this.gbxFiltros.TabStop = false;
            this.gbxFiltros.Text = "Filtros";
            // 
            // chbTodos
            // 
            this.chbTodos.AutoSize = true;
            this.chbTodos.Location = new System.Drawing.Point(25, 378);
            this.chbTodos.Name = "chbTodos";
            this.chbTodos.Size = new System.Drawing.Size(115, 19);
            this.chbTodos.TabIndex = 6;
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
            this.label4.Size = new System.Drawing.Size(42, 15);
            this.label4.TabIndex = 24;
            this.label4.Text = "Email:";
            // 
            // txtbEmail
            // 
            this.txtbEmail.BackColor = System.Drawing.Color.White;
            this.txtbEmail.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(154)))));
            this.txtbEmail.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtbEmail.BorderSize = 2;
            this.txtbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbEmail.ForeColor = System.Drawing.Color.White;
            this.txtbEmail.Location = new System.Drawing.Point(25, 270);
            this.txtbEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtbEmail.Multiline = false;
            this.txtbEmail.Name = "txtbEmail";
            this.txtbEmail.Padding = new System.Windows.Forms.Padding(9);
            this.txtbEmail.PasswordChar = false;
            this.txtbEmail.Size = new System.Drawing.Size(196, 35);
            this.txtbEmail.TabIndex = 4;
            this.txtbEmail.UnderlinedStyle = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 174);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 15);
            this.label3.TabIndex = 22;
            this.label3.Text = "Apellido:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 102);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 15);
            this.label2.TabIndex = 21;
            this.label2.Text = "Nombre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 15);
            this.label1.TabIndex = 20;
            this.label1.Text = "Usuario:";
            // 
            // txtbApellido
            // 
            this.txtbApellido.BackColor = System.Drawing.Color.White;
            this.txtbApellido.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(154)))));
            this.txtbApellido.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtbApellido.BorderSize = 2;
            this.txtbApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbApellido.ForeColor = System.Drawing.Color.White;
            this.txtbApellido.Location = new System.Drawing.Point(25, 194);
            this.txtbApellido.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtbApellido.Multiline = false;
            this.txtbApellido.Name = "txtbApellido";
            this.txtbApellido.Padding = new System.Windows.Forms.Padding(9);
            this.txtbApellido.PasswordChar = false;
            this.txtbApellido.Size = new System.Drawing.Size(196, 35);
            this.txtbApellido.TabIndex = 3;
            this.txtbApellido.UnderlinedStyle = false;
            // 
            // txtbNombre
            // 
            this.txtbNombre.BackColor = System.Drawing.Color.White;
            this.txtbNombre.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(154)))));
            this.txtbNombre.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtbNombre.BorderSize = 2;
            this.txtbNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbNombre.ForeColor = System.Drawing.Color.White;
            this.txtbNombre.Location = new System.Drawing.Point(25, 123);
            this.txtbNombre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtbNombre.Multiline = false;
            this.txtbNombre.Name = "txtbNombre";
            this.txtbNombre.Padding = new System.Windows.Forms.Padding(9);
            this.txtbNombre.PasswordChar = false;
            this.txtbNombre.Size = new System.Drawing.Size(196, 35);
            this.txtbNombre.TabIndex = 2;
            this.txtbNombre.UnderlinedStyle = false;
            // 
            // txtbUsuario
            // 
            this.txtbUsuario.BackColor = System.Drawing.Color.White;
            this.txtbUsuario.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(154)))));
            this.txtbUsuario.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtbUsuario.BorderSize = 2;
            this.txtbUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbUsuario.ForeColor = System.Drawing.Color.White;
            this.txtbUsuario.Location = new System.Drawing.Point(25, 54);
            this.txtbUsuario.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtbUsuario.Multiline = false;
            this.txtbUsuario.Name = "txtbUsuario";
            this.txtbUsuario.Padding = new System.Windows.Forms.Padding(9);
            this.txtbUsuario.PasswordChar = false;
            this.txtbUsuario.Size = new System.Drawing.Size(196, 35);
            this.txtbUsuario.TabIndex = 1;
            this.txtbUsuario.UnderlinedStyle = false;
            // 
            // cbPerfil
            // 
            this.cbPerfil.FormattingEnabled = true;
            this.cbPerfil.Location = new System.Drawing.Point(73, 334);
            this.cbPerfil.Margin = new System.Windows.Forms.Padding(4);
            this.cbPerfil.Name = "cbPerfil";
            this.cbPerfil.Size = new System.Drawing.Size(148, 23);
            this.cbPerfil.TabIndex = 5;
            // 
            // lblPerfil
            // 
            this.lblPerfil.AutoSize = true;
            this.lblPerfil.Location = new System.Drawing.Point(21, 337);
            this.lblPerfil.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPerfil.Name = "lblPerfil";
            this.lblPerfil.Size = new System.Drawing.Size(38, 15);
            this.lblPerfil.TabIndex = 5;
            this.lblPerfil.Text = "Perfil:";
            // 
            // botonFacha4
            // 
            this.botonFacha4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(154)))));
            this.botonFacha4.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(154)))));
            this.botonFacha4.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.botonFacha4.BorderRadius = 20;
            this.botonFacha4.BorderSize = 0;
            this.botonFacha4.FlatAppearance.BorderSize = 0;
            this.botonFacha4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonFacha4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.botonFacha4.ForeColor = System.Drawing.Color.White;
            this.botonFacha4.Location = new System.Drawing.Point(33, 457);
            this.botonFacha4.Margin = new System.Windows.Forms.Padding(4);
            this.botonFacha4.Name = "botonFacha4";
            this.botonFacha4.Size = new System.Drawing.Size(79, 49);
            this.botonFacha4.TabIndex = 8;
            this.botonFacha4.Text = "Limpiar";
            this.botonFacha4.TextColor = System.Drawing.Color.White;
            this.botonFacha4.UseVisualStyleBackColor = false;
            this.botonFacha4.Click += new System.EventHandler(this.botonFacha4_Click);
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
            this.btnConsultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.btnConsultar.ForeColor = System.Drawing.Color.White;
            this.btnConsultar.Location = new System.Drawing.Point(194, 457);
            this.btnConsultar.Margin = new System.Windows.Forms.Padding(4);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(79, 49);
            this.btnConsultar.TabIndex = 7;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.TextColor = System.Drawing.Color.White;
            this.btnConsultar.UseVisualStyleBackColor = false;
            this.btnConsultar.Click += new System.EventHandler(this.botonFacha1_Click);
            // 
            // botonFacha3
            // 
            this.botonFacha3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(154)))));
            this.botonFacha3.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(154)))));
            this.botonFacha3.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.botonFacha3.BorderRadius = 20;
            this.botonFacha3.BorderSize = 0;
            this.botonFacha3.FlatAppearance.BorderSize = 0;
            this.botonFacha3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonFacha3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.botonFacha3.ForeColor = System.Drawing.Color.White;
            this.botonFacha3.Location = new System.Drawing.Point(1040, 15);
            this.botonFacha3.Margin = new System.Windows.Forms.Padding(4);
            this.botonFacha3.Name = "botonFacha3";
            this.botonFacha3.Size = new System.Drawing.Size(74, 49);
            this.botonFacha3.TabIndex = 9;
            this.botonFacha3.Text = "Agregar";
            this.botonFacha3.TextColor = System.Drawing.Color.White;
            this.botonFacha3.UseVisualStyleBackColor = false;
            this.botonFacha3.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnModifcar
            // 
            this.btnModifcar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(154)))));
            this.btnModifcar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(154)))));
            this.btnModifcar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnModifcar.BorderRadius = 20;
            this.btnModifcar.BorderSize = 0;
            this.btnModifcar.Enabled = false;
            this.btnModifcar.FlatAppearance.BorderSize = 0;
            this.btnModifcar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModifcar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.btnModifcar.ForeColor = System.Drawing.Color.White;
            this.btnModifcar.Location = new System.Drawing.Point(1040, 74);
            this.btnModifcar.Margin = new System.Windows.Forms.Padding(4);
            this.btnModifcar.Name = "btnModifcar";
            this.btnModifcar.Size = new System.Drawing.Size(74, 49);
            this.btnModifcar.TabIndex = 10;
            this.btnModifcar.Text = "Modificar";
            this.btnModifcar.TextColor = System.Drawing.Color.White;
            this.btnModifcar.UseVisualStyleBackColor = false;
            this.btnModifcar.Click += new System.EventHandler(this.btnModificarClick);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(154)))));
            this.btnEliminar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(154)))));
            this.btnEliminar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnEliminar.BorderRadius = 20;
            this.btnEliminar.BorderSize = 0;
            this.btnEliminar.Enabled = false;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(1040, 133);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(74, 49);
            this.btnEliminar.TabIndex = 11;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextColor = System.Drawing.Color.White;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
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
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Location = new System.Drawing.Point(1040, 457);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(74, 49);
            this.btnSalir.TabIndex = 12;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextColor = System.Drawing.Color.White;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click_1);
            // 
            // frmGestionarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(47)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(1139, 537);
            this.ControlBox = false;
            this.Controls.Add(this.botonFacha4);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.botonFacha3);
            this.Controls.Add(this.gbxFiltros);
            this.Controls.Add(this.btnModifcar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.dvgUsuarios);
            this.Controls.Add(this.btnSalir);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(159)))), ((int)(((byte)(161)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmGestionarUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Gestionar Usuario";
            ((System.ComponentModel.ISupportInitialize)(this.dvgUsuarios)).EndInit();
            this.gbxFiltros.ResumeLayout(false);
            this.gbxFiltros.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private BotonFacha btnSalir;
        private System.Windows.Forms.DataGridView dvgUsuarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPerfil;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmApellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmEmail;
        private BotonFacha btnEliminar;
        private BotonFacha btnModifcar;
        private BotonFacha botonFacha3;
        private System.Windows.Forms.GroupBox gbxFiltros;
        private System.Windows.Forms.CheckBox chbTodos;
        private System.Windows.Forms.Label label4;
        private frmTextBoxFacha txtbEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private frmTextBoxFacha txtbApellido;
        private frmTextBoxFacha txtbNombre;
        private frmTextBoxFacha txtbUsuario;
        private System.Windows.Forms.ComboBox cbPerfil;
        private System.Windows.Forms.Label lblPerfil;
        private BotonFacha btnConsultar;
        private BotonFacha botonFacha4;
    }
}