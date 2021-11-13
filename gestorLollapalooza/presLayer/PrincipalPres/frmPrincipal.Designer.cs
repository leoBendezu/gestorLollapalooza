
using System.Windows.Forms;

namespace gestorLollapalooza.pressLayer
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.festivalesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.diagramarNuevoFestivalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.soporteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionGruposMusicalesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionTipoDeEntradaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestiónCentroDeVentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionPuntoDeVentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grupoMusicalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.festivalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.centroDeVentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblBienvenido = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblPerfil = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(154)))));
            this.menuStrip1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.festivalesToolStripMenuItem,
            this.soporteToolStripMenuItem,
            this.reporteToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1344, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // festivalesToolStripMenuItem
            // 
            this.festivalesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.diagramarNuevoFestivalToolStripMenuItem});
            this.festivalesToolStripMenuItem.Name = "festivalesToolStripMenuItem";
            this.festivalesToolStripMenuItem.Size = new System.Drawing.Size(99, 24);
            this.festivalesToolStripMenuItem.Text = "Festivales";
            // 
            // diagramarNuevoFestivalToolStripMenuItem
            // 
            this.diagramarNuevoFestivalToolStripMenuItem.Name = "diagramarNuevoFestivalToolStripMenuItem";
            this.diagramarNuevoFestivalToolStripMenuItem.Size = new System.Drawing.Size(286, 26);
            this.diagramarNuevoFestivalToolStripMenuItem.Text = "Diagramar Nuevo Festival";
            this.diagramarNuevoFestivalToolStripMenuItem.Click += new System.EventHandler(this.diagramarNuevoFestivalToolStripMenuItem_Click);
            // 
            // soporteToolStripMenuItem
            // 
            this.soporteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionUsuariosToolStripMenuItem,
            this.gestionGruposMusicalesToolStripMenuItem,
            this.gestionTipoDeEntradaToolStripMenuItem,
            this.gestiónCentroDeVentaToolStripMenuItem,
            this.gestionPuntoDeVentaToolStripMenuItem});
            this.soporteToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(47)))), ((int)(((byte)(50)))));
            this.soporteToolStripMenuItem.Name = "soporteToolStripMenuItem";
            this.soporteToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.soporteToolStripMenuItem.Text = "Soporte";
            // 
            // gestionUsuariosToolStripMenuItem
            // 
            this.gestionUsuariosToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.gestionUsuariosToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(47)))), ((int)(((byte)(50)))));
            this.gestionUsuariosToolStripMenuItem.Name = "gestionUsuariosToolStripMenuItem";
            this.gestionUsuariosToolStripMenuItem.Size = new System.Drawing.Size(291, 26);
            this.gestionUsuariosToolStripMenuItem.Text = "Gestión Usuarios";
            this.gestionUsuariosToolStripMenuItem.Click += new System.EventHandler(this.gestionUsuariosToolStripMenuItem_Click);
            // 
            // gestionGruposMusicalesToolStripMenuItem
            // 
            this.gestionGruposMusicalesToolStripMenuItem.Name = "gestionGruposMusicalesToolStripMenuItem";
            this.gestionGruposMusicalesToolStripMenuItem.Size = new System.Drawing.Size(291, 26);
            this.gestionGruposMusicalesToolStripMenuItem.Text = "Gestión Grupos Musicales";
            this.gestionGruposMusicalesToolStripMenuItem.Click += new System.EventHandler(this.gestionGruposMusicalesToolStripMenuItem_Click);
            // 
            // gestionTipoDeEntradaToolStripMenuItem
            // 
            this.gestionTipoDeEntradaToolStripMenuItem.Name = "gestionTipoDeEntradaToolStripMenuItem";
            this.gestionTipoDeEntradaToolStripMenuItem.Size = new System.Drawing.Size(291, 26);
            this.gestionTipoDeEntradaToolStripMenuItem.Text = "Gestión Tipo de Entrada";
            this.gestionTipoDeEntradaToolStripMenuItem.Click += new System.EventHandler(this.gestionTipoDeEntradaToolStripMenuItem_Click);
            // 
            // gestiónCentroDeVentaToolStripMenuItem
            // 
            this.gestiónCentroDeVentaToolStripMenuItem.Name = "gestiónCentroDeVentaToolStripMenuItem";
            this.gestiónCentroDeVentaToolStripMenuItem.Size = new System.Drawing.Size(291, 26);
            this.gestiónCentroDeVentaToolStripMenuItem.Text = "Gestión Centro De Venta";
            this.gestiónCentroDeVentaToolStripMenuItem.Click += new System.EventHandler(this.gestiónCentroDeVentaToolStripMenuItem_Click);
            // 
            // gestionPuntoDeVentaToolStripMenuItem
            // 
            this.gestionPuntoDeVentaToolStripMenuItem.Name = "gestionPuntoDeVentaToolStripMenuItem";
            this.gestionPuntoDeVentaToolStripMenuItem.Size = new System.Drawing.Size(291, 26);
            this.gestionPuntoDeVentaToolStripMenuItem.Text = "Gestión Punto de venta";
            this.gestionPuntoDeVentaToolStripMenuItem.Click += new System.EventHandler(this.gestionPuntoDeVentaToolStripMenuItem_Click_1);
            // 
            // reporteToolStripMenuItem
            // 
            this.reporteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.grupoMusicalToolStripMenuItem,
            this.usuariosToolStripMenuItem,
            this.festivalToolStripMenuItem,
            this.centroDeVentaToolStripMenuItem});
            this.reporteToolStripMenuItem.Name = "reporteToolStripMenuItem";
            this.reporteToolStripMenuItem.Size = new System.Drawing.Size(82, 24);
            this.reporteToolStripMenuItem.Text = "Reporte";
            // 
            // grupoMusicalToolStripMenuItem
            // 
            this.grupoMusicalToolStripMenuItem.Name = "grupoMusicalToolStripMenuItem";
            this.grupoMusicalToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.grupoMusicalToolStripMenuItem.Text = "GrupoMusical";
            this.grupoMusicalToolStripMenuItem.Click += new System.EventHandler(this.grupoMusicalToolStripMenuItem_Click);
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.usuariosToolStripMenuItem.Text = "Usuarios";
            this.usuariosToolStripMenuItem.Click += new System.EventHandler(this.usuariosToolStripMenuItem_Click);
            // 
            // festivalToolStripMenuItem
            // 
            this.festivalToolStripMenuItem.Name = "festivalToolStripMenuItem";
            this.festivalToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.festivalToolStripMenuItem.Text = "Festival";
            this.festivalToolStripMenuItem.Click += new System.EventHandler(this.festivalToolStripMenuItem_Click);
            // 
            // centroDeVentaToolStripMenuItem
            // 
            this.centroDeVentaToolStripMenuItem.Name = "centroDeVentaToolStripMenuItem";
            this.centroDeVentaToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.centroDeVentaToolStripMenuItem.Text = "Centro De Venta";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(57, 24);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // gestionarToolStripMenuItem
            // 
            this.gestionarToolStripMenuItem.Name = "gestionarToolStripMenuItem";
            this.gestionarToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::gestorLollapalooza.Properties.Resources.principal;
            this.pictureBox1.Location = new System.Drawing.Point(189, 192);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(987, 295);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // lblBienvenido
            // 
            this.lblBienvenido.AutoSize = true;
            this.lblBienvenido.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBienvenido.ForeColor = System.Drawing.Color.White;
            this.lblBienvenido.Location = new System.Drawing.Point(16, 559);
            this.lblBienvenido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBienvenido.Name = "lblBienvenido";
            this.lblBienvenido.Size = new System.Drawing.Size(123, 31);
            this.lblBienvenido.TabIndex = 3;
            this.lblBienvenido.Text = "Usuario: ";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(188, 559);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(0, 31);
            this.lblName.TabIndex = 4;
            // 
            // lblPerfil
            // 
            this.lblPerfil.AutoSize = true;
            this.lblPerfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPerfil.ForeColor = System.Drawing.Color.White;
            this.lblPerfil.Location = new System.Drawing.Point(188, 612);
            this.lblPerfil.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPerfil.Name = "lblPerfil";
            this.lblPerfil.Size = new System.Drawing.Size(0, 31);
            this.lblPerfil.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(16, 612);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 31);
            this.label2.TabIndex = 5;
            this.label2.Text = "Perfil: ";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(47)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(1344, 661);
            this.Controls.Add(this.lblPerfil);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblBienvenido);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lollapalooza - Menú principal";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem soporteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionUsuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem festivalesToolStripMenuItem;
        private ToolStripMenuItem gestionarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionGruposMusicalesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionTipoDeEntradaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestiónCentroDeVentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem diagramarNuevoFestivalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gruposMusicalesToolStripMenuItem;
        private ToolStripMenuItem reporteToolStripMenuItem;
        private ToolStripMenuItem grupoMusicalToolStripMenuItem;
        private ToolStripMenuItem usuariosToolStripMenuItem;
        private ToolStripMenuItem festivalToolStripMenuItem;
        private ToolStripMenuItem centroDeVentaToolStripMenuItem;
        private ToolStripMenuItem gestionPuntoDeVentaToolStripMenuItem;
        private Label lblBienvenido;
        private Label lblName;
        private Label lblPerfil;
        private Label label2;
    }
}