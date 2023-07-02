/*
Напишите программу, которая принимает на вход цифру, 
обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/

Console.WriteLine("Enter number from 1 to 7:");
int number = Convert.ToInt32(Console.ReadLine());
if (number >= 1 && number <= 5) 
{
    Console.WriteLine("no");
}
if (number >= 6 && number <= 7)
{
    Console.WriteLine("yes");
}
 else 
 {
    Console.WriteLine("Error. Enter number from 1 to 7.");
 }