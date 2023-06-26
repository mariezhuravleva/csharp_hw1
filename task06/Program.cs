/* Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/

Console.WriteLine("Enter first number:");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter second number:");
int number2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter third number:");
int number3 = Convert.ToInt32(Console.ReadLine());

int max;

if (number1 > number2)
{
    max = number1;
} else {    
    max = number2;
}

if (max > number3)
{
    Console.WriteLine("max = " + max);
}
else
{
    Console.WriteLine("max = " + number3);
}
