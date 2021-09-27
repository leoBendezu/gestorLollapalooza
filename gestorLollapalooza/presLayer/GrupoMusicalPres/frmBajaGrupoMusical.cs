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

namespace gestorLollapalooza.presLayer.GrupoMusicalPres
{
    public partial class frmBajaGrupoMusical : Form
    {
        DataGridViewRow rowGrupo;
        GrupoMusicalService GrupoService = new GrupoMusicalService();
        GrupoMusical oGrupoMusical;

        public frmBajaGrupoMusical(DataGridViewRow row)
        {
            InitializeComponent();
            rowGrupo = row;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmBajaGrupoMusical_Load(object sender, EventArgs e)
        {
            this.txtbNombre.Enabled = false;
            this.txtbDescripcion.Enabled = false;
            this.txtbCantIntegranres.Enabled = false;

            oGrupoMusical = GrupoService.recuperarGrupoMusical((string)rowGrupo.Cells[1].Value);

            this.txtbNombre.Text = oGrupoMusical.Nombre;
            this.txtbDescripcion.Text = oGrupoMusical.Descripcion;
            this.txtbCantIntegranres.Text = oGrupoMusical.CantIntegrantes.ToString();

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

                MessageBox.Show("Se eliminara este Grupo Musical", "Advertencia");

                // intenta realizar la baja, de lograrlo avisa, recarga el comboBox cbUsuario y
                // limpia los campos

            

                if (this.GrupoService.borrarGrupo(oGrupoMusical.Nombre))
                {
                    MessageBox.Show("Se elimino el usuario de forma correcta", "Advertencia");

                }
            

        }
    }
}
