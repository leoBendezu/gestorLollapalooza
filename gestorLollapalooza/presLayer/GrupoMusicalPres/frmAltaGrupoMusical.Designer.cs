
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
            this.components = new System.ComponentModel.Container();
            this.gbxGrupoMusical = new System.Windows.Forms.GroupBox();
            this.numCantIntegrantes = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txtbDescripcion = new gestorLollapalooza.frmTextBoxFacha();
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
            this.gbxGrupoMusical.Controls.Add(this.label2);
            this.gbxGrupoMusical.Controls.Add(this.label1);
            this.gbxGrupoMusical.Controls.Add(this.lblNombre);
            this.gbxGrupoMusical.Controls.Add(this.txtbNombre);
            this.gbxGrupoMusical.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(159)))), ((int)(((byte)(161)))));
            this.gbxGrupoMusical.Location = new System.Drawing.Point(13, 13);
            this.gbxGrupoMusical.Margin = new System.Windows.Forms.Padding(4);
            this.gbxGrupoMusical.Name = "gbxGrupoMusical";
            this.gbxGrupoMusical.Padding = new System.Windows.Forms.Padding(4);
            this.gbxGrupoMusical.Size = new System.Drawing.Size(374, 266);
            this.gbxGrupoMusical.TabIndex = 15;
            this.gbxGrupoMusical.TabStop = false;
            this.gbxGrupoMusical.Text = "Datos del grupo musical";
            // 
            // numCantIntegrantes
            // 
            this.numCantIntegrantes.Location = new System.Drawing.Point(209, 219);
            this.numCantIntegrantes.Name = "numCantIntegrantes";
            this.numCantIntegrantes.Size = new System.Drawing.Size(120, 20);
            this.numCantIntegrantes.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 208);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 38);
            this.label2.TabIndex = 0;
            this.label2.Text = "   Cantidad de integrantes  : ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 113);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Descripcion (*) :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblNombre
            // 
            this.lblNombre.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(11, 17);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(90, 38);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre (*) : ";
            this.lblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txtbDescripcion
            // 
            this.txtbDescripcion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(47)))), ((int)(((byte)(50)))));
            this.txtbDescripcion.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(154)))));
            this.txtbDescripcion.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtbDescripcion.BorderSize = 2;
            this.txtbDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbDescripcion.ForeColor = System.Drawing.Color.White;
            this.txtbDescripcion.Location = new System.Drawing.Point(11, 156);
            this.txtbDescripcion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtbDescripcion.Multiline = false;
            this.txtbDescripcion.Name = "txtbDescripcion";
            this.txtbDescripcion.Padding = new System.Windows.Forms.Padding(9);
            this.txtbDescripcion.PasswordChar = false;
            this.txtbDescripcion.Size = new System.Drawing.Size(352, 35);
            this.txtbDescripcion.TabIndex = 4;
            this.txtbDescripcion.UnderlinedStyle = false;
            // 
            // txtbNombre
            // 
            this.txtbNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(47)))), ((int)(((byte)(50)))));
            this.txtbNombre.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(154)))));
            this.txtbNombre.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtbNombre.BorderSize = 2;
            this.txtbNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbNombre.ForeColor = System.Drawing.Color.White;
            this.txtbNombre.Location = new System.Drawing.Point(11, 60);
            this.txtbNombre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtbNombre.Multiline = false;
            this.txtbNombre.Name = "txtbNombre";
            this.txtbNombre.Padding = new System.Windows.Forms.Padding(9);
            this.txtbNombre.PasswordChar = false;
            this.txtbNombre.Size = new System.Drawing.Size(352, 35);
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
            this.btnSalir.Location = new System.Drawing.Point(222, 287);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(76, 43);
            this.btnSalir.TabIndex = 14;
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
            this.btnCrear.Location = new System.Drawing.Point(312, 287);
            this.btnCrear.Margin = new System.Windows.Forms.Padding(4);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(76, 43);
            this.btnCrear.TabIndex = 16;
            this.btnCrear.Text = "Crear";
            this.btnCrear.TextColor = System.Drawing.Color.White;
            this.btnCrear.UseVisualStyleBackColor = false;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // frmAltaGrupoMusical
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(47)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(401, 342);
            this.Controls.Add(this.gbxGrupoMusical);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnCrear);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAltaGrupoMusical";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmAltaGrupoMusical";
            this.gbxGrupoMusical.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numCantIntegrantes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private BotonFacha btnSalir;
        private BotonFacha btnCrear;
        private System.Windows.Forms.GroupBox gbxGrupoMusical;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNombre;
        private frmTextBoxFacha txtbNombre;
        private System.Windows.Forms.NumericUpDown numCantIntegrantes;
        private frmTextBoxFacha txtbDescripcion;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}