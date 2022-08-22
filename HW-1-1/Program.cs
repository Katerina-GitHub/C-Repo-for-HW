Console.WriteLine("Введите первое целое число");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе целое число");
int b = Convert.ToInt32(Console.ReadLine());
if (a > b)
{
    Console.WriteLine("Максимальное из введных число: " + a + ", минимальное: " + b);
}
else
{
    Console.WriteLine("Максимальное из введных число: " + b + ", минимальное: " + a);
}