// Напишите программу, которая на вход принимает два числа и проверяет, 
// является ли первое число квадратом второго

Console.WriteLine("Введите первое число ");
int number_1; 
number_1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число ");
int number_2;
number_2 = Convert.ToInt32(Console.ReadLine());

if (number_2 == number_1*number_1)
{
    Console.WriteLine("true");
}
else
{
    Console.WriteLine("false");
}