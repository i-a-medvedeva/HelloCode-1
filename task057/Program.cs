//57. Написать программу, упорядочивания по убыванию элементы каждой строки двумерной массива.

int[,] doubleArray = { { 9, 1, 6, 2, 3 }, { 4, 5, 8, 2, 9 } };
int n = 5;
int[] m = new int[n];
//Console.WriteLine(doubleArray.GetLength(0));


void SelectionSort(int[,] arr, int[] m)
{
    for (int row = 0; row < arr.GetLength(0); row++)
    {
        for (int i = 0; i < arr.GetLength(1) - 1; i++) //дальше будем сравнивать со вторым элементом и прогонять там цикл                             
        {                                     // от элемента с индексом один до последнего, значит здесь от нулевого до предпоследнего
            int minPosition = i;
            for (int j = i + 1; j < arr.GetLength(1); j++)
            {
                if (arr[row, j] < arr[row, minPosition])
                {
                    minPosition = j;
                }
            }
            m[i] = arr[row, i];
            arr[row, i] = arr[row, minPosition];
            arr[row, minPosition] = m[i];
        }
    }

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
Printarr(doubleArray);
Console.WriteLine();
SelectionSort(doubleArray, m);
Printarr(doubleArray);

