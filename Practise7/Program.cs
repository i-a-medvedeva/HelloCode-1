﻿//Рекурсия
// Написать функцию, формирующую строковую последовательность целых чисел от 1 до number.
// string getSequence(int number)
// {
//     if (number == 1)
//     {
//         return "" + number;
//     }
//     return getSequence(number - 1) + " " + number;
// }

// int myNumber =3;
// Console.WriteLine("Последовательность: "+ getSequence(myNumber));


// Даны два целых числа A и В. Выведите все числа от A до B включительно, в порядке возрастания, если A < B, или в порядке убывания в противном случае

// int A =200;
// int B =150;

// void PrintNum (int a, int b)
// {
//     Console.Write(a+" ");
//     if (a==b)
//     {
//         return;
//     }
//     if (a<b)
//     {
//         PrintNum (a+1,b);
//     }
//     else if (a>b)
//     {
//         PrintNum (a-1,b);
//     }
// }

// PrintNum(A,B);



// Дано натуральное число N. Выведите все его цифры по одной, в обратном порядке, разделяя их пробелами или новыми строками. 
//При решении этой задачи нельзя использовать строки (их можно только возвращать, если пишется функцией), 
//списки, массивы (ну и циклы, разумеется). Разрешена только рекурсия и целочисленная арифметика.

// int n = 16987;
// void PrintNumber (int n)
// {
//    if (n==0)
//    {
//        return;
//    }
//     Console.Write (n%10 + " ");
//     n = n/10;
//     PrintNumber (n);
// }

// PrintNumber (n);





// Дано натуральное число N. Выведите все его цифры по одной, в обычном порядке, разделяя их пробелами или новыми строками. 
//При решении этой задачи нельзя использовать строки (их можно только возвращать, если пишется функцией), 
//списки, массивы (ну и циклы, разумеется). Разрешена только рекурсия и целочисленная арифметика.

// int n = 16987;
// //string m = string.Empty;
// string PrintNumber(int n)
// {
//     if (n == 0)
//     {
//         //return m;
//         return "";
//     }

//     return PrintNumber(n / 10) + n % 10 + " ";



// }

// Console.WriteLine(PrintNumber(n));




// Дано слово, состоящее только из строчных латинских букв. Проверьте, является ли это слово палиндромом. 
//Выведите YES или NO. При решении этой задачи нельзя пользоваться циклами (кроме функции Substring(int startIndex, int length) строки. 
//Пример: "word".Substring(0,2) вернет "wo")

string word = "hyjel";
int length = word.Length;
Console.WriteLine(length);
string result = string.Empty;

string Printword(string p)
{
   
        if (p.Length < 1)
        {
            return "YES";
        }
        else 
        {
            if (p.Substring (0,1) == p.Substring(p.Length-1,1))
            {
                // string p = word.Substring(1, length - 1);
                Console.WriteLine("Перевернутое слово: " + p);
                return Printword(p) + "YES";
            }
            else
            {
                return "NO";
            }
            
        }
}

Console.WriteLine(result);



// Дана последовательность натуральных чисел (целочисленный массив), завершающаяся числом 0. 
//Выведите все нечетные числа из этой последовательности, сохраняя их порядок (разрешаются циклы, 
//которые перекопируют массив или его часть). Разрешается использовать void Array.Copy
//(Array sourceArray, int sourceIndex, Array destinationArray, int destinationIndex, int length)