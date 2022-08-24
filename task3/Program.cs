Console.WriteLine("Введите цифру, означающую день недели");
int day = Convert.ToInt32(Console.ReadLine());
if (day > 7 || day < 1)
{
    Console.WriteLine("Введите корректное значение, где 1- это Понедельник, а 7- Воскресенье");
}
else if (day == 6 || day == 7)
{
    Console.WriteLine("Ура-ура, выходной!");
}
else
{
    Console.WriteLine("Работайте, негры, солнце еще высоко!");
}
