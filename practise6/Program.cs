
// Написать функцию для вывода любого двумерного целочисленного массива в консоль в табличном виде.

// int m = new Random().Next(1, 10); // 1 2 3 4 ... 9
// Console.WriteLine(m);
// int n = new Random().Next(1, 10);
// Console.WriteLine(n);
// int[,] Array = new int [m, n];
// //int[,] Array = { { 1, 2, 3, 4 }, { 5, 6, 7, 8 } }; //можно и так массив задавать, уже со значениями


// void printDoubleArray(int[,] Array)
// {
//     for (int row = 0; row < Array.GetLength(0); row++)
//     {
//         for (int column = 0; column < Array.GetLength(1); column++)
//         {
//             Array[row,column] = new Random().Next(1, 10);
//             Console.Write(Array[row, column] + " ");
//         }
//         Console.WriteLine(); // отступ на новую строку
//     }
// }

// printDoubleArray(Array);





// Дан двумерный целочисленный массив X = { {1, 3, 7, 4, 5}, {9, 4, 5, 1, 2} }. Заменить в нем все элементы, меньшие 5 числом 111.

// int[,] X = { { 1, 3, 7, 4, 5 }, { 9, 4, 5, 1, 2 } };

// void printDoubleArray(int[,] X)
// {
//     for (int row = 0; row < X.GetLength(0); row++)
//     {
//         for (int column = 0; column < X.GetLength(1); column++)
//         {
//             if (X[row,column] < 5) X[row, column] = 111;
//             Console.Write(X[row, column] + " ");
//         }
//         Console.WriteLine(); // отступ на новую строку
//     }
// }

// printDoubleArray(X);


// Дан целочисленный двумерный массив А = {{-1, 2, -3}, {4, -5, 3}}. Напечатать индексы его отрицательных элементов.

// Создать квадратный двумерный целочисленный массив (количество строк и столбцов одинаковое), и с помощью цикла(-ов) заполнить его диагональные элементы единицами (можно только одну из диагоналей, если обе сложно).

