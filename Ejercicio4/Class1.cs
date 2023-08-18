using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    internal class Matrix
    {
        public readonly List<List<int>> numbers;
        int n, m;
        public Matrix(int m, int n)
        {
            this.n = n;
            this.m = m;
            numbers = new List<List<int>>();
            populate();
        }

        private void populate()
        {
            Random randomNumber = new Random();

            for (int i = 0; i < m; i++)
            {
                List<int> row = new List<int>();
                for (int j = 0; j < n; j++)
                {
                    row.Add(randomNumber.Next(1, 1000));
                }
                numbers.Add(row);
            }
        }

        public override string ToString()
        {
            string matrix = "";

            foreach (List<int> row in numbers)
            {
                foreach (int number in row)
                {
                    string spaces;
                    if (number < 10)
                    {
                        spaces = "   ";
                    }
                    else if (number < 100)
                    {
                        spaces = "  ";
                    }
                    else
                    {
                        spaces = " ";
                    }
                    matrix += number + spaces;
                }
                matrix += "\n";
            }
            return matrix;
        }

        public string ToSaveDB()
        {
            string matrix = "";

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {

                    matrix += numbers[i][j];
                    if (j != n - 1)
                    {
                        matrix += ".";
                    }
                }
                if (i != m - 1)
                {
                    matrix += "-";
                }

            }
            return matrix;
        }

        public void sort()
        {
            int temp;
            List<int> tempList = new List<int>();
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    tempList.Add(numbers[i][j]);
                }
            }
            sortList(tempList);
            temp = 0;
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    numbers[i][j] = tempList[temp++];
                }
            }
        }

        public void sortList(List<int> row)
        {
            int temp, length = row.Count;
            bool swapped;
            for (int i = 0; i < length - 1; i++)
            {
                swapped = false;
                for (int j = 0; j < length - i - 1; j++)
                {

                    if (row[j] > row[j + 1])
                    {
                        temp = row[j];
                        row[j] = row[j + 1];
                        row[j + 1] = temp;
                        swapped = true;
                    }
                }

                if (swapped == false)
                    break;
            }

        }

        public void reverse()
        {
            foreach (List<int> row in numbers)
            {
                row.Reverse();
            }
            numbers.Reverse();
        }

    }
}
