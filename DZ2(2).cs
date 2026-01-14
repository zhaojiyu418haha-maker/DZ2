using System;

class Program
{
    static void Main()
    {
        // 模拟：数组容量10，实际填充5个元素
        int[] arr = new int[10];
        int count = 10;

        // 初始化前5个元素
        for (int i = 0; i < count; i++)
        {
            arr[i] = i * 10; // 示例数据：0, 10, 20, 30, 40
        }

        Console.WriteLine("начальный массив：");
        PrintArray(arr, count);

        // 添加新元素
        Console.Write("пишите новое эленмен：");
        int newElement = int.Parse(Console.ReadLine());

        AddElement(ref arr, ref count, newElement);

        Console.WriteLine("массив после того ,что добавлять：");
        PrintArray(arr, count);
    }

    static void AddElement(ref int[] array, ref int count, int element)
    {
        if (count < array.Length)
        {
            // 还有空间，直接添加
            array[count] = element;
            count++;
            Console.WriteLine($"элемент {element} добавляется в конце");
        }
        else
        {
            // 数组已满，创建新数组（2倍大小）
            Console.WriteLine("в массиве нет места，создавать новое（х2）");
            int newSize = array.Length * 2;
            int[] newArray = new int[newSize];

            // 复制原数组元素
            for (int i = 0; i < count; i++)
            {
                newArray[i] = array[i];
            }

            // 添加新元素
            newArray[count] = element;
            count++;

            // 替换原数组
            array = newArray;
            Console.WriteLine($"обьём нового массива：{newSize}，эленмент {element} добавился");
        }
    }

    static void PrintArray(int[] array, int count)
    {
        Console.Write("Элемент：[");
        for (int i = 0; i < count; i++)
        {
            Console.Write(array[i]);
            if (i < count - 1) Console.Write(", ");
        }
        Console.WriteLine($"] (count={count}, capacity={array.Length})");
    }
}