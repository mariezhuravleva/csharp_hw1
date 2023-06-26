/*
Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

Console.WriteLine("Enter a number:");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 100)
{
    Console.WriteLine("No third digit.");
}
else
{
    int result = number / 100 % 10;
    Console.WriteLine("Third number of the entered digit: " + result);
}