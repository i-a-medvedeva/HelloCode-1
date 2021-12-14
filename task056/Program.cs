

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