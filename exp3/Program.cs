// Напишите программу, которая на вход принимает одно целое число (N),
// а на выход показывает все целые числа в промежутке от -N до N.

Console.WriteLine("Введите целое натуральное число");

int n = Convert.ToInt32(Console.ReadLine());
int count = n*(-1);
while (count <= n)
{
    Console.Write($"{count}, ");
    count = count + 1;
}
