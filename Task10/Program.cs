// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.WriteLine("Введите целое трехзначное число");
int a = Convert.ToInt32(Console.ReadLine());
int ten = a%100;
int twonumber = ten / 10;

Console.WriteLine("Вторая цифра числа - " + twonumber);
