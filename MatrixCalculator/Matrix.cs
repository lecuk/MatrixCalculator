using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixCalculator
{
    public class Matrix
    {
        private double[,] values;

        public double this[int i, int j] 
        {
            get
            {
                return values[i, j];
            }

            set
            {
                values[i, j] = value;
            }
        }

        public int Width
        {
            get
            {
                return values.GetLength(0);
            }
        }

        public int Height
        {
            get
            {
                return values.GetLength(1);
            }
        }

        public Matrix(int width, int height)
        {
            values = new double[width, height];
        }

        public Matrix(int size) : this(size, size) { }

        public Matrix(double[,] values)
        {
            this.values = new double[values.GetLength(0), values.GetLength(1)];
            for (int i = 0; i < Width; i++)
            {
                for (int j = 0; j < Height; j++)
                {
                    this.values[i, j] = values[i, j];
                }
            }
        }

        public static Matrix Identity(int size)
        {
            Matrix matrix = new Matrix(size);

            for (int i = 0; i < size; i++)
            {
                matrix[i, i] = 1;
            }

            return matrix;
        }

        public void CopyTo(Matrix destination)
        {
            for (int i = 0; i < Width; i++)
            {
                for (int j = 0; j < Height; j++)
                {
                    if (i < destination.Width && j < destination.Height)
                    {
                        destination.values[i, j] = values[i, j];
                    }
                }
            }
        }

        public static Matrix operator +(Matrix m1, Matrix m2)
        {
            if (m1.Width != m2.Width || m1.Height != m2.Height)
            {
                throw new ArgumentException($"{nameof(m1)} dimensions do not equal to {nameof(m2)} dimensions.");
            }

            Matrix result = new Matrix(m1.Width, m1.Height);

            for (int i = 0; i < m1.Width; i++)
            {
                for (int j = 0; j < m1.Height; j++)
                {
                    result[i, j] = m1[i, j] + m2[i, j];
                }
            }

            return result;
        }

        public static Matrix operator -(Matrix m1, Matrix m2)
        {
            if (m1.Width != m2.Width || m1.Height != m2.Height)
            {
                throw new ArgumentException($"{nameof(m1)} dimensions do not equal to {nameof(m2)} dimensions.");
            }

            Matrix result = new Matrix(m1.Width, m1.Height);

            for (int i = 0; i < m1.Width; i++)
            {
                for (int j = 0; j < m1.Height; j++)
                {
                    result[i, j] = m1[i, j] - m2[i, j];
                }
            }

            return result;
        }

        public static Matrix operator *(Matrix matrix, double factor)
        {
            Matrix result = new Matrix(matrix.Width, matrix.Height);
            matrix.CopyTo(result);

            for (int i = 0; i < result.Width; i++)
            {
                for (int j = 0; j < result.Height; j++)
                {
                    result[i, j] *= factor;
                }
            }

            return result;
        }
        
        public static Matrix operator *(double factor, Matrix matrix)
        {
            return matrix * factor;
        }

        public static Matrix operator /(Matrix matrix, double divisor)
        {
            Matrix result = new Matrix(matrix.Width, matrix.Height);
            matrix.CopyTo(result);

            for (int i = 0; i < result.Width; i++)
            {
                for (int j = 0; j < result.Height; j++)
                {
                    result[i, j] /= divisor;
                }
            }

            return result;
        }

        public static Matrix operator *(Matrix m1, Matrix m2)
        {
            if (m1.Width != m2.Height)
            {
                throw new ArgumentException($"{nameof(m1)} width does not equal to {nameof(m2)} height.");
            }

            Matrix result = new Matrix(m2.Width, m1.Height);

            for (int i = 0; i < result.Width; i++)
            {
                for (int j = 0; j < result.Height; j++)
                {
                    double sum = 0;
                    for (int k = 0; k < m1.Width; k++)
                    {
                        sum += m1[k, j] * m2[i, k];
                    }
                    result[i, j] = sum;
                }
            }

            return result;
        }

        public override string ToString()
        {
            string text = string.Empty;

            StringBuilder builder = new StringBuilder(text);

            for (int i = 0; i < Height; i++)
            {
                text += "[ ";
                for (int j = 0; j < Width; j++)
                {
                    text += values[i, j] + " ";
                }
                text += "]\n";
            }

            return text;
        }
    }
}
