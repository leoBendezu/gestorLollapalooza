using gestorLollapalooza.bussinesLayer;
using gestorLollapalooza.presLayer.DiaFestivalPres;
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
        private IList<DiaFestival> dias;
        public frmDiagramarFestival()
        {
            InitializeComponent();
            this.dias = new List<DiaFestival>();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmDiaFestival frm = new frmDiaFestival( this.dtpFechaInicio.Value, this.dtpFechaFin.Value, this.dias);
            frm.ShowDialog();
        }
    }
}
