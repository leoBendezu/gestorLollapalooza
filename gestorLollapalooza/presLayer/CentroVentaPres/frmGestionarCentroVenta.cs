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

namespace gestorLollapalooza.presLayer.CentroVentaPres
{
    public partial class frmGestionarCentroVenta : Form
    {
        CentroVentaService oCentro = new CentroVentaService();
        PuntoVentaService oPunto = new PuntoVentaService();
        public frmGestionarCentroVenta()
        {
            InitializeComponent();
        }

        private void dvgCentroVenta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int idCentro = (int)dgvCentroVenta.CurrentRow.Cells[0].Value;
            this.CargarGrillaPunto(dgvPuntoVenta, oPunto.recuperarDeCentro(idCentro));
            this.btnModifcar.Enabled = true;
            this.btnEliminar.Enabled = true;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CargarGrillaCentro(DataGridView grilla, DataTable tabla)
        {
            grilla.Rows.Clear();
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                grilla.Rows.Add(tabla.Rows[i]["idCentroVenta"],
                                tabla.Rows[i]["nombre"]);
            }
        }
        private void CargarGrillaPunto(DataGridView grilla, DataTable tabla)
        {
            grilla.Rows.Clear();
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                grilla.Rows.Add(tabla.Rows[i]["idPuntoVenta"],
                                tabla.Rows[i]["nombre"],
                                tabla.Rows[i]["numero"]);
            }
        }

        private void frmGestionarCentroVenta_Load(object sender, EventArgs e)
        {
            this.CargarGrillaCentro(dgvCentroVenta, oCentro.RecuperarTodos());
        }

        private void chbTodos_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            string _consulta;
            _consulta = string.Empty;

            if (!chbTodos.Checked)
            {
                if (!string.IsNullOrEmpty(this.txtbNombre.Text))
                {
                    _consulta += "AND nombre like '" + this.txtbNombre.Text + "' ";
                }

                if (!string.IsNullOrEmpty(_consulta))
                {
                    this.CargarGrillaCentro(dgvCentroVenta, oCentro.obtenerFiltados(_consulta));
                }

            }
            else
            {
                this.CargarGrillaCentro(dgvCentroVenta, oCentro.RecuperarTodos());
            }
        }

        private void botonFacha3_Click(object sender, EventArgs e)
        {
            frmAltaCentroVenta alta = new frmAltaCentroVenta();
            alta.ShowDialog();
            this.CargarGrillaCentro(dgvCentroVenta, oCentro.RecuperarTodos());
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            frmBajaCentroVenta baja = new frmBajaCentroVenta(dgvCentroVenta.CurrentRow);
            baja.ShowDialog();
            this.CargarGrillaCentro(dgvCentroVenta, oCentro.RecuperarTodos());
        }

        private void btnModifcar_Click(object sender, EventArgs e)
        {
            frmModificacionCentroVenta modificacion = new frmModificacionCentroVenta(dgvCentroVenta.CurrentRow);
            modificacion.ShowDialog();
            this.CargarGrillaCentro(dgvCentroVenta, oCentro.RecuperarTodos());
        }
    }
}
