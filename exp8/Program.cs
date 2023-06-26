// Напишите программу, которая на вход принимает число (N), и выдает, а на выходе показывает все
// все четные числа от 1 до N.

Console.Write("Введиете натуральное число ");
int n = Convert.ToInt32(Console.ReadLine());

if (n<=0) Console.WriteLine("Натуральное число, please!");

int count = 1;

while (count<=n)
{
    if (count % 2 == 0)
    Console.Write($"{count}, ");
    count++;
}