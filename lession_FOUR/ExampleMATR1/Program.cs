﻿// Задайте двумерный массив. Напишите программу, которая поменяет 
// местами первую и последнюю строку массива.



int GetSizeFromUser(string messageForUser)
{
    Console.Write(messageForUser);
    int size = Convert.ToInt32(Console.ReadLine());
    return size;
}

void FillMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 10);
        }
    }

}

void ShowMatrix(int[,] matrix)
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



int[,] SwapLinesMatrix(int[,] matrix)
{
    int colums = matrix.GetLength(1);
    int lastRow = matrix.GetLength(0) - 1;
    int temp = 0;
    for (int i = 0; i < colums; i++)
    {
      temp = matrix[0, i];
      matrix[0, i] = matrix[lastRow, i];
      matrix[lastRow, i] = temp;
    }
    return matrix;
}

int lines = GetSizeFromUser("Введите количество строк: ");
int colums = GetSizeFromUser("Введите количество столбцов: ");
int[,] matrix = new int[lines, colums];

FillMatrix(matrix);
ShowMatrix(matrix);
int[,] result = SwapLinesMatrix(matrix);
Console.WriteLine();
ShowMatrix(result);