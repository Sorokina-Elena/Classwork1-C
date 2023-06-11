/*
Задача 6
Напишите программу, которая принимает на вход число и выдает, является ли оно четным 
(делится ли оно на 2 без остатка)
*/

Console.Write("Введите число ");
int number = Convert.ToInt32(Console.ReadLine());

if (number%2 == 0)
{
   Console.WriteLine("является четным числом");
}
else
{
    Console.WriteLine("является нечетным числом");
}