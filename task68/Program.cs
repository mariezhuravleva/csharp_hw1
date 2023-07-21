/*
Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/

int SolveAckermann(int M, int N)
{
    if (M == 0)
    {
        return N + 1;
    }
    else if (M > 0 && N == 0)
    {
        return SolveAckermann(M - 1, 1);
    }
    else if (M > 0 && N > 0)
    {
        return SolveAckermann(M - 1, SolveAckermann(M, N - 1));
    }

    return 0;
}

// если n = 0
//      вернуть m + 1
//    иначе, если m = 0
//      вернуть ack (n - 1, 1)
//    еще
//      вернуть ack(n - 1, ack (n, m - 1))

Console.WriteLine("To solve Ackermann function we need M and N.");
Console.WriteLine("Enter M: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter N: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"The answer: {SolveAckermann(m, n)}.");