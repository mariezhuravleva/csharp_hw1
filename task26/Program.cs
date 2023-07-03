/*Напишите программу, 
которая принимает на вход число и выдаёт 
количество цифр в числе.
456 => 3
*/
Console.WriteLine("Enter number: ");
int number = Convert.ToInt32(Console.ReadLine());

int count = 0;

while (number > 0)
{
    number = number / 10;
    count++;
}

Console.WriteLine(count);

/*
int AmountOfDigits(int num)
{
    int amount = 0;
    while (num > 0)
    {
        num /= 10; // num = num / 10;
        amount++;  // amount = amount + 1;
    }
    return amount;
}


Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Количество цифр в числе {number} -> {AmountOfDigits(number)}");

*/