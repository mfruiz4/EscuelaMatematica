using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Drawing;
using System.Windows.Forms;

namespace ProyectoNuevoMatematica
{

    class CArray
    {
        private float[] mArray = new float[20];
        private int mNum;

        public void InitializeArray()
        {
            for (int i = 0; i < mArray.Length; i++)
            {
                mArray[i] = -1.0f;
            }
            mNum = 0;
        }

        public void GenerateData(float cifra, int red)
        {
            InitializeArray();
            int i;
            int index=1;
            mNum = 9;
            for (i = 0; i < mNum; i++)
            {
                
                mArray[i] = (float)Math.Round(index * cifra, red);

                index++;
                
            }
            
        }

        public void PrintList(ListBox l1, ListBox l2, ListBox l3, ListBox l4, ListBox l5, ListBox l6, ListBox l7,
            ListBox l8, ListBox l9,float cifra,int red)
        {
            GenerateData(cifra,red);
            l1.Items.Clear();
            l2.Items.Clear();
            l3.Items.Clear();
            l4.Items.Clear();
            l5.Items.Clear();
            l6.Items.Clear();
            l7.Items.Clear();
            l8.Items.Clear();
            l9.Items.Clear();

            l1.Items.Add(mArray[0]);
            l2.Items.Add(mArray[1]);
            l3.Items.Add(mArray[2]);
            l4.Items.Add(mArray[3]);
            l5.Items.Add(mArray[4]);
            l6.Items.Add(mArray[5]);
            l7.Items.Add(mArray[6]);
            l8.Items.Add(mArray[7]);
            l9.Items.Add(mArray[8]);
        }

    }
}
