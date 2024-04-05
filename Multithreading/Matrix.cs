using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multithreading
{
    internal class Matrix
    {
        public int rows {  get; set; }
        public int[,] matrix { get; set; }
        public Matrix(int rows)
        {
            this.rows = rows;
            matrix = new int[rows, rows];
            
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < rows; j++)
                {
                    Random random = new();
                    matrix[i, j] = random.Next(1, 10);
                }
            }

        }

        public void Display(DataGridView dataGridView)
        {
            dataGridView.ColumnCount = rows;
            for (int i = 0; i < rows; i++)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dataGridView);

                for (int j = 0; j < rows; j++)
                {
                    row.Cells[j].Value = matrix[i, j];
                }

                dataGridView.Rows.Add(row);
            }
        }

        public Matrix Multiply(Matrix other)
        {
            int n = rows;
            Matrix result = new Matrix(n);

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    int sum = 0;
                    for (int k = 0; k < n; k++)
                    {
                        sum += matrix[i, k] * other.matrix[k, j];
                    }
                    result.matrix[i, j] = sum;
                }
            }

            return result;
        }




    }
}
