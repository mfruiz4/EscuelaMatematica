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
    public partial class frmE1 : Form
    {
        private CProcess OClass = new CProcess();

        private int nota;

        public frmE1()
        {
            InitializeComponent();
            
        }

       

        private void btnEnd_Click(object sender, EventArgs e)
        {


            /*if (rdbP1_O1.Checked == true)
                nota++;

            if (rdbP2_O2.Checked == true)
                nota++;

            if (rdbP3_O4.Checked == true)
                nota++;

            if (rdbP4_O3.Checked == true)
                nota++;

            if (rdbP5_O2.Checked == true)
                nota++;*/
            nota = OClass.Calificar(rdbP1_O1, rdbP2_O2, rdbP3_O4, rdbP4_O3, rdbP5_O2);
           // nota *= 2;

            
            MessageBox.Show("Tu nota obtenida es: " + nota
                +"\nRESPUESTAS CORRECTAS\n"
                + "1. 10\n" +
                "2. Contar\n" +
                "3. 3\n" +
                "4. Centenas\n" +
                "5. 4","Resultados",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
           
            this.Hide();
            frmEvaluacion obj = new frmEvaluacion();
            obj.Show();
        }

        private void frmE1_Load(object sender, EventArgs e)
        {

        }
    }
}
