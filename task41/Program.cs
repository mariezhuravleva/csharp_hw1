/*
Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/

int CountPositiveNumbers(int amountOfNumbers)
{
    int count = 0;
    for (int i = 0; i < amountOfNumbers; i++)
    {
        Console.WriteLine($"Enter number {i + 1}:");
        int number = Convert.ToInt32(Console.ReadLine());

        if (number > 0)
        {
            count++;
        }
    }
    return count;
}

Console.WriteLine("Enter amount of numbers:");
int amount = Convert.ToInt32(Console.ReadLine());

int positiveCount = CountPositiveNumbers(amount);
Console.WriteLine($"Amount of positive numbers: {positiveCount}");