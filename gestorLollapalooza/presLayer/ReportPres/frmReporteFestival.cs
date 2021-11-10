using gestorLollapalooza.Service;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gestorLollapalooza.presLayer.ReportPres
{
    public partial class frmReporteFestival : Form
    {

        FestivalService oFestival = new FestivalService();
        public frmReporteFestival()
        {
            InitializeComponent();
        }

        private void frmReporteFestival_Load(object sender, EventArgs e)
        {
            this.rvFestival.RefreshReport();
            this.cargar("");
        }

        private void cargar(string filtros)
        {
            var datos = oFestival.recuperarFiltadrosDT(filtros);     
            var ds = new ReportDataSource("DataSetFestival", datos);

            this.rvFestival.LocalReport.DataSources.Clear();
            this.rvFestival.LocalReport.DataSources.Add(ds);

            var fechaHoy = DateTime.Now.ToString("dd/MM/yyyy hh:mm");
            var paramFechaHoy = new ReportParameter("fechaHoy", fechaHoy);

            var parametros = new List<ReportParameter>();
            parametros.Add(paramFechaHoy);
            this.rvFestival.LocalReport.SetParameters(parametros);

            this.rvFestival.LocalReport.Refresh();
            this.rvFestival.RefreshReport();

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {

            if (chTodos.Checked) { this.cargar(""); }
            else
            {
                string filtros = "";
                if (this.numa.Value < this.numHasta.Value) { 
                filtros += "and anoEdicion >= " + this.numa.Value + "and anoEdicion <=" + this.numHasta.Value;
                }
                if (this.cbVigentes.Checked)
                {
                    filtros += "and vigente = 0";
                }

                this.cargar(filtros);
            }
        }

 
    }
}
