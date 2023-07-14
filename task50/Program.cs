/*
Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет
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
            Console.Write(arrayToPrint[i,j] + "\t");
        }
        Console.WriteLine();
    }
}

void IsInMatrix(int rowNumber, int colNumber, int[,] arrayToSearch)
{
    if (rowNumber < arrayToSearch.GetLength(0) && colNumber < arrayToSearch.GetLength(1))
    {
        Console.WriteLine($"The value of element [{rowNumber}, {colNumber}]: {arrayToSearch[rowNumber,colNumber]}");
    }
    else
    {
    Console.WriteLine("There's no such element.");
    }
}

int[,] array = GetRandom2DArray(5, 6, 10);
Print2DArray(array);

Console.WriteLine("Enter row:");
int row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter column:");
int column = Convert.ToInt32(Console.ReadLine());

IsInMatrix(row, column, array);