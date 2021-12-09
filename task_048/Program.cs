//48. Показать двумерный массив размером m×n заполненный целыми числами
int m = new Random().Next(1, 10); // 1 2 3 4 ... 9
Console.WriteLine(m);
int n = new Random().Next(1, 10);
Console.WriteLine(n);
int[,] Array = new int [m, n];
//int[,] Array = { { 1, 2, 3, 4 }, { 5, 6, 7, 8 } };


void printDoubleArray(int[,] Array)
{
    for (int row = 0; row < Array.GetLength(0); row++)
    {
        for (int column = 0; column < Array.GetLength(1); column++)
        {
            Array[row,column] = new Random().Next(1, 10);
            Console.Write(Array[row, column] + " ");
        }
        Console.WriteLine(); // отступ на новую строку
    }
}

printDoubleArray(Array);
// Console.WriteLine(); //отступ на новую строку
// printDoubleArray(Array);

