using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoLibrary
{
    public class DoubleTransposition
    {
        public DoubleTransposition(int matX,int matY,string permX,string permY)
        {
            this.matX = matX;
            this.matY = matY;
            this.permX = permX;
            this.permY = permY;
        }

        private int matX;

        public int X
        {
            get
            {
                return matX;
            }
            set
            {
                matX = value;
            }
        }

        private int matY;

        public int Y
        {
            get
            {
                return matY;
            }
            set
            {
                matY = value;
            }
        }

        private string permX;

        public string PermX
        {
            get
            {
                return permX;
            }
            set
            {
                permX = value;
            }
        }

        private string permY;

        public string PermY
        {
            get
            {
                return permY;
            }
            set
            {
                permY = value;
            }
        }

        public string Crypt(string source)
        {
            string[] xp = this.permX.Split(',');
            string[] yp = this.permY.Split(',');

            // source to matrix
            char[,] transpositionMatrix = new char[this.matX, this.matY];

            for (int i = 0; i < this.matX; i++)
            {
                for (int j = 0; j < this.matY; j++)
                {
                    transpositionMatrix[i, j] = source[i * matY + j];
                }
            }

            // perm x
            char[,] matrixAfterX = new char[this.matX, this.matY];

            for (int i = 0; i < xp.Length; i++)
            {
                int c = System.Convert.ToInt32(xp[i]);
                for (int j = 0; j < this.matY; j++)
                {
                    matrixAfterX[i, j] = transpositionMatrix[c, j];
                }
            }

            // perm y

            char[,] matrixAfterY = new char[this.matX, this.matY];

            for (int i = 0; i < yp.Length; i++)
            {
                int c = System.Convert.ToInt32(yp[i]);
                for (int j = 0; j < this.matX; j++)
                {
                    matrixAfterY[j, i] = matrixAfterX[j, c];
                }
            }

            // matrix to dest

            string dest = "";

            for (int i = 0; i < this.matX; i++)
            {
                for (int j = 0; j < this.matY; j++)
                {
                    dest += matrixAfterY[i, j];
                }
            }

            return dest;
        }

        public string Decrypt(string source)
        {
            string[] xp = this.permX.Split(',');
            string[] yp = this.permY.Split(',');

            // source to matrix
            char[,] transpositionMatrix = new char[this.matX, this.matY];

            for (int i = 0; i < this.matX; i++)
            {
                for (int j = 0; j < this.matY; j++)
                {
                    transpositionMatrix[i, j] = source[i * matY + j];
                }
            }

            // perm y
            char[,] matrixAfterY = new char[this.matX, this.matY];

            for (int i = 0; i < yp.Length; i++)
            {
                int c = System.Convert.ToInt32(yp[i]);
                for (int j = 0; j < this.matX; j++)
                {
                    matrixAfterY[j, c] = transpositionMatrix[j, i];
                }
            }

            // perm x
            char[,] matrixAfterX = new char[this.matX, this.matY];

            for (int i = 0; i < xp.Length; i++)
            {
                int c = System.Convert.ToInt32(xp[i]);
                for (int j = 0; j < this.matY; j++)
                {
                    matrixAfterX[c, j] = matrixAfterY[i, j];
                }
            }



            // matrix to dest

            string dest = "";

            for (int i = 0; i < this.matX; i++)
            {
                for (int j = 0; j < this.matY; j++)
                {
                    dest += matrixAfterX[i, j];
                }
            }

            return dest;
        }
    }
}
