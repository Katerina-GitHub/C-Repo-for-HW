Random random = new Random();
int[,] array = new int[random.Next(1, 10), random.Next(1, 10)];
FillArray(array);

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(1, 10);
            Console.Write(array[i, j] + " | ");
        }
        Console.WriteLine();
    }
}
Console.WriteLine("---------------------------");

FindAverage(array);
void FindAverage(int[,] array)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum += array[i, j];
        }
        Console.Write($"{sum / array.GetLength(0)} ");
    }
}
Console.ReadLine();