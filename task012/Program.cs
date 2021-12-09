//12. Удалить вторую цифру трёхзначного числа

Console.Write ("Введите трехзначное число ...");
int num = int.Parse(Console.ReadLine());

int X = num / 10;
int Y = num % 10;
int A = num/100;

    Console.Write(A);
    Console.Write(Y);


