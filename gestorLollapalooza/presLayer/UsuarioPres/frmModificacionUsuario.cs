using gestorLollapalooza.bussinesLayer;
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

        private Usuario usuarioObj;
        private Perfil perfilObj;
        private Usuario usuarioModificado;

        public frmModificacionUsuario()
        {
            InitializeComponent();
            this.usuarioObj = new Usuario();
            this.perfilObj = new Perfil();

            CargarCombo(cbUsuario, usuarioObj.RecuperarTodos(), "IdUsuario", "usuarioNombre");
            CargarCombo(cbPerfil, perfilObj.RecuperarTodos(), "IdPerfil", "nombrePerfil");
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

        private void btnModificar_Click_1(object sender, EventArgs e)
        {
            // Comprueba que se ha seleccionado un usuario

            if (cbUsuario.SelectedIndex != -1)
            {
                // Comprueba si los campos obligatorios han sidos llenados

                if (Comprobar())
                {
                    this.usuarioModificado = new Usuario();
                    this.usuarioModificado.IdUsuario = (int)cbUsuario.SelectedValue;
                    this.usuarioModificado.UsuarioNombre = this.txtbUsuario.Text;
                    this.usuarioModificado.Nombre = this.txtbNombre.Text;
                    this.usuarioModificado.Email = this.txtbEmail.Text;
                    this.usuarioModificado.Apellido = this.txtbApellido.Text;
                    this.usuarioModificado.Contrasena = this.txtbContraseña.Text;

                    Perfil perfilUsuario = new Perfil();
                    perfilUsuario.IdPerfil = (int)cbPerfil.SelectedValue;
                    this.usuarioModificado.PerfilUsuario = perfilUsuario;

                    // Intenta realizar la modificacion del usuario si lo logra avisa, limpia los campos de texto, resetea los campos
                    // y vuelve a cargar el comboBox de usuarios.
                    // En caso contrario avisa.

                    if (usuarioObj.modificarUsuario(usuarioModificado))
                    {
                        MessageBox.Show("Se ha modificado el usuario", "Advertencia");
                        LimpiarTxt();
                        resetearColor();
                        CargarCombo(cbUsuario, usuarioObj.RecuperarTodos(), "IdUsuario", "usuarioNombre");
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
            } else
            {
                MessageBox.Show("Selecione un usuario a modificar", "Advertencia");
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

    }
}
