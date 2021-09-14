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
    public partial class frmConsultaUsuario : Form
    {
        private Perfil perfilObj;
        private Usuario usuarioObj;

        public frmConsultaUsuario()
        {
            InitializeComponent();
            this.usuarioObj = new Usuario();
            this.perfilObj = new Perfil();
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
            grilla.Rows.Clear();
            foreach(Usuario usuario in fuente)
            {
                grilla.Rows.Add(usuario.UsuarioNombre, usuario.PerfilUsuario.NombrePerfil,
                                usuario.Nombre, usuario.Apellido, usuario.Email);
            }

        }



        private void botonFacha1_Click(object sender, EventArgs e)
        {
            
            string _usuario, _nombre, _apellido, _email ,_idPerfil, _consulta;
            _usuario = _nombre = _apellido = _idPerfil = _email = _consulta = string.Empty;

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

                if(!string.IsNullOrEmpty(_consulta))
                {
                    this.cargarGrilla(dvgUsuarios, usuarioObj.obtenerFiltados(_consulta));
                }

            } else
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
            if(chbTodos.CheckState == CheckState.Checked) {
                this.txtbUsuario.Text = String.Empty;
                this.txtbApellido.Text = String.Empty;
                this.txtbEmail.Text = String.Empty;
                this.txtbNombre.Text = String.Empty;
                this.cbPerfil.SelectedIndex = -1;

                this.txtbUsuario.Enabled = false;
                this.txtbApellido.Enabled = false;
                this.txtbEmail.Enabled = false;
                this.txtbNombre.Enabled = false;
                this.cbPerfil.Enabled = false;

            } else
            {
                this.txtbUsuario.Enabled = true;
                this.txtbApellido.Enabled = true;
                this.txtbEmail.Enabled = true;
                this.txtbNombre.Enabled = true;
                this.cbPerfil.Enabled = true;
            }
        }


    }
}
