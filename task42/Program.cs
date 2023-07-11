/*
Напиши программу, которая будет преобразовывать десятичное число в двоичное.
*/
int DecimalToBinary(int decimalNumber)
{
    int binaryNumber = 0;
    int baseValue = 1;

    while (decimalNumber > 0)
    {
        int remainder = decimalNumber % 2;
        binaryNumber += remainder * baseValue;
        decimalNumber /= 2;
        baseValue *= 10;
    }

    return binaryNumber;
}

Console.WriteLine("Enter a decimal number:");
int number = Convert.ToInt32(Console.ReadLine());

int binaryNumber = DecimalToBinary(number);

Console.WriteLine($"Binary number of {number}: {binaryNumber}");