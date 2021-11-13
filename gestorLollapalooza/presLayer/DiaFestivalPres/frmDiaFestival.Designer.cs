
namespace gestorLollapalooza.presLayer.DiaFestivalPres
{
    partial class frmDiaFestival
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDiaFestival));
            this.gbxFestivales = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dtpAnticipa = new System.Windows.Forms.DateTimePicker();
            this.dtpAnulacion = new System.Windows.Forms.DateTimePicker();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numDuracionEstimada = new System.Windows.Forms.NumericUpDown();
            this.botonFacha2 = new gestorLollapalooza.BotonFacha();
            this.botonFacha1 = new gestorLollapalooza.BotonFacha();
            this.btnQuitar = new gestorLollapalooza.BotonFacha();
            this.btnAgregar = new gestorLollapalooza.BotonFacha();
            this.numOrden = new System.Windows.Forms.NumericUpDown();
            this.lblNumeroOrden = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtbGrupoActuante = new gestorLollapalooza.frmTextBoxFacha();
            this.lblDuracion = new System.Windows.Forms.Label();
            this.dgvActuacion = new System.Windows.Forms.DataGridView();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.duracionEstimada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSalir = new gestorLollapalooza.BotonFacha();
            this.btnAceptar = new gestorLollapalooza.BotonFacha();
            this.gbxFestivales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDuracionEstimada)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOrden)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActuacion)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxFestivales
            // 
            this.gbxFestivales.Controls.Add(this.pictureBox1);
            this.gbxFestivales.Controls.Add(this.dtpAnticipa);
            this.gbxFestivales.Controls.Add(this.dtpAnulacion);
            this.gbxFestivales.Controls.Add(this.dtpFecha);
            this.gbxFestivales.Controls.Add(this.label4);
            this.gbxFestivales.Controls.Add(this.label1);
            this.gbxFestivales.Controls.Add(this.label3);
            this.gbxFestivales.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(159)))), ((int)(((byte)(161)))));
            this.gbxFestivales.Location = new System.Drawing.Point(10, 21);
            this.gbxFestivales.Name = "gbxFestivales";
            this.gbxFestivales.Size = new System.Drawing.Size(576, 170);
            this.gbxFestivales.TabIndex = 9;
            this.gbxFestivales.TabStop = false;
            this.gbxFestivales.Text = "Informacion del dia";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::gestorLollapalooza.Properties.Resources.logo1;
            this.pictureBox1.Location = new System.Drawing.Point(404, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(155, 138);
            this.pictureBox1.TabIndex = 39;
            this.pictureBox1.TabStop = false;
            // 
            // dtpAnticipa
            // 
            this.dtpAnticipa.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpAnticipa.Location = new System.Drawing.Point(235, 64);
            this.dtpAnticipa.Name = "dtpAnticipa";
            this.dtpAnticipa.Size = new System.Drawing.Size(95, 20);
            this.dtpAnticipa.TabIndex = 3;
            // 
            // dtpAnulacion
            // 
            this.dtpAnulacion.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpAnulacion.Location = new System.Drawing.Point(20, 123);
            this.dtpAnulacion.Name = "dtpAnulacion";
            this.dtpAnulacion.Size = new System.Drawing.Size(95, 20);
            this.dtpAnulacion.TabIndex = 2;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(20, 64);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(95, 20);
            this.dtpFecha.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(232, 39);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "Fecha vto de venta anticipada";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Fecha";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 97);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Fecha Limite de anulacion de entrada";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numDuracionEstimada);
            this.groupBox1.Controls.Add(this.botonFacha2);
            this.groupBox1.Controls.Add(this.botonFacha1);
            this.groupBox1.Controls.Add(this.btnQuitar);
            this.groupBox1.Controls.Add(this.btnAgregar);
            this.groupBox1.Controls.Add(this.numOrden);
            this.groupBox1.Controls.Add(this.lblNumeroOrden);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtbGrupoActuante);
            this.groupBox1.Controls.Add(this.lblDuracion);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(159)))), ((int)(((byte)(161)))));
            this.groupBox1.Location = new System.Drawing.Point(10, 197);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(576, 170);
            this.groupBox1.TabIndex = 38;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Actuacion";
            // 
            // numDuracionEstimada
            // 
            this.numDuracionEstimada.Location = new System.Drawing.Point(20, 56);
            this.numDuracionEstimada.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.numDuracionEstimada.Minimum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numDuracionEstimada.Name = "numDuracionEstimada";
            this.numDuracionEstimada.Size = new System.Drawing.Size(67, 20);
            this.numDuracionEstimada.TabIndex = 4;
            this.numDuracionEstimada.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // botonFacha2
            // 
            this.botonFacha2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(154)))));
            this.botonFacha2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(154)))));
            this.botonFacha2.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.botonFacha2.BorderRadius = 20;
            this.botonFacha2.BorderSize = 0;
            this.botonFacha2.FlatAppearance.BorderSize = 0;
            this.botonFacha2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonFacha2.ForeColor = System.Drawing.Color.White;
            this.botonFacha2.Location = new System.Drawing.Point(483, 66);
            this.botonFacha2.Margin = new System.Windows.Forms.Padding(4);
            this.botonFacha2.Name = "botonFacha2";
            this.botonFacha2.Size = new System.Drawing.Size(76, 43);
            this.botonFacha2.TabIndex = 9;
            this.botonFacha2.Text = "Quitar";
            this.botonFacha2.TextColor = System.Drawing.Color.White;
            this.botonFacha2.UseVisualStyleBackColor = false;
            this.botonFacha2.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // botonFacha1
            // 
            this.botonFacha1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(154)))));
            this.botonFacha1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(154)))));
            this.botonFacha1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.botonFacha1.BorderRadius = 20;
            this.botonFacha1.BorderSize = 0;
            this.botonFacha1.FlatAppearance.BorderSize = 0;
            this.botonFacha1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonFacha1.ForeColor = System.Drawing.Color.White;
            this.botonFacha1.Location = new System.Drawing.Point(214, 110);
            this.botonFacha1.Margin = new System.Windows.Forms.Padding(4);
            this.botonFacha1.Name = "botonFacha1";
            this.botonFacha1.Size = new System.Drawing.Size(43, 39);
            this.botonFacha1.TabIndex = 7;
            this.botonFacha1.Text = "?";
            this.botonFacha1.TextColor = System.Drawing.Color.White;
            this.botonFacha1.UseVisualStyleBackColor = false;
            this.botonFacha1.Click += new System.EventHandler(this.botonFacha1_Click);
            // 
            // btnQuitar
            // 
            this.btnQuitar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(154)))));
            this.btnQuitar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(154)))));
            this.btnQuitar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnQuitar.BorderRadius = 20;
            this.btnQuitar.BorderSize = 0;
            this.btnQuitar.FlatAppearance.BorderSize = 0;
            this.btnQuitar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuitar.ForeColor = System.Drawing.Color.White;
            this.btnQuitar.Location = new System.Drawing.Point(481, 117);
            this.btnQuitar.Margin = new System.Windows.Forms.Padding(4);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(76, 43);
            this.btnQuitar.TabIndex = 10;
            this.btnQuitar.Text = "Limpiar";
            this.btnQuitar.TextColor = System.Drawing.Color.White;
            this.btnQuitar.UseVisualStyleBackColor = false;
            this.btnQuitar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(154)))));
            this.btnAgregar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(154)))));
            this.btnAgregar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnAgregar.BorderRadius = 20;
            this.btnAgregar.BorderSize = 0;
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.Location = new System.Drawing.Point(483, 15);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(76, 43);
            this.btnAgregar.TabIndex = 8;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.TextColor = System.Drawing.Color.White;
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // numOrden
            // 
            this.numOrden.Location = new System.Drawing.Point(288, 56);
            this.numOrden.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.numOrden.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numOrden.Name = "numOrden";
            this.numOrden.Size = new System.Drawing.Size(67, 20);
            this.numOrden.TabIndex = 5;
            this.numOrden.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblNumeroOrden
            // 
            this.lblNumeroOrden.AutoSize = true;
            this.lblNumeroOrden.Location = new System.Drawing.Point(285, 29);
            this.lblNumeroOrden.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumeroOrden.Name = "lblNumeroOrden";
            this.lblNumeroOrden.Size = new System.Drawing.Size(76, 13);
            this.lblNumeroOrden.TabIndex = 33;
            this.lblNumeroOrden.Text = "Numero Orden";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 96);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(120, 13);
            this.label9.TabIndex = 30;
            this.label9.Text = "Grupo musical Actuante";
            // 
            // txtbGrupoActuante
            // 
            this.txtbGrupoActuante.BackColor = System.Drawing.Color.White;
            this.txtbGrupoActuante.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(154)))));
            this.txtbGrupoActuante.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtbGrupoActuante.BorderSize = 2;
            this.txtbGrupoActuante.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbGrupoActuante.ForeColor = System.Drawing.Color.White;
            this.txtbGrupoActuante.Location = new System.Drawing.Point(20, 114);
            this.txtbGrupoActuante.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtbGrupoActuante.Multiline = false;
            this.txtbGrupoActuante.Name = "txtbGrupoActuante";
            this.txtbGrupoActuante.Padding = new System.Windows.Forms.Padding(9);
            this.txtbGrupoActuante.PasswordChar = false;
            this.txtbGrupoActuante.Size = new System.Drawing.Size(186, 35);
            this.txtbGrupoActuante.TabIndex = 6;
            this.txtbGrupoActuante.UnderlinedStyle = false;
            // 
            // lblDuracion
            // 
            this.lblDuracion.AutoSize = true;
            this.lblDuracion.Location = new System.Drawing.Point(17, 29);
            this.lblDuracion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDuracion.Name = "lblDuracion";
            this.lblDuracion.Size = new System.Drawing.Size(150, 13);
            this.lblDuracion.TabIndex = 20;
            this.lblDuracion.Text = "Duracion Estimada en minutos";
            // 
            // dgvActuacion
            // 
            this.dgvActuacion.AllowUserToAddRows = false;
            this.dgvActuacion.AllowUserToDeleteRows = false;
            this.dgvActuacion.AllowUserToResizeColumns = false;
            this.dgvActuacion.AllowUserToResizeRows = false;
            this.dgvActuacion.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(47)))), ((int)(((byte)(50)))));
            this.dgvActuacion.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(47)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvActuacion.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvActuacion.ColumnHeadersHeight = 30;
            this.dgvActuacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvActuacion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column3,
            this.duracionEstimada,
            this.Column4});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(47)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(159)))), ((int)(((byte)(161)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvActuacion.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvActuacion.EnableHeadersVisualStyles = false;
            this.dgvActuacion.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(154)))));
            this.dgvActuacion.Location = new System.Drawing.Point(69, 382);
            this.dgvActuacion.Name = "dgvActuacion";
            this.dgvActuacion.ReadOnly = true;
            this.dgvActuacion.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvActuacion.RowHeadersVisible = false;
            this.dgvActuacion.RowHeadersWidth = 51;
            this.dgvActuacion.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvActuacion.Size = new System.Drawing.Size(473, 163);
            this.dgvActuacion.TabIndex = 39;
            // 
            // Column3
            // 
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            this.Column3.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column3.HeaderText = "numero orden";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 120;
            // 
            // duracionEstimada
            // 
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            this.duracionEstimada.DefaultCellStyle = dataGridViewCellStyle3;
            this.duracionEstimada.HeaderText = "Duracion Estimada (min)";
            this.duracionEstimada.Name = "duracionEstimada";
            this.duracionEstimada.ReadOnly = true;
            this.duracionEstimada.Width = 170;
            // 
            // Column4
            // 
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            this.Column4.DefaultCellStyle = dataGridViewCellStyle4;
            this.Column4.HeaderText = "Grupo Musical Actuante";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 180;
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
            this.btnSalir.Location = new System.Drawing.Point(407, 561);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(76, 43);
            this.btnSalir.TabIndex = 12;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextColor = System.Drawing.Color.White;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(154)))));
            this.btnAceptar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(154)))));
            this.btnAceptar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnAceptar.BorderRadius = 20;
            this.btnAceptar.BorderSize = 0;
            this.btnAceptar.FlatAppearance.BorderSize = 0;
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.ForeColor = System.Drawing.SystemColors.Window;
            this.btnAceptar.Location = new System.Drawing.Point(499, 561);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(76, 43);
            this.btnAceptar.TabIndex = 11;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.TextColor = System.Drawing.SystemColors.Window;
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // frmDiaFestival
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(47)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(601, 617);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.dgvActuacion);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbxFestivales);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDiaFestival";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Dias Festival";
            this.gbxFestivales.ResumeLayout(false);
            this.gbxFestivales.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDuracionEstimada)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOrden)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActuacion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxFestivales;
        private System.Windows.Forms.DateTimePicker dtpAnulacion;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblNumeroOrden;
        private System.Windows.Forms.Label lblDuracion;
        private System.Windows.Forms.DateTimePicker dtpAnticipa;
        private System.Windows.Forms.DataGridView dgvActuacion;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label9;
        private frmTextBoxFacha txtbGrupoActuante;
        private System.Windows.Forms.NumericUpDown numOrden;
        private BotonFacha botonFacha1;
        private BotonFacha btnQuitar;
        private BotonFacha btnAgregar;
        private BotonFacha btnSalir;
        private BotonFacha btnAceptar;
        private BotonFacha botonFacha2;
        private System.Windows.Forms.NumericUpDown numDuracionEstimada;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn duracionEstimada;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}