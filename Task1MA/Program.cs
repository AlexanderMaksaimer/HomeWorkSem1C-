// Задача 1. Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
//пример: a = 5; b = 7 -> max = 7 a = 2 b = 10 -> max = 10 a = -9 b = -3 -> max = -3

Console.WriteLine("Введите число 'A' - >");
int numA = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число 'B' - >");
int numB = int.Parse(Console.ReadLine());
if (numA > numB)
{
    Console.WriteLine(numA);
    Console.Write("Число А больше чем число B");
}
else
{
    Console.WriteLine(numB);
    Console.Write("Число B больше чем число A");
}

