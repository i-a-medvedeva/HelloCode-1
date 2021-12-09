//13. Выяснить, кратно ли число заданному, если нет, вывести остаток.

Console.Write ("Введите трехзначное число ...");
int num = int.Parse(Console.ReadLine());

int X = 5;

double result = num%X;
if (result ==0)
{
    Console.WriteLine("Кратно!");
}
else
{
    Console.WriteLine(result + $"  Остаток от деления на {X}");
}
