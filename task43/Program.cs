/*
Напишите программу, которая найдёт точку пересечения двух прямых,
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
значения b1, k1, b2 и k2 задаются пользователем.

x = (b2 - b1) / (k1 - k2)
y = k1 * x + b1

k1 = 5, b1 = 2, k2 = 9, b2 = 4 -> (-0,5; -0,5)
*/

void GetPointOfCrossing(double k1, double b1, double k2, double b2)
{
    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * x + b1;
    Console.WriteLine($"The point of crossing is: ({x}; {y}).");
}

Console.WriteLine("We have two lines described by equations: y = k1 * x + b1, y = k2 * x + b2.");

Console.WriteLine("Enter value of k1:");
int k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter value of b1:");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter value of k2:");
int k2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter value of b2:");
int b2 = Convert.ToInt32(Console.ReadLine());

GetPointOfCrossing(k1, b1, k2, b2);