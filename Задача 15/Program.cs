// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет

Console.WriteLine("Введите день недели: ");
int день_недели
 = Convert.ToInt32(Console.ReadLine());
switch (день_недели)
{
    case 1:
        Console.WriteLine($"{день_недели} -> рабочий день");
        break;
    case 2:
        Console.WriteLine($"{день_недели} -> рабочий день");
        break;
    case 3:
         Console.WriteLine($"{день_недели} -> рабочий день");
         break;
    case 4:
        Console.WriteLine($"{день_недели} -> рабочий день");
        break;
    case 5:
        Console.WriteLine($"{день_недели} -> рабочий день");
        break;
    case 6:
         Console.WriteLine( $"{день_недели} -> выходной");
         break;
    case 7:
         Console.WriteLine($"{день_недели} -> выходной");
         break;
    case 8:
         Console.WriteLine("Такого дня недели нет");
         break;
}











