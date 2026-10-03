using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace WinFormsAppMergeSortPersonalAssigment
{
    public partial class Form1 : Form
    {
        private double[] originalArray;
        private double[] processedArray;

        public Form1()
        {
            InitializeComponent();

            button_GenerateArray.Click += button_GenerateArray_Click;
            button_Sort.Click += button_Sort_Click;
            button_Clear.Click += button_Clear_Click;
        }

        private void button_GenerateArray_Click(object sender, EventArgs e)
        {
            int size = (int)numericUpDown_SizeOfArray.Value;
            originalArray = new double[size];
            Random rand = new Random();

            for (int i = 0; i < size; i++)
            {
                double val = Math.Round(rand.NextDouble() * 100 - 50, 1);
                originalArray[i] = val;
            }

            textBox_ArrayAtFirst.Text = string.Join(", ", originalArray);

            textBox_ArrayFunc.Clear();
            textBox_SortedArray.Clear();
            textBox_Time.Clear();
            richTextBox_Steps.Clear();
        }

        private void button_Sort_Click(object sender, EventArgs e)
        {
            if (originalArray == null || originalArray.Length == 0)
            {
                MessageBox.Show("Спершу згенеруйте масив!", "Попередження", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            processedArray = (double[])originalArray.Clone();
            richTextBox_Steps.Clear();

            for (int i = 0; i < processedArray.Length; i++)
            {
                if (processedArray[i] < 0)
                {
                    processedArray[i] = Math.Sin(processedArray[i]);
                }
            }

            textBox_ArrayFunc.Text = string.Join(", ", processedArray);

            Stopwatch stopwatch = Stopwatch.StartNew();

            MergeSort(processedArray, 0, processedArray.Length - 1);

            stopwatch.Stop();

            textBox_SortedArray.Text = string.Join(", ",processedArray);
            textBox_Time.Text = stopwatch.Elapsed.ToString(@"hh\:mm\:ss\.ffffff");
        }

        private void MergeSort(double[] arr, int left, int right)
        {
            if (left < right)
            {
                int mid = left + (right - left) / 2;

                string subArrayStr = string.Join(", ", arr[left..Math.Min(right + 1, arr.Length)]);

                richTextBox_Steps.AppendText($"Ділимо підмасив: {subArrayStr}\n");

                MergeSort(arr, left, mid);
                MergeSort(arr, mid + 1, right);

                Merge(arr, left, mid, right);
            }
        }

        private void Merge(double[] arr, int left, int mid, int right)
        {
            int n1 = mid - left + 1;
            int n2 = right - mid;

            double[] leftArr = new double[n1];
            double[] rightArr = new double[n2];

            Array.Copy(arr, left, leftArr, 0, n1);
            Array.Copy(arr, mid + 1, rightArr, 0, n2);

            int i = 0, j = 0;
            int k = left;

            while (i < n1 && j < n2)
            {
                if (leftArr[i] >= rightArr[j])
                {
                    arr[k] = leftArr[i];
                    i++;
                }
                else
                {
                    arr[k] = rightArr[j];
                    j++;
                }
                k++;
            }

            while (i < n1)
            {
                arr[k] = leftArr[i];
                i++;
                k++;
            }

            while (j < n2)
            {
                arr[k] = rightArr[j];
                j++;
                k++;
            }

            string mergedPart = string.Join(", ", arr[left..Math.Min(right + 1, arr.Length)]);
            richTextBox_Steps.AppendText($"Злили у відсортовану частину: {mergedPart}\n");
        }

        private void button_Clear_Click(object sender, EventArgs e)
        {
            textBox_ArrayAtFirst.Clear();
            textBox_ArrayFunc.Clear();
            textBox_SortedArray.Clear();
            textBox_Time.Clear();
            richTextBox_Steps.Clear();
            numericUpDown_SizeOfArray.Value = numericUpDown_SizeOfArray.Minimum;
            originalArray = null;
            processedArray = null;
        }

        private void label1_Click(object sender, EventArgs e) { }
    }
}