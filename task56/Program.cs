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

void FindMinSumRow(int[,] matrix)
{
    int sumMin = 99999;
    int indexMin = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
            int sum = 0;
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                sum += matrix[i,j];
            }
            if(sum<sumMin){
                sumMin = sum;
                indexMin = i;
            } 
            Console.WriteLine($"Сумма {i+1} строки = {sum} ");
        }
        Console.WriteLine(sumMin);
        Console.WriteLine($"Строка с наименьшей суммой: {indexMin+1}");
    }

Console.Clear();
Console.WriteLine("Введите количество строк n: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов m: ");
int m = Convert.ToInt32(Console.ReadLine());
int[,] arr = new int[n, m];
CreateMatrix(arr);
int[] sum = new int[n];
FindMinSumRow(arr);

