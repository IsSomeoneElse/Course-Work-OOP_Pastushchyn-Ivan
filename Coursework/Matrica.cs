using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coursework
{
    public class Matrica
    {
        private readonly int[,] data;
        private readonly int rows;
        private readonly int cols;

        // Конструктори
        public Matrica(int[,] data, int rows, int cols)
        {
            this.data = data;
            this.rows = rows;
            this.cols = cols;
        }

        public Matrica(int rows, int cols)
        {
            this.data = new int[rows, cols];
            this.rows = rows;
            this.cols = cols;
        }

        // Деструктор
        ~Matrica()
        {
            // Звільнення ресурсів
        }

        // Конструктор копіювання
        public Matrica(Matrica other)
        {
            this.data = (int[,])other.data.Clone();
            this.rows = other.rows;
            this.cols = other.cols;
        }

        // Метод зміни елементу матриці
        public void Set(int row, int col, int value)
        {
            this.data[row, col] = value;
        }

        // Метод, що повертає елемент матриці з вказаними координатами
        public int Get(int row, int col)
        {
            return this.data[row, col];
        }

        // Методи виконання операцій з матрицями
        // Додавання
        public static Matrica Add(Matrica a, Matrica b)
        {
            if (a.rows != b.rows || a.cols != b.cols)
            {
                throw new ArgumentException("Матриці мають різні розміри.");
            }

            Matrica result = new Matrica(a.rows, a.cols);

            for (int i = 0; i < a.rows; i++)
            {
                for (int j = 0; j < a.cols; j++)
                {
                    result.Set(i, j, a.data[i, j] + b.data[i, j]);
                }
            }
            return result;
        }

        // Множення
        public static Matrica Multiply(Matrica a, Matrica b)
        {
            if (a.cols != b.rows)
            {
                throw new ArgumentException("Матриці не можуть бути перемножені.");
            }

            Matrica result = new Matrica(a.rows, b.cols);

            for (int i = 0; i < a.rows; i++)
            {
                for (int j = 0; j < b.cols; j++)
                {
                    int sum = 0;
                    for (int k = 0; k < a.cols; k++)
                    {
                        sum += a.data[i, k] * b.data[k, j];
                    }
                    result.Set(i, j, sum);
                }
            }
            return result;
        }

        // Транспонування
        public Matrica Transpose()
        {
            Matrica result = new Matrica(this.cols, this.rows);
            for (int i = 0; i < this.rows; i++)
            {
                for (int j = 0; j < this.cols; j++)
                {
                    result.Set(j, i, this.data[i, j]);
                }
            }
            return result;
        }

        // Визначник матриці
        public int Determinant()
        {
            if (this.rows != this.cols)
            {
                throw new ArgumentException("Матриця повинна бути квадратною.");
            }
            if (this.rows == 1)
            {
                return this.data[0, 0];
            }
            if (this.rows == 2)
            {
                return this.data[0, 0] * this.data[1, 1] - this.data[0, 1] * this.data[1, 0];
            }
            int result = 0;
            for (int i = 0; i < this.cols; i++)
            {
                Matrica submatrix = new Matrica(this.rows - 1, this.cols - 1);
                for (int j = 1; j < this.rows; j++)
                {
                    for (int k = 0; k < this.cols; k++)
                    {
                        if (k < i)
                        {
                            submatrix.Set(j - 1, k, this.data[j, k]);
                        }
                        else if (k > i)
                        {
                            submatrix.Set(j - 1, k - 1, this.data[j, k]);
                        }
                    }
                }
                int sign = (i % 2 == 0) ? 1 : -1;
                result += sign * this.data[0, i] * submatrix.Determinant();
            }
            return result;
        }

        // Допоміжний метод для виводу матриці у ListView
        public override string ToString()
        {
            string matrixString = "";
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    matrixString += data[i, j] + " ";
                }
                matrixString += Environment.NewLine;
            }
            return matrixString;
        }

        // Метод, що повертає кількість рядків
        public int RowCount()
        {
            return this.rows;
        }

        // Метод, що повертає кількість стовпців
        public int ColumnCount()
        {
            return this.cols;
        }
    }
}
