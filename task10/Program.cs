/*
Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1
*/

Console.WriteLine("Enter 3 digit number:");

int number = Convert.ToInt32(Console.ReadLine());

int temp = number / 10;

int result = temp % 10;

Console.WriteLine("Second number from a three-digit number: " + result);