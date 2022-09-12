
double[,] factor = new double[2, 2];
double[] point = new double[2];

void FactorInput()
{
    for (int i = 0; i < factor.GetLength(0); i++)
    {
        Console.Write($"Введите значения {i + 1}-го уравнения (y = k * x + b):\n");
        for (int j = 0; j < factor.GetLength(1); j++)
        {
            if (j == 0) Console.Write($"Введите значение k: ");
            else Console.Write($"Введите значение b: ");
            factor[i, j] = Convert.ToInt32(Console.ReadLine());
        }
    }
}

double[] Resolve(double[,] factor)
{
    point[0] = (factor[1, 1] - factor[0, 1]) / (factor[0, 0] - factor[1, 0]);
    point[1] = point[0] * factor[0, 0] + factor[0, 1];
    return point;
}

void OutputResolve(double[,] factor)
{
    if (factor[0, 0] == factor[1, 0] && factor[0, 1] == factor[1, 1])
    {
        Console.Write($"Прямые совпадают");
    }
    else if (factor[0, 0] == factor[1, 0] && factor[0, 1] != factor[1, 1])
    {
        Console.Write($"Прямые параллельны");
    }
    else
    {
        Resolve(factor);
        Console.Write($"Точка пересечения: ({point[0]}, {point[1]})");
    }
}

FactorInput();
OutputResolve(factor);