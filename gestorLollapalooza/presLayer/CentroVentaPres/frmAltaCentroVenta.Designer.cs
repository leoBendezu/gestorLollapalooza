
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
            this.gbxGrupoMusical.Location = new System.Drawing.Point(55, 16);
            this.gbxGrupoMusical.Margin = new System.Windows.Forms.Padding(4);
            this.gbxGrupoMusical.Name = "gbxGrupoMusical";
            this.gbxGrupoMusical.Padding = new System.Windows.Forms.Padding(4);
            this.gbxGrupoMusical.Size = new System.Drawing.Size(213, 114);
            this.gbxGrupoMusical.TabIndex = 18;
            this.gbxGrupoMusical.TabStop = false;
            this.gbxGrupoMusical.Text = "Datos del centro";
            this.gbxGrupoMusical.Enter += new System.EventHandler(this.gbxGrupoMusical_Enter);
            // 
            // lblNombre
            // 
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(11, 17);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(90, 38);
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
            this.txtbNombre.Location = new System.Drawing.Point(14, 60);
            this.txtbNombre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtbNombre.Multiline = false;
            this.txtbNombre.Name = "txtbNombre";
            this.txtbNombre.Padding = new System.Windows.Forms.Padding(9);
            this.txtbNombre.PasswordChar = false;
            this.txtbNombre.Size = new System.Drawing.Size(185, 35);
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
            this.dgvPuntoVenta.Location = new System.Drawing.Point(13, 233);
            this.dgvPuntoVenta.Name = "dgvPuntoVenta";
            this.dgvPuntoVenta.ReadOnly = true;
            this.dgvPuntoVenta.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvPuntoVenta.RowHeadersVisible = false;
            this.dgvPuntoVenta.RowHeadersWidth = 51;
            this.dgvPuntoVenta.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvPuntoVenta.Size = new System.Drawing.Size(786, 242);
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
            this.gbxFiltros.Location = new System.Drawing.Point(369, 13);
            this.gbxFiltros.Margin = new System.Windows.Forms.Padding(4);
            this.gbxFiltros.Name = "gbxFiltros";
            this.gbxFiltros.Padding = new System.Windows.Forms.Padding(4);
            this.gbxFiltros.Size = new System.Drawing.Size(283, 157);
            this.gbxFiltros.TabIndex = 20;
            this.gbxFiltros.TabStop = false;
            this.gbxFiltros.Text = "Datos de punto de venta";
            // 
            // numPuntoVenta
            // 
            this.numPuntoVenta.Location = new System.Drawing.Point(21, 109);
            this.numPuntoVenta.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numPuntoVenta.Name = "numPuntoVenta";
            this.numPuntoVenta.Size = new System.Drawing.Size(120, 20);
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
            this.label4.Location = new System.Drawing.Point(21, 249);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 82);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Numero (*):";
            // 
            // lblPv
            // 
            this.lblPv.AutoSize = true;
            this.lblPv.Location = new System.Drawing.Point(21, 18);
            this.lblPv.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPv.Name = "lblPv";
            this.lblPv.Size = new System.Drawing.Size(60, 13);
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
            this.txtbNombrePv.Location = new System.Drawing.Point(21, 39);
            this.txtbNombrePv.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtbNombrePv.Multiline = false;
            this.txtbNombrePv.Name = "txtbNombrePv";
            this.txtbNombrePv.Padding = new System.Windows.Forms.Padding(9);
            this.txtbNombrePv.PasswordChar = false;
            this.txtbNombrePv.Size = new System.Drawing.Size(228, 35);
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
            this.btnQuitar.Location = new System.Drawing.Point(723, 73);
            this.btnQuitar.Margin = new System.Windows.Forms.Padding(4);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(76, 43);
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
            this.btnLimpiar.Location = new System.Drawing.Point(723, 130);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(4);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(76, 43);
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
            this.btnAgregar.Location = new System.Drawing.Point(723, 16);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(76, 43);
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
            this.btnSalir.Location = new System.Drawing.Point(55, 160);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(76, 43);
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
            this.btnCrear.Location = new System.Drawing.Point(192, 160);
            this.btnCrear.Margin = new System.Windows.Forms.Padding(4);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(76, 43);
            this.btnCrear.TabIndex = 7;
            this.btnCrear.Text = "Crear";
            this.btnCrear.TextColor = System.Drawing.Color.White;
            this.btnCrear.UseVisualStyleBackColor = false;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // frmAltaCentroVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(47)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(812, 483);
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