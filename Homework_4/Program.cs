/* Задача 4
Напишите программу, которая принимает на вход три числа
и выдает максимальное из этих чисел
*/

Console.WriteLine("Input number1 => ");
Console.WriteLine("Input number2 => ");
Console.WriteLine("Input number3 => ");

int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());
int number3 = Convert.ToInt32(Console.ReadLine());


if (number1 > number2)
{
    if (number1 > number3)
    {
        Console.WriteLine($"Max is {number1}");
    }
    else
    {
        Console.WriteLine($"Max is {number3}");
    }
}
else
{
    if (number2 > number3)
    {
         Console.WriteLine($"Max is {number2}");    
    }   
     else
    {
        Console.WriteLine($"Max is {number3}"); 
    }
    }


