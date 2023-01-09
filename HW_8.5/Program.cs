double[,] CreateSpiralFilledMatrix(int a, int b)
{
    double[,] matrix = new double[a, b];
    double spiral = 1;
    int iTemp = 0, jTemp = 0, count = 0;
    int toggle = 0;

    for (int v = 0; v < ((a + b) / 4) + 1; v++)
    {
        toggle = 0;
        
        for (int j = count; j < matrix.GetLength(1) - count; j++)
        {
            matrix[iTemp - count, j] = spiral;
            spiral++;
            jTemp++;
            toggle++;
        }

        if (toggle == 0)
        {
            break;
        }

        jTemp--;
        toggle = 0;

        for (int i = count + 1; i < matrix.GetLength(0) - count; i++)
        {
            matrix[i, jTemp] = spiral;
            spiral++;
            iTemp++;
            toggle++;
        }

        if (toggle == 0)
        {
            break;
        }

        toggle = 0;

        for (int j = jTemp - 1; j >= 0 + count; j--)
        {
            matrix[iTemp - count, j] = spiral;
            spiral++;
            jTemp--;
            toggle++;
        }

        if (toggle == 0)
        {
            break;
        }

        jTemp++;
        count++;
        toggle = 0;

        for (int i = iTemp - count; i >= 0 + count; i--)
        {
            matrix[i, jTemp - 1] = spiral;
            spiral++;
            iTemp--;
            toggle++;
        }

        if (toggle == 0)
        {
            break;
        }

        iTemp++;
    }
    return matrix;
}

void PrintMatrixAdapted(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] < 10)
            {
                Console.Write($"0{matrix[i, j]} ");
            }
            else
            {
                Console.Write($"{matrix[i, j]} ");
            }
        }
        Console.WriteLine();
    }
}

PrintMatrixAdapted(CreateSpiralFilledMatrix(9, 9));