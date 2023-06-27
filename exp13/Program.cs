// Нипишите программу, которая принимает на вход два чилса и проверяет, является ли одно число квадратом
// другого.

Console.Write("Ввидите первое число ");
int number1=Convert.ToInt32(Console.ReadLine());

Console.Write("Ввидите второе число ");
int number2=Convert.ToInt32(Console.ReadLine());

bool Squ(int num1, int num2)
{
    return num1 * num1 == num2 || num2 * num2 == num1;
}

bool squ = Squ(number1, number2);
Console.WriteLine(squ ? "является" : "не является");
