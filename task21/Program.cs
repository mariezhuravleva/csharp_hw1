/*
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/

Console.WriteLine("Enter X of point A: ");
int AX = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter Y of point A: ");
int AY = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter Z of point A: ");
int AZ = Convert.ToInt32(Console.ReadLine());


Console.WriteLine("Enter X of point B: ");
int BX = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter Y of point B: ");
int BY = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter Z of point B: ");
int BZ = Convert.ToInt32(Console.ReadLine());

double result = Math.Sqrt((AX-BX)*(AX-BX)+(AY-BY)*(AY-BY)+(AZ-BZ)*(AZ-BZ));

Console.WriteLine($"Distance is {result}");