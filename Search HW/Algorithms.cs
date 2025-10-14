using System;
using System.Collections.Generic;
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
        }
    }

