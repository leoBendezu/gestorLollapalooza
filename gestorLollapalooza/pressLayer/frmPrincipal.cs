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
            frmLogin Login = new frmLogin();
            Login.ShowDialog();
        }

        private void aBMCUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void altaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAltaUsuario altaUsuario = new frmAltaUsuario();
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
    }
}
