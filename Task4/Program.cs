// Задача 4.
//Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Введите число - >");
int a = int.Parse(Console.ReadLine());

 int num = 1;
            while (num <= a)
            {
                int result = num % 2;
                if (result != 1)
                {
                    Console.WriteLine("четное " + num);
                    num++;
                }
                else
                {
                    num++;
                }
            }

