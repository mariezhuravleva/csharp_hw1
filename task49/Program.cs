/*
Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные,
и замените эти элементы на их квадраты.

Например, изначально массив выглядел вот так:
1 4 7 2
5 9 2 3
8 4 2 4
Новый массив будет выглядеть вот так:
1 4 49 2
25 9 4 9
64 4 4 4
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

int[,] ChangeMatrix(int[,] arrayToUpdate)
{
    for (int i = 0; i < arrayToUpdate.GetLength(0); i++)
    {
        for (int j = 0; j < arrayToUpdate.GetLength(1); j++)
        {
            if(i % 2 == 0 && j % 2 == 0)
            {
                arrayToUpdate[i,j] *= arrayToUpdate[i,j];
            }
        }
    }
    return arrayToUpdate;
}

int[,] randomArray = GetRandom2DArray(3, 4, 10);
Print2DArray(randomArray);
Console.WriteLine();

int[,] changedArray = ChangeMatrix(randomArray);
Print2DArray(changedArray);