/*
Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив: 
8 4 2 4
5 9 2 3
1 4 7 2
*/
int[,] GetRandom2DArray(int rowNumber, int colNumber, int deviation)
{
    int[,] result = new int[rowNumber, colNumber];
    for (int i = 0; i < rowNumber; i++)
    {
        for (int j = 0; j < colNumber; j++)
        {
            result[i, j] = new Random().Next(-deviation, deviation + 1);
        }
    }
    return result;
}

void SwapFirstAndLastRow(int[,] array)
{
    int rows = array.GetLength(0);
    int cols = array.GetLength(1);

    for (int j = 0; j < cols; j++)
    {
        int temp = array[0, j];
        array[0, j] = array[rows - 1, j];
        array[rows - 1, j] = temp;
    }
}

void Print2DArray(int[,] arrayToPrint)
{
    Console.Write($"[ ]\t");
    for (int i = 0; i < arrayToPrint.GetLength(1); i++)
    {
        Console.Write($"[{i}]\t");
    }
    Console.WriteLine();
    for (int i = 0; i < arrayToPrint.GetLength(0); i++)
    {
        Console.Write($"[{i}]\t");
        for (int j = 0; j < arrayToPrint.GetLength(1); j++)
        {
            Console.Write(arrayToPrint[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

int[,] array = GetRandom2DArray(3, 4, 10);

Console.WriteLine("Original Array:");
Print2DArray(array);

SwapFirstAndLastRow(array);

Console.WriteLine("Array after swapping first and last rows:");
Print2DArray(array);