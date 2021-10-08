
namespace gestorLollapalooza.presLayer.FestivalPres
{
    partial class frmGestionarFestival
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
            this.dgvFestivales = new System.Windows.Forms.DataGridView();
            this.idFestival = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anoEdicion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descuentoVentaAnticipada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.porcentajeDevolucionPorAnulacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vigente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvActuaciones = new System.Windows.Forms.DataGridView();
            this.idActuacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.duracionActuacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horaInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroOrden = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grupoMusical = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDiasFestival = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbNombre = new gestorLollapalooza.frmTextBoxFacha();
            this.txtbAnoEdicion = new gestorLollapalooza.frmTextBoxFacha();
            this.label2 = new System.Windows.Forms.Label();
            this.chbTodos = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnLimpiar = new gestorLollapalooza.BotonFacha();
            this.btnConsultar = new gestorLollapalooza.BotonFacha();
            this.chbVigente = new System.Windows.Forms.CheckBox();
            this.botonFacha3 = new gestorLollapalooza.BotonFacha();
            this.btnModifcar = new gestorLollapalooza.BotonFacha();
            this.btnEliminar = new gestorLollapalooza.BotonFacha();
            this.btnSalir = new gestorLollapalooza.BotonFacha();
            this.idDia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaLimiteAnulacionEntrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaVtoVentaAnticipada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horaPresentacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.festival = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFestivales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActuaciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiasFestival)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvFestivales
            // 
            this.dgvFestivales.AllowUserToAddRows = false;
            this.dgvFestivales.AllowUserToDeleteRows = false;
            this.dgvFestivales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFestivales.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idFestival,
            this.anoEdicion,
            this.descuentoVentaAnticipada,
            this.fechaInicio,
            this.nombre,
            this.porcentajeDevolucionPorAnulacion,
            this.vigente});
            this.dgvFestivales.Location = new System.Drawing.Point(262, 21);
            this.dgvFestivales.Name = "dgvFestivales";
            this.dgvFestivales.ReadOnly = true;
            this.dgvFestivales.Size = new System.Drawing.Size(843, 229);
            this.dgvFestivales.TabIndex = 0;
            this.dgvFestivales.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // idFestival
            // 
            this.idFestival.HeaderText = "Nro";
            this.idFestival.Name = "idFestival";
            this.idFestival.ReadOnly = true;
            // 
            // anoEdicion
            // 
            this.anoEdicion.HeaderText = "Año de Edicion";
            this.anoEdicion.Name = "anoEdicion";
            this.anoEdicion.ReadOnly = true;
            // 
            // descuentoVentaAnticipada
            // 
            this.descuentoVentaAnticipada.HeaderText = "Descuento VA";
            this.descuentoVentaAnticipada.Name = "descuentoVentaAnticipada";
            this.descuentoVentaAnticipada.ReadOnly = true;
            this.descuentoVentaAnticipada.Width = 150;
            // 
            // fechaInicio
            // 
            this.fechaInicio.HeaderText = "Inicio";
            this.fechaInicio.Name = "fechaInicio";
            this.fechaInicio.ReadOnly = true;
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            this.nombre.Width = 150;
            // 
            // porcentajeDevolucionPorAnulacion
            // 
            this.porcentajeDevolucionPorAnulacion.HeaderText = "%Devolucion";
            this.porcentajeDevolucionPorAnulacion.Name = "porcentajeDevolucionPorAnulacion";
            this.porcentajeDevolucionPorAnulacion.ReadOnly = true;
            // 
            // vigente
            // 
            this.vigente.HeaderText = "Vigente";
            this.vigente.Name = "vigente";
            this.vigente.ReadOnly = true;
            // 
            // dgvActuaciones
            // 
            this.dgvActuaciones.AllowUserToAddRows = false;
            this.dgvActuaciones.AllowUserToDeleteRows = false;
            this.dgvActuaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvActuaciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idActuacion,
            this.duracionActuacion,
            this.horaInicio,
            this.numeroOrden,
            this.grupoMusical});
            this.dgvActuaciones.Location = new System.Drawing.Point(12, 447);
            this.dgvActuaciones.Name = "dgvActuaciones";
            this.dgvActuaciones.ReadOnly = true;
            this.dgvActuaciones.Size = new System.Drawing.Size(843, 153);
            this.dgvActuaciones.TabIndex = 1;
            // 
            // idActuacion
            // 
            this.idActuacion.HeaderText = "Nro Actuacion";
            this.idActuacion.Name = "idActuacion";
            this.idActuacion.ReadOnly = true;
            // 
            // duracionActuacion
            // 
            this.duracionActuacion.HeaderText = "Duracion estimada";
            this.duracionActuacion.Name = "duracionActuacion";
            this.duracionActuacion.ReadOnly = true;
            this.duracionActuacion.Width = 200;
            // 
            // horaInicio
            // 
            this.horaInicio.HeaderText = "Hora de inicio";
            this.horaInicio.Name = "horaInicio";
            this.horaInicio.ReadOnly = true;
            // 
            // numeroOrden
            // 
            this.numeroOrden.HeaderText = "Numero de orden";
            this.numeroOrden.Name = "numeroOrden";
            this.numeroOrden.ReadOnly = true;
            this.numeroOrden.Width = 200;
            // 
            // grupoMusical
            // 
            this.grupoMusical.HeaderText = "Grupo musical";
            this.grupoMusical.Name = "grupoMusical";
            this.grupoMusical.ReadOnly = true;
            this.grupoMusical.Width = 200;
            // 
            // dgvDiasFestival
            // 
            this.dgvDiasFestival.AllowUserToAddRows = false;
            this.dgvDiasFestival.AllowUserToDeleteRows = false;
            this.dgvDiasFestival.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDiasFestival.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDia,
            this.fecha,
            this.fechaLimiteAnulacionEntrada,
            this.fechaVtoVentaAnticipada,
            this.horaPresentacion,
            this.festival});
            this.dgvDiasFestival.Location = new System.Drawing.Point(12, 266);
            this.dgvDiasFestival.Name = "dgvDiasFestival";
            this.dgvDiasFestival.ReadOnly = true;
            this.dgvDiasFestival.Size = new System.Drawing.Size(843, 153);
            this.dgvDiasFestival.TabIndex = 2;
            this.dgvDiasFestival.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nombre: ";
            // 
            // txtbNombre
            // 
            this.txtbNombre.BackColor = System.Drawing.SystemColors.Window;
            this.txtbNombre.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtbNombre.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtbNombre.BorderSize = 2;
            this.txtbNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbNombre.ForeColor = System.Drawing.Color.DimGray;
            this.txtbNombre.Location = new System.Drawing.Point(98, 20);
            this.txtbNombre.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtbNombre.Multiline = false;
            this.txtbNombre.Name = "txtbNombre";
            this.txtbNombre.Padding = new System.Windows.Forms.Padding(7);
            this.txtbNombre.PasswordChar = false;
            this.txtbNombre.Size = new System.Drawing.Size(130, 31);
            this.txtbNombre.TabIndex = 4;
            this.txtbNombre.UnderlinedStyle = false;
            // 
            // txtbAnoEdicion
            // 
            this.txtbAnoEdicion.BackColor = System.Drawing.SystemColors.Window;
            this.txtbAnoEdicion.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtbAnoEdicion.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtbAnoEdicion.BorderSize = 2;
            this.txtbAnoEdicion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbAnoEdicion.ForeColor = System.Drawing.Color.DimGray;
            this.txtbAnoEdicion.Location = new System.Drawing.Point(98, 59);
            this.txtbAnoEdicion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtbAnoEdicion.Multiline = false;
            this.txtbAnoEdicion.Name = "txtbAnoEdicion";
            this.txtbAnoEdicion.Padding = new System.Windows.Forms.Padding(7);
            this.txtbAnoEdicion.PasswordChar = false;
            this.txtbAnoEdicion.Size = new System.Drawing.Size(130, 31);
            this.txtbAnoEdicion.TabIndex = 6;
            this.txtbAnoEdicion.UnderlinedStyle = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Año de Edicion:";
            // 
            // chbTodos
            // 
            this.chbTodos.AutoSize = true;
            this.chbTodos.Location = new System.Drawing.Point(98, 140);
            this.chbTodos.Name = "chbTodos";
            this.chbTodos.Size = new System.Drawing.Size(103, 17);
            this.chbTodos.TabIndex = 26;
            this.chbTodos.Text = "Consultar Todos";
            this.chbTodos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chbTodos.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnLimpiar);
            this.groupBox1.Controls.Add(this.btnConsultar);
            this.groupBox1.Controls.Add(this.chbVigente);
            this.groupBox1.Controls.Add(this.txtbNombre);
            this.groupBox1.Controls.Add(this.chbTodos);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtbAnoEdicion);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(244, 248);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(154)))));
            this.btnLimpiar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(154)))));
            this.btnLimpiar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnLimpiar.BorderRadius = 20;
            this.btnLimpiar.BorderSize = 0;
            this.btnLimpiar.FlatAppearance.BorderSize = 0;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.5F);
            this.btnLimpiar.ForeColor = System.Drawing.Color.White;
            this.btnLimpiar.Location = new System.Drawing.Point(17, 180);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(4);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(79, 49);
            this.btnLimpiar.TabIndex = 30;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.TextColor = System.Drawing.Color.White;
            this.btnLimpiar.UseVisualStyleBackColor = false;
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
            this.btnConsultar.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.5F);
            this.btnConsultar.ForeColor = System.Drawing.Color.White;
            this.btnConsultar.Location = new System.Drawing.Point(149, 180);
            this.btnConsultar.Margin = new System.Windows.Forms.Padding(4);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(79, 49);
            this.btnConsultar.TabIndex = 29;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.TextColor = System.Drawing.Color.White;
            this.btnConsultar.UseVisualStyleBackColor = false;
            // 
            // chbVigente
            // 
            this.chbVigente.AutoSize = true;
            this.chbVigente.Location = new System.Drawing.Point(98, 106);
            this.chbVigente.Name = "chbVigente";
            this.chbVigente.Size = new System.Drawing.Size(62, 17);
            this.chbVigente.TabIndex = 28;
            this.chbVigente.Text = "Vigente";
            this.chbVigente.UseVisualStyleBackColor = true;
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
            this.botonFacha3.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.5F);
            this.botonFacha3.ForeColor = System.Drawing.Color.White;
            this.botonFacha3.Location = new System.Drawing.Point(1031, 266);
            this.botonFacha3.Margin = new System.Windows.Forms.Padding(4);
            this.botonFacha3.Name = "botonFacha3";
            this.botonFacha3.Size = new System.Drawing.Size(74, 49);
            this.botonFacha3.TabIndex = 31;
            this.botonFacha3.Text = "Agregar";
            this.botonFacha3.TextColor = System.Drawing.Color.White;
            this.botonFacha3.UseVisualStyleBackColor = false;
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
            this.btnModifcar.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.5F);
            this.btnModifcar.ForeColor = System.Drawing.Color.White;
            this.btnModifcar.Location = new System.Drawing.Point(949, 266);
            this.btnModifcar.Margin = new System.Windows.Forms.Padding(4);
            this.btnModifcar.Name = "btnModifcar";
            this.btnModifcar.Size = new System.Drawing.Size(74, 49);
            this.btnModifcar.TabIndex = 30;
            this.btnModifcar.Text = "Modificar";
            this.btnModifcar.TextColor = System.Drawing.Color.White;
            this.btnModifcar.UseVisualStyleBackColor = false;
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
            this.btnEliminar.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.5F);
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(867, 266);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(74, 49);
            this.btnEliminar.TabIndex = 29;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextColor = System.Drawing.Color.White;
            this.btnEliminar.UseVisualStyleBackColor = false;
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
            this.btnSalir.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.5F);
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Location = new System.Drawing.Point(1031, 551);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(74, 49);
            this.btnSalir.TabIndex = 28;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextColor = System.Drawing.Color.White;
            this.btnSalir.UseVisualStyleBackColor = false;
            // 
            // idDia
            // 
            this.idDia.HeaderText = "Nro";
            this.idDia.Name = "idDia";
            this.idDia.ReadOnly = true;
            // 
            // fecha
            // 
            this.fecha.HeaderText = "Fecha";
            this.fecha.Name = "fecha";
            this.fecha.ReadOnly = true;
            // 
            // fechaLimiteAnulacionEntrada
            // 
            this.fechaLimiteAnulacionEntrada.HeaderText = "Fecha limite de anulacion de entrada";
            this.fechaLimiteAnulacionEntrada.Name = "fechaLimiteAnulacionEntrada";
            this.fechaLimiteAnulacionEntrada.ReadOnly = true;
            this.fechaLimiteAnulacionEntrada.Width = 200;
            // 
            // fechaVtoVentaAnticipada
            // 
            this.fechaVtoVentaAnticipada.HeaderText = "Fecha de Vto de Venta Anticipada";
            this.fechaVtoVentaAnticipada.Name = "fechaVtoVentaAnticipada";
            this.fechaVtoVentaAnticipada.ReadOnly = true;
            this.fechaVtoVentaAnticipada.Width = 200;
            // 
            // horaPresentacion
            // 
            this.horaPresentacion.HeaderText = "Hora de Presentacion";
            this.horaPresentacion.Name = "horaPresentacion";
            this.horaPresentacion.ReadOnly = true;
            // 
            // festival
            // 
            this.festival.HeaderText = "Festival";
            this.festival.Name = "festival";
            this.festival.ReadOnly = true;
            // 
            // frmGestionarFestival
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1126, 622);
            this.Controls.Add(this.botonFacha3);
            this.Controls.Add(this.btnModifcar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvDiasFestival);
            this.Controls.Add(this.dgvActuaciones);
            this.Controls.Add(this.dgvFestivales);
            this.Name = "frmGestionarFestival";
            this.Text = "frmGestionarFestival";
            this.Load += new System.EventHandler(this.frmGestionarFestival_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFestivales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActuaciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiasFestival)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvFestivales;
        private System.Windows.Forms.DataGridView dgvActuaciones;
        private System.Windows.Forms.DataGridView dgvDiasFestival;
        private System.Windows.Forms.Label label1;
        private frmTextBoxFacha txtbNombre;
        private frmTextBoxFacha txtbAnoEdicion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chbTodos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chbVigente;
        private BotonFacha btnLimpiar;
        private BotonFacha btnConsultar;
        private BotonFacha botonFacha3;
        private BotonFacha btnModifcar;
        private BotonFacha btnEliminar;
        private BotonFacha btnSalir;
        private System.Windows.Forms.DataGridViewTextBoxColumn idFestival;
        private System.Windows.Forms.DataGridViewTextBoxColumn anoEdicion;
        private System.Windows.Forms.DataGridViewTextBoxColumn descuentoVentaAnticipada;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn porcentajeDevolucionPorAnulacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn vigente;
        private System.Windows.Forms.DataGridViewTextBoxColumn idActuacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn duracionActuacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn horaInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroOrden;
        private System.Windows.Forms.DataGridViewTextBoxColumn grupoMusical;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDia;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaLimiteAnulacionEntrada;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaVtoVentaAnticipada;
        private System.Windows.Forms.DataGridViewTextBoxColumn horaPresentacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn festival;
    }
}