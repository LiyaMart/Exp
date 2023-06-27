// Напишите программу, которая  принимает на вход цифру, обазначающую день недели, и проверяет, является
// ли этот день выходным.

Console.Write("Введите цифру ");
int number=Convert.ToInt32(Console.ReadLine());

bool Weekend(int num)
{
   return num==6 || num==7;
}

bool weekend = Weekend(number);
Console.WriteLine(weekend ? "Является" : "Не является");