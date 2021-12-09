//8. Показать четные числа от 1 до N

Console.Write ("Введите число ...");
int num = int.Parse(Console.ReadLine());
int ok = 2;
while (ok<= num)
{
    Console.WriteLine(ok);
    ok+=2; //ok=ok+2
}
