//56. Написать программу, которая обменивает элементы первой строки и последней строки

//int[,] array = new int[3,5];
int[,] array = { { 1, 1, 1, 1, 1 }, { 2, 2, 2, 2, 2 }, { 3, 3, 3, 3, 3 } };
int n = 5;
int[] m = new int[n];

int row = 0;

for (int i = 0; i < m.Length; i++)
{
    m[i] = array[row, i];
    array[row, i] = array[array.GetLength(0) - 1, i];
    array[array.GetLength(0) - 1, i] = m[i];
}

void Printarr(int[,] array)
{
    for (int k = 0; k < array.GetLength(0); k++)
    {
        for (int r = 0; r < array.GetLength(1); r++)
        {
            Console.Write(array[k, r] + " ");
        }
        Console.WriteLine();
    }
}
Printarr(array);

















//вариант решения с рандомом и методами

// void FillArray(int[,] matrix, int m, int n)

// {
//     for (int i = 0; i <matrix.GetLength(0); i++)

//     {
//         for (int j = 0; j <matrix.GetLength(1); j++)

//         {
//             matrix[i,j]=new Random().Next(m,n);

//         }

//     }

// }

 

// void PrintArray(int[,] matr)

// {
//     for (int i = 0; i < matr.GetLength(0); i++)

//     {
//         for (int j = 0; j < matr.GetLength(1); j++)

//         {
//             Console.Write($"{matr[i, j]} ");

//         }

//         Console.WriteLine();

//     }

// }

 



// void Copy(int[,] array, int[] m)

// {
//     for (int i = 0; i < m.Length; i++)

//     {
//         m[i] = array[0, i];

//         array[0, i] = array[array.GetLength(0) - 1, i];

//         array[array.GetLength(0) - 1, i] = m[i];



//     }

//     for (int k = 0; k < array.GetLength(0); k++)

//     {
//         for (int r = 0; r < array.GetLength(1); r++)

//         {
//             Console.Write(array[k, r] + " ");

//         }

//         Console.WriteLine();

//     }

// }



// Console.Write("введите количество строк: ");

// int lengthM=int.Parse(Console.ReadLine());

// Console.Write("введите количество столбцов:");

// int lengthN=int.Parse(Console.ReadLine());

// int[,] matrica=new int[lengthM,lengthN];

 

// FillArray(matrica, 1,10);

// PrintArray(matrica);

// Console.WriteLine();

// // int[]M=new int[lengthM];
// int [] M = new int [lengthN]; 

// Copy(matrica,M);