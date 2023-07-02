/*
Напишите программу, которая принимает на вход число (N) 
и выдаёт таблицу квадратов чисел от 1 до N.
*/

Console.WriteLine("Enter a number: ");
int number = Convert.ToInt32(Console.ReadLine());

int count = 1;

Console.Write($"Squares from 1 to {number}: ");

if(number > 0)
{
    while(count <= number)
    {
        Console.Write(count*count+" ");
        count++; //count = count + 1
    }    
}
else
{
    while(count >= number)
    {
        Console.Write(count*count+" ");
        count--; //count = count - 1
    }
}
