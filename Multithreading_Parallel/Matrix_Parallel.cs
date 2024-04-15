using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multithreading_Parallel
{
    internal class Matrix_Parallel
    {
        public int rows { get; set; }
        public int[,] matrix { get; set; }
        public Matrix_Parallel(int rows)
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
                DataGridViewRow row = new();
                row.CreateCells(dataGridView);

                for (int j = 0; j < rows; j++)
                {
                    row.Cells[j].Value = matrix[i, j];
                }

                dataGridView.Rows.Add(row);
            }
        }
        public Matrix_Parallel Multiplication(Matrix_Parallel other, int numberOfThreads)
        {
            int n = rows;
            Matrix_Parallel result = new(n);

            int maxThreads = numberOfThreads;
            ParallelOptions options = new() { MaxDegreeOfParallelism = maxThreads };

            Parallel.For(0, maxThreads, options, i =>
            {
                for (int j = 0; j < n; j++)
                {    
                    int sum = 0;
                    for (int k = 0; k < n; k++)
                    {
                       sum += matrix[i, k] * other.matrix[k, j];
                    }
                
                    Interlocked.Add(ref result.matrix[i, j], sum);
                }
            });
            


            return result;
        }       

    }
}
