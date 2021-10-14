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

namespace gestorLollapalooza.presLayer.DiaFestivalPres
{
    public partial class frmDiaFestival : Form
    {
        private DateTime fchInicio;
        private DateTime fchFin;
        private IList<Actuacion> actuaciones;
        private IList<DiaFestival> dias;
        private GrupoMusicalService gmObj = new GrupoMusicalService();

        public frmDiaFestival( DateTime fechaInicioFestival, DateTime fechaFinFestival, IList<DiaFestival> dias)
        {
            InitializeComponent();
            this.fchInicio = fechaInicioFestival;
            this.fchFin = fechaFinFestival;
            this.actuaciones = new List<Actuacion>();
            this.dias = dias;
        }

        

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (ComprobarActuacion())
            {
                if (!gmObj.existeGrupoMusical(this.txtbGrupoActuante.Text))
                {
                    MessageBox.Show("No existe el Grupo Musical Ingresado, puede usar el boton ? para revisar los grupos");
                }
                else { 
                Actuacion act = new Actuacion()
                {
                    DuracionActuacion = (int) this.numDuracionEstimada.Value,
                    NumeroOrden = (int) this.numOrden.Value,
                    GrupoMusical = gmObj.recuperarGrupoMusical(this.txtbGrupoActuante.Text)
                };

                this.actuaciones.Add(act);
                this.dgvActuacion.Rows.Add( act.NumeroOrden, act.DuracionActuacion, act.GrupoMusical.Nombre);
                }
                this.LimpiarActuacion();
                this.resetearColor();

            } else
            {
                MessageBox.Show("Los campos en rojo son incorrrectos");
            }
        }
      

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            if (this.dgvActuacion.CurrentRow != null)
            {


                var actuacion = (Actuacion)dgvActuacion.CurrentRow.DataBoundItem;


                actuaciones.Remove(actuacion);
                this.dgvActuacion.Rows.Remove(dgvActuacion.CurrentRow);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.LimpiarActuacion();
        } 

        private bool ComprobarActuacion()
        {
            bool band = true;
            if(this.numDuracionEstimada.Value <= 0)
            {
                this.lblDuracion.BackColor =  Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(66)))), ((int)(((byte)(56)))));
                band = false;
            }      
            if(this.txtbGrupoActuante.Text == String.Empty )
            {
                this.txtbGrupoActuante.BorderColor = Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(66)))), ((int)(((byte)(56)))));
                band = false;
            }           
            if(!ValidarNumOrden())
            {
                this.lblNumeroOrden.BackColor = Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(66)))), ((int)(((byte)(56)))));
                band = false;
            }

            return band;
        }

        private void resetearColor()
        {
            // Devuelve el color original a los campos que hayan sido cmabiados por Comprobar()

            this.txtbGrupoActuante.BorderColor = Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(154)))));
            this.lblDuracion.BackColor = Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(47)))), ((int)(((byte)(50)))));
            this.lblNumeroOrden.BackColor = Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(47)))), ((int)(((byte)(50)))));
        }

        private bool ValidarNumOrden()
        {
            bool band = true;
            if(this.numOrden.Value == 0)
            {
                band = false;
   
            }
            else
            {
                foreach(Actuacion act in actuaciones) 
                {
                    
                    if (this.numOrden.Value == act.NumeroOrden)
                    {
                        MessageBox.Show("El numero de orden ya fue registrado");
                        return band = false;
                    }
                }
            }
            return band;
        }


        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if(ComprobarDiaFestival())
            {
                DiaFestival dia = new DiaFestival()
                {
                    Fecha = this.dtpFecha.Value.Date,
                    FechaLimiteAnulacionEntrada = this.dtpAnulacion.Value.Date,
                    FechaVtoVentaAnticipada = this.dtpAnticipa.Value.Date,
                    Actuaciones = new List<Actuacion>(this.actuaciones)
                };

                dias.Add(dia);

                this.Limpiar();
            }
        }

        private void LimpiarActuacion()
        {

            this.txtbGrupoActuante.Text = String.Empty;
            this.numDuracionEstimada.Value = 0;
            this.numOrden.Value = 0;
        }
        private void Limpiar()
        {
            this.dtpAnticipa.Value = DateTime.Today;
            this.dtpAnulacion.Value = DateTime.Today;
            this.dtpFecha.Value = DateTime.Today;
            this.dgvActuacion.Rows.Clear();
            actuaciones.Clear();
            this.LimpiarActuacion();

        }


 


        private bool ComprobarDiaFestival()
        {
            bool band = true;

            if(dtpFecha.Value.Date.CompareTo(this.fchInicio.Date) < 0 || dtpFecha.Value.Date.CompareTo(this.fchFin.Date) > 0)
            {
                MessageBox.Show("La Fecha Ingresada para el dia no se encuentra entre los dias del festival");
                band = false;
            }           
            
            if(dtpAnulacion.Value.Date.CompareTo(dtpFecha.Value.Date) >= 0 )
            {
                MessageBox.Show("La Fecha limite para anular la entrada no puede ser posterior a la fecha del dia");
                band = false;
            }  
            
            if(dtpAnticipa.Value.Date.CompareTo(dtpFecha.Value.Date) > 0 )
            {
                MessageBox.Show("La Fecha limite para comprar anticipado debe ser de almenos un dia anterior a la fecha del dia");
                band = false;
            }

            if (actuaciones.Count == 0)
            {
                MessageBox.Show("Debe agregar al menos una actuacion");
                band = false;
            }
            return band;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }
    }



}
