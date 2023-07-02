// Напишите программу, которая принимает на вхот пятизначное число и проверяет, является ли оно палидромом.

Console.Write("Введите пятизначное число ");
int number = Convert.ToInt32(Console.ReadLine());

int[] Array(int n)
{
    int [] array = new int[5];
    int i = array.Length-1;
    while (i>=0)
    {
        array[i] = n%10;
        n = n/10;
        i--;
    }
    return array;
} 

bool Poly(int[] arr)
{
    return arr[0] == arr[4] && arr[1] == arr[3];
}

bool poly=Poly(Array(number));

Console.WriteLine(poly);
