// Напишите программу, замены элементов массива: положительные элементы замените на соответствующие отрицательные,
// и наоборот.

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

int[] ChangeNum(int[] a)
{
    for (int i = 0; i < a.Length; i++)
    {
        a[i] = - a[i];        
    }
    return a;
}


int [] array = CreateArrayRndInt(4, -8, 8);
PrintArray(array);

int[] ar = ChangeNum(array);
PrintArray(ar);