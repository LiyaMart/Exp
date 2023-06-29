// Напишите программу, которая на вход принимает координаты двух точек и находит расстояние между ними в 2D
// простанстве.

Console.WriteLine("Введите координаты первой точки:");
Console.Write("x1 = ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("y1 = ");
int y1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты второй точки:");
Console.Write("x2 = ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("y2 = ");
int y2=Convert.ToInt32(Console.ReadLine());

double DistancePoints(int x, int y, int xx, int yy)
{
    return Math.Sqrt(Math.Pow((x-xx), 2) + Math.Pow((y-yy), 2));
}

double distancePoints = Math.Round(DistancePoints(x1, y1, x2, y2), 2, MidpointRounding.ToZero);
Console.WriteLine($"Расстояние в 2D простанстве между точками равно {distancePoints}");