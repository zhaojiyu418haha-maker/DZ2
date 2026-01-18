using System;
namespace Pro
{
    class Program
    {
        static void Yasuozhuzu(int[] arr)
        {
            int index = arr.Length;
            for (int i = 0; i < arr.Length - 1; i++) 
            {
                if (arr[i + 1] == arr[i])
                {
                    index--;
                }
            }
            int[] arr2 = new int[index];
            int index2 = 0;
            for (int m = 0; m < arr.Length - 1; m++) 
            {
                if (arr[m + 1] != arr[m])
                {
                    arr2[index2] = arr[m];
                    index2++;
                }
            }
            arr2[index - 1] = arr[arr.Length - 1];
            for(int n = 0; n < index; n++)
            {
                Console.Write(arr2[n]);

            }
        }



        static void Main()
        {
            int[] arr = { 1, 1, 1, 1, 2, 3, 3, 4, 4, 4, 5, 5, 5, 5, 6, 6, 6, 6, 7, 8, 9, 10 };
            Yasuozhuzu(arr);

        }
    }
}




