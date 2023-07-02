// Напишите программу, которая принимает на вход число (N) и выадет таблицу кубов чисел от 1 до N.

Console.Write("Введите натуральное число ");
int number = Convert.ToInt32(Console.ReadLine());

void PrintCube(int n)
{
   for (int i=1; i<=n; i++)
    {
        Console.Write($"{Math.Pow(i,3)} ");
    }
}

PrintCube(number);