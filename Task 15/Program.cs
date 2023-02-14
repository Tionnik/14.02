Console.Clear();
Console.WriteLine("Введите день недели");
int a = int.Parse(Console.ReadLine());
if (a<8)
{
    if (a ==6 || a==7) Console.WriteLine("Да, выходной");
    else Console.WriteLine("Нет, не выходной");
}
else Console.WriteLine("Нет такого дня недели");