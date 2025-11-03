using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Search_HW
{
    public class Algorithms
    {
       
        
            List<int> algorithms;

            public static int LinearSearch<T>(T[] arr, T searchTerm) where T : IComparable<T>
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i].Equals(searchTerm))
                    {
                        return i;
                    }
                }
                return -1;
            }

            public static int BinarySearch<T>(T[] arr, int low, int high, T searchTerm) where T : IComparable<T>
            {

                int mid = low + ((high - low) / 2);

                if (high >= low)
                {
                    if (arr[mid].Equals(searchTerm))
                    {
                        return mid;
                    }



                    if (arr[mid].CompareTo(searchTerm) < 0)
                    {
                        return BinarySearch(arr, low, mid - 1, searchTerm);
                    }


                    return BinarySearch(arr, mid + 1, high, searchTerm);


                }




                return -1;
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
    

