 //Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
//456 -> 5
//782 -> 8
//918 -> 1


Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
if(num < 100)
{
    Console.WriteLine($"{num} -> не соответствует условиям задачи");
}
else if(num < 10)
{
    Console.WriteLine($"{num} -> не соответствует условиям задачи");
}
else
{
   string second = Convert.ToString(num);
   char md = second[1];
   Console.WriteLine($"{num} -> {md}");
}
