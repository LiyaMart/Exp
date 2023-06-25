// Напишите программу, которая на вход принимает трехзначное число и 
// на выходе показывает последнюю цифру этого числа.

Console.WriteLine("Введите трехзначное число");

int number = Convert.ToInt32(Console.ReadLine());

if (number<1000 && number>99)
{
    Console.WriteLine(number%10);
}
else
{
    Console.WriteLine("Вы ввели число отличное от трехзначного!");
}
