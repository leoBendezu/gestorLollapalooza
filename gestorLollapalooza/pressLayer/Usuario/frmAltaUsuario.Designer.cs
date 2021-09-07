
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
            this.txtbUsuario = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txtbContraseña = new System.Windows.Forms.TextBox();
            this.txtbNombre = new System.Windows.Forms.TextBox();
            this.txtbApellido = new System.Windows.Forms.TextBox();
            this.txtbDni = new System.Windows.Forms.TextBox();
            this.txtbNombrePerfil = new System.Windows.Forms.TextBox();
            this.txtbDescripcion = new System.Windows.Forms.TextBox();
            this.gbxUsuario = new System.Windows.Forms.GroupBox();
            this.gbxPerfil = new System.Windows.Forms.GroupBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblDni = new System.Windows.Forms.Label();
            this.lblNombrePerfil = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnCrear = new System.Windows.Forms.Button();
            this.gbxUsuario.SuspendLayout();
            this.gbxPerfil.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtbUsuario
            // 
            this.txtbUsuario.Location = new System.Drawing.Point(87, 35);
            this.txtbUsuario.Name = "txtbUsuario";
            this.txtbUsuario.Size = new System.Drawing.Size(100, 20);
            this.txtbUsuario.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txtbContraseña
            // 
            this.txtbContraseña.Location = new System.Drawing.Point(87, 76);
            this.txtbContraseña.Name = "txtbContraseña";
            this.txtbContraseña.Size = new System.Drawing.Size(100, 20);
            this.txtbContraseña.TabIndex = 2;
            // 
            // txtbNombre
            // 
            this.txtbNombre.Location = new System.Drawing.Point(87, 117);
            this.txtbNombre.Name = "txtbNombre";
            this.txtbNombre.Size = new System.Drawing.Size(100, 20);
            this.txtbNombre.TabIndex = 3;
            // 
            // txtbApellido
            // 
            this.txtbApellido.Location = new System.Drawing.Point(87, 158);
            this.txtbApellido.Name = "txtbApellido";
            this.txtbApellido.Size = new System.Drawing.Size(100, 20);
            this.txtbApellido.TabIndex = 4;
            // 
            // txtbDni
            // 
            this.txtbDni.Location = new System.Drawing.Point(87, 199);
            this.txtbDni.Name = "txtbDni";
            this.txtbDni.Size = new System.Drawing.Size(100, 20);
            this.txtbDni.TabIndex = 5;
            // 
            // txtbNombrePerfil
            // 
            this.txtbNombrePerfil.Location = new System.Drawing.Point(85, 39);
            this.txtbNombrePerfil.Name = "txtbNombrePerfil";
            this.txtbNombrePerfil.Size = new System.Drawing.Size(100, 20);
            this.txtbNombrePerfil.TabIndex = 6;
            // 
            // txtbDescripcion
            // 
            this.txtbDescripcion.Location = new System.Drawing.Point(85, 72);
            this.txtbDescripcion.Name = "txtbDescripcion";
            this.txtbDescripcion.Size = new System.Drawing.Size(100, 20);
            this.txtbDescripcion.TabIndex = 7;
            // 
            // gbxUsuario
            // 
            this.gbxUsuario.Controls.Add(this.lblDni);
            this.gbxUsuario.Controls.Add(this.lblApellido);
            this.gbxUsuario.Controls.Add(this.lblNombre);
            this.gbxUsuario.Controls.Add(this.lblContraseña);
            this.gbxUsuario.Controls.Add(this.lblUsuario);
            this.gbxUsuario.Controls.Add(this.txtbApellido);
            this.gbxUsuario.Controls.Add(this.txtbUsuario);
            this.gbxUsuario.Controls.Add(this.txtbContraseña);
            this.gbxUsuario.Controls.Add(this.txtbDni);
            this.gbxUsuario.Controls.Add(this.txtbNombre);
            this.gbxUsuario.Location = new System.Drawing.Point(12, 8);
            this.gbxUsuario.Name = "gbxUsuario";
            this.gbxUsuario.Size = new System.Drawing.Size(228, 249);
            this.gbxUsuario.TabIndex = 8;
            this.gbxUsuario.TabStop = false;
            this.gbxUsuario.Text = "Usuario";
            // 
            // gbxPerfil
            // 
            this.gbxPerfil.Controls.Add(this.lblNombrePerfil);
            this.gbxPerfil.Controls.Add(this.lblDescripcion);
            this.gbxPerfil.Controls.Add(this.txtbNombrePerfil);
            this.gbxPerfil.Controls.Add(this.txtbDescripcion);
            this.gbxPerfil.Location = new System.Drawing.Point(246, 12);
            this.gbxPerfil.Name = "gbxPerfil";
            this.gbxPerfil.Size = new System.Drawing.Size(206, 146);
            this.gbxPerfil.TabIndex = 9;
            this.gbxPerfil.TabStop = false;
            this.gbxPerfil.Text = "Perfil";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(24, 38);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(46, 13);
            this.lblUsuario.TabIndex = 10;
            this.lblUsuario.Text = "Usuario:";
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.Location = new System.Drawing.Point(6, 79);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(64, 13);
            this.lblContraseña.TabIndex = 11;
            this.lblContraseña.Text = "Contraseña:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(23, 120);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 12;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(23, 161);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(47, 13);
            this.lblApellido.TabIndex = 13;
            this.lblApellido.Text = "Apellido:";
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Location = new System.Drawing.Point(41, 202);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(29, 13);
            this.lblDni.TabIndex = 14;
            this.lblDni.Text = "DNI:";
            // 
            // lblNombrePerfil
            // 
            this.lblNombrePerfil.AutoSize = true;
            this.lblNombrePerfil.Location = new System.Drawing.Point(34, 42);
            this.lblNombrePerfil.Name = "lblNombrePerfil";
            this.lblNombrePerfil.Size = new System.Drawing.Size(47, 13);
            this.lblNombrePerfil.TabIndex = 15;
            this.lblNombrePerfil.Text = "Nombre:";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(13, 75);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(66, 13);
            this.lblDescripcion.TabIndex = 16;
            this.lblDescripcion.Text = "Descripcion:";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(262, 200);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 10;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(356, 200);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(75, 23);
            this.btnCrear.TabIndex = 11;
            this.btnCrear.Text = "Crear";
            this.btnCrear.UseVisualStyleBackColor = true;
            // 
            // frmAltaUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 269);
            this.ControlBox = false;
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.gbxPerfil);
            this.Controls.Add(this.gbxUsuario);
            this.Name = "frmAltaUsuario";
            this.Text = "Alta Usuario";
            this.gbxUsuario.ResumeLayout(false);
            this.gbxUsuario.PerformLayout();
            this.gbxPerfil.ResumeLayout(false);
            this.gbxPerfil.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtbUsuario;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox txtbContraseña;
        private System.Windows.Forms.TextBox txtbNombre;
        private System.Windows.Forms.TextBox txtbApellido;
        private System.Windows.Forms.TextBox txtbDni;
        private System.Windows.Forms.TextBox txtbNombrePerfil;
        private System.Windows.Forms.TextBox txtbDescripcion;
        private System.Windows.Forms.GroupBox gbxUsuario;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblContraseña;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.GroupBox gbxPerfil;
        private System.Windows.Forms.Label lblNombrePerfil;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnCrear;
    }
}