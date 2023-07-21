/*
Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/

void PrintNaturalNumbersFromNto1(int N)
{
    if (N <= 0)
    {
        return;
    }

    Console.Write($"{N} ");
    PrintNaturalNumbersFromNto1(N - 1);
}

int N = 5;
Console.Write("N = " + N + " -> ");
PrintNaturalNumbersFromNto1(N);