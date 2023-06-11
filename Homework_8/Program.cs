/*
Задача 8
Напишите программу, которая на вход принимает число N, а на выходе показывает
все четные числа от 0 до N
*/

Console.Write("Input number: ");
int N = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i < N+1; i=i+2)
{
    Console.Write(i);
}