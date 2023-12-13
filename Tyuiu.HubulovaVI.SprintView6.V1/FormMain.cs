using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.HubulovaVI.SprintView6.V1.Lib;

namespace Tyuiu.HubulovaVI.SprintView6.V1
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void textBoxRows_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != ',') && (e.KeyChar != 8) && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }
        }

        DataService dataService = new DataService();
        public int[,] array;
        public int N, M;

        private void buttonGetMulti_Click(object sender, EventArgs e)
        {
            int n1 = int.Parse(textBoxRandomStart.Text);
            int n2 = int.Parse(textBoxRandomStop.Text);
            int k = int.Parse(textBoxSumStart.Text);
            int l = int.Parse(textBoxSumStop.Text);
            int c = int.Parse(textBoxColum_C.Text);
            if (k > l || c > M) { MessageBox.Show("Введены неверные значения для подсчёта произведения", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            textBoxResult.Text = Convert.ToString(dataService.result(array, n1, n2, c, k, l));
        }

        private void buttonViewMatrix_Click(object sender, EventArgs e)
        {
            N = int.Parse(textBoxRows.Text);
            M = int.Parse(textBoxColumns.Text);
            int n1 = int.Parse(textBoxRandomStart.Text);
            int n2 = int.Parse(textBoxRandomStop.Text);
            array = new int[N, M];
            if (n1 >= n2) { MessageBox.Show("Введены неверные значения для генерации случайных чисел", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            else
            {
                int[,] matrix = dataService.GetMatrix(array, n1, n2);

                dataGridViewMatrix.RowCount = N; dataGridViewMatrix.ColumnCount = M;
                for (int i = 0; i < M; i++)
                {
                    dataGridViewMatrix.Columns[i].Width = 25;
                }
                for (int i = 0; i < N; i++)
                {
                    for (int j = 0; j < M; j++)
                    {
                        dataGridViewMatrix.Rows[i].Cells[j].Value = array[i, j];
                    }
                }
            }



        }
    }
}