// Напишите программу, которая перевернет одномерный массив (последний элемент будет на первом месте, а первый на
// на последнем).

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

// void ReverseArray (int [] a)
// {
//     for (int i = 0; i < a.Length/2; i++)
//     {
//         int save = a[i];
//         a[i] = a[a.Length-1-i];
//         a[a.Length-1-i] = save;
//     }
// }

// int [] array = FillArray(4, 100, 999);
// PrintArray(array);
// ReverseArray(array);
// PrintArray(array);

// Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с
// сторонами такой длины.

// Console.WriteLine("Введите стороны треугольника:");
// Console.Write("AB - ");
// int ab = Convert.ToInt32(Console.ReadLine());
// Console.Write("BC - ");
// int bc = Convert.ToInt32(Console.ReadLine());
// Console.Write("AC - ");
// int ac = Convert.ToInt32(Console.ReadLine());

// bool Triangle(int a, int b, int c)
// {
//     if (a+b>c && a+c>b && b+c>a) return true;
//     return false; 
// }

// bool triangle = Triangle(ab, ac, bc);
// Console.WriteLine(triangle ? "Треугольник сущетсвует" : "Треугольник не существует");

// Напишите программу, которое преобразовывает десятичное число в двоичное.

// Console.Write("Введите десятичное число -> ");
// int number = Convert.ToInt32(Console.ReadLine());

// string ConvertDecBin(int n)
// {
//     string bin = string.Empty;
//     for (int i = 0; n > 0; i++)
//     {
//         int res = n%2;
//         bin = res + bin;
//         n = n/2;
//     }
//     return bin;
// }

// string bin = ConvertDecBin(number);
// Console.WriteLine($"В двоичном представлении -> {bin}");

// Не используя рекурсию, выведите первые N чисел Фибоначи. Первые два числа Фибоначчи: 0 и 1.

// int[] Fibonacci(int n)
// {
//     int[] array = new int[n];
//     array[1] = 1;
//     for (int i = 2; i < array.Length; i++)
//     {
//         array[i] = array[i-1] + array[i-2];
//     }
//     return array;
// } 

// void PrintArray(int[] arr)
// {
//         for (int i = 0; i < arr.Length; i++)
//     {
//         Console.Write($"{arr[i]} ");
//     }
//     Console.WriteLine();
// }

// int[] array = Fibonacci(5);
// PrintArray(array);

// Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.

int[] FillArray(int size, int min, int max)
{
    int[] a = new int[size];
    Random rnd = new Random();
        for (int i = 0; i < a.Length; i++)
    {
        a[i] = rnd.Next(min, max+1);      
    }
    return a;
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i != arr.Length-1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}]");
    }
    Console.WriteLine();
}

int[] CopyArray(int[] a)
{
    int[] array = new int[a.Length];
    for (int i = 0; i < a.Length; i++)
    {
        array[i] = a[i];      
    }
    return array;
}

int[] array = FillArray(6, -100, 100);
PrintArray(array);
int[] copyArray = CopyArray(array);
PrintArray(copyArray);