using System.Diagnostics;

namespace Search_HW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopwatch = Stopwatch.StartNew();


            //usage 100 thousand values
            //stopwatch.Start();
            //int[] largeRandomArr = GenerateRandomArray(10, 1, 1000000000);
            //stopwatch.Stop();
            //DisplayRuntime(stopwatch);

            stopwatch.Start();
            int[] largeSortedArr = GenerateArray(100000, 1);
            stopwatch.Stop();
            DisplayRuntime(stopwatch);

            //stopwatch.Start();
            //for (int i = 0; i < largeArr.Length; i++)
            //{
            //    Console.WriteLine(largeArr[i]);
            //}
            //stopwatch.Stop();
            //DisplayRuntime(stopwatch);

            Console.WriteLine();

            //stopwatch.Start();
            //Console.WriteLine("3 was found at index:" + Algorithms.LinearSearch<int>(largeRandomArr, 3));
            //stopwatch.Stop();
            //DisplayRuntime(stopwatch);

            stopwatch.Start();
            Console.WriteLine("3 was found at index:" + Algorithms.BinarySearch<int>(largeSortedArr, 0, largeSortedArr.Length - 1, 3));
            stopwatch.Stop();
            DisplayRuntime(stopwatch);

            static int[] GenerateArray(int numElements, int start)
            {

                int[] arr = new int[numElements];

                for (int i = 0; i < numElements; i++)
                {
                    arr[i] = 5;
                }


                return arr;
            }



            static int[] GenerateRandomArray(int numElements, int min, int max)
            {
                Random rand = new Random();
                int[] arr = new int[numElements];

                for (int i = 0; i < numElements; i++)
                {
                    arr[i] = rand.Next(min, max);
                }


                return arr;
            }


           

            static List<int> GenerateBigList(int size)
            {
                List<int> list = new List<int>();

                for (int i = 0; i < size; i++)
                {
                    list.Add(i);
                }

                return list;
            }

            List<int> nums = GenerateBigList(1000000000);

            int[] array = { 108, 23, 69, 420, 9 };
            int temporary;

            for (int j = 0; j <= array.Length - 2; j++)
            {
                for (int i = 0; i <= array.Length - 2; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        temporary = array[i + 1];
                        array[i + 1] = array[i];
                        array[i] = temporary;
                    }
                }
            }

            Console.WriteLine("Sorted:");
            foreach (int p in array)
            {
                Console.Write($"{p} ");
            }
            Console.ReadLine();
        }


        public int[] SortArray(int[] array, int length, Stopwatch stopwatch)
        {
            for (int i = 1; i < length; i++)
            {
                var key = array[i];
                var flag = 0;

                for (int j = i - 1; j >= 0 && flag != 1;)
                {
                    if (key < array[j])
                    {
                        array[j + 1] = array[j];
                        j--;
                        array[j + 1] = key;
                    }
                    else flag = 1;


                }
                for (int j = i - 1; j >= 0 && flag != 1;)
                {
                    if (key < array[j])
                    {
                        array[j + 1] = array[j];
                        j--;
                        array[j + 1] = key;
                    }
                    else flag = 1;
                }
                
            }

            DisplayRuntime(stopwatch);
            return array;
        }
            public int[] SortArray2(int[] array, int left, int right)
        {
            if (left < right)
            {
                int middle = left + (right - left) / 2;

        

               
            }

            return array;
        }
        public void MergeArray(int[] array, int left, int middle, int right, Stopwatch stopwatch)
        {
            var leftArrayLength = middle - left + 1;
            var rightArrayLength = right - middle;
            var leftTempArray = new int[leftArrayLength];
            var rightTempArray = new int[rightArrayLength];
            int i, j;

            for (i = 0; i < leftArrayLength; ++i)
                leftTempArray[i] = array[left + i];
            for (j = 0; j < rightArrayLength; ++j)
                rightTempArray[j] = array[middle + 1 + j];

            i = 0;
            j = 0;
            int k = left;

            while (i < leftArrayLength && j < rightArrayLength)
            {
                if (leftTempArray[i] <= rightTempArray[j])
                {
                    array[k++] = leftTempArray[i++];
                }
                else
                {
                    array[k++] = rightTempArray[j++];
                }
            }

            while (i < leftArrayLength)
            {
                array[k++] = leftTempArray[i++];
            }

            while (j < rightArrayLength)
            {
                array[k++] = rightTempArray[j++];
            }
            DisplayRuntime(stopwatch);
        }
        public int[] SortArray(int[] array, int leftIndex, int rightIndex, Stopwatch stopwatch)
        {
            var i = leftIndex;
            var j = rightIndex;
            var pivot = array[leftIndex];

            while (i <= j)
            {
                while (array[i] < pivot)
                {
                    i++;
                }

                while (array[j] > pivot)
                {
                    j--;
                }

                if (i <= j)
                {
                    int temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                    i++;
                    j--;
                }
            }

            

           

            return array;

            DisplayRuntime(stopwatch);
        }
        static void DisplayRuntime(Stopwatch stopwatch)
        {
            TimeSpan ts = stopwatch.Elapsed;

            // Format and display the TimeSpan value.
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                ts.Hours, ts.Minutes, ts.Seconds,
                ts.Milliseconds / 10);
            Console.WriteLine("Time Taken: " + elapsedTime);
            stopwatch.Reset();
        }
    }
    }
    

