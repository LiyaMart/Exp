// Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму
// отрицательных и положительных элементов массива.

int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] a = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < a.Length; i++)
    {
        a[i] = rnd.Next(min, (max+1));      
    }
    return a;
}

void PrintArray(int [] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i == arr.Length - 1) Console.Write(arr[i]);
        else Console.Write($"{arr[i]}, ");
    }
    Console.Write("]");
    Console.WriteLine();
}

int SumNegative(int[] a)
{
    int sum = 0;
    for (int i = 0; i < a.Length; i++)
    {
        if(a[i]<0) sum = sum + a[i];        
    }
    return sum;
}


int SumPositive(int[] ar)
{
    int sum = 0;
    for (int i = 0; i < ar.Length; i++)
    {
        if(ar[i]>0) sum = sum +ar[i];        
    }
    return sum;
}

int [] array = CreateArrayRndInt(12, -9, 9);
PrintArray(array);

int sumNegative = SumNegative(array);
int sumPositive = SumPositive(array);

Console.WriteLine($"Сумма отрицательных чисел равна {sumNegative}");
Console.WriteLine($"Сумма положительных чисел равна {sumPositive}");