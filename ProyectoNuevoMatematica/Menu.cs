using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.IO;

using System.Threading;

namespace ProyectoNuevoMatematica
{
    public partial class Menu : Form
    {

        //private CAgent mObjAgent;
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            //Load_Agent();

            
        }
        private void Load_Agent()
        {
            //mObjAgent = new CAgent("merlin", this, 400, 200);
            //mObjAgent = new CAgent("Genie", this, 400, 200);
            //mObjAgent = new CAgent("Peedy", this, 400, 200);
            //mObjAgent = new CAgent("Robby", this, 400, 200);

           // mObjAgent.ShowAgent(this);
            //mObjAgent.IniciarBienvenida(this);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Juega ju = new Juega();
            ju.Show();

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Aprender ap = new Aprender();
            ap.Show();
            this.Hide();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            frmEvaluacion mir = new frmEvaluacion();
            mir.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
