// See https://aka.ms/new-console-template for more information
Console.WriteLine("task29");

/*Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

6, 1, 33 -> [6, 1, 33]*/

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i=0; i<array.Length-1; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.WriteLine($"{array[array.Length-1]}]");
}

void Test()
{
    int[] array1 = {1, 2, 5, 7, 19};
    PrintArray(array1);
    int[] array2 = {6, 1, 33};
    PrintArray(array2);
}

Test();