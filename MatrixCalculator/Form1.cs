using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MatrixCalculator
{
    public partial class Form1 : Form
    {
        public Matrix Matrix1
        {
            get
            {
                return MatrixEditControl_1.Matrix;
            }

            set
            {
                MatrixEditControl_1.Matrix = value;
            }
        }

        public Matrix Matrix2
        {
            get
            {
                return MatrixEditControl_2.Matrix;
            }

            set
            {
                MatrixEditControl_2.Matrix = value;
            }
        }

        public Matrix Matrix3
        {
            get
            {
                return MatrixEditControl_3.Matrix;
            }

            set
            {
                MatrixEditControl_3.Matrix = value;
            }
        }

        public Form1()
        {
            InitializeComponent();

            Matrix1 = new Matrix(3);
            Matrix2 = new Matrix(3);
            Matrix3 = new Matrix(3);

            MatrixEditControl_3.CanEditMatrix = false;
            MatrixEditControl_3.UpdateCells();
        }
        
        private void Button_Add_Click(object sender, EventArgs e)
        {
            if (!MatrixEditControl_1.IsMatrixValid || !MatrixEditControl_2.IsMatrixValid)
            {
                MessageBox.Show(FindForm(), "Invalid data!");
                return;
            }
            try
            {
                Matrix3 = Matrix1 + Matrix2;
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(FindForm(), ex.Message);
            }
            MatrixEditControl_3.UpdateCells();
        }

        private void Button_Substract_Click(object sender, EventArgs e)
        {
            try
            {
                Matrix3 = Matrix1 - Matrix2;
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(FindForm(), ex.Message);
            }
            MatrixEditControl_3.UpdateCells();
        }

        private void Button_Multiply_Click(object sender, EventArgs e)
        {
            if (!MatrixEditControl_1.IsMatrixValid || !MatrixEditControl_2.IsMatrixValid)
            {
                MessageBox.Show(FindForm(), "Invalid data!");
                return;
            }
            try
            {
                Matrix3 = Matrix1 * Matrix2;
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(FindForm(), ex.Message);
            }
            MatrixEditControl_3.UpdateCells();
        }
    }
}
