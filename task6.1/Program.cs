Console.Write($"Сколько у вас будет чисел? ");
int m = Convert.ToInt32(Console.ReadLine());
int[] arrayNumbers = new int[m];

void NumbersInput(int m)
{
    for (int i = 0; i < m; i++)
    {
        Console.Write($"Введи {i + 1} число: ");
        arrayNumbers[i] = Convert.ToInt32(Console.ReadLine());
    }
}


int Compare(int[] arrayNumbers)
{
    int counter = 0;
    for (int i = 0; i < arrayNumbers.Length; i++)
    {
        if (arrayNumbers[i] > 0) counter += 1;
    }
    return counter;
}

NumbersInput(m);

Console.WriteLine($"Введено чисел больше 0: {Compare(arrayNumbers)} ");