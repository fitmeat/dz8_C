void InputArray(int[,] array, int n, int m)
{
    int count = 1;
    int i = 0;
    int j = 0;
    while (count <= n * m)
    {
        array[i, j] = count;
        if (i <= j + 1 && i + j < n - 1)
        {
            j++;
        }
        else if (i < j && i + j >= m - 1)
        {
            i++;
        }
        else if (i >= j && i + j > n - 1)
        {
            j--;
        } else 
            i--;
        count++;
    }
}

void ShowArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} \t");
        }
        Console.WriteLine();
    }
}
Console.Clear();
Console.WriteLine("Введите количество строк n: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов m: ");
int m = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[n, m];
InputArray(array, n, m);
ShowArray(array);
