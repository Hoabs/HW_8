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

double[,] MatrixMultiplication(double[,] matrix1, double[,] matrix2)
{
    double[,] matrixMult = new double[matrix1.GetLength(0), matrix2.GetLength(1)];
    if (matrix1.GetLength(1)==matrix2.GetLength(0))
    { 
        for (int i = 0; i < matrix1.GetLength(0); i++)
        {
            for (int j = 0; j < matrix2.GetLength(1); j++)
            {
                for (int k = 0; k < matrix1.GetLength(1); k++)
                {
                    matrixMult[i, j] += matrix1[i, k] * matrix2[k, j];
                }
            }
        }

        return matrixMult;
    }
    else
    {
        Console.WriteLine("ERROR! Number of columns in 'mat1' should be eqile to number of lines in 'mat2'");
        return matrixMult;  
    }
    
}

double[,] mat1 = CreateFilledMatrix(5, 2);
double[,] mat2 = CreateFilledMatrix(2, 3);

Console.WriteLine("Initial array 1");
PrintMatrix(mat1);
Console.WriteLine("Initial array 2");
PrintMatrix(mat2);
Console.WriteLine("Multiplicated array");
PrintMatrix(MatrixMultiplication(mat1, mat2));
