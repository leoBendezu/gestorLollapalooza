using gestorLollapalooza.bussinesLayer;
using gestorLollapalooza.presLayer.PuntoVentaPres;
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
    public partial class frmModificacionCentroVenta : Form
    {
       private CentroVenta centroVentaSeleccionado;
        private CentroVentaService centroService;
       private PuntoVentaService puntoVentaService;

        public frmModificacionCentroVenta(CentroVenta centroVenta)
        {
            InitializeComponent();
            this.centroVentaSeleccionado = centroVenta;
            this.centroService = new CentroVentaService();
            this.puntoVentaService = new PuntoVentaService();
        }

        private void frmModificacionCentroVenta_Load(object sender, EventArgs e)
        {
           
            this.txtbNombre.Text = centroVentaSeleccionado.Nombre;
            this.CargarGrillaPunto(dgvPuntoVenta, puntoVentaService.recuperarDeCentro(centroVentaSeleccionado.IdCentroVenta));
        }


        private void CargarGrillaPunto(DataGridView grilla, IList<PuntoVenta> fuente)
        {
            // Carga los usuarios recuperados en la grilla

            grilla.Rows.Clear();
            foreach (PuntoVenta puntoVenta in fuente)
            {
                grilla.Rows.Add(puntoVenta.NombrePuntoVenta, puntoVenta.NumeroPuntoVenta, puntoVenta.IdCentroVenta);
            }

        }

        public bool Comprobar()
        {

            // Comprueba que los campos no esten vacios, cambiandoles el color a rojo a aquellos que son obligatorios

            bool band = true;

            if (string.IsNullOrEmpty(this.txtbNombre.Text))
            {
                this.txtbNombre.BorderColor = Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(66)))), ((int)(((byte)(56)))));
                band = false;

            }
            return band;

        }

        private void LimpiarTxt()
        {
            // Limpia los campos de texto

            this.txtbNombre.Text = String.Empty;
            this.txtbNombre.Focus();
        }

        private void resetearColor()
        {
            // Devuelve el color original a los campos que hayan sido cmabiados por Comprobar()

            this.txtbNombre.BorderColor = Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(154)))));
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
        private void btnModificar_Click(object sender, EventArgs e)
        {
            // Comprueba si los campos obligatorios han sidos llenados

            if (Comprobar())
            {
                this.centroVentaSeleccionado.Nombre = txtbNombre.Text;



                // Intenta realizar la modificacion del CentroVenta si lo logra avisa, y resetea los campos
                // En caso contrario avisa.

                if (centroService.modificarCentroVenta(centroVentaSeleccionado))
                {
                    MessageBox.Show("Se ha modificado el Centro de Venta", "Advertencia");
                    resetearColor();
                }
                else
                {
                    MessageBox.Show("No se ha podido modificar el Centro de Venta", "Advertencia");
                    resetearColor();
                }
            }
            else
            {
                MessageBox.Show("Los campos en rojo deben ser completados ", "Advertencia");
            } 
        }

        private void btnModificarPv_Click(object sender, EventArgs e)
        {
            if (dgvPuntoVenta.CurrentRow != null)
            {
                frmModificarPuntoVenta frm = new frmModificarPuntoVenta(dgvPuntoVenta.CurrentRow.Cells[0].Value.ToString());
                frm.ShowDialog();
                this.CargarGrillaPunto(dgvPuntoVenta, puntoVentaService.recuperarDeCentro(centroVentaSeleccionado.IdCentroVenta));
            }
        }

        private void botonFacha1_Click(object sender, EventArgs e)
        {
            frmBajaPuntoVenta frm = new frmBajaPuntoVenta(dgvPuntoVenta.CurrentRow.Cells[0].Value.ToString());
            frm.ShowDialog();
            this.CargarGrillaPunto(dgvPuntoVenta, puntoVentaService.recuperarDeCentro(centroVentaSeleccionado.IdCentroVenta));
        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
