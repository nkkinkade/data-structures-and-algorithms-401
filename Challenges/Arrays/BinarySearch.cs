using System;
using System.Collections.Generic;
using System.Text;

namespace Challenges.Arrays
{
    public class BinarySearch
    {
        public static int Search(int[] arr, int searchValue)
        {
            int minPosition = 0;
            int maxPosition = arr.Length - 1;
                while (minPosition <= maxPosition)
            {
                int midPosition = (minPosition + maxPosition) / 2;
                if (searchValue == arr[midPosition])
                {
                    return midPosition;
                }
                else if (searchValue < arr[midPosition])
                {
                    maxPosition = midPosition - 1;
                }
                else
                {
                    minPosition = midPosition + 1;
                }
            }
            return -1;
        }
    }
}
