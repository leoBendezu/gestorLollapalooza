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

namespace gestorLollapalooza.presLayer.GrupoMusicalPres
{
    public partial class frmConsultaGrupoMusical : Form
    {
        GrupoMusicalService oGrupoMusicalService = new GrupoMusicalService();

        public frmConsultaGrupoMusical()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmConsultaGrupoMusical_Load(object sender, EventArgs e)
        {
            this.CargarGrilla(dvgGrupoMusical, oGrupoMusicalService.traerTodos());
        }

        private void CargarGrilla(DataGridView grilla, DataTable tabla)
        {
            grilla.Rows.Clear();
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                grilla.Rows.Add(tabla.Rows[i]["idGrupoMusical"],
                                tabla.Rows[i]["nombre"],
                                tabla.Rows[i]["descripcion"],
                                tabla.Rows[i]["cantIntegrantes"]);
            }
        }




        private void btnConsultar_Click_1(object sender, EventArgs e)
        {
            string _consulta;
            _consulta = string.Empty;

            if (!chbTodos.Checked)
            {
                if (!string.IsNullOrEmpty(this.txtbNombre.Text))
                {
                    _consulta += "AND nombre like '" + this.txtbNombre.Text + "' ";
                }
                if (!string.IsNullOrEmpty(this.txtbDescripcion.Text))
                {
                    _consulta += "AND descripcion = '%" + this.txtbDescripcion.Text + "%' ";
                }
                if (!(this.numCantIntegrantes.Value == 0))
                {
                    _consulta += "AND cantIntegrantes = " + this.numCantIntegrantes.Text;
                }




                if (!string.IsNullOrEmpty(_consulta))
                {
                    this.CargarGrilla(dvgGrupoMusical, oGrupoMusicalService.traerFiltrados(_consulta));
                }

            }
            else
            {
                this.CargarGrilla(dvgGrupoMusical, oGrupoMusicalService.traerTodos());
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAltaGrupoMusical alta = new frmAltaGrupoMusical();
            alta.ShowDialog();
        }
    }


}
