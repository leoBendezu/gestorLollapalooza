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
    public partial class frmReporteGM : Form
    {
        GrupoMusicalService oGrupo = new GrupoMusicalService();
        public frmReporteGM()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            this.reportViewerGM.RefreshReport();
            this.CargarReporte();
        }


        private void CargarReporte()
        {
            var datos = oGrupo.traerTodos();

            this.reportViewerGM.LocalReport.DataSources.Clear();

            var ds = new ReportDataSource("DataSetGruposMusicales", datos);
            this.reportViewerGM.LocalReport.DataSources.Add(ds);

            var fechaHoy = DateTime.Now.ToString("dd/MM/yyyy hh:mm");
            var paramFechaHoy = new ReportParameter("fechaHoy", fechaHoy);

            var parametros = new List<ReportParameter>();
            parametros.Add(paramFechaHoy);

            this.reportViewerGM.LocalReport.SetParameters(parametros);

            this.reportViewerGM.RefreshReport();
        }
    }
}
