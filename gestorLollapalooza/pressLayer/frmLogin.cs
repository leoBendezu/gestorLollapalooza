﻿using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;



namespace gestorLollapalooza
{
    public partial class frmLogin : Form
    {
        public bool ValidarCredenciales(string pUsuario, string pPassword)
        {
            bool usuarioValido = false;
            SqlConnection cnn = new SqlConnection();
            cnn.ConnectionString = "Data Source=SQL5103.site4now.net;Initial Catalog=db_a79729_dynamiteteam;User Id=db_a79729_dynamiteteam_admin;Password=dt123456";
            
            try
            {
                cnn.Open();
                String query = "SELECT idUsuario FROM Usuarios where nombre = '" + pUsuario + "' AND password = '" + pPassword+"'";
                SqlCommand cmd = new SqlCommand(query, cnn);
                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                usuarioValido = (dt.Rows.Count != 0);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error de base de datos" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (cnn.State == ConnectionState.Open)
                    cnn.Close();
            }
            //MessageBox.Show("hola: " + usuarioValido.ToString());
            return usuarioValido;
            }
        
            
        public frmLogin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void botonFacha1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.txtbUsuario.Text) || string.IsNullOrEmpty(this.txtbPassword.Text))
            {
                MessageBox.Show("Complete todos los campos del Login porfavor...");
            } else {
                if (ValidarCredenciales(this.txtbUsuario.Text, this.txtbPassword.Text))
                {
                    this.Close();
                }
                   
                   }

        }

        private void frmTextBoxFacha1_Load(object sender, EventArgs e)
        {

        }

        private void frmTextBoxFachaPswd_Load(object sender, EventArgs e)
        {

        }

        private void botonFacha2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro de abandonar la aplicación?", "SALIENDO DE LA APLICACIÓN",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
