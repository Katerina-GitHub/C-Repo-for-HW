Console.WriteLine("Введите три числа, разделяя их клавишей Enter");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());
int max = a;
if (b > max) max = b;
if (c > max) max = c;
Console.WriteLine("Максимальное число:" + max);