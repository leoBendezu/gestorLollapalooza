using gestorLollapalooza.Service;
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

namespace gestorLollapalooza.presLayer.PuntoVentaPres
{
    public partial class frmGestionarPuntoVenta : Form
    {
        private PuntoVentaService puntoVentaService;
        public frmGestionarPuntoVenta()
        {
            InitializeComponent();
            this.puntoVentaService = new PuntoVentaService();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {

            string _consulta;
            _consulta = string.Empty;

            // Comprueba si el checkbox de todos esta selecionado, en caso de estarlo recupera todos los 
            // usuarios y los carga en la grilla.
            // en caso de no estarlo comprueba cada campo si esta vacio o es nulo y va agregando informacion a la consulta
            // si es necesario.

            if (!chbTodos.Checked)
            {
                if (!string.IsNullOrEmpty(this.txtbNombre.Text))
                {
                    _consulta += "AND pv.nombre like '%" + this.txtbNombre.Text + "%'";
                }

                if (! ( numCentroVenta.Value == 0))
                {
                    _consulta += "AND pv.idCentroVenta = '" + this.numCentroVenta.Text + "'";
                }

                if (! ( numPuntoVenta.Value == 0))
                {
                    _consulta += "AND pv.numPuntoVenta = '" + this.numPuntoVenta.Text + "'";
                }

                // Si la consulta no es nula ni vacia carga la grilla con los usuarios filtrados

                if (!string.IsNullOrEmpty(_consulta))
                {
                    this.cargarGrilla(dvgPuntoVenta, puntoVentaService.obtenerFiltados(_consulta));
                }

            }
            else
            {
                this.cargarGrilla(dvgPuntoVenta, puntoVentaService.RecuperarTodos());
            }
        }


        private void cargarGrilla(DataGridView grilla, IList<PuntoVenta> fuente)
        {
            // Carga los usuarios recuperados en la grilla

            grilla.Rows.Clear();
            foreach (PuntoVenta puntoVenta in fuente)
            {
                grilla.Rows.Add(puntoVenta.NombrePuntoVenta, puntoVenta.NumeroPuntoVenta, puntoVenta.IdCentroVenta );
            }

        }


        private void LimpiarTxt()
        {
            this.numCentroVenta.Value = 0;
            this.numPuntoVenta.Value = 0;
            this.txtbNombre.Text = String.Empty;
        }

        private void Habilitar(bool x)
        {
            this.txtbNombre.Enabled = x;
            this.numCentroVenta.Enabled = x;
            this.numPuntoVenta.Enabled = x;
        }

        private void chbTodos_CheckedChanged(object sender, EventArgs e)
        {
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

        }

        private void btnLimpiar_Click_1(object sender, EventArgs e)
        {
            this.LimpiarTxt();
        }



        private void dvgPuntoVenta_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.btnModificar.Enabled = true;
            this.btnEliminar.Enabled = true;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAltaPuntoVenta alta = new frmAltaPuntoVenta();
            alta.ShowDialog();
        }


        
        private void btnModificar_Click(object sender, EventArgs e)
        {
            frmModificarPuntoVenta formularioMod = new frmModificarPuntoVenta(this.dvgPuntoVenta.CurrentRow.Cells[0].Value.ToString());
            formularioMod.ShowDialog();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            frmBajaPuntoVenta formularioBaja = new frmBajaPuntoVenta(this.dvgPuntoVenta.CurrentRow.Cells[0].Value.ToString());
            formularioBaja.ShowDialog();
        } 
    }
}
