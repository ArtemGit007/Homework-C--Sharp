// Напишите программу, которая принимает на вход пятизначное число 
//и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да

int num,r,sum=0,t;
Console.WriteLine("Введите число");
Console.WriteLine("Является  ли введенное число палиндромом?");
num = Convert.ToInt32(Console.ReadLine());
for(t=num;num!=0;num=num/10)
    {
         r=num % 10;
         sum=sum*10+r;
    }
    if(t==sum)
    {
         Console.Write(" Это палиндром",t);
    }
    else
         Console.Write(" Это не палиндром",t);
