/*
Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/

int[,] FillSpiralArray(int n)
{
    int[,] spiralArray = new int[n, n];

    int rowStart = 0;
    int rowEnd = n - 1;
    int colStart = 0;
    int colEnd = n - 1;
    int count = 1;

    while (count <= n * n)
    {
        for (int i = colStart; i <= colEnd; i++)
        {
            spiralArray[rowStart, i] = count++;
        }
        rowStart++;

        for (int i = rowStart; i <= rowEnd; i++)
        {
            spiralArray[i, colEnd] = count++;
        }
        colEnd--;

        for (int i = colEnd; i >= colStart; i--)
        {
            spiralArray[rowEnd, i] = count++;
        }
        rowEnd--;

        for (int i = rowEnd; i >= rowStart; i--)
        {
            spiralArray[i, colStart] = count++;
        }
        colStart++;
    }

    return spiralArray;
}

int n = 4;
int[,] spiralArray = FillSpiralArray(n);

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        Console.Write($"{spiralArray[i, j]:D2} ");
    }
    Console.WriteLine();
}