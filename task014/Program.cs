//14. Найти третью цифру числа или сообщить, что её нет

Console.WriteLine("Введите число ");
int num = int.Parse(Console.ReadLine());
//Console.WriteLine(num);
//int N=num/100;
while (num >= 1000)
{
    num = num/10;   
}
    if (num<100)
{
   Console.WriteLine("Третьей цифры нет!");
}
else
{
    Console.WriteLine (num%10);
}
