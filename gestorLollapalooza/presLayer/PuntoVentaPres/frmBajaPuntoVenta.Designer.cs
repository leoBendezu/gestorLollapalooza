
namespace gestorLollapalooza.presLayer.PuntoVentaPres
{
    partial class frmBajaPuntoVenta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBajaPuntoVenta));
            this.btnSalir = new gestorLollapalooza.BotonFacha();
            this.btnEliminar = new gestorLollapalooza.BotonFacha();
            this.gbxFiltros = new System.Windows.Forms.GroupBox();
            this.txtbNumCentroVenta = new gestorLollapalooza.frmTextBoxFacha();
            this.txtbNumero = new gestorLollapalooza.frmTextBoxFacha();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbNombre = new gestorLollapalooza.frmTextBoxFacha();
            this.gbxFiltros.SuspendLayout();
            this.SuspendLayout();
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
            this.btnSalir.Location = new System.Drawing.Point(122, 262);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(76, 43);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "Cancelar";
            this.btnSalir.TextColor = System.Drawing.Color.White;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click_1);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(154)))));
            this.btnEliminar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(154)))));
            this.btnEliminar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnEliminar.BorderRadius = 20;
            this.btnEliminar.BorderSize = 0;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.ForeColor = System.Drawing.SystemColors.Window;
            this.btnEliminar.Location = new System.Drawing.Point(206, 262);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(76, 43);
            this.btnEliminar.TabIndex = 4;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextColor = System.Drawing.SystemColors.Window;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click_1);
            // 
            // gbxFiltros
            // 
            this.gbxFiltros.Controls.Add(this.txtbNumCentroVenta);
            this.gbxFiltros.Controls.Add(this.txtbNumero);
            this.gbxFiltros.Controls.Add(this.label2);
            this.gbxFiltros.Controls.Add(this.label4);
            this.gbxFiltros.Controls.Add(this.label3);
            this.gbxFiltros.Controls.Add(this.label1);
            this.gbxFiltros.Controls.Add(this.txtbNombre);
            this.gbxFiltros.ForeColor = System.Drawing.Color.White;
            this.gbxFiltros.Location = new System.Drawing.Point(14, 13);
            this.gbxFiltros.Margin = new System.Windows.Forms.Padding(4);
            this.gbxFiltros.Name = "gbxFiltros";
            this.gbxFiltros.Padding = new System.Windows.Forms.Padding(4);
            this.gbxFiltros.Size = new System.Drawing.Size(273, 241);
            this.gbxFiltros.TabIndex = 19;
            this.gbxFiltros.TabStop = false;
            this.gbxFiltros.Text = "Datos del punto de venta";
            // 
            // txtbNumCentroVenta
            // 
            this.txtbNumCentroVenta.BackColor = System.Drawing.Color.White;
            this.txtbNumCentroVenta.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(154)))));
            this.txtbNumCentroVenta.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtbNumCentroVenta.BorderSize = 2;
            this.txtbNumCentroVenta.Enabled = false;
            this.txtbNumCentroVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbNumCentroVenta.ForeColor = System.Drawing.Color.White;
            this.txtbNumCentroVenta.Location = new System.Drawing.Point(24, 175);
            this.txtbNumCentroVenta.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtbNumCentroVenta.Multiline = false;
            this.txtbNumCentroVenta.Name = "txtbNumCentroVenta";
            this.txtbNumCentroVenta.Padding = new System.Windows.Forms.Padding(9);
            this.txtbNumCentroVenta.PasswordChar = false;
            this.txtbNumCentroVenta.Size = new System.Drawing.Size(228, 35);
            this.txtbNumCentroVenta.TabIndex = 3;
            this.txtbNumCentroVenta.UnderlinedStyle = false;
            // 
            // txtbNumero
            // 
            this.txtbNumero.BackColor = System.Drawing.Color.White;
            this.txtbNumero.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(154)))));
            this.txtbNumero.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtbNumero.BorderSize = 2;
            this.txtbNumero.Enabled = false;
            this.txtbNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbNumero.ForeColor = System.Drawing.Color.White;
            this.txtbNumero.Location = new System.Drawing.Point(24, 109);
            this.txtbNumero.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtbNumero.Multiline = false;
            this.txtbNumero.Name = "txtbNumero";
            this.txtbNumero.Padding = new System.Windows.Forms.Padding(9);
            this.txtbNumero.PasswordChar = false;
            this.txtbNumero.Size = new System.Drawing.Size(228, 35);
            this.txtbNumero.TabIndex = 2;
            this.txtbNumero.UnderlinedStyle = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 157);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Nro Centro Venta (*):";
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
            this.label3.Location = new System.Drawing.Point(24, 90);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Numero (*):";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Nombre (*):";
            // 
            // txtbNombre
            // 
            this.txtbNombre.BackColor = System.Drawing.Color.White;
            this.txtbNombre.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(154)))));
            this.txtbNombre.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtbNombre.BorderSize = 2;
            this.txtbNombre.Enabled = false;
            this.txtbNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbNombre.ForeColor = System.Drawing.Color.White;
            this.txtbNombre.Location = new System.Drawing.Point(24, 47);
            this.txtbNombre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtbNombre.Multiline = false;
            this.txtbNombre.Name = "txtbNombre";
            this.txtbNombre.Padding = new System.Windows.Forms.Padding(9);
            this.txtbNombre.PasswordChar = false;
            this.txtbNombre.Size = new System.Drawing.Size(228, 35);
            this.txtbNombre.TabIndex = 1;
            this.txtbNombre.UnderlinedStyle = false;
            // 
            // frmBajaPuntoVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(47)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(299, 321);
            this.ControlBox = false;
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.gbxFiltros);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmBajaPuntoVenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Baja de punto de venta";
            this.gbxFiltros.ResumeLayout(false);
            this.gbxFiltros.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private BotonFacha btnSalir;
        private BotonFacha btnEliminar;
        private System.Windows.Forms.GroupBox gbxFiltros;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private frmTextBoxFacha txtbNombre;
        private frmTextBoxFacha txtbNumCentroVenta;
        private frmTextBoxFacha txtbNumero;
    }
}