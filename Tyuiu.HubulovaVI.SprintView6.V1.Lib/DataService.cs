using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyuiu.HubulovaVI.SprintView6.V1.Lib
{
    public class DataService
    {
        public double result(int[,] array, int n1, int n2, int c, int k, int l)
        {
            int rows = array.GetUpperBound(0) + 1;
            int cols = array.GetUpperBound(1) + 1;
            

            double sum = 0;

            for (int i = k; i <= l; i++)
            {
                sum += array[i, c];
            }
            return Math.Round(sum, 3);
        }
        public int[,] GetMatrix(int[,] array, int n1, int n2)
        {
            int rows = array.GetUpperBound(0) + 1;
            int cols = array.GetUpperBound(1) + 1;
            
            Random rnd = new Random();
            int[] temp = new int[rows];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    temp[j] = rnd.Next(n1, n2);
                }
                Array.Sort(temp);
                for (int j = 0; j < cols; j++)
                {
                    array[i, j] = temp[j];
                }
            }
            return array;
        }
    }
}
