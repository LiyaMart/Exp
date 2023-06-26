// Напишите программу, которая на вход принимает число и выдает, является ли число четным.

Console.Write("Введите число ");
int number = Convert.ToInt32(Console.ReadLine());

if (number % 2 == 0)
{
    Console.WriteLine("является");
}
else Console.WriteLine("не является");