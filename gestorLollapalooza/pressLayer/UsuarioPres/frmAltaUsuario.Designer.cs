
namespace gestorLollapalooza.pressLayer
{
    partial class frmAltaUsuario
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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.gbxUsuario = new System.Windows.Forms.GroupBox();
            this.txtbApellido = new gestorLollapalooza.frmTextBoxFacha();
            this.txtbNombre = new gestorLollapalooza.frmTextBoxFacha();
            this.txtbEmail = new gestorLollapalooza.frmTextBoxFacha();
            this.txtbContraseña = new gestorLollapalooza.frmTextBoxFacha();
            this.txtbUsuario = new gestorLollapalooza.frmTextBoxFacha();
            this.gbxPerfil = new System.Windows.Forms.GroupBox();
            this.cbPerfil = new System.Windows.Forms.ComboBox();
            this.btnCrear = new gestorLollapalooza.BotonFacha();
            this.btnSalir = new gestorLollapalooza.BotonFacha();
            this.gbxUsuario.SuspendLayout();
            this.gbxPerfil.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // gbxUsuario
            // 
            this.gbxUsuario.Controls.Add(this.txtbApellido);
            this.gbxUsuario.Controls.Add(this.txtbNombre);
            this.gbxUsuario.Controls.Add(this.txtbEmail);
            this.gbxUsuario.Controls.Add(this.txtbContraseña);
            this.gbxUsuario.Controls.Add(this.txtbUsuario);
            this.gbxUsuario.Location = new System.Drawing.Point(12, 8);
            this.gbxUsuario.Name = "gbxUsuario";
            this.gbxUsuario.Size = new System.Drawing.Size(168, 253);
            this.gbxUsuario.TabIndex = 8;
            this.gbxUsuario.TabStop = false;
            this.gbxUsuario.Text = "Usuario";
            // 
            // txtbApellido
            // 
            this.txtbApellido.BackColor = System.Drawing.SystemColors.Window;
            this.txtbApellido.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtbApellido.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtbApellido.BorderSize = 2;
            this.txtbApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbApellido.ForeColor = System.Drawing.Color.DimGray;
            this.txtbApellido.Location = new System.Drawing.Point(15, 196);
            this.txtbApellido.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtbApellido.Multiline = false;
            this.txtbApellido.Name = "txtbApellido";
            this.txtbApellido.Padding = new System.Windows.Forms.Padding(7);
            this.txtbApellido.PasswordChar = false;
            this.txtbApellido.Size = new System.Drawing.Size(123, 31);
            this.txtbApellido.TabIndex = 17;
            this.txtbApellido.Text = "Apellido";
            this.txtbApellido.UnderlinedStyle = false;
            // 
            // txtbNombre
            // 
            this.txtbNombre.BackColor = System.Drawing.SystemColors.Window;
            this.txtbNombre.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtbNombre.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtbNombre.BorderSize = 2;
            this.txtbNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbNombre.ForeColor = System.Drawing.Color.DimGray;
            this.txtbNombre.Location = new System.Drawing.Point(15, 157);
            this.txtbNombre.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtbNombre.Multiline = false;
            this.txtbNombre.Name = "txtbNombre";
            this.txtbNombre.Padding = new System.Windows.Forms.Padding(7);
            this.txtbNombre.PasswordChar = false;
            this.txtbNombre.Size = new System.Drawing.Size(123, 31);
            this.txtbNombre.TabIndex = 13;
            this.txtbNombre.Text = "Nombre";
            this.txtbNombre.UnderlinedStyle = false;
            // 
            // txtbEmail
            // 
            this.txtbEmail.BackColor = System.Drawing.SystemColors.Window;
            this.txtbEmail.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtbEmail.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtbEmail.BorderSize = 2;
            this.txtbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbEmail.ForeColor = System.Drawing.Color.DimGray;
            this.txtbEmail.Location = new System.Drawing.Point(15, 118);
            this.txtbEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtbEmail.Multiline = false;
            this.txtbEmail.Name = "txtbEmail";
            this.txtbEmail.Padding = new System.Windows.Forms.Padding(7);
            this.txtbEmail.PasswordChar = false;
            this.txtbEmail.Size = new System.Drawing.Size(123, 31);
            this.txtbEmail.TabIndex = 16;
            this.txtbEmail.Tag = "";
            this.txtbEmail.Text = "Email";
            this.txtbEmail.UnderlinedStyle = false;
            // 
            // txtbContraseña
            // 
            this.txtbContraseña.BackColor = System.Drawing.SystemColors.Window;
            this.txtbContraseña.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtbContraseña.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtbContraseña.BorderSize = 2;
            this.txtbContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbContraseña.ForeColor = System.Drawing.Color.DimGray;
            this.txtbContraseña.Location = new System.Drawing.Point(15, 75);
            this.txtbContraseña.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtbContraseña.Multiline = false;
            this.txtbContraseña.Name = "txtbContraseña";
            this.txtbContraseña.Padding = new System.Windows.Forms.Padding(7);
            this.txtbContraseña.PasswordChar = false;
            this.txtbContraseña.Size = new System.Drawing.Size(123, 31);
            this.txtbContraseña.TabIndex = 15;
            this.txtbContraseña.Tag = "";
            this.txtbContraseña.Text = "Contraseña";
            this.txtbContraseña.UnderlinedStyle = false;
            // 
            // txtbUsuario
            // 
            this.txtbUsuario.BackColor = System.Drawing.SystemColors.Window;
            this.txtbUsuario.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtbUsuario.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtbUsuario.BorderSize = 2;
            this.txtbUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbUsuario.ForeColor = System.Drawing.Color.DimGray;
            this.txtbUsuario.Location = new System.Drawing.Point(15, 36);
            this.txtbUsuario.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtbUsuario.Multiline = false;
            this.txtbUsuario.Name = "txtbUsuario";
            this.txtbUsuario.Padding = new System.Windows.Forms.Padding(7);
            this.txtbUsuario.PasswordChar = false;
            this.txtbUsuario.Size = new System.Drawing.Size(123, 31);
            this.txtbUsuario.TabIndex = 13;
            this.txtbUsuario.Tag = "";
            this.txtbUsuario.Text = "Usuario";
            this.txtbUsuario.UnderlinedStyle = false;
            // 
            // gbxPerfil
            // 
            this.gbxPerfil.Controls.Add(this.cbPerfil);
            this.gbxPerfil.Location = new System.Drawing.Point(186, 12);
            this.gbxPerfil.Name = "gbxPerfil";
            this.gbxPerfil.Size = new System.Drawing.Size(206, 92);
            this.gbxPerfil.TabIndex = 9;
            this.gbxPerfil.TabStop = false;
            this.gbxPerfil.Text = "Perfil";
            // 
            // cbPerfil
            // 
            this.cbPerfil.FormattingEnabled = true;
            this.cbPerfil.Location = new System.Drawing.Point(50, 35);
            this.cbPerfil.Name = "cbPerfil";
            this.cbPerfil.Size = new System.Drawing.Size(121, 21);
            this.cbPerfil.TabIndex = 0;
            // 
            // btnCrear
            // 
            this.btnCrear.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnCrear.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnCrear.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnCrear.BorderRadius = 20;
            this.btnCrear.BorderSize = 0;
            this.btnCrear.FlatAppearance.BorderSize = 0;
            this.btnCrear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrear.ForeColor = System.Drawing.Color.White;
            this.btnCrear.Location = new System.Drawing.Point(301, 220);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(91, 41);
            this.btnCrear.TabIndex = 11;
            this.btnCrear.Text = "Crear";
            this.btnCrear.TextColor = System.Drawing.Color.White;
            this.btnCrear.UseVisualStyleBackColor = false;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnSalir.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnSalir.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnSalir.BorderRadius = 20;
            this.btnSalir.BorderSize = 0;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Location = new System.Drawing.Point(204, 220);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(91, 41);
            this.btnSalir.TabIndex = 12;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextColor = System.Drawing.Color.White;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click_1);
            // 
            // frmAltaUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 273);
            this.ControlBox = false;
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.gbxPerfil);
            this.Controls.Add(this.gbxUsuario);
            this.Name = "frmAltaUsuario";
            this.Text = "Alta Usuario";
            this.gbxUsuario.ResumeLayout(false);
            this.gbxPerfil.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.GroupBox gbxUsuario;
        private System.Windows.Forms.GroupBox gbxPerfil;
        private frmTextBoxFacha txtbEmail;
        private frmTextBoxFacha txtbContraseña;
        private frmTextBoxFacha txtbUsuario;
        private System.Windows.Forms.ComboBox cbPerfil;
        private BotonFacha btnCrear;
        private BotonFacha btnSalir;
        private frmTextBoxFacha txtbApellido;
        private frmTextBoxFacha txtbNombre;
    }
}