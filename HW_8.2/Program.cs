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

double FindMinMatrixLine(double[,] matrix)
{
    double minSum = 0;
    int minSumLine = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        double sum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum += matrix[i,j];
        }

        if (minSum == 0)
        {
            minSum = sum;
            minSumLine = i+1;
        }
        if (sum < minSum)
        {
            minSum = sum;
            minSumLine = i+1;
        } 
    }
    return minSumLine;
}

Console.WriteLine("Enter an number of lines");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter an number of columns");
int n = Convert.ToInt32(Console.ReadLine());

while (m==n)
{
    Console.WriteLine("Error! Enter a rectangle array parametrs");
    Console.WriteLine("Enter an number of lines");
    m = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter an number of columns");
    n = Convert.ToInt32(Console.ReadLine());
}

double[,] mat = CreateFilledMatrix(m, n);
Console.WriteLine("Initial array");
PrintMatrix(mat);
Console.WriteLine($"Minimal line summ - {FindMinMatrixLine(mat)}");



