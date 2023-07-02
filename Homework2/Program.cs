// Напишите программу, которая на вход принимает координаты двух точек и находит расстояние между ними в 3D
// пространстве.

Console.WriteLine("Введите координаты первой точки: ");
Console.Write("x1 ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("y1 ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("z1 ");
int z1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты второй точки: ");
Console.Write("x2 ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("y2 ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("z2 ");
int z2 = Convert.ToInt32(Console.ReadLine());

double Distance(int x, int y, int z, int xx, int yy, int zz)
{
    return Math.Sqrt(Math.Pow((x-xx),2) + Math.Pow((y-yy),2) + Math.Pow((z-zz),2));
}

double distance = Math.Round(Distance(x1, y1, z1, x2, y2, z2), 2, MidpointRounding.ToZero);
Console.WriteLine(distance);