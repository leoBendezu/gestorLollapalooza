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
    public partial class frmBajaTipoEntrada : Form
    {
        private TipoEntradaService tipoEntradaService;
        private TipoEntrada tipoEntradaSeleccionado;

        public frmBajaTipoEntrada(string nombre)
        {
            InitializeComponent();
            this.tipoEntradaService = new TipoEntradaService();
            this.tipoEntradaSeleccionado = tipoEntradaService.recuperarTipoEntrada(nombre);
            this.cargarDatosTipoEntrada();
        }

        private void cargarDatosTipoEntrada()
        {
            this.txtbNombre.Text = tipoEntradaSeleccionado.Nombre;
            this.txtbDescripcion.Text = tipoEntradaSeleccionado.Descripcion;
        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {

            MessageBox.Show("Se eliminara este Tipo de Entrada", "Advertencia");

            // intenta realizar la baja, de lograrlo avisa, recarga el comboBox cbUsuario y
            // limpia los campos

            if (this.tipoEntradaService.borrarLogicamente(this.tipoEntradaSeleccionado.Nombre))
            {
                MessageBox.Show("Se elimino el Tipo de Entrada de forma correcta", "Advertencia");
                this.Close();
            }

        }
    }
}
