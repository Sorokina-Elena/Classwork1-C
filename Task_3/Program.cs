/* Напишиете программу, которая будет выдавать название дня недели по заданному номеру:

3 -> среда
5 -> пятница

*/

Console.Write("Input number");
int n = Convert.ToInt32(Console.ReadLine());

Dictionary<int, string> number = new Dictionary<int, string>()
{
{1, "Monday"},
{2, "Tuesday"},
{3, "Wednesday"},
{4, "Thursday"},
{5, "Friday"},
{6, "Saturday"},
{7, "Sunday"}
};

if(n > 0 && n < 8)
{
    Console.WriteLine(number[n]);
}
else
{
   Console.WriteLine("Ошибка"); 
}