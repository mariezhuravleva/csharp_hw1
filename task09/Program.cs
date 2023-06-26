/* Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
78 -> 8
12-> 2
85 -> 8
*/

int randomNumber = new Random().Next(10, 100);
Console.WriteLine("Random number is "+randomNumber);

int number1 = randomNumber % 10;
int number2 = randomNumber / 10;

if (number1 > number2)
{
    Console.WriteLine(number1);
} 
else
{
    Console.WriteLine(number2);
}