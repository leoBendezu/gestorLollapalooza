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
    public partial class frmModificacionGrupoMusical : Form
    {
        DataGridViewRow rowGrupo;
        GrupoMusicalService GrupoService = new GrupoMusicalService();
        GrupoMusical oGrupoMusical;

        public frmModificacionGrupoMusical(DataGridViewRow row)
        {
            InitializeComponent();
            rowGrupo = row;
        }

        private void frmModificacionGrupoMusical_Load(object sender, EventArgs e)
        {
            oGrupoMusical = GrupoService.recuperarGrupoMusical((string)rowGrupo.Cells[1].Value);

            this.txtbNombre.Text = oGrupoMusical.Nombre;
            this.txtbDescripcion.Text = oGrupoMusical.Descripcion;
            this.numCantIntegrantes.Value = oGrupoMusical.CantIntegrantes;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public bool Comprobar()
        {

            // Comprueba que los campos no esten vacios, cambiandoles el color a rojo a aquellos que son obligatorios

            bool band = true;

            if (string.IsNullOrEmpty(this.txtbNombre.Text))
            {
                this.txtbNombre.BorderColor = Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(66)))), ((int)(((byte)(56)))));
                band = false;

            }

            if (string.IsNullOrEmpty(this.txtbDescripcion.Text))
            {
                this.txtbDescripcion.BorderColor = Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(66)))), ((int)(((byte)(56)))));
                band = false;
            }

            if (numCantIntegrantes.Value == 0)
            {
                this.numCantIntegrantes.BackColor = Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(66)))), ((int)(((byte)(56)))));
                band = false;
            }


            return band;

        }

        private void LimpiarTxt()
        {
            // Limpia los campos de texto

            this.txtbNombre.Text = String.Empty;
            this.txtbDescripcion.Text = String.Empty;
            this.numCantIntegrantes.Value = 0;
            this.txtbNombre.Focus();
        }

        private void resetearColor()
        {
            // Devuelve el color original a los campos que hayan sido cmabiados por Comprobar()

            this.txtbNombre.BorderColor = Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(154)))));
            this.txtbDescripcion.BorderColor = Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(154)))));
            this.numCantIntegrantes.BackColor = Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(154)))));
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            // Comprueba si los campos obligatorios han sidos llenados

            if (Comprobar())
            {
                this.oGrupoMusical.Nombre = txtbNombre.Text;
                this.oGrupoMusical.Descripcion = txtbDescripcion.Text;
                this.oGrupoMusical.CantIntegrantes = (int)numCantIntegrantes.Value;


                // Intenta realizar la modificacion del GrupoMusical si lo logra avisa, y resetea los campos
                // En caso contrario avisa.

                if (GrupoService.modificarGrupo(oGrupoMusical))
                {
                    MessageBox.Show("Se ha modificado el usuario", "Advertencia");
                    resetearColor();
                }
                else
                {
                    MessageBox.Show("No se ha podido modificar el usuario", "Advertencia");
                    resetearColor();
                }
            }
            else
            {
                MessageBox.Show("Los campos en rojo deben ser completados ", "Advertencia");
            }
        
}
    }
}
