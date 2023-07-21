/*
Напишите программу, которая на вход принимает два числа A и B, 
и возводит число А в целую степень B с помощью рекурсии.
A = 3; B = 5 -> 243 (3⁵)
A = 2; B = 3 -> 8
*/

int Power(int a, int b)
{
    if (b == 0)
    {
        return 1;
    }
    else
    {
        return a * Power(a, b - 1);
    }
}

int A = 2;
int B = 3;
int result = Power(A, B);
Console.WriteLine($"{A}^{B} = {result}");