/*
Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/

int GetSumNum(int num)
{
    int sum = 0;
    if (num > 0)
    {
        while (num != 0)
        {
            int digit = num % 10;
            sum = sum + digit;
            num = num / 10;
        }
        return sum;
    }
    else
    {
        num = num * -1;
        while (num != 0)
        {
            int digit = num % 10;
            sum = sum + digit;
            num = num / 10;
        }
        return sum;
    }
}

Console.WriteLine("Enter number: ");
int number = Convert.ToInt32(Console.ReadLine());

int sum = GetSumNum(number);
Console.WriteLine($"Sum {number} = {sum}.");