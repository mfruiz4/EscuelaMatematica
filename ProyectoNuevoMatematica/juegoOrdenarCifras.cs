using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProyectoNuevoMatematica
{
    public partial class juegoOrdenarCifras : Form
    {
        public juegoOrdenarCifras()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Juega me = new Juega();
            me.Show();
            this.Hide();
        }
    }
}
