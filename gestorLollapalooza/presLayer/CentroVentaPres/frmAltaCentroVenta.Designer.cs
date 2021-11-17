
namespace gestorLollapalooza.presLayer.CentroVentaPres
{
    partial class frmAltaCentroVenta
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAltaCentroVenta));
            this.gbxGrupoMusical = new System.Windows.Forms.GroupBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtbNombre = new gestorLollapalooza.frmTextBoxFacha();
            this.dgvPuntoVenta = new System.Windows.Forms.DataGridView();
            this.nombrePuntoVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbxFiltros = new System.Windows.Forms.GroupBox();
            this.numPuntoVenta = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblPv = new System.Windows.Forms.Label();
            this.txtbNombrePv = new gestorLollapalooza.frmTextBoxFacha();
            this.btnQuitar = new gestorLollapalooza.BotonFacha();
            this.btnLimpiar = new gestorLollapalooza.BotonFacha();
            this.btnAgregar = new gestorLollapalooza.BotonFacha();
            this.btnSalir = new gestorLollapalooza.BotonFacha();
            this.btnCrear = new gestorLollapalooza.BotonFacha();
            this.gbxGrupoMusical.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPuntoVenta)).BeginInit();
            this.gbxFiltros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPuntoVenta)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxGrupoMusical
            // 
            this.gbxGrupoMusical.Controls.Add(this.lblNombre);
            this.gbxGrupoMusical.Controls.Add(this.txtbNombre);
            this.gbxGrupoMusical.ForeColor = System.Drawing.Color.White;
            this.gbxGrupoMusical.Location = new System.Drawing.Point(73, 20);
            this.gbxGrupoMusical.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.gbxGrupoMusical.Name = "gbxGrupoMusical";
            this.gbxGrupoMusical.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.gbxGrupoMusical.Size = new System.Drawing.Size(284, 140);
            this.gbxGrupoMusical.TabIndex = 18;
            this.gbxGrupoMusical.TabStop = false;
            this.gbxGrupoMusical.Text = "Datos del centro";
            this.gbxGrupoMusical.Enter += new System.EventHandler(this.gbxGrupoMusical_Enter);
            // 
            // lblNombre
            // 
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(15, 21);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(120, 47);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre (*) : ";
            this.lblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtbNombre
            // 
            this.txtbNombre.BackColor = System.Drawing.Color.White;
            this.txtbNombre.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(154)))));
            this.txtbNombre.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtbNombre.BorderSize = 2;
            this.txtbNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbNombre.ForeColor = System.Drawing.Color.White;
            this.txtbNombre.Location = new System.Drawing.Point(19, 74);
            this.txtbNombre.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtbNombre.Multiline = false;
            this.txtbNombre.Name = "txtbNombre";
            this.txtbNombre.Padding = new System.Windows.Forms.Padding(12, 11, 12, 11);
            this.txtbNombre.PasswordChar = false;
            this.txtbNombre.Size = new System.Drawing.Size(247, 43);
            this.txtbNombre.TabIndex = 1;
            this.txtbNombre.UnderlinedStyle = false;
            // 
            // dgvPuntoVenta
            // 
            this.dgvPuntoVenta.AllowUserToAddRows = false;
            this.dgvPuntoVenta.AllowUserToDeleteRows = false;
            this.dgvPuntoVenta.AllowUserToResizeColumns = false;
            this.dgvPuntoVenta.AllowUserToResizeRows = false;
            this.dgvPuntoVenta.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(47)))), ((int)(((byte)(50)))));
            this.dgvPuntoVenta.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(47)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPuntoVenta.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPuntoVenta.ColumnHeadersHeight = 30;
            this.dgvPuntoVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvPuntoVenta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombrePuntoVenta,
            this.numero});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(47)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPuntoVenta.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPuntoVenta.EnableHeadersVisualStyles = false;
            this.dgvPuntoVenta.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(154)))));
            this.dgvPuntoVenta.Location = new System.Drawing.Point(17, 287);
            this.dgvPuntoVenta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvPuntoVenta.Name = "dgvPuntoVenta";
            this.dgvPuntoVenta.ReadOnly = true;
            this.dgvPuntoVenta.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvPuntoVenta.RowHeadersVisible = false;
            this.dgvPuntoVenta.RowHeadersWidth = 51;
            this.dgvPuntoVenta.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvPuntoVenta.Size = new System.Drawing.Size(1048, 298);
            this.dgvPuntoVenta.TabIndex = 19;
            // 
            // nombrePuntoVenta
            // 
            this.nombrePuntoVenta.HeaderText = "Nombre";
            this.nombrePuntoVenta.MinimumWidth = 6;
            this.nombrePuntoVenta.Name = "nombrePuntoVenta";
            this.nombrePuntoVenta.ReadOnly = true;
            this.nombrePuntoVenta.Width = 680;
            // 
            // numero
            // 
            this.numero.HeaderText = "Nro";
            this.numero.MinimumWidth = 6;
            this.numero.Name = "numero";
            this.numero.ReadOnly = true;
            this.numero.Width = 125;
            // 
            // gbxFiltros
            // 
            this.gbxFiltros.Controls.Add(this.numPuntoVenta);
            this.gbxFiltros.Controls.Add(this.label4);
            this.gbxFiltros.Controls.Add(this.label3);
            this.gbxFiltros.Controls.Add(this.lblPv);
            this.gbxFiltros.Controls.Add(this.txtbNombrePv);
            this.gbxFiltros.ForeColor = System.Drawing.Color.White;
            this.gbxFiltros.Location = new System.Drawing.Point(492, 16);
            this.gbxFiltros.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.gbxFiltros.Name = "gbxFiltros";
            this.gbxFiltros.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.gbxFiltros.Size = new System.Drawing.Size(377, 193);
            this.gbxFiltros.TabIndex = 20;
            this.gbxFiltros.TabStop = false;
            this.gbxFiltros.Text = "Datos de punto de venta";
            // 
            // numPuntoVenta
            // 
            this.numPuntoVenta.Location = new System.Drawing.Point(28, 134);
            this.numPuntoVenta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numPuntoVenta.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numPuntoVenta.Name = "numPuntoVenta";
            this.numPuntoVenta.Size = new System.Drawing.Size(160, 22);
            this.numPuntoVenta.TabIndex = 3;
            this.numPuntoVenta.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 306);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 17);
            this.label4.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 101);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 17);
            this.label3.TabIndex = 22;
            this.label3.Text = "Número (*):";
            // 
            // lblPv
            // 
            this.lblPv.AutoSize = true;
            this.lblPv.Location = new System.Drawing.Point(28, 22);
            this.lblPv.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblPv.Name = "lblPv";
            this.lblPv.Size = new System.Drawing.Size(81, 17);
            this.lblPv.TabIndex = 20;
            this.lblPv.Text = "Nombre (*):";
            // 
            // txtbNombrePv
            // 
            this.txtbNombrePv.BackColor = System.Drawing.Color.White;
            this.txtbNombrePv.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(154)))));
            this.txtbNombrePv.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtbNombrePv.BorderSize = 2;
            this.txtbNombrePv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbNombrePv.ForeColor = System.Drawing.Color.White;
            this.txtbNombrePv.Location = new System.Drawing.Point(28, 48);
            this.txtbNombrePv.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtbNombrePv.Multiline = false;
            this.txtbNombrePv.Name = "txtbNombrePv";
            this.txtbNombrePv.Padding = new System.Windows.Forms.Padding(12, 11, 12, 11);
            this.txtbNombrePv.PasswordChar = false;
            this.txtbNombrePv.Size = new System.Drawing.Size(304, 43);
            this.txtbNombrePv.TabIndex = 2;
            this.txtbNombrePv.UnderlinedStyle = false;
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
            this.btnQuitar.Location = new System.Drawing.Point(964, 90);
            this.btnQuitar.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(101, 53);
            this.btnQuitar.TabIndex = 5;
            this.btnQuitar.Text = "Quitar";
            this.btnQuitar.TextColor = System.Drawing.Color.White;
            this.btnQuitar.UseVisualStyleBackColor = false;
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
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
            this.btnLimpiar.ForeColor = System.Drawing.Color.White;
            this.btnLimpiar.Location = new System.Drawing.Point(964, 160);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(101, 53);
            this.btnLimpiar.TabIndex = 6;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.TextColor = System.Drawing.Color.White;
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
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
            this.btnAgregar.Location = new System.Drawing.Point(964, 20);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(101, 53);
            this.btnAgregar.TabIndex = 4;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.TextColor = System.Drawing.Color.White;
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
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
            this.btnSalir.Location = new System.Drawing.Point(73, 197);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(101, 53);
            this.btnSalir.TabIndex = 8;
            this.btnSalir.Text = "Cancelar";
            this.btnSalir.TextColor = System.Drawing.Color.White;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnCrear
            // 
            this.btnCrear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(154)))));
            this.btnCrear.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(154)))));
            this.btnCrear.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnCrear.BorderRadius = 20;
            this.btnCrear.BorderSize = 0;
            this.btnCrear.FlatAppearance.BorderSize = 0;
            this.btnCrear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrear.ForeColor = System.Drawing.Color.White;
            this.btnCrear.Location = new System.Drawing.Point(256, 197);
            this.btnCrear.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(101, 53);
            this.btnCrear.TabIndex = 7;
            this.btnCrear.Text = "Crear";
            this.btnCrear.TextColor = System.Drawing.Color.White;
            this.btnCrear.UseVisualStyleBackColor = false;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // frmAltaCentroVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(47)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(1083, 594);
            this.ControlBox = false;
            this.Controls.Add(this.btnQuitar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.gbxFiltros);
            this.Controls.Add(this.dgvPuntoVenta);
            this.Controls.Add(this.gbxGrupoMusical);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnCrear);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmAltaCentroVenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Alta Centro de Venta";
            this.gbxGrupoMusical.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPuntoVenta)).EndInit();
            this.gbxFiltros.ResumeLayout(false);
            this.gbxFiltros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPuntoVenta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxGrupoMusical;
        private System.Windows.Forms.Label lblNombre;
        private frmTextBoxFacha txtbNombre;
        private BotonFacha btnSalir;
        private BotonFacha btnCrear;
        private System.Windows.Forms.DataGridView dgvPuntoVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombrePuntoVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn numero;
        private System.Windows.Forms.GroupBox gbxFiltros;
        private System.Windows.Forms.NumericUpDown numPuntoVenta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblPv;
        private frmTextBoxFacha txtbNombrePv;
        private BotonFacha btnAgregar;
        private BotonFacha btnLimpiar;
        private BotonFacha btnQuitar;
    }
}