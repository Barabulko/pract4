// See https://aka.ms/new-console-template for more information
Console.WriteLine("task25");

/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)

2, 4 -> 16*/

Console.Write("enter base: ");
int basenumber = int.Parse(Console.ReadLine());
Console.Write("enter power: ");
int power = int.Parse(Console.ReadLine());
int result = 1;

for (int i=1; i<=power; i++)
{
    result*=basenumber;
}

Console.WriteLine($"result = {result}");