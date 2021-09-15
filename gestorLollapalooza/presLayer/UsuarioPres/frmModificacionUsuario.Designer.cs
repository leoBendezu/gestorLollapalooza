
namespace gestorLollapalooza.presLayer.UsuarioPres
{
    partial class frmModificacionUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmModificacionUsuario));
            this.label1 = new System.Windows.Forms.Label();
            this.cbUsuario = new System.Windows.Forms.ComboBox();
            this.btnSalir = new gestorLollapalooza.BotonFacha();
            this.btnModificar = new gestorLollapalooza.BotonFacha();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ckbContraseña = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.txtbApellido = new gestorLollapalooza.frmTextBoxFacha();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.txtbEmail = new gestorLollapalooza.frmTextBoxFacha();
            this.txtbNombre = new gestorLollapalooza.frmTextBoxFacha();
            this.txtbUsuario = new gestorLollapalooza.frmTextBoxFacha();
            this.txtbContraseña = new gestorLollapalooza.frmTextBoxFacha();
            this.lblPerfil = new System.Windows.Forms.Label();
            this.cbPerfil = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 16);
            this.label1.TabIndex = 17;
            this.label1.Text = "Usuario a Modificar:";
            // 
            // cbUsuario
            // 
            this.cbUsuario.FormattingEnabled = true;
            this.cbUsuario.Location = new System.Drawing.Point(183, 26);
            this.cbUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.cbUsuario.Name = "cbUsuario";
            this.cbUsuario.Size = new System.Drawing.Size(173, 24);
            this.cbUsuario.TabIndex = 16;
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
            this.btnSalir.Location = new System.Drawing.Point(18, 463);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(117, 54);
            this.btnSalir.TabIndex = 15;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextColor = System.Drawing.Color.White;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
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
            this.btnModificar.Location = new System.Drawing.Point(226, 463);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(4);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(117, 54);
            this.btnModificar.TabIndex = 14;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.TextColor = System.Drawing.Color.White;
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblPerfil);
            this.groupBox1.Controls.Add(this.cbPerfil);
            this.groupBox1.Controls.Add(this.ckbContraseña);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblNombre);
            this.groupBox1.Controls.Add(this.lblContraseña);
            this.groupBox1.Controls.Add(this.txtbApellido);
            this.groupBox1.Controls.Add(this.lblUsuario);
            this.groupBox1.Controls.Add(this.txtbEmail);
            this.groupBox1.Controls.Add(this.txtbNombre);
            this.groupBox1.Controls.Add(this.txtbUsuario);
            this.groupBox1.Controls.Add(this.txtbContraseña);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(159)))), ((int)(((byte)(161)))));
            this.groupBox1.Location = new System.Drawing.Point(18, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(338, 374);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Información del usuario";
            // 
            // ckbContraseña
            // 
            this.ckbContraseña.AutoSize = true;
            this.ckbContraseña.Location = new System.Drawing.Point(154, 283);
            this.ckbContraseña.Margin = new System.Windows.Forms.Padding(4);
            this.ckbContraseña.Name = "ckbContraseña";
            this.ckbContraseña.Size = new System.Drawing.Size(153, 20);
            this.ckbContraseña.TabIndex = 17;
            this.ckbContraseña.Text = "Mostrar Contraseña";
            this.ckbContraseña.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ckbContraseña.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 140);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 38);
            this.label2.TabIndex = 7;
            this.label2.Text = "        Email  : ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 89);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 38);
            this.label3.TabIndex = 8;
            this.label3.Text = "Apellido (*) :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNombre
            // 
            this.lblNombre.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(26, 41);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(127, 38);
            this.lblNombre.TabIndex = 9;
            this.lblNombre.Text = "Nombre (*) : ";
            this.lblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblContraseña
            // 
            this.lblContraseña.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContraseña.Location = new System.Drawing.Point(7, 236);
            this.lblContraseña.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(146, 38);
            this.lblContraseña.TabIndex = 10;
            this.lblContraseña.Text = "Contraseña (*) : ";
            this.lblContraseña.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtbApellido
            // 
            this.txtbApellido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(47)))), ((int)(((byte)(50)))));
            this.txtbApellido.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(154)))));
            this.txtbApellido.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtbApellido.BorderSize = 2;
            this.txtbApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbApellido.ForeColor = System.Drawing.Color.White;
            this.txtbApellido.Location = new System.Drawing.Point(154, 89);
            this.txtbApellido.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtbApellido.Multiline = false;
            this.txtbApellido.Name = "txtbApellido";
            this.txtbApellido.Padding = new System.Windows.Forms.Padding(9);
            this.txtbApellido.PasswordChar = false;
            this.txtbApellido.Size = new System.Drawing.Size(164, 35);
            this.txtbApellido.TabIndex = 13;
            this.txtbApellido.UnderlinedStyle = false;
            // 
            // lblUsuario
            // 
            this.lblUsuario.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(26, 188);
            this.lblUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(127, 38);
            this.lblUsuario.TabIndex = 11;
            this.lblUsuario.Text = "Usuario (*) : ";
            this.lblUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtbEmail
            // 
            this.txtbEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(47)))), ((int)(((byte)(50)))));
            this.txtbEmail.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(154)))));
            this.txtbEmail.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtbEmail.BorderSize = 2;
            this.txtbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbEmail.ForeColor = System.Drawing.Color.White;
            this.txtbEmail.Location = new System.Drawing.Point(154, 140);
            this.txtbEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtbEmail.Multiline = false;
            this.txtbEmail.Name = "txtbEmail";
            this.txtbEmail.Padding = new System.Windows.Forms.Padding(9);
            this.txtbEmail.PasswordChar = false;
            this.txtbEmail.Size = new System.Drawing.Size(164, 35);
            this.txtbEmail.TabIndex = 14;
            this.txtbEmail.Tag = "";
            this.txtbEmail.UnderlinedStyle = false;
            // 
            // txtbNombre
            // 
            this.txtbNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(47)))), ((int)(((byte)(50)))));
            this.txtbNombre.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(154)))));
            this.txtbNombre.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtbNombre.BorderSize = 2;
            this.txtbNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbNombre.ForeColor = System.Drawing.Color.White;
            this.txtbNombre.Location = new System.Drawing.Point(154, 44);
            this.txtbNombre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtbNombre.Multiline = false;
            this.txtbNombre.Name = "txtbNombre";
            this.txtbNombre.Padding = new System.Windows.Forms.Padding(9);
            this.txtbNombre.PasswordChar = false;
            this.txtbNombre.Size = new System.Drawing.Size(164, 35);
            this.txtbNombre.TabIndex = 12;
            this.txtbNombre.UnderlinedStyle = false;
            // 
            // txtbUsuario
            // 
            this.txtbUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(47)))), ((int)(((byte)(50)))));
            this.txtbUsuario.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(154)))));
            this.txtbUsuario.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtbUsuario.BorderSize = 2;
            this.txtbUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbUsuario.ForeColor = System.Drawing.Color.White;
            this.txtbUsuario.Location = new System.Drawing.Point(154, 188);
            this.txtbUsuario.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtbUsuario.Multiline = false;
            this.txtbUsuario.Name = "txtbUsuario";
            this.txtbUsuario.Padding = new System.Windows.Forms.Padding(9);
            this.txtbUsuario.PasswordChar = false;
            this.txtbUsuario.Size = new System.Drawing.Size(164, 35);
            this.txtbUsuario.TabIndex = 15;
            this.txtbUsuario.Tag = "";
            this.txtbUsuario.UnderlinedStyle = false;
            // 
            // txtbContraseña
            // 
            this.txtbContraseña.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(47)))), ((int)(((byte)(50)))));
            this.txtbContraseña.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(154)))));
            this.txtbContraseña.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtbContraseña.BorderSize = 2;
            this.txtbContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbContraseña.ForeColor = System.Drawing.Color.White;
            this.txtbContraseña.Location = new System.Drawing.Point(154, 239);
            this.txtbContraseña.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtbContraseña.Multiline = false;
            this.txtbContraseña.Name = "txtbContraseña";
            this.txtbContraseña.Padding = new System.Windows.Forms.Padding(9);
            this.txtbContraseña.PasswordChar = true;
            this.txtbContraseña.Size = new System.Drawing.Size(164, 35);
            this.txtbContraseña.TabIndex = 16;
            this.txtbContraseña.Tag = "";
            this.txtbContraseña.UnderlinedStyle = false;
            // 
            // lblPerfil
            // 
            this.lblPerfil.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPerfil.Location = new System.Drawing.Point(30, 313);
            this.lblPerfil.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPerfil.Name = "lblPerfil";
            this.lblPerfil.Size = new System.Drawing.Size(99, 38);
            this.lblPerfil.TabIndex = 18;
            this.lblPerfil.Text = "Perfil (*) :  ";
            this.lblPerfil.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbPerfil
            // 
            this.cbPerfil.FormattingEnabled = true;
            this.cbPerfil.Location = new System.Drawing.Point(155, 321);
            this.cbPerfil.Margin = new System.Windows.Forms.Padding(4);
            this.cbPerfil.Name = "cbPerfil";
            this.cbPerfil.Size = new System.Drawing.Size(163, 24);
            this.cbPerfil.TabIndex = 19;
            // 
            // frmModificacionUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(47)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(369, 539);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbUsuario);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnModificar);
            this.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(159)))), ((int)(((byte)(161)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmModificacionUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Modificar Usuario";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbUsuario;
        private BotonFacha btnSalir;
        private BotonFacha btnModificar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox ckbContraseña;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblContraseña;
        private frmTextBoxFacha txtbApellido;
        private System.Windows.Forms.Label lblUsuario;
        private frmTextBoxFacha txtbEmail;
        private frmTextBoxFacha txtbNombre;
        private frmTextBoxFacha txtbUsuario;
        private frmTextBoxFacha txtbContraseña;
        private System.Windows.Forms.Label lblPerfil;
        private System.Windows.Forms.ComboBox cbPerfil;
    }
}