// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.WriteLine("Введите целое число:");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе целое число:");
int num2 = Convert.ToInt32(Console.ReadLine());

int max = num1;

if (num2 > max) max = num2;

Console.Write("max = ");
Console.Write(max);