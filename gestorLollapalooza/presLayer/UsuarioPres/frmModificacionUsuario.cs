using gestorLollapalooza.bussinesLayer;
using gestorLollapalooza.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gestorLollapalooza.presLayer.UsuarioPres
{
    public partial class frmModificacionUsuario : Form
    {

        private UsuarioService usuarioObj;
        private PerfilService perfilObj;
        private Usuario usuarioSeleccionado;

        public frmModificacionUsuario(string nombreUsuarioSelecionado)
        {
            InitializeComponent();
            this.usuarioObj = new UsuarioService();
            this.perfilObj = new PerfilService();

            this.usuarioSeleccionado = usuarioObj.recuperarUsuario(nombreUsuarioSelecionado);
            CargarCombo(cbPerfil, perfilObj.RecuperarTodos(), "IdPerfil", "nombrePerfil");
            CargarDatosUsuario();



        }

        private void CargarDatosUsuario()
        {
            this.txtbUsuario.Text = usuarioSeleccionado.UsuarioNombre;
            this.txtbApellido.Text = usuarioSeleccionado.Apellido;
            this.txtbEmail.Text = usuarioSeleccionado.Email;
            this.txtbNombre.Text = usuarioSeleccionado.Nombre;
            this.txtbContraseña.Text = usuarioSeleccionado.Contrasena;
            this.cbPerfil.SelectedIndex = usuarioSeleccionado.PerfilUsuario.IdPerfil - 1;
        }


        private void CargarCombo(ComboBox combo, Object fuente, string campoValor, string campoMostrar)
        {
            combo.DataSource = fuente;
            combo.DisplayMember = campoMostrar;
            combo.ValueMember = campoValor;
            combo.SelectedIndex = -1;
        }


        private void LimpiarTxt()
        {
            this.txtbUsuario.Text = String.Empty;
            this.txtbApellido.Text = String.Empty;
            this.txtbEmail.Text = String.Empty;
            this.txtbNombre.Text = String.Empty;
            this.txtbContraseña.Text = String.Empty;
            this.cbPerfil.SelectedIndex = -1;
        }


        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btnModificar_Click(object sender, EventArgs e)
        {
            // Comprueba si los campos obligatorios han sidos llenados

            if (Comprobar())
            {
                this.usuarioSeleccionado.UsuarioNombre = this.txtbUsuario.Text;
                this.usuarioSeleccionado.Nombre = this.txtbNombre.Text;
                this.usuarioSeleccionado.Email = this.txtbEmail.Text;
                this.usuarioSeleccionado.Apellido = this.txtbApellido.Text;
                this.usuarioSeleccionado.Contrasena = this.txtbContraseña.Text;

                Perfil perfilUsuario = new Perfil();
                perfilUsuario.IdPerfil = (int)cbPerfil.SelectedValue;
                this.usuarioSeleccionado.PerfilUsuario = perfilUsuario;

                // Intenta realizar la modificacion del usuario si lo logra avisa, limpia los campos de texto, resetea los campos
                // y vuelve a cargar el comboBox de usuarios.
                // En caso contrario avisa.

                if (usuarioObj.modificarUsuario(usuarioSeleccionado))
                {
                    MessageBox.Show("Se ha modificado el usuario", "Advertencia");
                    this.Close();

                }
                else
                {
                    MessageBox.Show("No se ha podido modificar el usuario", "Advertencia");
                    LimpiarTxt();
                    resetearColor();
                }
            } else
            {
                MessageBox.Show("Los campos en rojo deben ser completados ", "Advertencia");
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

        private void resetearColor()
        {
            // Devuelve el color original de los campos cambiados por comprobar()

            this.txtbUsuario.BorderColor = Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(154)))));
            this.txtbContraseña.BorderColor = Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(154)))));
            this.txtbNombre.BorderColor = Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(154)))));
            this.txtbApellido.BorderColor = Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(154)))));
            this.lblPerfil.ForeColor = Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(159)))), ((int)(((byte)(161)))));

        }

        private void txtbNombre_Load(object sender, EventArgs e)
        {

        }

        private void txtbUsuario_Load(object sender, EventArgs e)
        {

        }

        private void lblUsuario_Click(object sender, EventArgs e)
        {

        }

        private void frmModificacionUsuario_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblContraseña_Click(object sender, EventArgs e)
        {

        }
        private void ckbContraseña_CheckedChanged(object sender, EventArgs e)
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


    }
}
