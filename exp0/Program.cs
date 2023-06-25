// Напишите программу, которая на вход принимат число и выдает его квадрат (число уноженное на самл себя)

Console.Write("Введите число ");
long number =Convert.ToInt64(Console.ReadLine());
long square = number*number;
Console.WriteLine($"Квадрат числа {number} = {square}");