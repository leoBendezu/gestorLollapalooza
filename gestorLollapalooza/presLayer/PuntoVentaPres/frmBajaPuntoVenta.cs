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

namespace gestorLollapalooza.presLayer.PuntoVentaPres
{
    public partial class frmBajaPuntoVenta : Form
    {
        private PuntoVentaService puntoVentaService;
        private PuntoVenta puntoVentaSeleccionado;

        public frmBajaPuntoVenta(string nombre)
        {
            InitializeComponent();
            this.puntoVentaService = new PuntoVentaService();
            this.puntoVentaSeleccionado = puntoVentaService.recuperarPuntoVenta(nombre);
            this.cargarDatosPuntoVenta();
        }

        private void cargarDatosPuntoVenta()
        {
            this.txtbNombre.Text = puntoVentaSeleccionado.NombrePuntoVenta;
            this.txtbNumCentroVenta.Text = puntoVentaSeleccionado.IdCentroVenta.ToString();
            this.txtbNumero.Text = puntoVentaSeleccionado.NumeroPuntoVenta.ToString();

        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {

            MessageBox.Show("Se eliminara este Punto de Venta", "Advertencia");

            // intenta realizar la baja, de lograrlo avisa, recarga el comboBox cbUsuario y
            // limpia los campos

            if (this.puntoVentaService.borrarLogicamente(this.puntoVentaSeleccionado.NombrePuntoVenta))
            {
                MessageBox.Show("Se elimino el Punto de Venta de forma correcta", "Advertencia");
                this.Close();
            }

        }
    }
}
