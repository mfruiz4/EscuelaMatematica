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
    public partial class Juega : Form
    {
        public Juega()
        {
            InitializeComponent();
        }

        private void Juega_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Menu m = new Menu();
            m.Show();
            this.Hide();
        }

        private void picBoxTest_Click(object sender, EventArgs e)
        {
            this.Hide();
            juegoTestNumerosNaturales obj = new juegoTestNumerosNaturales();
            obj.Show();
        }

        private void picBoxOrdena_Click(object sender, EventArgs e)
        {
            this.Hide();
            juegoOrdenarCifras obj = new juegoOrdenarCifras();
            obj.Show();
        }

        private void picBoxCifras_Click(object sender, EventArgs e)
        {
            this.Hide();
            juegoCifras obj = new juegoCifras();
            obj.Show();
        }

        private void picBox10_Click(object sender, EventArgs e)
        {
            this.Hide();
            juegoLaberinto obj = new juegoLaberinto();
            obj.Show();
        }
    }
}
