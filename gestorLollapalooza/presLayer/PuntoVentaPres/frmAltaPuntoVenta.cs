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
    public partial class frmAltaPuntoVenta : Form
    {
        private PuntoVentaService PuntoVentaObj;
        public frmAltaPuntoVenta()
        {
            InitializeComponent();
            this.PuntoVentaObj = new PuntoVentaService();
        }

        private void btnCrear_Click_1(object sender, EventArgs e)
        {

            if (this.Comprobar())
            {
                // Se valida que el usuario a crear no existe en la BD

                if (PuntoVentaObj.ExistePuntoVenta(this.txtbNombre.Text) == false)
                {

                    // Recupera los datos del formulario 


                    string nombre = this.txtbNombre.Text;
                    int numero = (int) this.numPuntoVenta.Value;
                    int idCentroVenta = (int) this.numCentroVenta.Value;


                    // Se instancia el nuevo usuario

                    PuntoVenta puntoVenta = new PuntoVenta()
                    {
                        NombrePuntoVenta = nombre,
                        IdCentroVenta = idCentroVenta,
                        IdPuntoVenta = numero

                    };

                    // Se intenta persistir el usuario en caso de lograrlo se informa y se limpian los txtBox


                    if (PuntoVentaObj.PersistirPuntoVenta(puntoVenta))
                    {
                        MessageBox.Show("Punto de venta Creado con exito", "info");
                        this.LimpiarTxt();
                        this.resetearColor();

                    }
                    else
                    {
                        MessageBox.Show("El Punto de venta no pudo crearse");
                    }
                }
                else
                {
                    MessageBox.Show("Ya existe dicho Punto de Venta");
                    this.LimpiarTxt();
                    this.resetearColor();
                }

            }
            else
            {
                MessageBox.Show("Los campos en rojo deben ser completados obligatoriamente");
            }
        }
        public bool Comprobar()
        {
            // Comprueba que los campos no esten vacios, cambiandoles el color a rojo a aquellos que son obligatorios

            bool band = true;

            if (numCentroVenta.Value == 0)
            {
                this.numCentroVenta.BackColor = Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(66)))), ((int)(((byte)(56)))));
                band = false;

            }      
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
            this.numCentroVenta.Value = 0;
            this.txtbNombre.Text = String.Empty;
            this.txtbNombre.Focus();
        }

        private void resetearColor()
        {
            // Devuelve el color original a los campos que hayan sido cmabiados por COmprobar()
            this.txtbNombre.BorderColor = Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(154)))));
            this.numCentroVenta.BackColor = Color.White;
            this.numPuntoVenta.BackColor = Color.White;

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}



























































































































// BRANDY LOVE 