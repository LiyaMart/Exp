// Нипишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23. 

Console.WriteLine("Введите целое число ");
int number=Convert.ToInt32(Console.ReadLine());

bool Multiplicity(int num)
{
   return num % 7 == 0 && num % 23 == 0;
}

bool multiplicity = Multiplicity(number);
string resultStr = multiplicity ? "кратно" : "не кратно";

Console.WriteLine ($"{number} - {resultStr}");