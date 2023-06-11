/*
Задача №1. Напишите программу, которая на вход принимает два числа и проверяет, 
является ли первое число квадратом второго.
a = 25, b = 5->да
a = 2, b = 10->нет
a = 9, b = -3->да
a = -3 b = 9->нет
*/

Console.WriteLine("Input number1 =>");
Console.WriteLine("Input number2 =>");

int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());

int power = 2; // power of number
if(number1 == Math.Pow(number2, power))
    {
    Console.Write($"square {number2} is {number1}");
    }
else
    {
    Console.Write($"square {number2} isn't {number1}");
    }
