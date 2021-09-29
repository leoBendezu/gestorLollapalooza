using gestorLollapalooza.presLayer.CentroVentaPres;
using gestorLollapalooza.presLayer.GrupoMusicalPres;
using gestorLollapalooza.presLayer.LoginPres;
using gestorLollapalooza.presLayer.PuntoVentaPres;
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
            /*
            frmLogin login = new frmLogin();
            login.ShowDialog();

            if(login.UsuarioLoggeado == null) { this.Close(); } 

            login.Dispose();*/
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
    }
}
