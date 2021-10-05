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
    public partial class frmModificarPuntoVenta : Form
    {
        private PuntoVentaService puntoVentaService;
        private PuntoVenta puntoVentaSeleccionado;

        public frmModificarPuntoVenta(string nombre)
        {
            InitializeComponent();
            this.puntoVentaService = new PuntoVentaService();
            this.puntoVentaSeleccionado = puntoVentaService.recuperarPuntoVenta(nombre);
            this.cargarDatosPuntoVenta();
        }

        private void cargarDatosPuntoVenta()
        {
            this.txtbNombre.Text = puntoVentaSeleccionado.NombrePuntoVenta;
           // this.numCentroVenta.Value = puntoVentaSeleccionado.IdCentroVenta;
            this.numPuntoVenta.Value = puntoVentaSeleccionado.NumeroPuntoVenta;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            // Comprueba si los campos obligatorios han sidos llenados

            if (Comprobar())
            {
                this.puntoVentaSeleccionado.NombrePuntoVenta = txtbNombre.Text;
                this.puntoVentaSeleccionado.NumeroPuntoVenta = (int) numPuntoVenta.Value;
              //  this.puntoVentaSeleccionado.IdCentroVenta = (int) numCentroVenta.Value;


                // Intenta realizar la modificacion del usuario si lo logra avisa, limpia los campos de texto, resetea los campos
                // y vuelve a cargar el comboBox de usuarios.
                // En caso contrario avisa.

                if (puntoVentaService.modificarPuntoVenta(this.puntoVentaSeleccionado))
                {
                    MessageBox.Show("Se ha modificado el punto de venta", "Advertencia");
                    this.Close();

                }
                else
                {
                    MessageBox.Show("No se ha podido modificar el punto de venta", "Advertencia");
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

           
            if (numPuntoVenta.Value == 0)
            {
                this.numPuntoVenta.BackColor = Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(66)))), ((int)(((byte)(56)))));
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
            this.numPuntoVenta.Value = 0;
           // this.numCentroVenta.Value = 0;
            this.txtbNombre.Text = String.Empty;
            this.txtbNombre.Focus();
        }

        private void resetearColor()
        {
            // Devuelve el color original a los campos que hayan sido cmabiados por COmprobar()
            this.txtbNombre.BorderColor = Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(154)))));
            //this.numCentroVenta.BackColor = Color.White;
            this.numPuntoVenta.BackColor = Color.White;

        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
