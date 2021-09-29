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

namespace gestorLollapalooza.presLayer.TipoEntradaPres
{
    public partial class frmGestionarTipoEntrada : Form
    {
        private TipoEntradaService tipoEntradaObj;
        public frmGestionarTipoEntrada()
        {
            InitializeComponent();
            this.tipoEntradaObj = new TipoEntradaService();
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
                if (!string.IsNullOrEmpty(this.txtbDescripcion.Text))
                {
                    _consulta += "AND te.descripcion like '%" + this.txtbDescripcion.Text + "%'";
                }

                if (!string.IsNullOrEmpty(this.txtbNombre.Text))
                {
                    _consulta += "AND te.nombre like '%" + this.txtbNombre.Text + "%'";
                }

                // Si la consulta no es nula ni vacia carga la grilla con los usuarios filtrados

                if (!string.IsNullOrEmpty(_consulta))
                {
                    this.cargarGrilla(dvgTipoEntrada, tipoEntradaObj.obtenerFiltados(_consulta));
                }

            }
            else
            {
                this.cargarGrilla(dvgTipoEntrada, tipoEntradaObj.RecuperarTodos());
            }
        }


        private void cargarGrilla(DataGridView grilla, IList<TipoEntrada> fuente)
        {
            // Carga los usuarios recuperados en la grilla

            grilla.Rows.Clear();
            foreach (TipoEntrada tipoEntrada in fuente)
            {
                grilla.Rows.Add(tipoEntrada.Nombre, tipoEntrada.Descripcion);
            }

        }


        private void LimpiarTxt()
        {
            this.txtbDescripcion.Text = String.Empty;
            this.txtbNombre.Text = String.Empty;
        }

        private void Habilitar(bool x)
        {
            this.txtbNombre.Enabled = x;
            this.txtbDescripcion.Enabled = x;
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



        private void dvgTipoEntrada_CellClick(object sender, DataGridViewCellEventArgs e)
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
            frmAltaTipoEntrada alta = new frmAltaTipoEntrada();
            alta.ShowDialog();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            frmModificacionTipoEntrada formularioMod = new frmModificacionTipoEntrada(this.dvgTipoEntrada.CurrentRow.Cells[0].Value.ToString());
            formularioMod.ShowDialog();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
           frmBajaTipoEntrada formularioBaja = new frmBajaTipoEntrada(this.dvgTipoEntrada.CurrentRow.Cells[0].Value.ToString());
           formularioBaja.ShowDialog();
        }
    }
}
