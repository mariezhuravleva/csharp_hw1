/*
Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.
[3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76
*/

double[] GetRandomArray(int length)
{
    double[] result = new double[length];
    for (int i = 0; i < length; i++)
    {
        result[i] = new Random().NextDouble();
    }
    return result;
}

void PrintArray(double[] arrayToPrint)
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

double DifferenceBetweenMaxAndMinInArray(double[] array)
{
    double min = array[0];
    double max = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
        }
        if (array[i] > max)
        {
            max = array[i];
        }
    }
    return max - min;
}

double[] array = GetRandomArray(10);
PrintArray(array);
Console.WriteLine($"Difference between maximum and minimum elements: {DifferenceBetweenMaxAndMinInArray(array)}");