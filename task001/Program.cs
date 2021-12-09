 //1. По двум заданным числам проверять является ли первое квадратом второго

int A = 5;
int B = 25;
double n = 0.5;

if (Math.Pow(B,n) == A)
{
    Console.WriteLine("Является!");
}
else
{
    Console.Write("Не является");
}
