using System;
using System.Diagnostics;

namespace myProgram
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int[] array;
        private Stopwatch stopwatch = new Stopwatch();
        private void generateButton_Click(object sender, EventArgs e)
        {
            int size = int.Parse(SizeArrayTextBox.Text);
            array = GenerateRandomArray(size);
            DisplayArray(array, textBox1);
        }
        private int[] GenerateRandomArray(int size)
        {
            Random random = new Random();
            int[] randomArray = new int[size];
            for (int i = 0; i < size; i++)
            {
                randomArray[i] = random.Next(1, 100);
            }
            return randomArray;
        }

        private void DisplayArray(int[] array, TextBox textBox)
        {
            string result = string.Join(", ", array);
            textBox.Text = result;
        }

        private void CountingSort(int[] arr)
        {
            int max = arr[0];
            int min = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }
            int range = max - min + 1;
            int[] countArray = new int[range];

            listBoxIterations.Items.Clear();
            listBoxIterations.Items.Add("Source array:");
            listBoxIterations.Items.Add(string.Join(" ", arr));

            listBoxIterations.Items.Add("The iterations of sorting:");
            listBoxIterations.Items.Add("Iteration 0:");

            listBoxIterations.Items.Add(string.Join(" ", countArray));
            for (int i = 0; i < arr.Length; i++)
            {
                countArray[arr[i] - min]++;
                listBoxIterations.Items.Add($"Iteration {i + 1}:");
                listBoxIterations.Items.Add(string.Join(" ", countArray));
            }

            int currentIndex = 0;

            for (int i = 0; i < range; i++)
            {
                while (countArray[i] > 0)
                {
                    arr[currentIndex] = i + min;
                    countArray[i]--;
                    currentIndex++;
                }
            }
            listBoxIterations.Items.Add("The sorted array:");
            listBoxIterations.Items.Add(string.Join(" ", arr));
        }

        private void PancakeSort(int[] array)
        {
            int n = array.Length;

            listBoxIterations.Items.Clear();
            listBoxIterations.Items.Add("Source array:");
            listBoxIterations.Items.Add(string.Join(" ", array));
            listBoxIterations.Items.Add("The iterations of sorting:");

            for (int currentSizeArray = n; currentSizeArray > 1; currentSizeArray--)
            {
                int maxIndex = FindMaxIndex(array, currentSizeArray);

                if (maxIndex != currentSizeArray - 1)
                {
                    listBoxIterations.Items.Add("Iteration: " + (n - currentSizeArray + 1));
                    listBoxIterations.Items.Add("The max element: " + array[maxIndex]);

                    listBoxIterations.Items.Add("Flip to the element with the maximum value:");
                    Flip(array, maxIndex);
                    listBoxIterations.Items.Add(string.Join(" ", array));

                    listBoxIterations.Items.Add("Flip the rest of the array:");
                    Flip(array, currentSizeArray - 1);
                    listBoxIterations.Items.Add(string.Join(" ", array));
                }
            }
            listBoxIterations.Items.Add("The sorted array:");
            listBoxIterations.Items.Add(string.Join(" ", array));
        }

        private int FindMaxIndex(int[] arr, int n)
        {
            int maxIndex = 0;
            for (int i = 0; i < n; i++)
            {
                if (arr[i] > arr[maxIndex])
                {
                    maxIndex = i;
                }
            }
            return maxIndex;
        }
        private void Flip(int[] arr, int index)
        {
            int start = 0;
            while (start < index)
            {
                int temp = arr[start];
                arr[start] = arr[index];
                arr[index] = temp;
                start++;
                index--;
            }
        }

        private void PigeonholeSort(int[] arr)
        {
            listBoxIterations.Items.Clear();
            Dictionary<int, int> counter = new Dictionary<int, int>();
            for (int i = 0; i < arr.Length; i++)
            {
                int num = arr[i];
                if (counter.ContainsKey(num))
                {
                    counter[num]++;
                }
                else
                {
                    counter[num] = 1;
                }

                listBoxIterations.Items.Add("Iteration " + (i + 1) + ":");
                listBoxIterations.Items.Add("Source array: " + string.Join(" ", arr));
                listBoxIterations.Items.Add("Number of elements:");
                PrintCountsToListBox(counter);
            }

            int index = 0;
            foreach (var keyValue in counter)
            {
                for (int j = 0; j < keyValue.Value; j++)
                {
                    arr[index] = keyValue.Key;
                    index++;
                }
            }

            listBoxIterations.Items.Add("The sorted array: " + string.Join(" ", arr));
        }
        private void PrintCountsToListBox(Dictionary<int, int> counter)
        {
            foreach (var keyValue in counter)
            {
                listBoxIterations.Items.Add(keyValue.Key + ":" + keyValue.Value);
            }
            listBoxIterations.Items.Add("");
        }

        private void sortButton_Click(object sender, EventArgs e)
        {
            if (countingSortRadioButton.Checked)
            {
                stopwatch.Reset();
                stopwatch.Start();
                CountingSort(array);
                stopwatch.Stop();

            }
            else if (pancakeSortRadioButton.Checked)
            {
                stopwatch.Reset();
                stopwatch.Start();
                PancakeSort(array);
                stopwatch.Stop();
            }
            else if (pigeonholeSortRadioButton.Checked)
            {
                stopwatch.Reset();
                stopwatch.Start();
                PigeonholeSort(array);
                stopwatch.Stop();
            }

            DisplayArray(array, textBox2);
            timeLabel.Text = "Taken time: " + stopwatch.ElapsedMilliseconds + " ms";

        }

        private void infoButtonCountingSort_Click(object sender, EventArgs e)
        {
            CountingSortInfoForm countingSortInfoForm = new CountingSortInfoForm();
            countingSortInfoForm.ShowDialog();
        }

        private void infoButtonPancakeSort_Click(object sender, EventArgs e)
        {
            PancakeSortInfoForm pancakeSortInfoForm = new PancakeSortInfoForm();
            pancakeSortInfoForm.ShowDialog();
        }

        private void infoButtonPigeonSort_Click(object sender, EventArgs e)
        {
            PigeonholeSortInfoForm pigeonholeSortInfoForm = new PigeonholeSortInfoForm();
            pigeonholeSortInfoForm.ShowDialog();
        }

        private void compareAnalyseButton_Click(object sender, EventArgs e)
        {
            CompareAnalyseForm compareAnalyseForm = new CompareAnalyseForm();
            compareAnalyseForm.ShowDialog();
        }
    }
}