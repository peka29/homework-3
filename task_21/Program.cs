﻿// Задача 21 Напишите программу, которая принимает на вход координаты двух 
// точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Clear();
Console.Write("введите координаты первой точки x1 = ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("введите координаты первой точки y1 = ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("введите координаты первой точки z1 = ");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.Write("введите координаты второй точки x2 = ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("введите координаты второй точки y2 = ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("введите координаты второй точки z2 = ");
int z2 = Convert.ToInt32(Console.ReadLine());

Console.Write(Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y2 - y2, 2) + Math.Pow(z1 - z2, 2)));