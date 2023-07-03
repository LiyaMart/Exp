// Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат 
// в отрезке [10, 99]

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

int SumDig(int[] a)
{
    int sum = 0;
    for (int i = 0; i < a.Length; i++)
    {
        if(a[i]>=10 && a[i]<=99) sum = sum + 1;        
    }
    return sum;
}

int [] array = CreateArrayRndInt(123, -100, 200);
PrintArray(array);

Console.WriteLine($"Количество элементов массива, значения которых лежат в отрезке [10, 99], равно {SumDig(array)}");