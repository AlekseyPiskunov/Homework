/* 
    Задача 21 Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
*/

System.Console.WriteLine("Введите координаты первой точки ");
double x1 = Convert.ToInt32(Console.ReadLine());
double y1 = Convert.ToInt32(Console.ReadLine());
double c1 = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите координаты второй точки ");
double x2 = Convert.ToInt32(Console.ReadLine());
double y2 = Convert.ToInt32(Console.ReadLine());
double c2 = Convert.ToInt32(Console.ReadLine());

double lengthGet(double a1, double b1, double c1, double a2, double b2, double c2)
{
    return Math.Sqrt(Math.Pow((a1 - a2), 2) + Math.Pow((b1 - b2), 2) + Math.Pow((c1 - c2), 2));
}

Console.Write("Длина отрезка = ");
Console.Write(lengthGet(x1, y1, c1, x2, y2, c2));