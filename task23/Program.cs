/*
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/

Console.WriteLine("Enter a number: ");
int number = Convert.ToInt32(Console.ReadLine());

int count = 1;

Console.Write($"Cube from 1 to {number}: ");

if(number > 0)
{
    while(count <= number)
    {
        Console.Write(count*count*count+" ");
        count++; //count = count + 1
    }    
}
else
{
    while(count >= number)
    {
        Console.Write(count*count*count+" ");
        count--; //count = count - 1
    }
}
