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
    public partial class frmAltaCentroVenta : Form
    {
        private CentroVentaService oCentro;
        private IList<PuntoVenta> puntosVentaAgregados;
        public frmAltaCentroVenta()
        {
            InitializeComponent();
            this.oCentro =  new CentroVentaService();
            this.puntosVentaAgregados = new List<PuntoVenta>();
        }

        private void gbxGrupoMusical_Enter(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
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

            if(puntosVentaAgregados.Count == 0)
            {
                MessageBox.Show("Debe agregar al menos un punto de venta");
                band = false;
            }


            return band;

        }

        private void LimpiarTxtCentroVenta()
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

        private void btnCrear_Click(object sender, EventArgs e)
        {
            if (this.Comprobar())
            {
                // Se valida que el centro de venta a crear no existe en la BD

                if (oCentro.ExisteCentroVenta(this.txtbNombre.Text) == false)
                {

                    // Recupera los datos del formulario 

                    string nombreCentroVenta = this.txtbNombre.Text;




                    // Se instancia el nuevo grupo musical

                    CentroVenta centroVentaN = new CentroVenta()
                    {
                        Nombre = nombreCentroVenta,
                        puntosDeVenta = puntosVentaAgregados,
                    };

                    // Se intenta persistir el centro de venta en caso de lograrlo se informa y se limpian los txtBox


                    if (oCentro.PersistirCentroVenta(centroVentaN))
                    {
                        MessageBox.Show("Centro de Venta Creado con exito", "info");
                        this.LimpiarTxtCentroVenta();
                        this.resetearColor();

                    }
                    else
                    {
                        MessageBox.Show("El Centro de Venta no pudo crearse");
                    }
                }
                else
                {
                    MessageBox.Show("Ya existe dicho Centro de Venta");
                    this.LimpiarTxtCentroVenta();
                    this.resetearColor();
                }

            }
            else
            {
                MessageBox.Show("Los campos en rojo deben ser completados obligatoriamente");
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            PuntoVenta puntoVenta = new PuntoVenta()
            {
                NombrePuntoVenta = this.txtbNombrePv.Text,
                NumeroPuntoVenta = (int) this.numPuntoVenta.Value
            };

            puntosVentaAgregados.Add(puntoVenta);

            this.dgvPuntoVenta.Rows.Add(puntoVenta.NombrePuntoVenta, puntoVenta.NumeroPuntoVenta);
                
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            if(this.dgvPuntoVenta.CurrentRow != null)
            {


                var puntoVenta = (PuntoVenta)dgvPuntoVenta.CurrentRow.DataBoundItem;
                   
                
                puntosVentaAgregados.Remove(puntoVenta);
                this.dgvPuntoVenta.Rows.Remove(dgvPuntoVenta.CurrentRow);
            }
            
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.dgvPuntoVenta.Rows.Clear();
            puntosVentaAgregados.Clear();
        }
    }
}
