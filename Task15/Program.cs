// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.WriteLine("Введите порядковый номер дня недели (от 1 до 7)");
int index = Convert.ToInt32(Console.ReadLine());
if (index<=5)

    {
        Console.WriteLine("Это будний день");
    }
if (index>5)

    {
        Console.WriteLine("Это выходной");
    }
if (index>7)

    {
        Console.WriteLine("Число введено неверно, в неделе 7 дней!");
    }
