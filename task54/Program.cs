void CreateMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 11);
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }
}

void SortMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1) - 1; j++)
        {
            for (int k = j + 1; k < matrix.GetLength(1); k++)
            {
                    if (matrix[i, j] < matrix[i, k])
                    {
                        int tepm = matrix[i, j];
                        matrix[i, j] = matrix[i, k];
                        matrix[i, k] = tepm;
                    }
            }
        }
    }
 
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }
}

Console.Clear();
Console.WriteLine("Введите количество строк n: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов m: ");
int m = Convert.ToInt32(Console.ReadLine());
int[,] arr = new int[n, m];
Console.WriteLine("Начальный массив:");
CreateMatrix(arr);
Console.WriteLine();
Console.WriteLine("Отсортированный массив:");
SortMatrix(arr);

