
namespace gestorLollapalooza.presLayer.GrupoMusicalPres
{
    partial class frmAltaGrupoMusical
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAltaGrupoMusical));
            this.gbxGrupoMusical = new System.Windows.Forms.GroupBox();
            this.txtbDescripcion = new gestorLollapalooza.frmTextBoxFacha();
            this.numCantIntegrantes = new System.Windows.Forms.NumericUpDown();
            this.lblCantInt = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtbNombre = new gestorLollapalooza.frmTextBoxFacha();
            this.btnSalir = new gestorLollapalooza.BotonFacha();
            this.btnCrear = new gestorLollapalooza.BotonFacha();
            this.gbxGrupoMusical.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCantIntegrantes)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxGrupoMusical
            // 
            this.gbxGrupoMusical.Controls.Add(this.txtbDescripcion);
            this.gbxGrupoMusical.Controls.Add(this.numCantIntegrantes);
            this.gbxGrupoMusical.Controls.Add(this.lblCantInt);
            this.gbxGrupoMusical.Controls.Add(this.label1);
            this.gbxGrupoMusical.Controls.Add(this.lblNombre);
            this.gbxGrupoMusical.Controls.Add(this.txtbNombre);
            this.gbxGrupoMusical.ForeColor = System.Drawing.Color.White;
            this.gbxGrupoMusical.Location = new System.Drawing.Point(17, 16);
            this.gbxGrupoMusical.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.gbxGrupoMusical.Name = "gbxGrupoMusical";
            this.gbxGrupoMusical.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.gbxGrupoMusical.Size = new System.Drawing.Size(499, 327);
            this.gbxGrupoMusical.TabIndex = 15;
            this.gbxGrupoMusical.TabStop = false;
            this.gbxGrupoMusical.Text = "Datos del grupo musical";
            // 
            // txtbDescripcion
            // 
            this.txtbDescripcion.BackColor = System.Drawing.Color.White;
            this.txtbDescripcion.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(154)))));
            this.txtbDescripcion.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtbDescripcion.BorderSize = 2;
            this.txtbDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbDescripcion.ForeColor = System.Drawing.Color.White;
            this.txtbDescripcion.Location = new System.Drawing.Point(15, 192);
            this.txtbDescripcion.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtbDescripcion.Multiline = false;
            this.txtbDescripcion.Name = "txtbDescripcion";
            this.txtbDescripcion.Padding = new System.Windows.Forms.Padding(12, 11, 12, 11);
            this.txtbDescripcion.PasswordChar = false;
            this.txtbDescripcion.Size = new System.Drawing.Size(469, 43);
            this.txtbDescripcion.TabIndex = 2;
            this.txtbDescripcion.UnderlinedStyle = false;
            // 
            // numCantIntegrantes
            // 
            this.numCantIntegrantes.Location = new System.Drawing.Point(279, 270);
            this.numCantIntegrantes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numCantIntegrantes.Name = "numCantIntegrantes";
            this.numCantIntegrantes.Size = new System.Drawing.Size(160, 22);
            this.numCantIntegrantes.TabIndex = 3;
            this.numCantIntegrantes.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblCantInt
            // 
            this.lblCantInt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantInt.Location = new System.Drawing.Point(15, 256);
            this.lblCantInt.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblCantInt.Name = "lblCantInt";
            this.lblCantInt.Size = new System.Drawing.Size(256, 47);
            this.lblCantInt.TabIndex = 0;
            this.lblCantInt.Text = "   Cantidad de integrantes  : ";
            this.lblCantInt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 139);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 47);
            this.label1.TabIndex = 0;
            this.label1.Text = "Descripción (*) :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.txtbNombre.Location = new System.Drawing.Point(15, 74);
            this.txtbNombre.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtbNombre.Multiline = false;
            this.txtbNombre.Name = "txtbNombre";
            this.txtbNombre.Padding = new System.Windows.Forms.Padding(12, 11, 12, 11);
            this.txtbNombre.PasswordChar = false;
            this.txtbNombre.Size = new System.Drawing.Size(469, 43);
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
            this.btnSalir.Location = new System.Drawing.Point(296, 353);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(101, 53);
            this.btnSalir.TabIndex = 5;
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
            this.btnCrear.Location = new System.Drawing.Point(416, 353);
            this.btnCrear.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(101, 53);
            this.btnCrear.TabIndex = 4;
            this.btnCrear.Text = "Crear";
            this.btnCrear.TextColor = System.Drawing.Color.White;
            this.btnCrear.UseVisualStyleBackColor = false;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // frmAltaGrupoMusical
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(47)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(541, 443);
            this.ControlBox = false;
            this.Controls.Add(this.gbxGrupoMusical);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnCrear);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAltaGrupoMusical";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Alta Grupo Musical";
            this.gbxGrupoMusical.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numCantIntegrantes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private BotonFacha btnSalir;
        private BotonFacha btnCrear;
        private System.Windows.Forms.GroupBox gbxGrupoMusical;
        private System.Windows.Forms.Label lblCantInt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNombre;
        private frmTextBoxFacha txtbNombre;
        private System.Windows.Forms.NumericUpDown numCantIntegrantes;
        private frmTextBoxFacha txtbDescripcion;
    }
}