/*
Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
Пример для массива из 5, а не 123 элементов. В своем решении сделайте для 123
[5, 18, 123, 6, 2] -> 1
[1, 2, 3, 6, 2] -> 0
[10, 11, 12, 13, 14] -> 5
*/

// int[] FillArray(int size, int deviation) // also prints it out
// {
//     int[] result = new int[size];
//     for (int i = 0; i < size; i++) {
//         result[i] = new Random().Next(-deviation, deviation + 1);
//     }
//     PrintArray(result);
//     return result;
// }

// void PrintArray(int[] array) {
//     Console.Write("[");
//     for (int i = 0; i < array.Length; i++) {
//         if (i == array.Length - 1){
//             Console.WriteLine($"{array[i]}]");
//         }
//         else {
//             Console.Write($"{array[i]}, ");
//         }
//     }
// }

// int AmountOfNumbersInRange10To99 (int[] array)
// {

//     int amount = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if ((array[i] >= 10) && (array[i] < 100))
//         {
//             amount++;
//         }
//     }

//     return amount;
// }

// System.Console.WriteLine($"Amount of numbers in range [10, 99] is {AmountOfNumbersInRange10To99(FillArray(123, 1000))}");

int[] GenerateRandomArray(int length)
{
    int[] array = new int[length];
    Random random = new Random();

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(1, 201);
    }

    return array;
}

int CountElementsInRange(int[] array, int start, int end)
{
    int count = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] >= start && array[i] <= end)
        {
            count++;
        }
    }

    return count;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if (i < array.Length - 1)
        {
            Console.Write(", ");
        }
    }
    Console.WriteLine("]");
}

int[] array = GenerateRandomArray(123);
PrintArray(array);

int startRange = 10;
int endRange = 99;
int countInRange = CountElementsInRange(array, startRange, endRange);

Console.WriteLine($"Number of elements in the range [{startRange}, {endRange}]: {countInRange}");
