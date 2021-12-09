//11. Дано число из отрезка [10, 99]. Показать наибольшую цифру числа

int num = new Random().Next(10, 100);
Console.WriteLine(num);

int X = num / 10;
int Y = num % 10;
if (X>Y)
{
    Console.WriteLine(X);
}
else
{
    Console.WriteLine(Y);
}

