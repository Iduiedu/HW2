// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.WriteLine("Введите целое положительное число");
int Number = Convert.ToInt32(Console.ReadLine());
string stringNumber = Convert.ToString(Number);

if (stringNumber.Length > 2)
{
    Console.WriteLine("Третья цифра числа - " + stringNumber[2]);
}
else
{
    Console.WriteLine("третьей цифры нет");
}

