// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет 
// количество чётных чисел в массиве.

// int[] FillArray(int size, int min, int max)
// {
//     int[] a = new int[size];
//     Random rnd = new Random();
//         for (int i = 0; i < a.Length; i++)
//     {
//         a[i] = rnd.Next(min, max+1);      
//     }
//     return a;
// }

// void PrintArray(int[] arr)
// {
//     Console.Write("[");
//     for (int i = 0; i < arr.Length; i++)
//     {
//         if (i != arr.Length-1) Console.Write($"{arr[i]}, ");
//         else Console.Write($"{arr[i]}]");
//     }
//     Console.WriteLine();
// }
// int SumEvenDig(int [] a)
// {
//     int sum = 0;
//     for (int i = 0; i < a.Length; i++)
//     {
//         if (a[i]%2==0) sum=sum+1;
//     }
//     return sum;
// }

// int [] array = FillArray(5, 100, 999);
// PrintArray(array);
// Console.WriteLine($"Количество четных чисел в массиве равно {SumEvenDig(array)}");

// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// int[] FillArray(int size, int min, int max)
// {
//     int[] a = new int[size];
//     Random rnd = new Random();
//     for (int i = 0; i < a.Length; i++)
//     {
//         a[i] = rnd.Next(min, max+1);
//     }
//     return a;
// }

// void PrintArray(int [] arr)
// {
//     Console.Write("[");
//     for (int i = 0; i < arr.Length; i++)
//     {
//         if (i==arr.Length-1) Console.Write($"{arr[i]}]");
//         else Console.Write($"{arr[i]}, ");
//     }
//     Console.WriteLine();
// }

// int SumUnevenNum(int[] a)
// {
//     int sum = 0;
//     for (int i = 0; i < a.Length; i++)
//     {
//         if (i%2 != 0) sum = sum +a[i];
//     }
//     return sum;
// }

// int[] array = FillArray(5, -100, 100);
// PrintArray(array); 
// Console.WriteLine($"Cумма элементов, стоящих на нечётных позициях равна {SumUnevenNum(array)}");

// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементами массива.

double[] FillArray(int size, int min, int max)
{
    double[] a = new double[size];
    Random rnd = new Random();
        for (int i = 0; i < a.Length; i++)
    {
        a[i] = Math.Round(rnd.NextDouble()*(max-min)+min, 1);      
    }
    return a;
}

void PrintArray(double[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i != arr.Length-1) Console.Write($"{arr[i]}  ");
        else Console.Write($"{arr[i]}]");
    }
    Console.WriteLine();
}

double MaxArrayNum(double[] a)
{
    double max = a[0];
    for (int i = 0; i < a.Length; i++)
    {
        if (a[i]>max) max = a[i];
    }
    return Math.Round(max, 1);
}

double MinArrayNum(double[] a)
{
    double min = a[0];
    for (int i = 0; i < a.Length; i++)
    {
        if (a[i]<min) min = a[i];
    }
    return Math.Round(min, 1);
}

double[] array = FillArray(5, -100, 100);
PrintArray(array);
double res = Math.Round((MaxArrayNum(array) - MinArrayNum(array)), 1);
Console.WriteLine($"Разница между max и min элементами массива равна {res}");