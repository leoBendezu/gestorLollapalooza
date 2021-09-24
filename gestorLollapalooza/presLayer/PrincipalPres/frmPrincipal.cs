using gestorLollapalooza.presLayer.GrupoMusicalPres;
using gestorLollapalooza.presLayer.UsuarioPres;
using gestorLollapalooza.pressLayer.UsuarioPres;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gestorLollapalooza.pressLayer
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void aBMCUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void altaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRegistrarUsuario altaUsuario = new frmRegistrarUsuario();
            altaUsuario.ShowDialog();
        }

        private void consultaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultaUsuario consultaUsuario = new frmConsultaUsuario();
            consultaUsuario.ShowDialog();
        }

        private void bajaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBajaUsuario bajaUsuario = new frmBajaUsuario();
            bajaUsuario.ShowDialog();
        }

        private void consultarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultaUsuario consultaUsuario = new frmConsultaUsuario();
            consultaUsuario.ShowDialog();
        }

        private void registrarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRegistrarUsuario altaUsuario = new frmRegistrarUsuario();
            altaUsuario.ShowDialog();
        }

        private void eliminarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBajaUsuario bajaUsuario = new frmBajaUsuario();
            bajaUsuario.ShowDialog();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            
            frmLogin login = new frmLogin();
            //login.ShowDialog();

            //if(login.UsuarioLoggeado == null) { this.Close(); } 

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

        private void modificarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmModificacionUsuario modificacionUsuario = new frmModificacionUsuario();
            modificacionUsuario.ShowDialog();
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

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultaGrupoMusical consultaGrupoMusical = new frmConsultaGrupoMusical();
            consultaGrupoMusical.ShowDialog();
        }
    }
}
