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
    public partial class juegoTestNumerosNaturales : Form
    {
        float cifra;
        int red;
        CArray ObjArray = new CArray();

        public juegoTestNumerosNaturales()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Juega me = new Juega();
            me.Show();
            this.Hide();
        }

     

        private void btnUnidades_Click(object sender, EventArgs e)
        {
            cifra = 1;
            red = 0;
            ObjArray.PrintList(listBox1, listBox2, listBox3, listBox4, listBox5,
                listBox6, listBox7, listBox8, listBox9, cifra, red);

        }

        private void btnDecimas_Click(object sender, EventArgs e)
        {
            cifra = 0.1f;
            red = 1;
            ObjArray.PrintList(listBox1, listBox2, listBox3, listBox4, listBox5,
               listBox6, listBox7, listBox8, listBox9, cifra, red);
        }

        private void btnDecenas_Click(object sender, EventArgs e)
        {
            cifra = 10;
            red = 0;
            ObjArray.PrintList(listBox1, listBox2, listBox3, listBox4, listBox5,
               listBox6, listBox7, listBox8, listBox9, cifra, red);
        }

        private void btnCentesimas_Click(object sender, EventArgs e)
        {
            cifra = 0.01f;
            red = 2;
            ObjArray.PrintList(listBox1, listBox2, listBox3, listBox4, listBox5,
               listBox6, listBox7, listBox8, listBox9, cifra, red);
        }

        private void btnCentenas_Click(object sender, EventArgs e)
        {
            cifra = 100;
            red = 0;
            ObjArray.PrintList(listBox1, listBox2, listBox3, listBox4, listBox5,
                listBox6, listBox7, listBox8, listBox9, cifra,red);
        }

        private void btnMilesimas_Click(object sender, EventArgs e)
        {
            cifra = 0.001f;
            red = 3;
            ObjArray.PrintList(listBox1, listBox2, listBox3, listBox4, listBox5,
                 listBox6, listBox7, listBox8, listBox9, cifra, red);
        }
    }
}
