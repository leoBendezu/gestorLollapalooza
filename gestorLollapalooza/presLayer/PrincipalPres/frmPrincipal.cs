using gestorLollapalooza.presLayer.CentroVentaPres;
using gestorLollapalooza.presLayer.FestivalPres;
using gestorLollapalooza.presLayer.GrupoMusicalPres;
using gestorLollapalooza.presLayer.LoginPres;
using gestorLollapalooza.presLayer.PuntoVentaPres;
using gestorLollapalooza.presLayer.ReportPres;
using gestorLollapalooza.presLayer.TipoEntradaPres;
using gestorLollapalooza.presLayer.UsuarioPres;
using System;
using System.Windows.Forms;

namespace gestorLollapalooza.pressLayer
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }



        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            
            frmLogin login = new frmLogin();
            login.ShowDialog();

            if (login.UsuarioLoggeado == null) { this.Close(); }
            else
            {
                this.lblName.Text = login.UsuarioLoggeado.Nombre;
                this.lblPerfil.Text = login.UsuarioLoggeado.PerfilUsuario.NombrePerfil;
            }
            login.Dispose(); 
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            {
                this.salirConConfrimacion();
            }
        }

        private void frmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
///
        }


        private void salirConConfrimacion()
        {
            if (MessageBox.Show("¿Esta seguro de abandonar la aplicación?", "SALIENDO DE LA APLICACIÓN",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                
            }
        }

        private void gestionUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGestionarUsuario consultaUsuario = new frmGestionarUsuario();
            consultaUsuario.ShowDialog();
        }

        private void gestionGruposMusicalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultaGrupoMusical consultaGrupoMusical = new frmConsultaGrupoMusical();
            consultaGrupoMusical.ShowDialog();
        }

        private void gestionTipoDeEntradaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGestionarTipoEntrada gestionTipoEntrada = new frmGestionarTipoEntrada();
            gestionTipoEntrada.ShowDialog();
        }

        private void gestionPuntoDeVentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGestionarPuntoVenta gestionarPuntoVenta = new frmGestionarPuntoVenta();
            gestionarPuntoVenta.ShowDialog();
        }

        private void gestiónCentroDeVentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGestionarCentroVenta gestionarCentroVenta = new frmGestionarCentroVenta();
            gestionarCentroVenta.ShowDialog();
        }



        private void diagramarNuevoFestivalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDiagramarFestival frmf = new frmDiagramarFestival();
            frmf.ShowDialog();
        }

        private void gruposMusicalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReporteGM reporte = new frmReporteGM();
            reporte.ShowDialog();
        }

        private void grupoMusicalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReporteGM reporte = new frmReporteGM();
            reporte.ShowDialog();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReporteUsuarios reporte = new frmReporteUsuarios();
            reporte.ShowDialog();
        }

        private void festivalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReporteFestival reporteFestival = new frmReporteFestival();
            reporteFestival.ShowDialog();
        }

        private void gestionPuntoDeVentaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmGestionarPuntoVenta gestionarPuntoVenta = new frmGestionarPuntoVenta();
            gestionarPuntoVenta.ShowDialog();
        }
    }
}
