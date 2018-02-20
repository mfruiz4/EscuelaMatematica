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
    public partial class frmEvaluacion : Form
    {
        public frmEvaluacion()
        {
            InitializeComponent();
        }

     
        
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Menu me = new Menu();
            me.Show();
            this.Hide();

        }
        

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            int n;
            Random randomN = new Random();
            n = randomN.Next(1, 4);

            switch(n)
            {
                case 1:
                    
                    frmE1 obj = new frmE1();
                    obj.Show();
                    this.Hide();
                    break;
                case 2:
                    frmE2 obj1 = new frmE2();
                    obj1.Show();
                    this.Hide();
                    break;
                case 3:
                    frmE3 obj2 = new frmE3();
                    obj2.Show();
                    this.Hide();
                    break;

                default: MessageBox.Show("Opcion Incorrecta");
                    break;
            }
        }
    }
}
