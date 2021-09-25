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
    public partial class frmBajaUsuario : Form
    {

        private UsuarioService usuarioObj;
        private Usuario usuarioSeleccionado;

        public frmBajaUsuario(string usuarioSeleccionado)
        {
            InitializeComponent();
            this.usuarioObj = new UsuarioService();
            this.usuarioSeleccionado = usuarioObj.recuperarUsuario(usuarioSeleccionado);
            this.CargarDatosUsuario();
        }


        private void CargarDatosUsuario()
        {
            this.txtbUsuario.Text = usuarioSeleccionado.UsuarioNombre;
            this.txtbApellido.Text = usuarioSeleccionado.Apellido;
            this.txtbEmail.Text = usuarioSeleccionado.Email;
            this.txtbNombre.Text = usuarioSeleccionado.Nombre;
            this.txtbPerfil.Text = usuarioSeleccionado.PerfilUsuario.NombrePerfil;
        }


        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            
            MessageBox.Show("Se eliminara este usuario", "Advertencia");

            // intenta realizar la baja, de lograrlo avisa, recarga el comboBox cbUsuario y
            // limpia los campos

            if (this.usuarioObj.borrarLogicamente(this.usuarioSeleccionado.UsuarioNombre))
            {
                MessageBox.Show("Se elimino el usuario de forma correcta", "Advertencia");
            }

        } 

    }
}
