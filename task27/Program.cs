// See https://aka.ms/new-console-template for more information
Console.WriteLine("task27");

/*Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11

82 -> 10

9012 -> 12*/

int NumberSumm(int number)
{
    int result = 0;
    string line = number.ToString();
    for (int i=0; i<line.Length; i++)
    {
        result+=int.Parse($"{line[i]}");
    }
    return result;
}

void Test()
{
    Console.WriteLine($"452 -> {NumberSumm(452)}");
    Console.WriteLine($"82 -> {NumberSumm(82)}");
    Console.WriteLine($"9012 -> {NumberSumm(9012)}");
}

Test();