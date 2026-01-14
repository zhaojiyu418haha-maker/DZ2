using System;

class Program
{
    static void array2(params int[]arr)
    {
        int[] arr2 = new int[arr.Length];


        for (int a = 0; a < arr.Length; a++)
        {
            arr2[a] = arr[a];
            

        }
        Console.WriteLine("пишите ваше число");
            
        string about = Console.ReadLine();
        int numabout = int.Parse(about);
        int count = 0;
        for (int b = 0; b < arr.Length; b++)
        {
            if (arr2[b] != numabout)
            {
                count++;
            }
        }

        int arr3index = 0;
        int[] arr3 = new int[count];
        for(int c = 0; c < arr2.Length; c++)
        {
            if (arr2[c] != numabout)
            {
                arr3[arr3index] = arr2[c];
                arr3index++;
            }
        }
        for (int d = 0; d < arr3.Length; d++)
        {
            Console.WriteLine(arr3[d]);

        }


    }




    static void array(params int[] arr)
    {
        int[] arr2 = new int[10];


        for (int a = 0; a < arr.Length; a++)
        {
            arr2[a] = arr[a];
            Console.WriteLine(arr2[a]);

        }
        int[] arr3 = new int[4];
        for (int b = 3; b >= 0; b--)
        {
            arr3[b] = arr2[b + 1];

        }
        for (int m = 0; m < arr3.Length; m++)
        {
            Console.WriteLine(arr3[m]);
        }

    }



    static void Main()
    {
        //模拟：数组容量10，实际填充5个元素
        array(1, 2, 3, 4, 5);

        array2(1, 2, 2, 3, 3, 3, 4, 4, 4, 4, 5, 5, 5, 5, 5);

       
    }

    
}