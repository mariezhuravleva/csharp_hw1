/* Задайте значение N. Напишите программу, 
которая выведет все натуральные числа в промежутке от 1 до N
N = 5 -> "1, 2, 3, 4, 5"
N = 6 -> "1, 2, 3, 4, 5, 6" */

void PrintNaturalNumbers(int N, int currentNumber = 1)
{
    Console.Write(currentNumber);
    if (currentNumber != N)
    {
        Console.Write(", ");
        PrintNaturalNumbers(N, currentNumber + 1);
    }
}

int N = 5;
Console.Write("N = " + N + " -> ");
PrintNaturalNumbers(N);