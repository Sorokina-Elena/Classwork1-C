/*
Задача 2
Напишите программу, которая на вход принимает два числа и выдает какое число большее, 
а какое - меньшее
*/

Console.WriteLine("Input number1 =>");
Console.WriteLine("Input number2 =>");

int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());

if(number2 > number1)
    {
    Console.WriteLine($"Max is {number2}");
    Console.WriteLine($"Min is {number1}");
    }
else
    {
    Console.WriteLine($"Max is {number1}");
    Console.WriteLine($"Min is {number2}");
    }