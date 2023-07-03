// Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и
// предпоследний и т.д. Результат запишите в новом массиве.

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

int[] FillNewArray(int[] a)
{
    int size;
    if  (a.Length%2 == 0) size = a.Length/2;
    else size = a.Length/2+1;

    int[] ar = new int[size];
    
    for (int i = 0; i < a.Length/2; i++)
    {
        ar[i] = a[i] * a[(a.Length-1-i)];        
    }
    if  (a.Length % 2 != 0) ar[ar.Length-1] = a[a.Length/2];

    return ar;
}

int [] array = CreateArrayRndInt(4, 0, 10);
PrintArray(array);
int [] newArray = FillNewArray(array);
PrintArray(newArray);