/*
Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
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

void PrintMean(double[] arrayToPrint)
{
    Console.ForegroundColor = ConsoleColor.DarkMagenta;
    Console.WriteLine("----------------------------------------------");
    Console.Write("[M]\t");
    for (int i = 0; i < arrayToPrint.Length; i++)
    {
        Console.Write(arrayToPrint[i]);
        if (i != arrayToPrint.Length - 1)
        {
            Console.Write("\t");
        }
    }
    Console.WriteLine();
    Console.ForegroundColor = ConsoleColor.Black;
}

double[] FindMeanOfColumnInArray(int[,] arrayToCalculate)
{
    double[] meansOfColumns = new double[arrayToCalculate.GetLength(1)];
    for (int j = 0; j < arrayToCalculate.GetLength(1); j++)
    {
        double sumOfElements = 0;
        for (int i = 0; i < arrayToCalculate.GetLength(0); i++)
        {
            sumOfElements += arrayToCalculate[i, j];
        }
        meansOfColumns[j] = Math.Round(sumOfElements / arrayToCalculate.GetLength(0), 1);
    }
    return meansOfColumns;
}

int[,] array = GetRandom2DArray(3, 4, 10);
Print2DArray(array);
PrintMean(FindMeanOfColumnInArray(array));