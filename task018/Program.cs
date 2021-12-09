//18. Проверить истинность утверждения ¬(X ⋁ Y) = ¬X ⋀ ¬Y

//Console.WriteLine("Введите true или false ");
//bool numX = bool.Parse(Console.ReadLine());
//Console.WriteLine(numX);
Console.WriteLine("Введите первое число true или false :");
bool number1 = bool.Parse(Console.ReadLine());
Console.WriteLine(number1);
Console.WriteLine("Введите второе число false или true:");
bool number2 = bool.Parse(Console.ReadLine());
Console.WriteLine(number2);
if (!(number1 | number2 ) == (!number1 & !number2))
{
   Console.WriteLine($"Закон работает!");
    
}
else
{
    Console.WriteLine("Закон не работает!");
}
