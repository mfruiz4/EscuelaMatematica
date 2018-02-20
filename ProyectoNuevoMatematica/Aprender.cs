using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Diagnostics;
using System.Resources;

namespace ProyectoNuevoMatematica
{
    public partial class Aprender : Form
    {
        public Aprender()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Menu me = new Menu();
            me.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Process.Start("POWERPNT.EXE");
            Process proceso = new Process(); 
            proceso.StartInfo.FileName =( @"..\..\Resources\Numeros_Naturales.ppsx");
            proceso.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Process proceso = new Process();
            proceso.StartInfo.FileName = (@"..\..\Resources\CifrasNuméricas.ppsx");
            proceso.Start();
        }

        private void Aprender_Load(object sender, EventArgs e)
        {

        }
    }
}
