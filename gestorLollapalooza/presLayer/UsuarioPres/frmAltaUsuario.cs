using gestorLollapalooza.bussinesLayer;
using gestorLollapalooza.dataAccessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gestorLollapalooza.pressLayer
{
    public partial class frmRegistrarUsuario : Form
    {
        private Usuario usuarioObj;
        private Perfil perfilObj;

        public frmRegistrarUsuario()
        {
            InitializeComponent();
            this.usuarioObj = new Usuario();
            this.perfilObj = new Perfil();
            this.CargarCombo(cbPerfil, perfilObj.RecuperarTodos(), "idPerfil", "nombrePerfil");
        }

        private void CargarCombo(ComboBox combo, Object fuente, string campoValor, string campoMostrar)
        {
            combo.DataSource = fuente;
            combo.DisplayMember = campoMostrar;
            combo.ValueMember = campoValor;
            combo.SelectedIndex = -1;
        }


        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {

            if (this.Comprobar())
            {
                // Se valida que el usuario a crear no existe en la BD

                if(usuarioObj.ExisteUsuario(this.txtbUsuario.Text) == false)
                {

                    // Recupera los datos del formulario 

                    string nombreUsuario = this.txtbUsuario.Text;
                    string password = this.txtbContraseña.Text;
                    string email = this.txtbEmail.Text;
                    string nombre = this.txtbNombre.Text;
                    string apellido = this.txtbApellido.Text;
                    int idPerfil = (int)cbPerfil.SelectedValue;

                    // Se instancia un nuevo perfil para el usuario

                    Perfil perfilUsuarioN = new Perfil();
                    perfilUsuarioN.IdPerfil = idPerfil;

                    // Se instancia el nuevo usuario

                    Usuario usuarioN = new Usuario()
                    {
                        UsuarioNombre = nombreUsuario,
                        Contrasena = password,
                        Email = email,
                        Nombre = nombre,
                        Apellido = apellido,
                        PerfilUsuario = perfilUsuarioN
                    };

                    // Se intenta persistir el usuario en caso de lograrlo se informa y se limpian los txtBox
                    

                    if(usuarioObj.PersistirUsuario(usuarioN))
                    {
                        MessageBox.Show("Usuario Creado con exito", "info");
                        this.LimpiarTxt();
                        this.resetearColor();

                    } else 
                    {
                        MessageBox.Show("El usuario no pudo crearse"); 
                    }
                } else
                {
                    MessageBox.Show("Ya existe dicho usuario");
                    this.LimpiarTxt();
                    this.resetearColor();
                }

            }else
            {
                MessageBox.Show("Los campos en rojo deben ser completados obligatoriamente");
            }
        }

        public bool Comprobar()
        {

            // Comprueba que los campos no esten vacios, cambiandoles el color a rojo a aquellos que son obligatorios

            bool band = true;

            if (string.IsNullOrEmpty(this.txtbUsuario.Text))
            {
                this.txtbUsuario.BorderColor = Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(66)))), ((int)(((byte)(56)))));
                band = false;

            }
                
            if (string.IsNullOrEmpty(this.txtbContraseña.Text))
            {
                this.txtbContraseña.BorderColor = Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(66)))), ((int)(((byte)(56)))));
                band = false;
            }
                
            if (string.IsNullOrEmpty(this.txtbNombre.Text))
            {
                this.txtbNombre.BorderColor = Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(66)))), ((int)(((byte)(56)))));
                band = false;
            }
                
            if (string.IsNullOrEmpty(this.txtbApellido.Text))
            {
                this.txtbApellido.BorderColor = Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(66)))), ((int)(((byte)(56)))));
                band = false;
            }
                
            if (cbPerfil.SelectedIndex == -1)
            {
                this.lblPerfil.ForeColor = Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(66)))), ((int)(((byte)(56)))));
                band = false;
            }

            return band;

        }

        private void ckbContraseña_CheckStateChanged(object sender, EventArgs e)
        {

            // Permite visualizar la contraseña

            if (this.ckbContraseña.CheckState == CheckState.Checked)
            {
                this.txtbContraseña.PasswordChar = false;
            }
            else
            {
                this.txtbContraseña.PasswordChar = true;
            }
            
        }

        private void LimpiarTxt()
        {
            this.txtbUsuario.Text = String.Empty;
            this.txtbContraseña.Text = String.Empty;
            this.txtbApellido.Text = String.Empty;
            this.txtbEmail.Text = String.Empty;
            this.txtbNombre.Text = String.Empty;
            this.txtbUsuario.Focus();
        }

        private void resetearColor()
        {
            this.txtbUsuario.BorderColor = Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(154)))));
            this.txtbContraseña.BorderColor = Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(154)))));
            this.txtbNombre.BorderColor = Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(154)))));
            this.txtbApellido.BorderColor = Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(154)))));
            this.lblPerfil.ForeColor = Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(154)))));
        }
    }
}
