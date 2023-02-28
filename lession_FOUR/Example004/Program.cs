/* 1. Заполнить матрицу
2. Вывести на экран матрицу
3. Посчитать перемноженную матрицу
4. Вывести на экран перемноженную матрицу (та же задача 2);
*/

void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write(matr[i, j] + " ");
        }
        Console.WriteLine();
    }
}

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 10);
        }
    }
}

int[,] MultArray(int[,] matr1, int[,] matr2)
{
    int[,] matr = new int[matr1.GetLength(0),matr2.GetLength(1)];
    for (int i = 0; i < matr1.GetLength(0); i++)
    {
        for (int j = 0; j < matr2.GetLength(1); j++)
        {
            for (int k = 0; k < matr1.GetLength(1); k++)
            {
                matr[i, j] += matr1[i, k] * matr2[k, j];
            }
        }
    }
    return matr;
}

int[,] matrix1 = new int[2, 3];
FillArray(matrix1);
PrintArray(matrix1);
Console.WriteLine();

int[,] matrix2 = new int[3, 4];
FillArray(matrix2);
PrintArray(matrix2);
Console.WriteLine();

PrintArray(MultArray(matrix1, matrix2));