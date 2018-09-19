using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MatrixCalculator
{
    public partial class MatrixEditControl : UserControl
    {
        public Matrix Matrix { get; set; }

        private TextBox[,] Cells { get; set; }
        private List<IDisposable> ControlsToDispose { get; set; }

        public const int CellWidth = 33;
        public const int CellHeight = 20;
        public const int CellGap = 2;

        public bool IsMatrixValid { get; private set; } = true;
        public bool CanEditMatrix { get; set; } = true;

        public MatrixEditControl()
        {
            InitializeComponent();

            Matrix = new Matrix(3);

            ControlsToDispose = new List<IDisposable>();

            UpdateCells();
        }

        public void UpdateCells()
        {
            foreach (IDisposable control in ControlsToDispose)
            {
                control.Dispose();
            }
            ControlsToDispose.Clear();
            Cells = new TextBox[Matrix.Width, Matrix.Height];

            for (int x = 0; x < Matrix.Width; x++)
            {
                for (int y = 0; y < Matrix.Height; y++)
                {
                    TextBox box = new TextBox
                    {
                        Location = new Point(x * (CellWidth + CellGap), y * (CellHeight + CellGap)),
                        Text = Matrix[x, y].ToString(),
                        Size = new Size(CellWidth, CellHeight),
                        TextAlign = HorizontalAlignment.Center,
                        Parent = this,
                        MaxLength = 5,
                        ReadOnly = !CanEditMatrix
                    };
                    box.TextChanged += CellTextChanged;

                    Cells[x, y] = box;
                    ControlsToDispose.Add(box);
                    
                    box.Show();
                }
            }

            if (CanEditMatrix)
            {
                Button columnAddButton = new Button
                {
                    Location = new Point(Matrix.Width * (CellWidth + CellGap), 0),
                    Text = "C+",
                    Size = new Size(CellWidth, CellHeight),
                    TextAlign = ContentAlignment.MiddleCenter,
                    Parent = this
                };
                columnAddButton.MouseClick += AddColumn;
                ControlsToDispose.Add(columnAddButton);

                Button columnRemoveButton = new Button
                {
                    Location = new Point(Matrix.Width * (CellWidth + CellGap), CellHeight + CellGap),
                    Text = "C-",
                    Size = new Size(CellWidth, CellHeight),
                    TextAlign = ContentAlignment.MiddleCenter,
                    Parent = this
                };
                columnRemoveButton.MouseClick += RemoveColumn;
                ControlsToDispose.Add(columnRemoveButton);

                Button rowAddButton = new Button
                {
                    Location = new Point(0, Matrix.Height * (CellHeight + CellGap)),
                    Text = "R+",
                    Size = new Size(CellWidth, CellHeight),
                    TextAlign = ContentAlignment.MiddleCenter,
                    Parent = this
                };
                rowAddButton.MouseClick += AddRow;
                ControlsToDispose.Add(rowAddButton);

                Button rowRemoveButton = new Button
                {
                    Location = new Point(CellWidth + CellGap, Matrix.Height * (CellHeight + CellGap)),
                    Text = "R-",
                    Size = new Size(CellWidth, CellHeight),
                    TextAlign = ContentAlignment.MiddleCenter,
                    Parent = this
                };
                rowRemoveButton.MouseClick += RemoveRow;
                ControlsToDispose.Add(rowRemoveButton);
            }
        }

        public void CellTextChanged(object sender, EventArgs e)
        {
            int cx = 0, cy = 0;

            TextBox box = null;

            for (int x = 0; x < Matrix.Width; x++)
            {
                for (int y = 0; y < Matrix.Height; y++)
                {
                    if ((TextBox)sender == Cells[x, y])
                    {
                        cx = x;
                        cy = y;
                        box = Cells[x, y];
                        break;
                    }
                }
            }
            ValidateCell(cx, cy);
        }

        public void AddColumn(object sender, EventArgs e)
        {
            SetNewSize(Matrix.Width + 1, Matrix.Height);
        }
        
        public void RemoveColumn(object sender, EventArgs e)
        {
            SetNewSize(Matrix.Width - 1, Matrix.Height);
        }

        public void AddRow(object sender, EventArgs e)
        {
            SetNewSize(Matrix.Width, Matrix.Height + 1);
        }

        public void RemoveRow(object sender, EventArgs e)
        {
            SetNewSize(Matrix.Width, Matrix.Height - 1);
        }

        void SetNewSize(int width, int height)
        {
            if (width < 1 | height < 1)
                return;

            Matrix origin = Matrix;
            Matrix newMatrix = new Matrix(width, height);
            origin.CopyTo(newMatrix);
            Matrix = newMatrix;

            UpdateCells();

            for (int x = 0; x < Matrix.Width; x++)
            {
                for (int y = 0; y < Matrix.Height; y++)
                {
                    ValidateCell(x, y);
                }
            }
        }

        public void ValidateCell(int x, int y)
        {
            TextBox box = Cells[x, y];
            if (double.TryParse(box.Text, out double value))
            {
                Matrix[x, y] = value;
                box.BackColor = Color.White;
                IsMatrixValid = true;
            }
            else
            {
                box.BackColor = Color.Red;
                IsMatrixValid = false;
            }
        }
    }
}
