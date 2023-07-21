/*
Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

int SumOfNaturalNumbersInRange(int m, int n)
{
    if (m == n)
    {
        return m;
    }
    if (m < n)
    {
        return m + SumOfNaturalNumbersInRange(m + 1, n);
    }
    else
    {
        return m + SumOfNaturalNumbersInRange(m - 1, n);
    }
}

Console.Write("Enter M: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter N: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Sum of natural numbers between {m} and {n}: {SumOfNaturalNumbersInRange(m, n)}");