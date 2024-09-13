using System;

class StrassenMatrixMultiplication
{
    public static int[,] Multiply(int[,] matrixA, int[,] matrixB)
    {
        int n = matrixA.GetLength(0);
        int[,] result = new int[n, n];

        if (n == 1)
        {
            result[0, 0] = matrixA[0, 0] * matrixB[0, 0];
        }
        else
        {
            int[,] A11 = new int[n / 2, n / 2];
            int[,] A12 = new int[n / 2, n / 2];
            int[,] A21 = new int[n / 2, n / 2];
            int[,] A22 = new int[n / 2, n / 2];
            int[,] B11 = new int[n / 2, n / 2];
            int[,] B12 = new int[n / 2, n / 2];
            int[,] B21 = new int[n / 2, n / 2];
            int[,] B22 = new int[n / 2, n / 2];

            // Divide matrices into submatrices
            DivideMatrix(matrixA, A11, 0, 0);
            DivideMatrix(matrixA, A12, 0, n / 2);
            DivideMatrix(matrixA, A21, n / 2, 0);
            DivideMatrix(matrixA, A22, n / 2, n / 2);
            DivideMatrix(matrixB, B11, 0, 0);
            DivideMatrix(matrixB, B12, 0, n / 2);
            DivideMatrix(matrixB, B21, n / 2, 0);
            DivideMatrix(matrixB, B22, n / 2, n / 2);

            // Calculate intermediate matrices
            int[,] M1 = Multiply(Add(A11, A22), Add(B11, B22));
            int[,] M2 = Multiply(Add(A21, A22), B11);
            int[,] M3 = Multiply(A11, Subtract(B12, B22));
            int[,] M4 = Multiply(A22, Subtract(B21, B11));
            int[,] M5 = Multiply(Add(A11, A12), B22);
            int[,] M6 = Multiply(Subtract(A21, A11), Add(B11, B12));
            int[,] M7 = Multiply(Subtract(A12, A22), Add(B21, B22));

            // Calculate result submatrices
            int[,] C11 = Add(Subtract(Add(M1, M4), M5), M7);
            int[,] C12 = Add(M3, M5);
            int[,] C21 = Add(M2, M4);
            int[,] C22 = Add(Subtract(Add(M1, M3), M2), M6);

            // Combine result submatrices into the final result matrix
            MergeMatrix(C11, result, 0, 0);
            MergeMatrix(C12, result, 0, n / 2);
            MergeMatrix(C21, result, n / 2, 0);
            MergeMatrix(C22, result, n / 2, n / 2);
        }

        return result;
    }

    private static void DivideMatrix(int[,] source, int[,] dest, int startRow, int startCol)
    {
        int n = dest.GetLength(0);
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                dest[i, j] = source[i + startRow, j + startCol];
            }
        }
    }

    private static void MergeMatrix(int[,] source, int[,] dest, int startRow, int startCol)
    {
        int n = source.GetLength(0);
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                dest[i + startRow, j + startCol] = source[i, j];
            }
        }
    }

    private static int[,] Add(int[,] matrixA, int[,] matrixB)
    {
        int n = matrixA.GetLength(0);
        int[,] result = new int[n, n];
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                result[i, j] = matrixA[i, j] + matrixB[i, j];
            }
        }
        return result;
    }

    private static int[,] Subtract(int[,] matrixA, int[,] matrixB)
    {
        int n = matrixA.GetLength(0);
        int[,] result = new int[n, n];
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                result[i, j] = matrixA[i, j] - matrixB[i, j];
            }
        }
        return result;
    }

    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the size of the matrices (n):");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the elements of matrix A:");
        int[,] matrixA = ReadMatrix(n);

        Console.WriteLine("Enter the elements of matrix B:");
        int[,] matrixB = ReadMatrix(n);

        int[,] result = Multiply(matrixA, matrixB);

        Console.WriteLine("Result of matrix multiplication:");
        for (int i = 0; i < result.GetLength(0); i++)
        {
            for (int j = 0; j < result.GetLength(1); j++)
            {
                Console.Write(result[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }

    private static int[,] ReadMatrix(int n)
    {
        int[,] matrix = new int[n, n];
        for (int i = 0; i < n; i++)
        {
            string[] row = Console.ReadLine().Split(' ');
            for (int j = 0; j < n; j++)
            {
                matrix[i, j] = int.Parse(row[j]);
            }
        }
        return matrix;
    }
}
