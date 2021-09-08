
namespace gestorLollapalooza.pressLayer.Usuario
{
    partial class frmBajaUsuario
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
            this.gxBajaUsuario = new System.Windows.Forms.GroupBox();
            this.txtbUsuario = new gestorLollapalooza.frmTextBoxFacha();
            this.txtbContraseña = new gestorLollapalooza.frmTextBoxFacha();
            this.btnEliminar = new gestorLollapalooza.BotonFacha();
            this.btnSalir = new gestorLollapalooza.BotonFacha();
            this.txtbApelido = new gestorLollapalooza.frmTextBoxFacha();
            this.txtbNombre = new gestorLollapalooza.frmTextBoxFacha();
            this.gxBajaUsuario.SuspendLayout();
            this.SuspendLayout();
            // 
            // gxBajaUsuario
            // 
            this.gxBajaUsuario.Controls.Add(this.txtbApelido);
            this.gxBajaUsuario.Controls.Add(this.txtbNombre);
            this.gxBajaUsuario.Controls.Add(this.txtbContraseña);
            this.gxBajaUsuario.Controls.Add(this.txtbUsuario);
            this.gxBajaUsuario.Location = new System.Drawing.Point(12, 12);
            this.gxBajaUsuario.Name = "gxBajaUsuario";
            this.gxBajaUsuario.Size = new System.Drawing.Size(233, 198);
            this.gxBajaUsuario.TabIndex = 6;
            this.gxBajaUsuario.TabStop = false;
            this.gxBajaUsuario.Text = "Ingrese los valores del usuario a eliminar";
            this.gxBajaUsuario.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtbUsuario
            // 
            this.txtbUsuario.BackColor = System.Drawing.SystemColors.Window;
            this.txtbUsuario.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtbUsuario.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtbUsuario.BorderSize = 2;
            this.txtbUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbUsuario.ForeColor = System.Drawing.Color.DimGray;
            this.txtbUsuario.Location = new System.Drawing.Point(44, 30);
            this.txtbUsuario.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtbUsuario.Multiline = false;
            this.txtbUsuario.Name = "txtbUsuario";
            this.txtbUsuario.Padding = new System.Windows.Forms.Padding(7);
            this.txtbUsuario.PasswordChar = false;
            this.txtbUsuario.Size = new System.Drawing.Size(138, 31);
            this.txtbUsuario.TabIndex = 4;
            this.txtbUsuario.Texts = "Usuario";
            this.txtbUsuario.UnderlinedStyle = false;
            // 
            // txtbContraseña
            // 
            this.txtbContraseña.BackColor = System.Drawing.SystemColors.Window;
            this.txtbContraseña.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtbContraseña.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtbContraseña.BorderSize = 2;
            this.txtbContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbContraseña.ForeColor = System.Drawing.Color.DimGray;
            this.txtbContraseña.Location = new System.Drawing.Point(44, 69);
            this.txtbContraseña.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtbContraseña.Multiline = false;
            this.txtbContraseña.Name = "txtbContraseña";
            this.txtbContraseña.Padding = new System.Windows.Forms.Padding(7);
            this.txtbContraseña.PasswordChar = false;
            this.txtbContraseña.Size = new System.Drawing.Size(138, 31);
            this.txtbContraseña.TabIndex = 9;
            this.txtbContraseña.Texts = "Contraseña";
            this.txtbContraseña.UnderlinedStyle = false;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnEliminar.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnEliminar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnEliminar.BorderRadius = 20;
            this.btnEliminar.BorderSize = 0;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(157, 237);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(88, 44);
            this.btnEliminar.TabIndex = 9;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextColor = System.Drawing.Color.White;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click_1);
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
            this.btnSalir.Location = new System.Drawing.Point(12, 237);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(88, 44);
            this.btnSalir.TabIndex = 10;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextColor = System.Drawing.Color.White;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click_1);
            // 
            // txtbApelido
            // 
            this.txtbApelido.BackColor = System.Drawing.SystemColors.Window;
            this.txtbApelido.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtbApelido.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtbApelido.BorderSize = 2;
            this.txtbApelido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbApelido.ForeColor = System.Drawing.Color.DimGray;
            this.txtbApelido.Location = new System.Drawing.Point(44, 147);
            this.txtbApelido.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtbApelido.Multiline = false;
            this.txtbApelido.Name = "txtbApelido";
            this.txtbApelido.Padding = new System.Windows.Forms.Padding(7);
            this.txtbApelido.PasswordChar = false;
            this.txtbApelido.Size = new System.Drawing.Size(138, 31);
            this.txtbApelido.TabIndex = 19;
            this.txtbApelido.Texts = "Apellido";
            this.txtbApelido.UnderlinedStyle = false;
            // 
            // txtbNombre
            // 
            this.txtbNombre.BackColor = System.Drawing.SystemColors.Window;
            this.txtbNombre.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtbNombre.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtbNombre.BorderSize = 2;
            this.txtbNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbNombre.ForeColor = System.Drawing.Color.DimGray;
            this.txtbNombre.Location = new System.Drawing.Point(44, 108);
            this.txtbNombre.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtbNombre.Multiline = false;
            this.txtbNombre.Name = "txtbNombre";
            this.txtbNombre.Padding = new System.Windows.Forms.Padding(7);
            this.txtbNombre.PasswordChar = false;
            this.txtbNombre.Size = new System.Drawing.Size(138, 31);
            this.txtbNombre.TabIndex = 18;
            this.txtbNombre.Texts = "Nombre";
            this.txtbNombre.UnderlinedStyle = false;
            // 
            // frmBajaUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 293);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.gxBajaUsuario);
            this.Name = "frmBajaUsuario";
            this.Text = "frmBajaUsuario";
            this.gxBajaUsuario.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gxBajaUsuario;
        private frmTextBoxFacha txtbContraseña;
        private frmTextBoxFacha txtbUsuario;
        private BotonFacha btnEliminar;
        private BotonFacha btnSalir;
        private frmTextBoxFacha txtbApelido;
        private frmTextBoxFacha txtbNombre;
    }
}