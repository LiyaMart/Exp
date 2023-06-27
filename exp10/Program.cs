// Наипишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.

int number = new Random().Next(100, 1000);
Console.WriteLine($"Случайное трехзначное число {number}");

int SecondDel(int num)
{
   int firstDig=num/100;
   int thirdDig=num%10;
   int result = firstDig*10 + thirdDig;
   return result;
}

int secondDel = SecondDel(number);
Console.WriteLine($"Новое число {secondDel}");
