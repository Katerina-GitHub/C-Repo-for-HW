int ShowSum(int m, int n)
{
    int start = m;
    int end = n;
    if (m > n)
    {
        start = n;
        end = m;
    }
    return (end + start) * (end - start + 1) / 2;
}

Console.WriteLine(ShowSum(4, 8));

