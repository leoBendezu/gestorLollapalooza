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
            this.btnEliminar.Enabled = false;
            this.btnModificar.Enabled = false;
        }


        private void CargarGrilla(DataGridView grilla, IList<GrupoMusical> fuente)
        {
            // Carga los grupos musicales recuperados en la grilla

            grilla.Rows.Clear();
            foreach (GrupoMusical grupo in fuente)
            {
                grilla.Rows.Add(grupo.IdGrupoMusical, grupo.Nombre, grupo.Descripcion, grupo.CantIntegrantes);
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
                    _consulta += "AND nombre like '%" + this.txtbNombre.Text + "%' ";
                }
                if (!string.IsNullOrEmpty(this.txtbDescripcion.Text))
                {
                    _consulta += "AND descripcion like '%" + this.txtbDescripcion.Text + "%' ";
                }
                if (!(this.numCantIntegrantes.Value == 0) && this.numCantIntegrantes.Enabled)
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
            this.CargarGrilla(dvgGrupoMusical, oGrupoMusicalService.traerTodos());
        }

        private void dvgGrupoMusical_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.btnModificar.Enabled = true;
            this.btnEliminar.Enabled = true;
        }

        private void btnModificar_Click(object sender, EventArgs e) //este boton es el eliminar, nose pq no cambia de nombre, en el design esta cambiado

        {
            frmBajaGrupoMusical frmBaja = new frmBajaGrupoMusical(dvgGrupoMusical.CurrentRow);
            frmBaja.ShowDialog();
            this.CargarGrilla(dvgGrupoMusical, oGrupoMusicalService.traerTodos());
        }

        private void btnModificar_Click_1(object sender, EventArgs e) //este boton es el de modificar
        {
            frmModificacionGrupoMusical frmModificacion = new frmModificacionGrupoMusical(dvgGrupoMusical.CurrentRow);
            frmModificacion.ShowDialog();
            this.CargarGrilla(dvgGrupoMusical, oGrupoMusicalService.traerTodos());
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.LimpiarTxt();
        }

        private void LimpiarTxt()
        {
            this.txtbDescripcion.Text = String.Empty;
            this.txtbNombre.Text = String.Empty;
            this.numCantIntegrantes.Value = 1;
        }

        private void Habilitar(bool x)
        {
            this.numCantIntegrantes.Enabled = x;
            this.txtbNombre.Enabled = x;
            this.txtbDescripcion.Enabled = x;
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

        private void cbCantidadInt_CheckedChanged(object sender, EventArgs e)
        {

            if (cbCantidadInt.CheckState == CheckState.Checked)
            {
                this.numCantIntegrantes.Enabled = true;
            }
            else
            {
                this.numCantIntegrantes.Enabled = false;
                this.numCantIntegrantes.Value = 1;
            }
        }
    }


}
