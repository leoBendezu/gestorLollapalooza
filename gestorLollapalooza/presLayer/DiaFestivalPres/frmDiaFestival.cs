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
                Actuacion act = new Actuacion()
                {
                    DuracionActuacion = (int) this.numDuracionEstimada.Value,
                    NumeroOrden = (int) this.numOrden.Value,
                    GrupoMusical = gmObj.recuperarGrupoMusical(this.txtbGrupoActuante.Text)
                };
                this.actuaciones.Add(act);

                this.dgvActuacion.Rows.Add(act.DuracionActuacion, act.NumeroOrden, act.GrupoMusical.Nombre);

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
            this.dgvActuacion.Rows.Clear();
            actuaciones.Clear();
        } 

        private bool ComprobarActuacion()
        {
            bool band = true;
            if(this.numDuracionEstimada.Value == 0)
            {
                this.lblDuracion.BackColor =  Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(66)))), ((int)(((byte)(56)))));
                band = false;
            }      
            if(this.txtbGrupoActuante.Text == String.Empty )
            {
                this.txtbGrupoActuante.BorderColor = Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(66)))), ((int)(((byte)(56)))));
                band = false;
            }           
            if(this.numOrden.Value == 0 )
            {
                this.lblNumeroOrden.BackColor = Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(66)))), ((int)(((byte)(56)))));
                band = false;
            }
            if (!gmObj.existeGrupoMusical(this.txtbGrupoActuante.Text))
            {
                MessageBox.Show("No existe el Grupo Musical Ingresado, puede usar el boton ? para revisar los grupos");
                band = false;
            }
            return band;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if(ComprobarDiaFestival())
            {
                DiaFestival dia = new DiaFestival()
                {
                    Fecha = this.dtpFecha.Value,
                    FechaLimiteAnulacionEntrada = this.dtpAnulacion.Value,
                    FechaVtoVentaAnticipada = this.dtpAnticipa.Value,
                    Actuaciones = this.actuaciones
                };

                dias.Add(dia);

                this.Limpiar();
            }
        }

        private void Limpiar()
        {
            throw new NotImplementedException();
        }

        private bool ComprobarDiaFestival()
        {
            throw new NotImplementedException();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }
    }



}
