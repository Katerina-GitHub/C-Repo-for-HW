Console.WriteLine("Введите число N");
int n = int.Parse(Console.ReadLine());
int startPoint = 1;
while (startPoint < n)
{
    Console.WriteLine(startPoint + 1);
    startPoint += 2;
}


