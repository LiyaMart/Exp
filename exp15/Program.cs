// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

int number = -1187764;

int ThirdDig(int num)
{
    int res = 0;
    while (Math.Abs(num)/100>0)
    {
        res = Math.Abs(num)%10;
        num = num/10;
    }
    return res;
}

if (number < 100 && number > -100) Console.WriteLine("Третьей цифры нет");

else
{
    int thirdDig = ThirdDig(number);
    Console.WriteLine($"Третья цифра числа равна {thirdDig}");
} 
    