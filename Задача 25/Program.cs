// Задача 25: Напишите цикл, который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B. (без использования Math.Pow)

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Введите число A: ");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число B: ");
int numberB =  Convert.ToInt32(Console.ReadLine());

int expon = numberA;

  
    for (int i = 1; i < numberB; i++)
    {
        expon = expon * numberA;
    }
    
Console.WriteLine(" A в степени В равно:"  + expon);
