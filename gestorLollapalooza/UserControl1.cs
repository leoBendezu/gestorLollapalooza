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
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        private void botonFacha1_Click(object sender, EventArgs e)
        {
            botonFacha1.Text = "Ocùpado";
            botonFacha1.BackColor = Color.Red;
            botonFacha1.Enabled = false;
               
        }

        private void botonFacha3_Click(object sender, EventArgs e)
        {
            botonFacha3.Text = "Ocùpado";
            botonFacha3.BackColor = Color.Red;
            botonFacha3.Enabled = false;
        }

        private void botonFacha5_Click(object sender, EventArgs e)
        {
            botonFacha5.Text = "Ocùpado";
            botonFacha5.BackColor = Color.Red;
            botonFacha5.Enabled = false;
        }

        private void botonFacha4_Click(object sender, EventArgs e)
        {
            botonFacha4.Text = "Ocùpado";
            botonFacha4.BackColor = Color.Red;
            botonFacha4.Enabled = false;
        }
    }
}
