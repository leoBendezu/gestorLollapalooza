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
    public partial class frmModificacionCentroVenta : Form
    {
        DataGridViewRow rowCentro;
        CentroVentaService centroService = new CentroVentaService();
        CentroVenta oCentroVenta;

        public frmModificacionCentroVenta(DataGridViewRow row)
        {
            InitializeComponent();
            rowCentro = row;
        }

        private void frmModificacionCentroVenta_Load(object sender, EventArgs e)
        {
            oCentroVenta = centroService.recuperarCentroVenta((string)rowCentro.Cells[1].Value);

            this.txtbNombre.Text = oCentroVenta.Nombre;
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
                this.oCentroVenta.Nombre = txtbNombre.Text;



                // Intenta realizar la modificacion del CentroVenta si lo logra avisa, y resetea los campos
                // En caso contrario avisa.

                if (centroService.modificarCentroVenta(oCentroVenta))
                {
                    MessageBox.Show("Se ha modificado el CentroVenta", "Advertencia");
                    resetearColor();
                }
                else
                {
                    MessageBox.Show("No se ha podido modificar el CentroVenta", "Advertencia");
                    resetearColor();
                }
            }
            else
            {
                MessageBox.Show("Los campos en rojo deben ser completados ", "Advertencia");
            }
        }
    }
}
