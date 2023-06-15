using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coursework
{
    public partial class MainForm : Form
    {
        private readonly List<Matrica> matrixArray;
        private Matrica matrixResult;

        public MainForm()
        {
            InitializeComponent();
            matrixArray = new List<Matrica>();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            labelResult.Text = "";

            CleanListMenuItem.Enabled = false;

            AddButton.Enabled = false;
            SortButton.Enabled = false;
        }

        private void RestartProgramMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void ExitProgramMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CleanListMenuItem_Click(object sender, EventArgs e)
        {
            matrixListView.Items.Clear();
            matrixArray.Clear();
            CleanListMenuItem.Enabled = false;
            AddButton.Enabled = false;
            SortButton.Enabled = false;
        }

        private void AboutMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Це програма, що дозволяє працювати з масивом матриць.{Environment.NewLine}Можна здійснювати різні операції: додавання матриці до{Environment.NewLine}масиву, сортування масиву, додавання та множення двох{Environment.NewLine}вибраних матриць з масиву, транспонування та пошук{Environment.NewLine}визначника вибраної матриці з масиву. Також наявна{Environment.NewLine}можливість замінити елемент однієї з матриць масиву. За{Environment.NewLine}допомогою кнопки 'Очистити введений масив', що{Environment.NewLine}розташована у елементі меню 'Правка' можна очистити{Environment.NewLine}масив матриць.", "Про програму", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void SetTableSizeButton_Click(object sender, EventArgs e)
        {
            // Зчитування розміру масиву, заданого користувачем
            int size = (int)SizeNumericUpDown.Value;

            // Очищення dataGridView
            dataGridView.Rows.Clear();
            dataGridView.Columns.Clear();

            // Додавання стовпців та рядків до dataGridView
            for (int i = 0; i < size; i++)
            {
                dataGridView.Columns.Add("", "");
                dataGridView.Rows.Add();
            }

            // Включення кнопок для подальшої роботи з програмою
            if (size == 0)
            {
                AddButton.Enabled = false;
                SortButton.Enabled = false;
            }
            else
            {
                AddButton.Enabled = true;
                SortButton.Enabled = true;
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            // Зчитування розміру масиву, заданого користувачем
            int rows = int.Parse(SizeNumericUpDown.Text);
            int cols = rows;

            // Створення нової матриці
            Matrica matrix = new Matrica(rows, cols);

            // Заповнення матриці значеннями з dataGridView
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    DataGridViewCell cell = dataGridView.Rows[i].Cells[j];
                    if (cell.Value == null || string.IsNullOrEmpty(cell.Value.ToString()))
                    {
                        MessageBox.Show("Не всі комірки заповнені!");
                        return;
                    }

                    string cellValue = cell.Value.ToString();
                    if (int.TryParse(cellValue, out int value))
                    {
                        matrix.Set(i, j, value);
                    }
                    else
                    {
                        MessageBox.Show("Некоректне значення для елемента матриці!");
                        return;
                    }
                }
            }

            // Додавання матриці до масиву
            matrixArray.Add(matrix);

            // Оновлення списку матриць
            UpdateMatrixList();

            // Включення можливості очищення масиву матриць
            CleanListMenuItem.Enabled = true;
        }

        private void SortButton_Click(object sender, EventArgs e)
        {
            // Сортування масиву матриць за зростанням значень визначників
            matrixArray.Sort((a, b) => a.Determinant().CompareTo(b.Determinant()));

            // Оновлення списку матриць
            UpdateMatrixList();
        }

        private void MatrixAddButton_Click(object sender, EventArgs e)
        {
            // Перевірка, що в матриці щонайменш один масив
            if (matrixArray.Count < 1)
            {
                MessageBox.Show($"Потрібно додати щонайменше одну матрицю для виконання{Environment.NewLine}операцій!");
                return;
            }

            // Зчитування індексів відповідних матриць у масиві, введених користувачем
            int matrixAIndex = (int)matrixANumericUpDown.Value;
            int matrixBIndex = (int)matrixBNumericUpDown.Value;


            if (matrixAIndex >= 0 && matrixAIndex < matrixArray.Count && matrixBIndex >= 0 && matrixBIndex < matrixArray.Count)
            {
                try
                {
                    Matrica matrixA = matrixArray[matrixAIndex];
                    Matrica matrixB = matrixArray[matrixBIndex];

                    // Додавання матриць
                    matrixResult = Matrica.Add(matrixA, matrixB);

                    // Оновлення списку матриць
                    ResultMatrixList();
                }
                catch (ArgumentException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Порядковий номер не має виходити за межі розміру маcиву!");
                return;
            }
        }

        private void MatrixMultiplyButton_Click(object sender, EventArgs e)
        {
            // Перевірка, що в матриці щонайменш один масив
            if (matrixArray.Count < 1)
            {
                MessageBox.Show($"Потрібно додати щонайменше одну матрицю для виконання{Environment.NewLine}операцій!");
                return;
            }

            // Зчитування індексів відповідних матриць у масиві, введених користувачем
            int matrixAIndex = (int)matrixANumericUpDown.Value;
            int matrixBIndex = (int)matrixBNumericUpDown.Value;

            if (matrixAIndex >= 0 && matrixAIndex < matrixArray.Count && matrixBIndex >= 0 && matrixBIndex < matrixArray.Count)
            {
                try
                {
                    Matrica matrixA = matrixArray[matrixAIndex];
                    Matrica matrixB = matrixArray[matrixBIndex];

                    // Множення матриць
                    matrixResult = Matrica.Multiply(matrixA, matrixB);

                    // Оновлення списку матриць
                    ResultMatrixList();
                }
                catch (ArgumentException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Порядковий номер не має виходити за межі розміру маcиву!");
                return;
            }
        }

        private void MatrixTransposeButton_Click(object sender, EventArgs e)
        {
            // Перевірка, що в матриці щонайменш один масив
            if (matrixArray.Count < 1)
            {
                MessageBox.Show($"Потрібно додати щонайменше одну матрицю для виконання{Environment.NewLine}операцій!");
                return;
            }

            // Зчитування індексу відповідної матриці у масиві, введеного користувачем
            int matrixTIndex = (int)matrixNumericUpDown.Value;

            if (matrixTIndex >= 0 && matrixTIndex < matrixArray.Count)
            {
                try
                {
                    Matrica matrixT = matrixArray[matrixTIndex];

                    // Транспонування матриці
                    matrixResult = matrixT.Transpose();

                    // Оновлення списку матриць
                    matrixListView3.Items.Clear();
                    TransposeResultMatrixList();
                }
                catch (ArgumentException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Порядковий номер не має виходити за межі розміру маcиву!");
                return;
            }
        }

        private void FindDeterminantButton_Click(object sender, EventArgs e)
        {
            // Перевірка, що в матриці щонайменш один масив
            if (matrixArray.Count < 1)
            {
                MessageBox.Show($"Потрібно додати щонайменше одну матрицю для виконання{Environment.NewLine}операцій!");
                return;
            }

            // Зчитування індексу відповідної матриці у масиві, введеного користувачем
            int matrixDIndex = (int)matrixNumericUpDown.Value;

            if (matrixDIndex >= 0 && matrixDIndex < matrixArray.Count)
            {
                try
                {
                    Matrica matrixD = matrixArray[matrixDIndex];

                    // Пошук визначника матриці
                    int determinant = matrixD.Determinant();

                    // Вивід матриці у надпис
                    labelResult.Text = determinant.ToString();
                }
                catch (ArgumentException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Порядковий номер не має виходити за межі розміру маcиву!");
                return;
            }
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            // Перевірка, що в матриці щонайменш один масив
            if (matrixArray.Count < 1)
            {
                MessageBox.Show($"Потрібно додати щонайменше одну матрицю для виконання{Environment.NewLine}операцій!");
                return;
            }

            // Зчитування індексу відповідної матриці у масиві, введеного користувачем
            int selectedIndex = (int)indexNumericUpDown.Value;

            // Зчитування координат елемента матриці, введених користувачем
            int rowIndex = (int)rowNumericUpDown.Value;
            int columnIndex = (int)columnsNumericUpDown.Value;

            // Зчитування нового значення елемента, введеного користувачем
            

            if (int.TryParse(ValueTextBox.Text, out int newValue))
            {
                if (selectedIndex >= 0 && selectedIndex < matrixArray.Count)
                {
                    Matrica selectedMatrix = matrixArray[selectedIndex];

                    if (rowIndex >= 0 && rowIndex < selectedMatrix.RowCount() && columnIndex >= 0 && columnIndex < selectedMatrix.ColumnCount())
                    {
                        // Зміна значення елемента вибраної матриці
                        selectedMatrix.Set(rowIndex, columnIndex, newValue);

                        // Оновлення списку матриць
                        UpdateMatrixList();
                    }
                    else
                    {
                        MessageBox.Show("Координати редагованого елемента виходять за межі матриці!");
                        return;
                    }
                }
                else
                {
                    MessageBox.Show($"Порядковий номер не має виходити за межі розміру маcиву! Введіть правильний номер або виконайте додавання матриць до масиву,{Environment.NewLine}якщо масив порожній.");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Некоректне значення для елемента матриці! Спробуйте ще раз.");
                return;
            }
        }

        private void UpdateMatrixList()
        {
            // Очищення ListView
            matrixListView.Items.Clear();

            // Додавання кожної матриці до ListView
            foreach (Matrica matrix in matrixArray)
            {
                ListViewItem item = new ListViewItem(matrix.ToString());
                matrixListView.Items.Add(item);
            }
        }

        private void ResultMatrixList()
        {
            // Очищення ListView
            matrixListView2.Items.Clear();

            ListViewItem item = new ListViewItem(matrixResult.ToString());
            matrixListView2.Items.Add(item);
        }

        private void TransposeResultMatrixList()
        {
            // Очищення ListView
            matrixListView3.Items.Clear();

            ListViewItem item = new ListViewItem(matrixResult.ToString());
            matrixListView3.Items.Add(item);
        }

        private void ValueTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                return;
            }

            if (e.KeyChar == '-')
            {
                if (ValueTextBox.Text.IndexOf('-') != -1)
                {
                    e.Handled = true;
                }
                return;
            }

            if (Char.IsControl(e.KeyChar))
            {
                if (e.KeyChar == (char)Keys.Enter)
                    EditButton.Focus();
                return;
            }
            e.Handled = true;
        }
    }
}