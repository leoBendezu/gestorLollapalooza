using gestorLollapalooza.bussinesLayer;
using gestorLollapalooza.dataLayer;
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
    public partial class frmAltaUsuario : Form
    {
        public frmAltaUsuario()
        {
            InitializeComponent();
            Perfil oPerfil = new Perfil();
            this.CargarCombo(cbPerfil, oPerfil.RecuperarTodos(), "idPerfil", "nombrePerfil");
        }

        private void CargarCombo(ComboBox combo, DataTable dataTable, string campoValor, string campoMostrar)
        {
            combo.DataSource = dataTable;
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

            if (string.IsNullOrEmpty(this.txtbUsuario.Text))
                MessageBox.Show("Completar Usuario", "Alerta");
            if (string.IsNullOrEmpty(this.txtbContraseña.Text))
                MessageBox.Show("Completar Contraseña", "Alerta");
            if (string.IsNullOrEmpty(this.txtbEmail.Text))
                MessageBox.Show("Completar Email", "Alerta");
            if (string.IsNullOrEmpty(this.txtbNombre.Text))
                MessageBox.Show("Completar Nombre", "Alerta");
            if (string.IsNullOrEmpty(this.txtbApellido.Text))
                MessageBox.Show("Completar Apellido", "Alerta");
            if (cbPerfil.SelectedIndex == -1)
                MessageBox.Show("Seleccionar Perfil", "Alerta");

            if (!((string.IsNullOrEmpty(this.txtbUsuario.Text)) && (string.IsNullOrEmpty(this.txtbContraseña.Text)) &&
                (string.IsNullOrEmpty(this.txtbEmail.Text)) && (string.IsNullOrEmpty(this.txtbNombre.Text)) &&
                (string.IsNullOrEmpty(this.txtbApellido.Text)) && (cbPerfil.SelectedIndex == -1)))
            {
                BDConexion sql = new BDConexion();
                string consulta = $"INSERT [dbo].[usuarios] ([idPerfil], [usuario],[password], [nombre], [apellido], [email]) " +
                    "VALUES ("+cbPerfil.SelectedValue.ToString()+", '"+this.txtbUsuario.Text+"', '"+ this.txtbContraseña.Text + "'" +
                    ",'"+ this.txtbNombre.Text + "','"+ this.txtbApellido.Text + "','"+ this.txtbEmail.Text + "');";
                
                sql.EjecutarSQL(consulta);
                MessageBox.Show("Usuario creado", "info");
            }
        }
    }
}
