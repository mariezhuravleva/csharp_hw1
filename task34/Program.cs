/*
Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
Пример:
[345, 897, 568, 234] вывод -> 2
*/
void PrintArray(int[] arrayToPrint)
{
    Console.ForegroundColor = ConsoleColor.DarkMagenta;
    Console.Write("[");
    for (int i = 0; i < arrayToPrint.Length; i++)
    {
        Console.Write(arrayToPrint[i]);
        if (i != arrayToPrint.Length - 1)
        {
            Console.Write(", ");
        }
    }
    Console.WriteLine("]");
    Console.WriteLine("--------------------------");
    Console.ForegroundColor = ConsoleColor.Black;
}

int[] GetRandomArray(int length)
{
    int[] result = new int[length];
    for (int i = 0; i < length; i++)
    {
        result[i] = new Random().Next(100, 1000);
    }
    return result;
}

int CountEven(int[] array)
{
    int evenCount = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            evenCount++;
        }
    }
    return evenCount;
}

int[] array = GetRandomArray(10);
PrintArray(array);
Console.WriteLine($"Number of even numbers: {CountEven(array)}");