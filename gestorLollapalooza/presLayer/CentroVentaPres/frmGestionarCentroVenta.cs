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

        private void CargarGrillaCentro(DataGridView grilla, IList<CentroVenta> fuente)
        {
            grilla.Rows.Clear();
            foreach (CentroVenta centroVenta in fuente)
            {
                grilla.Rows.Add(centroVenta.IdCentroVenta, centroVenta.Nombre);
            }
        }


        private void CargarGrillaPunto(DataGridView grilla, IList<PuntoVenta> fuente)
        {
            // Carga los usuarios recuperados en la grilla

            grilla.Rows.Clear();
            foreach (PuntoVenta puntoVenta in fuente)
            {
                grilla.Rows.Add(puntoVenta.IdPuntoVenta,puntoVenta.NombrePuntoVenta ,puntoVenta.NumeroPuntoVenta );
            }

        }

        private void frmGestionarCentroVenta_Load(object sender, EventArgs e)
        {
            this.CargarGrillaCentro(dgvCentroVenta, oCentro.RecuperarTodos());
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

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            string _consulta;
            _consulta = string.Empty;

            if (!chbTodos.Checked)
            {
                if (!string.IsNullOrEmpty(this.txtbNombre.Text))
                {
                    _consulta += "AND nombre like '%" + this.txtbNombre.Text + "%' ";
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
            CentroVenta centroVenta = new CentroVenta()
            {
                IdCentroVenta = Convert.ToInt32(dgvCentroVenta.CurrentRow.Cells[0].Value),
                Nombre = dgvCentroVenta.CurrentRow.Cells[1].Value.ToString()
            };

            frmModificacionCentroVenta modificacion = new frmModificacionCentroVenta(centroVenta);
            modificacion.ShowDialog();
            this.CargarGrillaCentro(dgvCentroVenta, oCentro.RecuperarTodos());
        }

        private void botonFacha4_Click(object sender, EventArgs e)
        {
            this.txtbNombre.Text = string.Empty;
        }

        public void LimpiarTxt()
        {
            this.txtbNombre.Text = string.Empty;
        }

        public void Habilitar(bool x)
        {
            this.txtbNombre.Enabled = x;
        }
    }
}
