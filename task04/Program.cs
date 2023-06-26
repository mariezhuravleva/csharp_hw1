/*
Напишите программу, которая принимает на вход 
трёхзначное число и на выходе показывает последнюю 
цифру этого числа.

456 -> 6
782 -> 2
918 -> 8
*/

Console.WriteLine("Enter 3 digit number:");

int number = Convert.ToInt32(Console.ReadLine());

int result = number %10;

Console.WriteLine("Last digit: " + result);

