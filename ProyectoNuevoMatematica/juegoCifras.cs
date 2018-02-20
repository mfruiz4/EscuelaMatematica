using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Diagnostics;
using System.Media;

namespace ProyectoNuevoMatematica
{
    public partial class juegoCifras : Form
    {
        Process proceso = new Process();
        public juegoCifras()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Juega me = new Juega();
            me.Show();
            this.Hide();
        }

        private void juegoCifras_Load(object sender, EventArgs e)
        {

        }

        private void btnPlay1_Click(object sender, EventArgs e)
        {
            SoundPlayer player = new SoundPlayer (@"..\..\Resources\Pronunciaciones\unidad.wav");
            player.Play();
        }

        private void btnPlay2_Click(object sender, EventArgs e)
        {
            SoundPlayer player = new SoundPlayer(@"..\..\Resources\Pronunciaciones\decena.wav");
            player.Play();
        }

        private void btnPlay3_Click(object sender, EventArgs e)
        {
            SoundPlayer player = new SoundPlayer(@"..\..\Resources\Pronunciaciones\centena.wav");
            player.Play();
        }

        private void btnPlay4_Click(object sender, EventArgs e)
        {
            SoundPlayer player = new SoundPlayer(@"..\..\Resources\Pronunciaciones\decima.wav");
            player.Play();
        }

        private void btnPlay5_Click(object sender, EventArgs e)
        {
            SoundPlayer player = new SoundPlayer(@"..\..\Resources\Pronunciaciones\centesima.wav");
            player.Play();
        }

        private void btnPlay6_Click(object sender, EventArgs e)
        {
            SoundPlayer player = new SoundPlayer(@"..\..\Resources\Pronunciaciones\milesima.wav");
            player.Play();
        }
    }
}
