
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
            this.venderEntradaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.festivalesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.soporteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionGruposMusicalesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionTipoDeEntradaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestiónCentroDeVentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(154)))));
            this.menuStrip1.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.venderEntradaToolStripMenuItem,
            this.festivalesToolStripMenuItem,
            this.soporteToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1344, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // venderEntradaToolStripMenuItem
            // 
            this.venderEntradaToolStripMenuItem.Name = "venderEntradaToolStripMenuItem";
            this.venderEntradaToolStripMenuItem.Size = new System.Drawing.Size(100, 26);
            this.venderEntradaToolStripMenuItem.Text = "Entradas";
            // 
            // festivalesToolStripMenuItem
            // 
            this.festivalesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionarToolStripMenuItem});
            this.festivalesToolStripMenuItem.Name = "festivalesToolStripMenuItem";
            this.festivalesToolStripMenuItem.Size = new System.Drawing.Size(109, 26);
            this.festivalesToolStripMenuItem.Text = "Festivales";
            // 
            // gestionarToolStripMenuItem
            // 
            this.gestionarToolStripMenuItem.Name = "gestionarToolStripMenuItem";
            this.gestionarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.gestionarToolStripMenuItem.Text = "Gestionar";
            this.gestionarToolStripMenuItem.Click += new System.EventHandler(this.gestionarToolStripMenuItem_Click);
            // 
            // soporteToolStripMenuItem
            // 
            this.soporteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionUsuariosToolStripMenuItem,
            this.gestionGruposMusicalesToolStripMenuItem,
            this.gestionTipoDeEntradaToolStripMenuItem,
            this.gestiónCentroDeVentaToolStripMenuItem});
            this.soporteToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(47)))), ((int)(((byte)(50)))));
            this.soporteToolStripMenuItem.Name = "soporteToolStripMenuItem";
            this.soporteToolStripMenuItem.Size = new System.Drawing.Size(91, 26);
            this.soporteToolStripMenuItem.Text = "Soporte";
            // 
            // gestionUsuariosToolStripMenuItem
            // 
            this.gestionUsuariosToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.gestionUsuariosToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(47)))), ((int)(((byte)(50)))));
            this.gestionUsuariosToolStripMenuItem.Name = "gestionUsuariosToolStripMenuItem";
            this.gestionUsuariosToolStripMenuItem.Size = new System.Drawing.Size(314, 26);
            this.gestionUsuariosToolStripMenuItem.Text = "Gestion Usuarios";
            this.gestionUsuariosToolStripMenuItem.Click += new System.EventHandler(this.gestionUsuariosToolStripMenuItem_Click);
            // 
            // gestionGruposMusicalesToolStripMenuItem
            // 
            this.gestionGruposMusicalesToolStripMenuItem.Name = "gestionGruposMusicalesToolStripMenuItem";
            this.gestionGruposMusicalesToolStripMenuItem.Size = new System.Drawing.Size(314, 26);
            this.gestionGruposMusicalesToolStripMenuItem.Text = "Gestion Grupos Musicales";
            this.gestionGruposMusicalesToolStripMenuItem.Click += new System.EventHandler(this.gestionGruposMusicalesToolStripMenuItem_Click);
            // 
            // gestionTipoDeEntradaToolStripMenuItem
            // 
            this.gestionTipoDeEntradaToolStripMenuItem.Name = "gestionTipoDeEntradaToolStripMenuItem";
            this.gestionTipoDeEntradaToolStripMenuItem.Size = new System.Drawing.Size(314, 26);
            this.gestionTipoDeEntradaToolStripMenuItem.Text = "Gestion Tipo de Entrada";
            this.gestionTipoDeEntradaToolStripMenuItem.Click += new System.EventHandler(this.gestionTipoDeEntradaToolStripMenuItem_Click);
            // 
            // gestiónCentroDeVentaToolStripMenuItem
            // 
            this.gestiónCentroDeVentaToolStripMenuItem.Name = "gestiónCentroDeVentaToolStripMenuItem";
            this.gestiónCentroDeVentaToolStripMenuItem.Size = new System.Drawing.Size(314, 26);
            this.gestiónCentroDeVentaToolStripMenuItem.Text = "Gestión CentroDeVenta";
            this.gestiónCentroDeVentaToolStripMenuItem.Click += new System.EventHandler(this.gestiónCentroDeVentaToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(63, 26);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
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
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(47)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(1344, 661);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lollapalooza - Menu principal";
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
        private System.Windows.Forms.ToolStripMenuItem venderEntradaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem festivalesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionGruposMusicalesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionTipoDeEntradaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestiónCentroDeVentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionarToolStripMenuItem;
    }
}