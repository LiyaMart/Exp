// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// Console.Write("Введите набор чисел (через пробел) ");
// int[] array = Array.ConvertAll(Console.ReadLine().Trim().Split(" "), int.Parse);

// int SumDig(int[] a)
// {
//     int sum = 0;
//     for (int i = 0; i < a.Length; i++)
//     {
//         if (a[i]>0) sum=sum+1;
//     }
//     return sum;
// }

// int result = SumDig(array);
// Console.WriteLine($"Чисел больше 0 -> {result}");

// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, 
// y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("Задайте значения параметром уравнения y = k1 * x + b1");
Console.Write("b1 = ");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("k1 = ");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("b2 = ");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.Write("k2 = ");
double k2 = Convert.ToInt32(Console.ReadLine());

double EquPointX(double b1P, double k1P, double b2P, double k2P)
{
    double x = (b2P-b1P)/(k1P-k2P); 
    return Math.Round(x, 1);
}

double EquPointY(double b1Point, double k1Point, double xPoint)
{
    double y = k1Point*xPoint + b1Point; 
    return Math.Round(y, 1);
}

double x = EquPointX(b1, k1, b2, k2);
double y = EquPointY(b1, k1, x);

Console.WriteLine($"Прямые пересекаются в точке ({x}; {y})");