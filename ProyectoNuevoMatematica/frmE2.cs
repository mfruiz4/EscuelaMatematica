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
    public partial class frmE2 : Form
    {
        private int nota;
        private CProcess OClass = new CProcess();
        public frmE2()
        {
            InitializeComponent();
        }

        private void frmE2_Load(object sender, EventArgs e)
        {

        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            /*nota = 0;
            if (rdbP1_O4.Checked == true)
                nota++;

            if (rdbP2_O2.Checked == true)
                nota++;

            if (rdbP3_O4.Checked == true)
                nota++;

            if (rdbP4_O1.Checked == true)
                nota++;

            if (rdbP5_O2.Checked == true)
                nota++;

            nota *= 2;*/

            nota = OClass.Calificar(rdbP1_O4, rdbP2_O2, rdbP3_O4, rdbP4_O1, rdbP5_O2);

            MessageBox.Show("Tu nota obtenida es: " + nota
                + "\nRESPUESTAS CORRECTAS\n"
                + "1. 9\n" +
                "2. 2\n" +
                "3. 3\n" +
                "4. N\n" +
                "5. Sumar", "Resultados", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            this.Hide();
            frmEvaluacion obj = new frmEvaluacion();
            obj.Show();
        }
    }
}
