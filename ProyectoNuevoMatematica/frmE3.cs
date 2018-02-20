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
    public partial class frmE3 : Form
    {
        private int nota;
        private CProcess OClass = new CProcess();
        public frmE3()
        {
            InitializeComponent();
        }

        private void frmE3_Load(object sender, EventArgs e)
        {

        }

        private void btnEnd_Click(object sender, EventArgs e)
        {

            /* if (rdbP1_O2.Checked == true)
                 nota++;

             if (rdbP2_O1.Checked == true)
                 nota++;

             if (rdbP3_O2.Checked == true)
                 nota++;

             if (rdbP4_O1.Checked == true)
                 nota++;

             if (rdbP5_O3.Checked == true)
                 nota++;

             nota *= 2;*/

            nota = OClass.Calificar(rdbP1_O2, rdbP2_O1, rdbP3_O2, rdbP4_O1, rdbP5_O3);
            MessageBox.Show("Tu nota obtenida es: " + nota
                + "\nRESPUESTAS CORRECTAS\n"
                + "1. N\n" +
                "2. 0\n" +
                "3. 1\n" +
                "4. 240\n" +
                "5. Restar", "Resultados", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            this.Hide();
            frmEvaluacion obj = new frmEvaluacion();
            obj.Show();
        }
    }
}
