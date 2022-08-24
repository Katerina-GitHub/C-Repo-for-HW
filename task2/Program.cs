Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
int transform = number.ToString().Length;
Console.WriteLine(MakeArray(number, transform));

int MakeArray(int a, int b)
{
    int result = 0;
    if (b < 3)
    {
        Console.Write("Нет третьей цифры: ");
    }
    else
    {
        int c = 1;
        for (int i = b; i > 3; i--)
        {
            c = c * 10;
        }

        result = (a / c) % 10;
    }
    return result;
}
