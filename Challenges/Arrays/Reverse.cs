namespace Challenges.Arrays
{
    public class Reverse
    {
        public static int[] ReverseArray(int[] arr)
        {
            for (int i = 0; i < arr.Length / 2; i++)
            {
                int tmp = arr[i];
                arr[i] = arr[arr.Length - i - 1];
                arr[arr.Length - i - 1] = tmp;
            }
            return arr;
        }
    }
}