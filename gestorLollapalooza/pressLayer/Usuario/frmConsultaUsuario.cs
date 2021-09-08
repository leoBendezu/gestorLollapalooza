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

namespace gestorLollapalooza.pressLayer.Usuario
{
    public partial class frmConsultaUsuario : Form
    {
        public frmConsultaUsuario()
        {
            InitializeComponent();
            Perfil oPerfil = new Perfil();
            this.CargarCombo(cbPerfil, oPerfil.RecuperarTodos(), "idPerfil", "nombre");
        }


        private void CargarCombo(ComboBox combo, DataTable dataTable, string campoValor, string campoMostrar)
        {
            combo.DataSource = dataTable;
            combo.DisplayMember = campoMostrar;
            combo.ValueMember = campoValor;
            combo.SelectedIndex = -1;
        }




        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void botonFacha1_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
