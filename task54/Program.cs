﻿/*
Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
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

void SortArrayDescending(int[,] arrayToSort)
{
    for (int i = 0; i < arrayToSort.GetLength(0); i++)
    {
        for (int j = 0; j < arrayToSort.GetLength(1) - 1; j++)
        {
            for (int k = 0; k < arrayToSort.GetLength(1) - j - 1; k++)
            {
                if (arrayToSort[i,k] < arrayToSort[i,k + 1])
                {
                    int temp = arrayToSort[i, k];
                    arrayToSort[i, k] = arrayToSort[i, k + 1];
                    arrayToSort[i, k + 1] = temp;
                }
            }
        }
    }
}

int[,] array = GetRandom2DArray(3,5,10);
Print2DArray(array);

Console.WriteLine();

SortArrayDescending(array);
Print2DArray(array);