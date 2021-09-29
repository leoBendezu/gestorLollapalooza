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
    public partial class frmGestionarUsuario : Form
    {
        private PerfilService perfilObj;
        private UsuarioService usuarioObj;

        public frmGestionarUsuario()
        {
            InitializeComponent();
            this.usuarioObj = new UsuarioService();
            this.perfilObj = new PerfilService();

            this.CargarCombo(cbPerfil, perfilObj.RecuperarTodos(), "idPerfil", "nombrePerfil");
        }


        private void CargarCombo(ComboBox combo, object fuente, string campoValor, string campoMostrar)
        {
            combo.DataSource = fuente;
            combo.DisplayMember = campoMostrar;
            combo.ValueMember = campoValor;
            combo.SelectedIndex = -1;
        }

        private void cargarGrilla(DataGridView grilla, IList<Usuario> fuente)
        {
            // Carga los usuarios recuperados en la grilla

            grilla.Rows.Clear();
            foreach (Usuario usuario in fuente)
            {
                grilla.Rows.Add(usuario.UsuarioNombre, usuario.PerfilUsuario.NombrePerfil,
                                usuario.Nombre, usuario.Apellido, usuario.Email);
            }

        }



        private void botonFacha1_Click(object sender, EventArgs e)
        {

            string _consulta;
            _consulta = string.Empty;

            // Comprueba si el checkbox de todos esta selecionado, en caso de estarlo recupera todos los 
            // usuarios y los carga en la grilla.
            // en caso de no estarlo comprueba cada campo si esta vacio o es nulo y va agregando informacion a la consulta
            // si es necesario.

            if (!chbTodos.Checked)
            {
                if (!string.IsNullOrEmpty(this.txtbUsuario.Text))
                {
                    _consulta += "AND u.usuario like '" + this.txtbUsuario.Text + "'";
                }

                if (!string.IsNullOrEmpty(this.txtbNombre.Text))
                {
                    _consulta += "AND u.nombre like '" + this.txtbNombre.Text + "'";
                }
                if (!string.IsNullOrEmpty(this.txtbApellido.Text))
                {
                    _consulta += "AND u.apellido like '" + this.txtbApellido.Text + "'";
                }
                if (!string.IsNullOrEmpty(this.txtbEmail.Text))
                {
                    _consulta += "AND u.email like '" + this.txtbEmail.Text + "'";
                }

                if (cbPerfil.SelectedIndex != -1)
                {
                    _consulta += "AND u.idPerfil =" + cbPerfil.SelectedValue.ToString();
                }

                // Si la consulta no es nula ni vacia carga la grilla con los usuarios filtrados

                if (!string.IsNullOrEmpty(_consulta))
                {
                    this.cargarGrilla(dvgUsuarios, usuarioObj.obtenerFiltados(_consulta));
                }

            }
            else
            {
                this.cargarGrilla(dvgUsuarios, usuarioObj.RecuperarTodos());
            }
        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chbTodos_CheckedChanged(object sender, EventArgs e)
        {
            if (chbTodos.CheckState == CheckState.Checked)
            {
                this.LimpiarTxt();
                this.Habilitar(false);
            }
            else
            {
                this.Habilitar(true);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            frmBajaUsuario formularioBaja = new frmBajaUsuario(this.dvgUsuarios.CurrentRow.Cells[0].Value.ToString());
            formularioBaja.ShowDialog();
        }

        private void btnModificarClick(object sender, EventArgs e)
        {
            frmModificacionUsuario formularioMod = new frmModificacionUsuario(this.dvgUsuarios.CurrentRow.Cells[0].Value.ToString());
            formularioMod.ShowDialog();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAltaUsuario formulario = new frmAltaUsuario();
            formulario.ShowDialog();

        }

        private void dvgUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.btnModifcar.Enabled = true;
            this.btnEliminar.Enabled = true;

        }

        private void botonFacha4_Click(object sender, EventArgs e)
        {
            this.LimpiarTxt();
        }

        private void LimpiarTxt()
        {
            this.txtbUsuario.Text = String.Empty;
            this.txtbApellido.Text = String.Empty;
            this.txtbEmail.Text = String.Empty;
            this.txtbNombre.Text = String.Empty;
            this.cbPerfil.SelectedIndex = -1;
        }

        private void Habilitar(bool x)
        {
            this.txtbUsuario.Enabled = x;
            this.txtbApellido.Enabled = x;
            this.txtbEmail.Enabled = x;
            this.txtbNombre.Enabled = x;
            this.cbPerfil.Enabled = x;
        }

    }
}
