
namespace FestivalFolklore
{
    partial class frmLogin
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.botonFacha1 = new FestivalFolklore.BotonFacha();
            this.frmTextBoxFachaPswd = new FestivalFolklore.frmTextBoxFacha();
            this.frmTextBoxFacha1 = new FestivalFolklore.frmTextBoxFacha();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(159)))), ((int)(((byte)(161)))));
            this.label1.Location = new System.Drawing.Point(57, 385);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Contraseña";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(159)))), ((int)(((byte)(161)))));
            this.label2.Location = new System.Drawing.Point(58, 300);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Usuario";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(60, 329);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(28, 27);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.Location = new System.Drawing.Point(60, 413);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(28, 27);
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // botonFacha1
            // 
            this.botonFacha1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(154)))));
            this.botonFacha1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(154)))));
            this.botonFacha1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.botonFacha1.BorderRadius = 17;
            this.botonFacha1.BorderSize = 0;
            this.botonFacha1.FlatAppearance.BorderSize = 0;
            this.botonFacha1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonFacha1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonFacha1.ForeColor = System.Drawing.Color.White;
            this.botonFacha1.Location = new System.Drawing.Point(94, 494);
            this.botonFacha1.Name = "botonFacha1";
            this.botonFacha1.Size = new System.Drawing.Size(150, 40);
            this.botonFacha1.TabIndex = 12;
            this.botonFacha1.Text = "Ingresar";
            this.botonFacha1.TextColor = System.Drawing.Color.White;
            this.botonFacha1.UseVisualStyleBackColor = false;
            this.botonFacha1.Click += new System.EventHandler(this.botonFacha1_Click);
            // 
            // frmTextBoxFachaPswd
            // 
            this.frmTextBoxFachaPswd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(47)))), ((int)(((byte)(50)))));
            this.frmTextBoxFachaPswd.BorderColor = System.Drawing.Color.DimGray;
            this.frmTextBoxFachaPswd.BorderFocusColor = System.Drawing.Color.HotPink;
            this.frmTextBoxFachaPswd.BorderSize = 2;
            this.frmTextBoxFachaPswd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frmTextBoxFachaPswd.ForeColor = System.Drawing.Color.DimGray;
            this.frmTextBoxFachaPswd.Location = new System.Drawing.Point(94, 405);
            this.frmTextBoxFachaPswd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.frmTextBoxFachaPswd.Multiline = false;
            this.frmTextBoxFachaPswd.Name = "frmTextBoxFachaPswd";
            this.frmTextBoxFachaPswd.Padding = new System.Windows.Forms.Padding(7);
            this.frmTextBoxFachaPswd.PasswordChar = true;
            this.frmTextBoxFachaPswd.Size = new System.Drawing.Size(178, 35);
            this.frmTextBoxFachaPswd.TabIndex = 11;
            this.frmTextBoxFachaPswd.Texts = "";
            this.frmTextBoxFachaPswd.UnderlinedStyle = true;
            this.frmTextBoxFachaPswd.Load += new System.EventHandler(this.frmTextBoxFachaPswd_Load);
            // 
            // frmTextBoxFacha1
            // 
            this.frmTextBoxFacha1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(47)))), ((int)(((byte)(50)))));
            this.frmTextBoxFacha1.BorderColor = System.Drawing.Color.DimGray;
            this.frmTextBoxFacha1.BorderFocusColor = System.Drawing.Color.HotPink;
            this.frmTextBoxFacha1.BorderSize = 2;
            this.frmTextBoxFacha1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frmTextBoxFacha1.ForeColor = System.Drawing.Color.DimGray;
            this.frmTextBoxFacha1.Location = new System.Drawing.Point(94, 321);
            this.frmTextBoxFacha1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.frmTextBoxFacha1.Multiline = false;
            this.frmTextBoxFacha1.Name = "frmTextBoxFacha1";
            this.frmTextBoxFacha1.Padding = new System.Windows.Forms.Padding(7);
            this.frmTextBoxFacha1.PasswordChar = false;
            this.frmTextBoxFacha1.Size = new System.Drawing.Size(178, 35);
            this.frmTextBoxFacha1.TabIndex = 10;
            this.frmTextBoxFacha1.Texts = "";
            this.frmTextBoxFacha1.UnderlinedStyle = true;
            this.frmTextBoxFacha1.Load += new System.EventHandler(this.frmTextBoxFacha1_Load);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.Location = new System.Drawing.Point(2, -1);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(319, 270);
            this.pictureBox3.TabIndex = 13;
            this.pictureBox3.TabStop = false;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(47)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(348, 571);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.botonFacha1);
            this.Controls.Add(this.frmTextBoxFachaPswd);
            this.Controls.Add(this.frmTextBoxFacha1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private frmTextBoxFacha frmTextBoxFacha1;
        private frmTextBoxFacha frmTextBoxFachaPswd;
        private BotonFacha botonFacha1;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}

