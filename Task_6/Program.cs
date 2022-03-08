//Найти расстояние между точками в пространстве 2D. 3D﻿
double Distance( int a1, int b1, int c1, int a2, int b2, int c2)
{
    double S = Math.Sqrt(Math.Pow((a2 - a1),2) + Math.Pow((b2 - b1),2) + Math.Pow((c2 - c1),2));
    return S;
}
Console.WriteLine("Расстояние между двумя точками в 2D");
Console.WriteLine("Введите координаты точки A: ");
int x1 = Convert.ToInt32(Console.ReadLine());
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты точки B: ");
int x2 = Convert.ToInt32(Console.ReadLine());
int y2 = Convert.ToInt32(Console.ReadLine());

double Dist = Distance( x1, y1, 0, x2, y2, 0);
Console.WriteLine($"Расстояние между точками A и B: {Dist}");

Console.WriteLine("Расстояние между двумя точками в 3D");
Console.WriteLine("Введите координаты точки A: ");
int x3 = Convert.ToInt32(Console.ReadLine());
int y3 = Convert.ToInt32(Console.ReadLine());
int z3 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты точки B: ");
int x4 = Convert.ToInt32(Console.ReadLine());
int y4 = Convert.ToInt32(Console.ReadLine());
int z4 = Convert.ToInt32(Console.ReadLine());

double D = Distance( x3, y3, z3, x4, y4, z4);
Console.WriteLine($"Расстояние между точками A и B: {D}");
