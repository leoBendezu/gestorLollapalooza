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
            this.txtbNombrePv.BorderColor = Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(154)))));
            this.lblPv.BackColor = Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(47)))), ((int)(((byte)(50)))));
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
                    MessageBox.Show("Ya existe dicho Centro de Venta, recomendamos volver al apartado de MODIFICACION");
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
            if (ComprobarPV())
            {
                PuntoVenta puntoVenta = new PuntoVenta()
                {
                    NombrePuntoVenta = this.txtbNombrePv.Text,
                    NumeroPuntoVenta = (int)this.numPuntoVenta.Value
                };

                puntosVentaAgregados.Add(puntoVenta);

                this.dgvPuntoVenta.Rows.Add(puntoVenta.NombrePuntoVenta, puntoVenta.NumeroPuntoVenta);
                this.limpiarPv();
                this.resetearColor();
            } else 
            {
                MessageBox.Show("Los campos en rojo son incorrrectos");
            }

                
        }

        private bool ComprobarPV()
        {
            bool band = true;

            if (String.IsNullOrEmpty(this.txtbNombrePv.Text)) {
                this.txtbNombrePv.BorderColor = Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(66)))), ((int)(((byte)(56)))));
                band = false;
            }
            if (!ValidarNumPv())
            {
                this.lblPv.BackColor = Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(66)))), ((int)(((byte)(56)))));
                band = false;
            }

            return band;
        }


        private bool ValidarNumPv()
        {
            bool band = true;
            if (this.numPuntoVenta.Value == 0)
            {
                band = false;

            }
            else
            {

                foreach (PuntoVenta punt in puntosVentaAgregados)
                {
                    if (punt.NumeroPuntoVenta == numPuntoVenta.Value)
                    {
                        MessageBox.Show("El numero de orden ya fue registrado");
                        break;
                    }
                }
            }
            return band;
        }



        public void limpiarPv()
        {
            if(puntosVentaAgregados.Count == 0)
            {
                numPuntoVenta.Value = 1;
            } else 
            {
                numPuntoVenta.Value++;
            }
            txtbNombrePv.Text = String.Empty;
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            if(this.dgvPuntoVenta.CurrentRow != null)
            {


                foreach(PuntoVenta punt in puntosVentaAgregados)
                {
                    if(punt.NumeroPuntoVenta == Convert.ToInt32(dgvPuntoVenta.CurrentRow.Cells[1].Value))
                    {
                        puntosVentaAgregados.Remove(punt);
                        break;
                    }
                }
                
                this.dgvPuntoVenta.Rows.Remove(dgvPuntoVenta.CurrentRow);
                this.numPuntoVenta.Value--;
            }
            
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.dgvPuntoVenta.Rows.Clear();
            puntosVentaAgregados.Clear();
        }
    }
}
