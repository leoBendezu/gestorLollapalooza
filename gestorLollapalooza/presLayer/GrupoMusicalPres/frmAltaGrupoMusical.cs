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
    public partial class frmAltaGrupoMusical : Form
    {
        GrupoMusicalService oGrupoMusical = new GrupoMusicalService();


        public frmAltaGrupoMusical()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            if (this.Comprobar())
            {


                if (oGrupoMusical.existeGrupoMusical(this.txtbNombre.Text) == false)
                {

                    string nombreGrupoMusical = this.txtbNombre.Text;
                    string descripcion = this.txtbDescripcion.Text;
                    int cantIntegrantes = (int)this.numCantIntegrantes.Value;

                    GrupoMusical grupoMusicalN = oGrupoMusical.crear(nombreGrupoMusical, descripcion, cantIntegrantes);


                    if (oGrupoMusical.persistirGrupoMusical(grupoMusicalN))
                    {
                        MessageBox.Show("Grupo Musical Creado con exito", "info");
                        this.LimpiarTxt();
                        this.resetearColor();

                    }
                    else
                    {
                        MessageBox.Show("El Grupo Musical no pudo crearse");
                    }
                }
                else
                {
                    MessageBox.Show("Ya existe dicho Grupo Musical");
                    this.LimpiarTxt();
                    this.resetearColor();
                }

            }
            else
            {
                MessageBox.Show("Los campos en rojo deben ser completados obligatoriamente");
            }
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

            if (numCantIntegrantes.Value <= 0)
            {
                this.lblCantInt.BackColor = Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(66)))), ((int)(((byte)(56)))));
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
            this.lblCantInt.BackColor = Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(154)))));
        }   
    }
}
