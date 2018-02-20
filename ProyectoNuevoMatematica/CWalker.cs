using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//

using System.Drawing;
using System.Windows.Forms;

namespace ProyectoNuevoMatematica
{
    class CWalker
    {
        private int[,] mMatrix;
        private int mRow, mColumn;
        private int mM, mN;

        public CWalker()
        {
            mRow = 0; mColumn = 0;
            mM = 0; mN = 0;
        }

        public void CreateMatrix(int r, int c)
        {
            mMatrix = new int[r, c];
            mM = r; mN = c;
        }

        public void InitializeMatrix(int[,] a)
        {
            int i, j;

            for (i = 0; i < mM; i++)
            {
                for (j = 0; j < mN; j++)
                {
                    mMatrix[i, j] = a[i, j];
                }
            }
        }

        public void InitializeRoad()
        {
            mRow = 0; mColumn = 0;
        }

        public void LocalizeStart()
        {
            int i, j;

            for (i = 0; i < mM; i++)
            {
                for (j = 0; j < mN; j++)
                {
                    if (mMatrix[i, j] == 2)
                    {
                        mRow = i; mColumn = j;
                    }
                }
            }
        }

        public void MoveRightSide(PictureBox picWalker)
        {
            picWalker.Left = picWalker.Left + 25;
            mColumn++;
        }

        public void MoveLeftSide(PictureBox picWalker)
        {
            picWalker.Left = picWalker.Left - 25;
            mColumn--;
        }

        public void MoveUpSide(PictureBox picWalker)
        {
            picWalker.Top = picWalker.Top - 25;
            mRow--;
        }

        public void MoveDownSide(PictureBox picWalker)
        {
            picWalker.Top = picWalker.Top + 25;
            mRow++;
        }

        public void ControlMovesInLaberynth(PictureBox picWalker, KeyEventArgs e)
        {
            if (mMatrix[mRow, mColumn] != 3)
            {
                if (e.KeyCode == Keys.Right)
                {
                    if (mMatrix[mRow, mColumn + 1] != 0)
                    {
                        MoveRightSide(picWalker);
                    }
                }
                if (e.KeyCode == Keys.Left)
                {
                    if (mMatrix[mRow, mColumn - 1] != 0)
                    {
                        MoveLeftSide(picWalker);
                    }
                }
                if (e.KeyCode == Keys.Up)
                {
                    if (mMatrix[mRow - 1, mColumn] != 0)
                    {
                        MoveUpSide(picWalker);
                    }
                }
                if (e.KeyCode == Keys.Down)
                {
                    if (mMatrix[mRow + 1, mColumn] != 0)
                    {
                        MoveDownSide(picWalker);
                    }
                }
                if (mMatrix[mRow, mColumn] == 3)
                {
                    MessageBox.Show("Felicitaciones, has completado el laberinto.",
                                "Mensaje de control");
                }
            }
        }

    }
}
