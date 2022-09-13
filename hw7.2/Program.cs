Console.WriteLine("Введите размеры массива, сначала строки, затем столбцы");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[m, n];
FillArray(array);

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = Convert.ToInt32(new Random().Next(0, 21));
    }

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + "\t  ");
        Console.WriteLine();
    }
}
Console.WriteLine("Введите координаты, сначала строки, затем столбцы");

FindNumber(array);
void FindNumber(int[,] array)
{
    int a = Convert.ToInt32(Console.ReadLine());
    int b = Convert.ToInt32(Console.ReadLine());
    if (a > m && b > n)
        Console.WriteLine("такого числа нет");
    else
    {
        var c = array.GetValue(a, b);
        Console.WriteLine(c);
    }
}