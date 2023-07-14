/*
Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
*/

double[,] GetRandomDouble2DArray(int rowNumber, int colNumber)
{
    double[,] result = new double[rowNumber, colNumber];
    for (int i = 0; i < rowNumber; i++)
    {
        for (int j = 0; j < colNumber; j++)
        {
            result[i, j] = Math.Round((new Random().NextDouble()) * 10, 2);
        }
    }
    return result;
}

void PrintDouble2DArray(double[,] arrayToPrint)
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

double[,] randomArray = GetRandomDouble2DArray(5, 4);
PrintDouble2DArray(randomArray);