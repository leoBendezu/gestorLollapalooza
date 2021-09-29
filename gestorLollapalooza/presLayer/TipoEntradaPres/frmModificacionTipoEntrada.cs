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
    public partial class frmModificacionTipoEntrada : Form
    {
        private TipoEntradaService tipoEntradaService;
        private TipoEntrada tipoEntradaSeleccionado;

        public frmModificacionTipoEntrada(string nombre)
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

        private void btnModificar_Click(object sender, EventArgs e)
        {
            // Comprueba si los campos obligatorios han sidos llenados

            if (Comprobar())
            {
                this.tipoEntradaSeleccionado.Nombre = txtbNombre.Text;
                this.tipoEntradaSeleccionado.Descripcion = txtbDescripcion.Text;


                // Intenta realizar la modificacion del usuario si lo logra avisa, limpia los campos de texto, resetea los campos
                // y vuelve a cargar el comboBox de usuarios.
                // En caso contrario avisa.

                if (tipoEntradaService.modificarTipoEntrada(this.tipoEntradaSeleccionado))
                {
                    MessageBox.Show("Se ha modificado el Tipo de Entrada", "Advertencia");
                    this.Close();

                }
                else
                {
                    MessageBox.Show("No se ha podido modificar el Tipo de Entrada", "Advertencia");
                    LimpiarTxt();
                    resetearColor();
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Los campos en rojo deben ser completados ", "Advertencia");
            }
        }
        public bool Comprobar()
        {
            // Comprueba que los campos no esten vacios, cambiandoles el color a rojo a aquellos que son obligatorios

            bool band = true;

            if (string.IsNullOrEmpty(this.txtbDescripcion.Text))
            {
                this.txtbDescripcion.BorderColor = Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(66)))), ((int)(((byte)(56)))));
                band = false;

            }

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
            this.txtbDescripcion.Text = String.Empty;
            this.txtbNombre.Text = String.Empty;
            this.txtbNombre.Focus();
        }

        private void resetearColor()
        {
            // Devuelve el color original a los campos que hayan sido cmabiados por COmprobar()
            this.txtbNombre.BorderColor = Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(154)))));
            this.txtbDescripcion.BorderColor = Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(154)))));

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
