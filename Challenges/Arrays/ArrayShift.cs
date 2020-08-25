using System;
using System.Collections.Generic;
using System.Text;

namespace Challenges.Arrays
{
    public class ArrayShift
    {
        public static int[] ShiftArray(int[] arr, int num)
            {
            int[] shiftedArray = new int[arr.Length + 1];
            int mid = shiftedArray.Length / 2;
            for (int i =0; i < mid; i++)
            {
                shiftedArray[i] = arr[i];
            }
            shiftedArray[mid] = num;
            for (int i = mid+1; i < shiftedArray.Length; i++)
            {
                shiftedArray[i] = arr[i - 1];
            }
            return shiftedArray;
        }
    }
}
