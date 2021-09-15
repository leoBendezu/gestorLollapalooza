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

namespace gestorLollapalooza.pressLayer.UsuarioPres
{
    public partial class frmBajaUsuario : Form
    {

        private Usuario usuarioObj;
        private Usuario usuarioSelecionado;

        public frmBajaUsuario()
        {
            InitializeComponent();
            this.usuarioObj = new Usuario();
            CargarCombo(cbUsuario, usuarioObj.RecuperarTodos(), "usuarioNombre", "usuarioNombre");
        }


        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {

            // Comprueba que se haya selecionado un usuario
            if (cbUsuario.SelectedIndex != -1)
            {
                MessageBox.Show("Se eliminara este usuario", "Advertencia");

                // intenta realizar la baja, de lograrlo avisa, recarga el comboBox cbUsuario y
                // limpia los campos

                if (this.usuarioObj.borrarLogicamente(this.usuarioSelecionado.UsuarioNombre))
                {
                    MessageBox.Show("Se elimino el usuario de forma correcta", "Advertencia");
                    CargarCombo(cbUsuario, usuarioObj.RecuperarTodos(), "usuarioNombre", "usuarioNombre");
                    LimpiarTxt();
                }
            } else
            {
                MessageBox.Show("Debe seleccionar el usuario a eliminar", "Advertencia");
            }
        }

        private void CargarCombo(ComboBox combo, Object fuente, string campoValor, string campoMostrar)
        {
            combo.DataSource = fuente;
            combo.DisplayMember = campoMostrar;
            combo.ValueMember = campoValor;
            combo.SelectedIndex = -1;
        }

        private void cbUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Comprueba que se haya selecionado un usuario

            if (cbUsuario.SelectedIndex != -1)
            {
                // Recupera y carga los datos del usuario selecionado

                string nombreUsuario = cbUsuario.SelectedValue.ToString();
                this.usuarioSelecionado = usuarioObj.recuperarUsuario(nombreUsuario);
                if (usuarioSelecionado!= null)
                {
                    this.txtbUsuario.Text = usuarioSelecionado.UsuarioNombre;
                    this.txtbApellido.Text = usuarioSelecionado.Apellido;
                    this.txtbEmail.Text = usuarioSelecionado.Email;
                    this.txtbNombre.Text = usuarioSelecionado.Nombre;
                    this.txtbPerfil.Text = usuarioSelecionado.PerfilUsuario.NombrePerfil;
                }
               
            }
        }
        private void LimpiarTxt()
        {
            // Limpia los campos de texto

            this.txtbUsuario.Text = String.Empty;
            this.txtbApellido.Text = String.Empty;
            this.txtbEmail.Text = String.Empty;
            this.txtbNombre.Text = String.Empty;
            this.txtbPerfil.Text = String.Empty;
        }
    }
}
