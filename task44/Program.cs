/*
Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
Пример:
Если N = 5 -> 0 1 1 2 3
Если N = 3 -> 0 1 1
Если N = 7 -> 0 1 1 2 3 5 8
*/

Console.WriteLine("Введите число N: ");
int number = Convert.ToInt32(Console.ReadLine());

int prevSum2 = 0;
int prevSum1 = 1;
int sum = 0;

Console.Write(prevSum2 + " ");
Console.Write(prevSum1 + " ");

for(int i = 0; i < number - 2; i++)
{
    sum = prevSum1 + prevSum2;
    Console.Write(sum + " ");
    prevSum2 = prevSum1;
    prevSum1 = sum;
}