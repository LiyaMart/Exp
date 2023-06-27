// Наипшите программу, которая принимает на вход трехзначное чило и на выходе показывет вторую цифру
// этого числа.

Console.Write("Введите трехзначное число ");
int number=Convert.ToInt32(Console.ReadLine());

int SecondDig(int num)
{
    return num/10%10;
}

if (number>999 || number<100) Console.WriteLine("Трехзначное число, please");

else
{
    int secondDig=SecondDig(number);
    Console.WriteLine($"Вторая цифра числа равна - {secondDig}");    
}