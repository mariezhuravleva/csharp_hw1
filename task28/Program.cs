/*
Напишите программу, которая принимает 
на вход число N и выдаёт произведение чисел от 1 до N.
4->24
5->120
*/

int GetMultiplicationOfSeries(int from, int to)
{
    int result = 1;
    for (int i = from; i <= to; i++)
    {
        result *= i; //result = result + i
    }
    return result;
}
Console.WriteLine("Enter number: ");
int number = Convert.ToInt32(Console.ReadLine());

int multiplication = GetMultiplicationOfSeries(1, number);
Console.WriteLine($"Multiplication from 1 to {number} = {multiplication}.");