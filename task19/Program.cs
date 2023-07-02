/*
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/

int FindLastDigit(int userNumber)
{
    return userNumber % 10;
}

int FindFirstDigit(int userNumber)
{
    return userNumber / 10000;
}

int FindSecondLastDigit(int userNumber)
{
    return (userNumber / 10) % 10; 
}

int FindSecondDigit(int userNumber)
{
    return (userNumber / 1000) % 10;
}  

void IsPalindrome(int userNumber)
{
    if (FindFirstDigit(userNumber) == FindLastDigit(userNumber) && FindSecondDigit(userNumber) == FindSecondLastDigit(userNumber))
    {
    Console.WriteLine("Yes.");
    }
    else
    {
    Console.WriteLine("No.");
    }
} 

Console.WriteLine("Enter a five digit number: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 10000 || number > 99999)
{
    Console.WriteLine("Error, this number is not five digits.");
}
else
{
    IsPalindrome(number);
}