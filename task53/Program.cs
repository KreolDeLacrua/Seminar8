﻿//Задача 53: Задайте двумерный массив. Напишите программу, 
//которая поменяет местами первую и последнюю строку массива.

int[,] FillMatrix(int rowCount, int columnsCount, int leftRange = 0, int rightRange = 10)
{
    int[,] matrix = new int[rowCount, columnsCount];

    Random rand = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = rand.Next(leftRange, rightRange + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write (matrix [i, j] + " ");
        }
        Console.WriteLine();
    }
}

Console.Write("Введите число строк "); 
int m = Convert.ToInt32(Console.ReadLine()); 
Console.Write("Введите число столбцов "); 
int n = Convert.ToInt32(Console.ReadLine()); 
int[,] matrix = FillMatrix(m, n);
PrintMatrix(matrix);
Console.WriteLine();
for (int j = 0; j < matrix.GetLength(1); j++)
{
    int temp = matrix[0, j];
    matrix[0, j] = matrix[matrix.GetLength(0)-1, j];
    matrix[matrix.GetLength(0)-1, j] = temp;
}
PrintMatrix(matrix);

