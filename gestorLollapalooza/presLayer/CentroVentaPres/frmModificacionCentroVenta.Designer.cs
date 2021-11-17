
namespace gestorLollapalooza.presLayer.CentroVentaPres
{
    partial class frmModificacionCentroVenta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmModificacionCentroVenta));
            this.dgvPuntoVenta = new System.Windows.Forms.DataGridView();
            this.nombrePuntoVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbxGrupoMusical = new System.Windows.Forms.GroupBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtbNombre = new gestorLollapalooza.frmTextBoxFacha();
            this.btnSalir = new gestorLollapalooza.BotonFacha();
            this.btnModificar = new gestorLollapalooza.BotonFacha();
            this.btnModificarPv = new gestorLollapalooza.BotonFacha();
            this.botonFacha1 = new gestorLollapalooza.BotonFacha();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPuntoVenta)).BeginInit();
            this.gbxGrupoMusical.SuspendLayout();
            this.SuspendLayout();
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
            this.dgvPuntoVenta.Location = new System.Drawing.Point(259, 13);
            this.dgvPuntoVenta.Name = "dgvPuntoVenta";
            this.dgvPuntoVenta.ReadOnly = true;
            this.dgvPuntoVenta.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvPuntoVenta.RowHeadersVisible = false;
            this.dgvPuntoVenta.RowHeadersWidth = 51;
            this.dgvPuntoVenta.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvPuntoVenta.Size = new System.Drawing.Size(606, 242);
            this.dgvPuntoVenta.TabIndex = 25;
            // 
            // nombrePuntoVenta
            // 
            this.nombrePuntoVenta.HeaderText = "Nombre";
            this.nombrePuntoVenta.MinimumWidth = 6;
            this.nombrePuntoVenta.Name = "nombrePuntoVenta";
            this.nombrePuntoVenta.ReadOnly = true;
            this.nombrePuntoVenta.Width = 500;
            // 
            // numero
            // 
            this.numero.HeaderText = "Nro";
            this.numero.MinimumWidth = 6;
            this.numero.Name = "numero";
            this.numero.ReadOnly = true;
            this.numero.Width = 125;
            // 
            // gbxGrupoMusical
            // 
            this.gbxGrupoMusical.Controls.Add(this.lblNombre);
            this.gbxGrupoMusical.Controls.Add(this.txtbNombre);
            this.gbxGrupoMusical.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(159)))), ((int)(((byte)(161)))));
            this.gbxGrupoMusical.Location = new System.Drawing.Point(24, 13);
            this.gbxGrupoMusical.Margin = new System.Windows.Forms.Padding(4);
            this.gbxGrupoMusical.Name = "gbxGrupoMusical";
            this.gbxGrupoMusical.Padding = new System.Windows.Forms.Padding(4);
            this.gbxGrupoMusical.Size = new System.Drawing.Size(213, 114);
            this.gbxGrupoMusical.TabIndex = 27;
            this.gbxGrupoMusical.TabStop = false;
            this.gbxGrupoMusical.Text = "Datos del centro";
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
            this.btnSalir.Location = new System.Drawing.Point(24, 156);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(76, 43);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "Cancelar";
            this.btnSalir.TextColor = System.Drawing.Color.White;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click_1);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(154)))));
            this.btnModificar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(154)))));
            this.btnModificar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnModificar.BorderRadius = 20;
            this.btnModificar.BorderSize = 0;
            this.btnModificar.FlatAppearance.BorderSize = 0;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.ForeColor = System.Drawing.Color.White;
            this.btnModificar.Location = new System.Drawing.Point(161, 156);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(4);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(76, 43);
            this.btnModificar.TabIndex = 4;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.TextColor = System.Drawing.Color.White;
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnModificarPv
            // 
            this.btnModificarPv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(154)))));
            this.btnModificarPv.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(154)))));
            this.btnModificarPv.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnModificarPv.BorderRadius = 20;
            this.btnModificarPv.BorderSize = 0;
            this.btnModificarPv.FlatAppearance.BorderSize = 0;
            this.btnModificarPv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarPv.ForeColor = System.Drawing.Color.White;
            this.btnModificarPv.Location = new System.Drawing.Point(872, 13);
            this.btnModificarPv.Margin = new System.Windows.Forms.Padding(4);
            this.btnModificarPv.Name = "btnModificarPv";
            this.btnModificarPv.Size = new System.Drawing.Size(119, 44);
            this.btnModificarPv.TabIndex = 2;
            this.btnModificarPv.Text = "Modificar PuntoVenta";
            this.btnModificarPv.TextColor = System.Drawing.Color.White;
            this.btnModificarPv.UseVisualStyleBackColor = false;
            this.btnModificarPv.Click += new System.EventHandler(this.btnModificarPv_Click);
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
            this.botonFacha1.Location = new System.Drawing.Point(872, 64);
            this.botonFacha1.Margin = new System.Windows.Forms.Padding(4);
            this.botonFacha1.Name = "botonFacha1";
            this.botonFacha1.Size = new System.Drawing.Size(119, 44);
            this.botonFacha1.TabIndex = 3;
            this.botonFacha1.Text = "Eliminar PuntoVenta";
            this.botonFacha1.TextColor = System.Drawing.Color.White;
            this.botonFacha1.UseVisualStyleBackColor = false;
            this.botonFacha1.Click += new System.EventHandler(this.botonFacha1_Click);
            // 
            // frmModificacionCentroVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(47)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(1005, 268);
            this.ControlBox = false;
            this.Controls.Add(this.botonFacha1);
            this.Controls.Add(this.btnModificarPv);
            this.Controls.Add(this.gbxGrupoMusical);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.dgvPuntoVenta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmModificacionCentroVenta";
            this.Text = "Modificar Centro de Venta";
            this.Load += new System.EventHandler(this.frmModificacionCentroVenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPuntoVenta)).EndInit();
            this.gbxGrupoMusical.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvPuntoVenta;
        private System.Windows.Forms.GroupBox gbxGrupoMusical;
        private System.Windows.Forms.Label lblNombre;
        private frmTextBoxFacha txtbNombre;
        private BotonFacha btnSalir;
        private BotonFacha btnModificar;
        private BotonFacha btnModificarPv;
        private BotonFacha botonFacha1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombrePuntoVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn numero;
    }
}