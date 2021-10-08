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

namespace gestorLollapalooza.presLayer.FestivalPres
{
    public partial class frmGestionarFestival : Form
    {
        FestivalService serviceF = new FestivalService();
        DiaFestivalService serviceD = new DiaFestivalService();
        ActuacionService serviceA = new ActuacionService();
        public frmGestionarFestival()
        {
            InitializeComponent();
        }

        private void frmGestionarFestival_Load(object sender, EventArgs e)
        {
            this.CargarGrillaFestivales(dgvFestivales, serviceF.obtenerTodos());
            MessageBox.Show("hola "+serviceF.obtenerTodos().Count);
        }

        private void /*festivales*/dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int idFestival = (int)dgvFestivales.CurrentRow.Cells[0].Value;
            this.CargarGrillaDiaFestival(dgvDiasFestival, serviceD.obtenerFiltados("and idFestival = " + idFestival));
            this.btnModifcar.Enabled = true;
            this.btnEliminar.Enabled = true;
        }

        private void /*diasFestivales*/dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int idDia = (int)dgvDiasFestival.CurrentRow.Cells[0].Value;
            this.CargarGrillaActuacion(dgvActuaciones, serviceA.obtenerTodosDeDiaFestival(idDia));
        }

        private void CargarGrillaFestivales(DataGridView grilla, IList<Festival> fuente)
        {
            grilla.Rows.Clear();
            foreach (Festival festival in fuente)
            {
                grilla.Rows.Add(festival.IdFestival, festival.AnoEdicion, festival.DescuentoVentaAnticipada, festival.FechaInicio, festival.Nombre, festival.PorcentajeDevolucionPorAnulacion, festival.Vigente);
            }
        }

        private void CargarGrillaDiaFestival(DataGridView grilla, IList<DiaFestival> fuente)
        {
            grilla.Rows.Clear();
            foreach (DiaFestival dia in fuente)
            {
                grilla.Rows.Add(dia.IdDiaFestival, dia.Fecha, dia.FechaLimiteAnulacionEntrada, dia.FechaVtoVentaAnticipada, dia.HoraPresentacion, dia.IdFestival);
            }
        }

        private void CargarGrillaActuacion(DataGridView grilla, IList<Actuacion> fuente)
        {
            grilla.Rows.Clear();
            foreach (Actuacion actuacion in fuente)
            {
                grilla.Rows.Add(actuacion.IdActuacion, actuacion.DuracionActuacion, actuacion.HoraInicio, actuacion.NumeroOrden, actuacion.GrupoMusical.Nombre);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
