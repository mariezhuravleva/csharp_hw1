/*
Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
453 -> 12
45 -> 9
*/

int SumOfDigits(int number)
{
    if (number < 10)
    {
        return number;
    }
    else
    {
        return number % 10 + SumOfDigits(number / 10);
    }
}

int inputNumber = 963;
int sum = SumOfDigits(inputNumber);
Console.WriteLine($"Sum of digits in {inputNumber}: {sum}");
