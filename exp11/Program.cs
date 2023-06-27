// Нипишите программу, которая будет принимать на вход два чилса и выводить, является ли первое число 
// кратным второму. Если 1 не кратно числу 2, то программа выводить остаток от деления.

Console.WriteLine("Ввдите первое число ");
int firstNum=Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число ");
int secondNum=Convert.ToInt32(Console.ReadLine());

int Multiplicity(int num1, int num2)
{
    return num1 % num2;
}

int multiplicity = Multiplicity(firstNum, secondNum);
if (multiplicity == 0) Console.WriteLine("кратное");
else Console.WriteLine($"не кратно, остаток от деления равен {multiplicity}");