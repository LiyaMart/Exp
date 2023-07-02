// Напишите программу, которая приимает на вход число (А) и выдает сумму чисел от 1 до А.

// Console.Write("Введите натуральное число ");
// int number = Convert.ToInt32(Console.ReadLine());

// int SumNumbers(int n)
// {
//     int sum = 0;
//     for (int i = 1; i<=n; i++)
//     {
//         sum = sum + i;
//     }
//     return sum;
// }

// if (number<=0) Console.WriteLine("Натуральное число, please!");
// else
// {
//     int sumNumbers = SumNumbers(number);
//     Console.WriteLine($"Сумма чисел от 1 до {number} равна {sumNumbers}");
// }

// Напишите программу, которая приимает на вход число и выдает сумму цифр в числе.

// Console.Write("Напишите число ");
// int number = Convert.ToInt32(Console.ReadLine());

// int SumDit(int n)
// {
//     int sum = 0;
//     while (n != 0)
//     {
//         sum = sum + 1;
//         n = n / 10;
//     }
//     return sum == 0 ? 1 : sum;
// }

// int sumDit = SumDit(number);
// Console.WriteLine($"Сумма цифр в числе {number} равна {sumDit}");

// Напишите программу, которая приимает на вход число (N) и выдает произведение чисел от 1 до N.

// Console.Write("Введите натуральное число ");
// int number = Convert.ToInt32(Console.ReadLine());

// int MultNum(int n)
// {
//     int mult = 1;
//     for (int i = 1; i <= n; i++)
//     {
//         mult = mult*i;
//     }
//     return mult;
// }

// if (number<=0) Console.WriteLine("Натуральное число, please");
// else 
// {
//     int multNum = MultNum(number);
//     Console.WriteLine($"Произведение чисел от 1 до {number} равна {multNum}");
// }

// Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.


void FillArray(int[] a)
{
    for (int i = 0; i < a.Length; i++)
    {
        a[i] = new Random().Next(0,2);
    }
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i == (arr.Length -1)) Console.Write($"{arr[i]}"); 
        else Console.Write($"{arr[i]}, ");
    }
    Console.Write("]");
}

int [] array = new int[8];
FillArray(array);
PrintArray(array);