/* Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
456 -> 46
782 -> 72
918 -> 98 */

int randomNumber = new Random().Next(100, 1000);
Console.WriteLine(randomNumber);

int number1 = randomNumber / 100;
int number3 = randomNumber % 10;

Console.Write(number1);
Console.Write(number3);