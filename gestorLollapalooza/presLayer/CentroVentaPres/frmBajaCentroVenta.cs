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
    public partial class frmBajaCentroVenta : Form
    {
        DataGridViewRow rowCentro;
        CentroVentaService oServiceCentro = new CentroVentaService();
        PuntoVentaService oServicePunto = new PuntoVentaService();
        CentroVenta oCentroVenta;

        public frmBajaCentroVenta(DataGridViewRow row)
        {
            InitializeComponent();
            rowCentro = row;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se eliminara este Grupo Musical", "Advertencia");

          




            if (this.oServiceCentro.borrarLogicamente(oCentroVenta.IdCentroVenta))
            {
                IList<PuntoVenta> puntosBorrar = oServicePunto.recuperarDeCentroListados(oCentroVenta.IdCentroVenta);

                foreach(PuntoVenta punto in puntosBorrar)
                {
                    oServicePunto.borrarLogicamente(punto.NombrePuntoVenta);
                }

                MessageBox.Show("Se elimino el centro de venta de forma correcta", "Advertencia");
                this.Close();
            }
        }

        private void frmBajaCentroVenta_Load(object sender, EventArgs e)
        {
            oCentroVenta = oServiceCentro.recuperarCentroVenta((string)rowCentro.Cells[1].Value);

            this.txtbNombre.Text = oCentroVenta.Nombre;
        }
    }
}
