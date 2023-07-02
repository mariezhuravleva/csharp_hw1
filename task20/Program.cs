/*
Напишите программу, которая принимает
на вход координаты двух точек и находит
расстояние между ними в 2D пространстве.

A (3,6); B (2,1) -> 5,09
A (7,-5); B (1,-1) -> 7,21

*/

Console.WriteLine("Enter X of point A: ");
int AX = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter Y of point A: ");
int AY = Convert.ToInt32(Console.ReadLine());


Console.WriteLine("Enter X of point B: ");
int BX = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter Y of point B: ");
int BY = Convert.ToInt32(Console.ReadLine());

double result = Math.Sqrt((AX-BX)*(AX-BX)+(AY-BY)*(AY-BY));

Console.WriteLine($"Distance is {result}");