double[,] CreateFilledMatrix(int a, int b)
{
    double[,] matrix = new double[a, b];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 10);
        }
    }
    return matrix;
}

void PrintMatrix(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

double[,] SortMatrixLines(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int c = 0; c < matrix.GetLength(1) - 2; c++)
        {
            for (int j = 0; j < matrix.GetLength(1) - c - 1; j++)
            {
                if (matrix[i,j+1]>matrix[i,j])
                {
                    double temp = matrix[i,j];
                    matrix[i,j] = matrix[i,j+1];
                    matrix[i,j+1] = temp;
                }
                
            }
        }
    }
    return matrix;
}

double[,] mat = CreateFilledMatrix(5, 5);
Console.WriteLine("Initial array");
PrintMatrix(mat);
Console.WriteLine("Sorted array");
PrintMatrix(SortMatrixLines(mat));