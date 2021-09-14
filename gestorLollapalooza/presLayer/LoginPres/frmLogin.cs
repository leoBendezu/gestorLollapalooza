using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using gestorLollapalooza.bussinesLayer;

namespace gestorLollapalooza
{
    public partial class frmLogin : Form
    {

        private Usuario usuarioLoggeado;
            
        public frmLogin()
        {
            InitializeComponent();
        }


        private void botonFacha1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.txtbUsuario.Text) || string.IsNullOrEmpty(this.txtbPassword.Text))
            {
                MessageBox.Show("Complete todos los campos del Login porfavor...");
            } 
            else 
            {
                Usuario usuarioObj = new Usuario();
                this.usuarioLoggeado = usuarioObj.ValidarCredenciales(this.txtbUsuario.Text, this.txtbPassword.Text);
                if (this.usuarioLoggeado != null)
                {
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Usuario y/o contraseña incorrectos", "Validación de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.LimpiarTxt();                    
                }                   
            }

        }


        private void botonFacha2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro de abandonar la aplicación?", "SALIENDO DE LA APLICACIÓN",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                this.Close();
            } else
            {
                this.LimpiarTxt();
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            this.txtbUsuario.Focus();
        }
 

        private void LimpiarTxt()
        {
            this.txtbUsuario.Text = String.Empty;
            this.txtbPassword.Text = String.Empty;
            this.txtbUsuario.Focus();
        }
    }
}
