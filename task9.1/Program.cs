void PrintNumbers(int m, int n)
{
    int start = m;
    int end = n;
    if (m > n)
    {
        start = n;
        end = m;
    }
    for (int i = start; i <= end; i++)
    {
        Console.Write($"{i} ");
    }
}
PrintNumbers(4, 8);

Console.WriteLine();