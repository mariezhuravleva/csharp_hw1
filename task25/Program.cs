/*
Напишите цикл, который принимает на вход два числа (A и B) 
и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

Console.WriteLine("Enter A: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter B: ");
int num2 = Convert.ToInt32(Console.ReadLine());

int SetAToDimensionB(int A, int B)
{
    int result = 1;
    for (int i = 0; i < B; i++)
{
        result *= A;
}
    return result;
}
int result = SetAToDimensionB(num1, num2);
Console.WriteLine("Result: "+result);