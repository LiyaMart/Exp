// Задайте массив. Напишите программу, которая отпределяет, присутствует ли заданное число в массиве.

int[] array = {1, 5, 7, 8};

Console.Write("Задайте число ");
int number = Convert.ToInt32(Console.ReadLine());

bool Choose(int[] a, int n)
{
    for (int i = 0; i < a.Length; i++)
    {
       if (a[i] == n) return true;        
    }
    return false;
}

Console.Write(Choose(array, number) ? "Присутствует" : "Отсутствует");