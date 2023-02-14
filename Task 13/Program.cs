Console.Clear();
Console.WriteLine("Введите число");
int a = int.Parse(Console.ReadLine());
if (a<100) Console.WriteLine("третьей цифры нет"); 
else 
{
    int namber3 = (a%1000-a%100)/100;
    Console.WriteLine(namber3);
}