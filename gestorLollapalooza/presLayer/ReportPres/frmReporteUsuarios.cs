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
    public partial class frmReporteUsuarios : Form
    {
        UsuarioService oUsuario = new UsuarioService();
        PerfilService oPerfil = new PerfilService();
        
        public frmReporteUsuarios()
        {
            InitializeComponent();
        }

        private void frmReporteUsuarios_Load(object sender, EventArgs e)
        {

            this.reportViewerUsuarios.RefreshReport();
            this.CargarCombo(cmbPerfil, oPerfil.recuperarTodosReporte(), "nombrePerfil", "idPerfil");
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            int mostrado = 0;
            if (cbxTraerTodos.Checked) 
            { 
                CargarReporte("");
                mostrado = 1;
            }
            if (cmbPerfil.SelectedIndex == -1 && mostrado == 0) { MessageBox.Show("Error: seleccione un perfil para mostrar sus usuarios, o en su defecto marque la opcion de 'Traer todos' "); }
            else { if (mostrado == 0) { CargarReporte("and u.idPerfil = " + cmbPerfil.SelectedValue); } }
        }

        private void CargarReporte(string filtros)
        {
            var datos = oUsuario.recuperarFiltradosReporte(filtros);
            
            this.reportViewerUsuarios.LocalReport.DataSources.Clear();

            var ds = new ReportDataSource("DataSetUsuario", datos);
            
            this.reportViewerUsuarios.LocalReport.DataSources.Add(ds);

            var fechaHoy = DateTime.Now.ToString("dd/MM/yyyy hh:mm");
            var paramFechaHoy = new ReportParameter("fechaHoy", fechaHoy);

            var parametros = new List<ReportParameter>();
            parametros.Add(paramFechaHoy);

            this.reportViewerUsuarios.LocalReport.SetParameters(parametros);

            this.reportViewerUsuarios.RefreshReport();
        }

        private void CargarCombo(ComboBox combo, DataTable tabla, string campoMostrar, string campoValor)
        {
            combo.DataSource = tabla;
            combo.DisplayMember = campoMostrar;
            combo.ValueMember = campoValor;
            combo.SelectedIndex = -1;
            combo.DropDownStyle = ComboBoxStyle.DropDownList;
        }

    }
}
