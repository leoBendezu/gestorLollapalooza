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

            if (string.IsNullOrEmpty(this.txtbUsuario.Texts))
                MessageBox.Show("Completar Usuario", "Alerta");
            if (string.IsNullOrEmpty(this.txtbContraseña.Texts))
                MessageBox.Show("Completar Contraseña", "Alerta");
            if (string.IsNullOrEmpty(this.txtbEmail.Texts))
                MessageBox.Show("Completar Email", "Alerta");
            if (string.IsNullOrEmpty(this.txtbNombre.Texts))
                MessageBox.Show("Completar Nombre", "Alerta");
            if (string.IsNullOrEmpty(this.txtbApellido.Texts))
                MessageBox.Show("Completar Apellido", "Alerta");
            if (cbPerfil.SelectedIndex == -1)
                MessageBox.Show("Seleccionar Perfil", "Alerta");

            if ((string.IsNullOrEmpty(this.txtbUsuario.Texts)) && (string.IsNullOrEmpty(this.txtbContraseña.Texts)) &&
                (string.IsNullOrEmpty(this.txtbEmail.Texts)) && (string.IsNullOrEmpty(this.txtbNombre.Texts)) &&
                (string.IsNullOrEmpty(this.txtbApellido.Texts)) && (cbPerfil.SelectedIndex != -1))
            {
                BDConexion sql = new BDConexion();
                string consulta = "INSERT [dbo].[usuarios] ([idPerfil], [usuario],[password], [nombre], [apellido], [email]) " +
                    "VALUES (1, 'Prueba', 'prueba123','puto','elquelee','putoelquelee@gmail.com');";
                
                sql.ConsultaSQL(consulta);
            }
        }
    }
}
