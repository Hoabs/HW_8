double[,,] CreateFilled3DMatrix(int a, int b, int c)
{
    double[,,] matrix = new double[a, b, c];
    double[] repeats = new double[a*b*c];
    int r = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {  
                int count = 0;
                while (count!=repeats.Length)
                {
                    double check = new Random().Next(10, 100);
                    count = 0;

                    for (int z = 0; z < repeats.Length; z++)
                    {
                        if(repeats[z]!=check)
                        {
                            count++;
                        }
                        
                    }

                    if (count==repeats.Length)
                    {
                        matrix[i, j, k] = check;
                        repeats[r] = check;
                        r++;
                    }
                }
            }
        }
    }
    return matrix;
}

void Print3DMatrix(double[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
            Console.Write($"{matrix[i, j, k]}({i},{j},{k}) ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

Print3DMatrix(CreateFilled3DMatrix(2,2,2));