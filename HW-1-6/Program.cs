int n = new Random().Next(-100, 100);
int startPoint = -n;
while (startPoint < n)
{
    Console.Write(startPoint + 1);
    startPoint++;
}
Console.WriteLine("Выпавшее число:" + n);
