/*
Напишите программу, которая будет создавать копию 
заданного одномерного массива с помощью поэлементного копирования.
*/

int[] array = { 1, 3, 8, 3, 4, 2 };
int[] copiedArray = new int[array.Length];

for (int i = 0; i < array.Length; i++)
{
    copiedArray[i] = array[i];
}

for (int i = 0; i < array.Length; i++)
{
    Console.Write(copiedArray[i]);
    if (i < array.Length - 1)
    {
        Console.Write(", ");
    }
}

Console.WriteLine();