using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Windows.Forms; //

namespace ProyectoNuevoMatematica
{
    class CProcess
    {
        private int nota;

       

        public int Calificar(RadioButton b1, RadioButton b2, RadioButton b3, RadioButton b4, RadioButton b5)
        {
            nota = 0;
            if(b1.Checked == true)
                nota++;

            if (b2.Checked == true)
                nota++;

            if (b3.Checked == true)
                nota++;

            if (b4.Checked == true)
                nota++;

            if (b5.Checked == true)
                nota++;

            nota *= 2;

            return nota;

        }

    }
}
