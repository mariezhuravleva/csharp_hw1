/*
Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
M = 1; N = 5. -> "1, 2, 3, 4, 5"
M = 4; N = 8. -> "4, 5, 6, 7, 8"
*/

void PrintNumbersInRange(int start, int end)
{
    if (start <= end)
    {
        Console.Write(start);
        if (start != end)
        {
            Console.Write(", ");
        }
        PrintNumbersInRange(start + 1, end);
    }
}

int M = 1;
int N = 5;
PrintNumbersInRange(M, N);