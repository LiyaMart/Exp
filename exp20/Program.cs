// Напишите программу, которая на вход принимает число (N) и выдает таблицу квадратов чисел от 1 до N.

Console.Write("Введите натуральное число ");
int n = Convert.ToInt32(Console.ReadLine());

void Quarter(int num)
{
    for (int i = 1; i <= num; i++)
    {
        Console.Write($"{i * i} ");
    }
}

if (n<1) Console.WriteLine("Натуральное чило, please!");
else Quarter(n);