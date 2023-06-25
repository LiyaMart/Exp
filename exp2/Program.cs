// Напишите программу, которая будет выдавать название дня недели по заданному номеру.

Console.WriteLine("Введите номер дня недели");
int number = Convert.ToInt32(Console.ReadLine());

if (number == 1) Console.WriteLine("monday");
if (number == 2) Console.WriteLine("tuesday");
if (number == 3) Console.WriteLine("wendsday");
if (number == 4) Console.WriteLine("tusday");
if (number == 5) Console.WriteLine("friday");
if (number == 6) Console.WriteLine("sunday");
if (number == 7) Console.WriteLine("saturday");
if (number > 7) Console.WriteLine("не является номером дня недели");
if (number < 1) Console.WriteLine("не является номером дня недели");