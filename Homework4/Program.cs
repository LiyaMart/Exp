// Напишите цикл, который на вход принимает два числа (А и В) и возводит число А в натуральную степень В.

Console.WriteLine("Введите два натуральных числа:");
Console.Write("a - ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("b - ");
int b = Convert.ToInt32(Console.ReadLine());

int DegreeNum(int n, int d)
{
    int mult = 1;
    for (int i = 1; i <= d; i++)
    {
        mult = mult*n;
    }
    return mult;
}

if (a<0 || b<0) Console.WriteLine("Натуральное число, please!");
else
    {
        int degreeNum = DegreeNum(a, b);
        Console.WriteLine($"Число {a} в степени {b} равна {degreeNum}");
    }
// Напишите программу, которая принимает на вход число и выдает сумму цифр в числе

// Console.Write ("Введите число ");
// int number = Convert.ToInt32(Console.ReadLine());

// int SumDig(int n)
// {
//     int sum = 0;
//     while (n != 0)
//     {
//         sum = sum + Math.Abs(n%10);
//         n = n/10;
//     }
//     return sum == 0 ? 0 : sum;
// }

// int sumDig = SumDig(number);
// Console.WriteLine($"Сумма цифр числа {number} равна {sumDig}");

// Напишите программу, которая задает массив из 8 элементов, заполненный псевдослучайными числами и выводит их на
// экран.

// void FillArray(int[] a)
// {
//     for (int i = 0; i < a.Length; i++)
//     {
//         a[i] = new Random().Next(0, 100);    
//     }
// }

// void PrintArray(int [] arr)
// {
//     Console.Write("[");
//     for (int i = 0; i < arr.Length; i++)
//     {
//         if (i == arr.Length - 1) Console.Write(arr[i]);
//         else Console.Write($"{arr[i]}, ");
//     }
//     Console.Write("]");
// }

// int [] array = new int[8];
// FillArray(array);
// PrintArray(array);