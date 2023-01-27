// Напишите  на вход принимает два числа и выдает, программу, которая показывает какое число большее, а какое меньшее.
// Например:
// a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3

Console.WriteLine("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
int max = 0; 

if (a > b) 
{
    max = a; 
    Console.WriteLine("max = " + max);
} 

else if (a < b) 
{
    max = b; 
    Console.WriteLine("max = " + max);
} 
 else 
{
    Console.WriteLine("Числа равны");
}
