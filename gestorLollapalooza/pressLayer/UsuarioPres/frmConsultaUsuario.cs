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
        public frmConsultaUsuario()
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

        private void cargarGrilla(DataGridView grilla, DataTable tabla)
        {
            grilla.Rows.Clear();
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                grilla.Rows.Add(tabla.Rows[i]["idUsuario"],
                                tabla.Rows[i]["usuario"],
                                tabla.Rows[i]["nombre"],
                                tabla.Rows[i]["apellido"],
                                tabla.Rows[i]["nombrePerfil"],
                                tabla.Rows[i]["email"],
                                tabla.Rows[i]["password"]);
            }
        }




        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void botonFacha1_Click(object sender, EventArgs e)
        {
            Usuario oUsuario = new Usuario();
            string _usuario, _nombre, _apellido, _idPerfil;
            _usuario = _nombre = _apellido = _idPerfil = string.Empty;

            if (!string.IsNullOrEmpty(this.txtbUsuario.Text))
                _usuario = this.txtbUsuario.Text;
            if (!string.IsNullOrEmpty(this.txtbNombre.Text))
                _nombre = this.txtbNombre.Text;
            if (!string.IsNullOrEmpty(this.txtbApellido.Text))
                _apellido = this.txtbApellido.Text;
            if (cbPerfil.SelectedIndex != -1)
                _idPerfil = cbPerfil.SelectedValue.ToString();


            //this.cargarGrilla(dgvUsuarios, oUsuario.RecuperarTodos());
            this.cargarGrilla(dgvUsuarios, oUsuario.RecuperarFiltrados(_usuario, _nombre, _apellido, _idPerfil));

        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtbUsuario_Load(object sender, EventArgs e)
        {

        }
    }
}
