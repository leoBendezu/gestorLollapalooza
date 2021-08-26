using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gestorLollapalooza
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void botonFacha1_Click(object sender, EventArgs e)
        {
            if ((frmTextBoxFacha1.Text == ""))
            {
                MessageBox.Show("Se debe ingresar al menos un nombre de usuario valido");
                return;
            }

            if ((frmTextBoxFachaPswd.Text == ""))
            {
                MessageBox.Show("Se debe ingresar al menos una contraseña valida");
                return;
            }

            MessageBox.Show("Usted ingreso al sistema ;)");

        }

        private void frmTextBoxFacha1_Load(object sender, EventArgs e)
        {

        }

        private void frmTextBoxFachaPswd_Load(object sender, EventArgs e)
        {

        }
    }
}
