// Напишите программу, которая по заданному номеру четверти показывает координаты точек в этой четверти (Х, Y)

Console.Write("Введите номер четверти ");
int quarter=Convert.ToInt32(Console.ReadLine());

string Range(int q)
{
    if (q==1) return "х>0 и y>0";
    if (q==2) return "x<0 и y>0";
    if (q==3) return "Х<0 и y<0";
    if (q==4) return "х>0 и y<0";
    return "Введен некорректный номер четверти";
}

string range=Range(quarter);
Console.WriteLine(range);
