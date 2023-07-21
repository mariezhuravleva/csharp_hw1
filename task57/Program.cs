/*
Составить частотный словарь элементов двумерного массива. Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных
{ 1, 9, 9, 0, 2, 8, 0, 9 }
0 встречается 2 раза
1 встречается 1 раз
2 встречается 1 раз
8 встречается 1 раз
9 встречается 3 раза

1, 2, 3
4, 6, 1
2, 1, 6
1 встречается 3 раза
2 встречается 2 раза
3 встречается 1 раз
4 встречается 1 раз
6 встречается 2 раза
*/

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

/*void FrequencyDictionary(int[,] array)
{
    Dictionary<int, int> frequencyDict = new Dictionary<int, int>();

    int rows = array.GetLength(0);
    int cols = array.GetLength(1);

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            int element = array[i, j];
            if (frequencyDict.ContainsKey(element))
            {
                frequencyDict[element]++;
            }
            else
            {
                frequencyDict[element] = 1;
            }
        }
    }

    Console.WriteLine("Frequency Dictionary:");

    var dictEnumerator = frequencyDict.GetEnumerator();
    while (dictEnumerator.MoveNext())
    {
        var kvp = dictEnumerator.Current;
        Console.WriteLine($"{kvp.Key} встречается {kvp.Value} раза");
    }
}*/

void FrequencyDictionary(int[,] array)
{
    int rows = array.GetLength(0);
    int cols = array.GetLength(1);
    int maxElement = FindMaxElement(array);
    int[] frequencies = new int[maxElement + 1];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            int element = array[i, j];
            frequencies[element]++;
        }
    }

    Console.WriteLine("Frequency Dictionary:");

    for (int i = 0; i <= maxElement; i++)
    {
        if (frequencies[i] > 0)
        {
            Console.WriteLine($"{i} встречается {frequencies[i]} раза");
        }
    }
}

int FindMaxElement(int[,] array)
{
    int maxElement = int.MinValue;
    int rows = array.GetLength(0);
    int cols = array.GetLength(1);

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            if (array[i, j] > maxElement)
            {
                maxElement = array[i, j];
            }
        }
    }

    return maxElement;
}

int[,] GenerateRandomArray(int rows, int cols, int minValue, int maxValue)
{
    int[,] array = new int[rows, cols];
    Random random = new Random();

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            array[i, j] = random.Next(minValue, maxValue + 1);
        }
    }

    return array;
}

int[,] array = GenerateRandomArray(3, 3, 0, 9);

Console.WriteLine("Array:");
Print2DArray(array);
FrequencyDictionary(array);

Console.WriteLine();