﻿// Нипишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23. 

Console.WriteLine("Введите целое число ");
int number=Convert.ToInt32(Console.ReadLine());

bool Multiplicity(int num, int num1, int num2)
{
   return num % num1 == 0 && num % num2 == 0;
}

bool multiplicity = Multiplicity(number, 7, 23);
string resultStr = multiplicity ? "кратно" : "не кратно";

Console.WriteLine ($"{number} - {resultStr}");