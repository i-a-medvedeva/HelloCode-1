//10. Показать вторую цифру трёхзначного числа

Console.Write ("Введите трехзначное число ...");
int num = int.Parse(Console.ReadLine());
int N = num/10;
int X=N%10;
Console.WriteLine(X);