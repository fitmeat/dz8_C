void CreateArray(int[,,] array)
{
    int count = new Random().Next(10,93);
    for(int i = 0; i<array.GetLength(0); i++){
        for(int j = 0; j<array.GetLength(1); j++){
            for(int k = 0; k<array.GetLength(2); k++){
                array[i,j,k] = count;
                count++;
                Console.Write($"{array[i,j,k]}({i},{j},{k}) \t");
            }
            Console.WriteLine();
        }
    }
}

Console.Clear();
int[,,] arr = new int [2,2,2];
CreateArray(arr);
