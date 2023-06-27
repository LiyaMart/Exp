// Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую
// цифру числа.

int MaxDigit(int num)
{
   int firstDigit = num/10;
   int secondDigit = num%10;
   if (firstDigit>secondDigit) return firstDigit;
   return secondDigit;    
}

int number = new Random().Next(10,100);
Console.WriteLine($"Случайоное число из отрезка [10, 99] - {number}");

int maxDigit = MaxDigit(number);

Console.WriteLine($"Нибольшая цифра числа равна {maxDigit}");