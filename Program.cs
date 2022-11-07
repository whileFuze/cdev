using System;

class MainClass
{
    /*static string ShowColor(string username, int useage)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Console.WriteLine("{0}, {1}\n Введите цвет: ", username, useage);
        string color = Console.ReadLine();

        switch (color)
        {
            case "red":
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.Black;

                Console.WriteLine("Your color is red!");
                break;

            case "green":
                Console.BackgroundColor = ConsoleColor.Green;
                Console.ForegroundColor = ConsoleColor.Black;

                Console.WriteLine("Your color is green!");
                break;
            case "cyan":
                Console.BackgroundColor = ConsoleColor.Cyan;
                Console.ForegroundColor = ConsoleColor.Black;

                Console.WriteLine("Your color is cyan!");
                break;
            default:
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.ForegroundColor = ConsoleColor.Red;

                Console.WriteLine("Your color is yellow!");
                break;
        }
        return color;

    }*/
    static int[] GetArrayFromConsole(int num = 5)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        var result = new int[num];

        for (int i = 0; i < result.Length; i++)
        {
            Console.WriteLine("Введите элемент массива номер {0}", i + 1);
            result[i] = int.Parse(Console.ReadLine());
        }

        return result;
    }
    static int[] SortArrayAsc(int[] unsortedArray)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        int temp = 0;
        for (int i = 0; i < unsortedArray.Length; i++)
            for (int j = i + 1; j < unsortedArray.Length;)
                if (unsortedArray[i] > unsortedArray[j])
                {
                    temp = unsortedArray[i];
                    unsortedArray[i] = unsortedArray[j];
                    unsortedArray[j] = temp;
                }

        return unsortedArray;
    }
    static int[] SortArrayDesc(int[] unsortedArray)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        int temp = 0;
        for (int i = 0; i < unsortedArray.Length; i++)
            for (int j = i + 1; j < unsortedArray.Length; j++)
                if (unsortedArray[i] < unsortedArray[j])
                {
                    temp = unsortedArray[j];
                    unsortedArray[j] = unsortedArray[i];
                    unsortedArray[i] = temp;
                }

        return unsortedArray;
    }
    static void SortArray(int[] array, out int[] sorteddesc, out int[] sortedasc)
    {
        sortedasc = SortArrayAsc(array);
        sorteddesc = SortArrayDesc(array);

    }
    
    static void ShowArray(int[] arr, bool IsSorted = true)
    {

        Console.OutputEncoding = System.Text.Encoding.UTF8;
        var temp = arr;
        if (IsSorted == true) SortArrayDesc(temp);
        foreach (int i in temp) Console.WriteLine(i);
    }
    static void Main()
    {
        int[] arr1 = GetArrayFromConsole();
        arr1 = SortArray(arr1);
        ShowArray(arr1);
    }
}
