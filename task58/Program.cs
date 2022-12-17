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

void IncreaseMatrix(int[,] matrix1, int[,] matrix2)
{
    int[,] result = new int[matrix1.GetLength(0), matrix1.GetLength(1)];
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix1.GetLength(1); j++)
        {
            result[i, j] = matrix1[i, j] * matrix2[i, j];
            Console.Write($"{result[i, j]} \t");
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
Console.WriteLine("Первая матрица: ");
CreateMatrix(arr);
int[,] newArr = new int[n, m];
Console.WriteLine();
Console.WriteLine("Вторая матрица: ");
CreateMatrix(newArr);
Console.WriteLine();
Console.WriteLine("Результирующая матрица: ");
IncreaseMatrix(arr, newArr);
