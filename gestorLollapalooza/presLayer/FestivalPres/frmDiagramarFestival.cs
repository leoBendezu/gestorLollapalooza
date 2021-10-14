﻿using gestorLollapalooza.bussinesLayer;
using gestorLollapalooza.dataAccessLayer;
using gestorLollapalooza.presLayer.DiaFestivalPres;
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

namespace gestorLollapalooza.presLayer.FestivalPres
{
    public partial class frmDiagramarFestival : Form
    {
        FestivalService oFestival = new FestivalService();

        private IList<DiaFestival> dias;
        public frmDiagramarFestival()
        {
            InitializeComponent();
            this.dias = new List<DiaFestival>();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            resetearColor();
            if (Validar())
            {
                frmDiaFestival frm = new frmDiaFestival(this.dtpFechaInicio.Value.Date, this.dtpFechaFin.Value.Date, this.dias);
                frm.ShowDialog();
                this.CargarGrillaDias(this.dgvDias, this.dias);
            }
            
        }

        private void CargarGrillaDias(DataGridView grilla, IList<DiaFestival> fuente)
        {
            grilla.Rows.Clear();
            foreach (DiaFestival dia in fuente)
            {
                grilla.Rows.Add(dia.Fecha.ToString("MM-dd-yy"), dia.FechaLimiteAnulacionEntrada.ToString("MM-dd-yy"), dia.FechaVtoVentaAnticipada.ToString("MM-dd-yy"));
            }
        }       
        
        private void CargarGrillaActuaciones(DataGridView grilla, IList<Actuacion> fuente)
        {
            grilla.Rows.Clear();
            foreach (Actuacion actuacion in fuente)
            {
                grilla.Rows.Add(actuacion.NumeroOrden, actuacion.DuracionActuacion, actuacion.GrupoMusical.Nombre);
            }
        }


        private void frmTextBoxFacha1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void frmDiagramarFestival_Load(object sender, EventArgs e)
        {
            this.txtbNombre.Enabled = true;
            this.numAno.Enabled = true;
            this.dtpFechaInicio.Enabled = true;
            this.dtpFechaFin.Enabled = true;
            this.txtbDescuento.Enabled = true;
            this.txtbDevolucion.Enabled = true;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool Validar()
        {
            if (string.IsNullOrEmpty(this.txtbNombre.Text))
            {
                MessageBox.Show("Ingrese nombre de festival...");
                this.txtbNombre.BorderColor = Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(66)))), ((int)(((byte)(56)))));
                return false;
            }
            if (this.numAno.Value == 0 || this.numAno.Value < DateTime.Today.Year)
            {
                MessageBox.Show("Ingrese año de festival...");
                this.numAno.BackColor = Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(66)))), ((int)(((byte)(56)))));
                return false;
            }
            if (!(this.dtpFechaFin.Value.Date.CompareTo(this.dtpFechaInicio.Value.Date) >= 0))
            { 
                MessageBox.Show("Ingrese correctamente el periodo del festival...");
                return false; 
            }
            if (string.IsNullOrEmpty(this.txtbDescuento.Text))
            {
                this.txtbDescuento.Text = "0";
            }
            string caracteres = "0123456789";
            for (int i =0; i< this.txtbDescuento.Text.Length; i++)
            {
                char letra = this.txtbDescuento.Text[i];
                if (!(caracteres.Contains(letra)))
                {
                    MessageBox.Show("Ingrese un porcentaje de descuento valido...");
                    this.txtbDescuento.BorderColor = Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(66)))), ((int)(((byte)(56)))));
                    return false;
                }
            }
            if (string.IsNullOrEmpty(this.txtbDevolucion.Text))
            {
                this.txtbDevolucion.Text = "0";
            }
            for (int i = 0; i < this.txtbDevolucion.Text.Length; i++)
            {
                char letra = this.txtbDevolucion.Text[i];
                if (!(caracteres.Contains(letra)))
                {
                    MessageBox.Show("Ingrese un porcentaje de devolucion valido...");
                    this.txtbDevolucion.BorderColor = Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(66)))), ((int)(((byte)(56)))));
                    return false;
                }
            }

            return true;
        }
        
        private void resetearColor()
        {
            // Devuelve el color original a los campos

            this.txtbNombre.BorderColor = Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(154)))));
            this.numAno.BackColor = Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(154)))));
            this.txtbDescuento.BorderColor = Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(154)))));
            this.txtbDevolucion.BorderColor = Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(154)))));

        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dgvDias.CurrentRow != null)
            {
                int dia = dgvDias.CurrentRow.Index;
                this.CargarGrillaActuaciones(dgvActuacion, dias[dia].Actuaciones);     
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvDias.Rows.Count > 0)

            {
                if (!existeFestival())
                {
                    Festival festival = new Festival()
                    {
                        Nombre = this.txtbNombre.Text,
                        AnoEdicion = (int)this.numAno.Value,
                        DescuentoVentaAnticipada = Convert.ToInt32(this.txtbDescuento.Text),
                        PorcentajeDevolucionPorAnulacion = Convert.ToInt32(this.txtbDevolucion.Text),
                        FechaFin = dtpFechaFin.Value,
                        FechaInicio = dtpFechaInicio.Value

                    };

                    oFestival.persistirFestival(festival);
                }
            }
            else
                MessageBox.Show("Debe tener al menos un item de pedido...");
        }

        private bool existeFestival()
        {
            string filtros = "and nombre = '" + this.txtbNombre.Text +
                             "' and fechaInicio = '" + this.dtpFechaInicio.Value.ToString("yy-MM-dd") +
                             "' and fechaFin = '" + this.dtpFechaFin.Value.ToString("yy-MM-dd") +
                             "' and descuentoVentaAnticipada = " + this.txtbDescuento.Text +
                             "' and porcentajeDevolucionPorAnulacion = " + this.txtbDevolucion.Text +
                             "' and anioEdicion = " + this.numAno.Value +
                             "";
            if (oFestival.recuperarFiltrados(filtros).Count != 0)
            {
                return true;
            }
            return false;
        }
    
    }
}