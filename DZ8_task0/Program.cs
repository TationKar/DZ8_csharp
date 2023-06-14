/* Задача 54: Задайте двумерный массив. Напишите программу, 
которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2 */
using System;
using static System.Console;
Clear();
int[,] GetArray(int m, int n)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(10);
        }
    }
    return result;
}
void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Write($"{inArray[i, j]} ");
        }
        WriteLine();
    }
    WriteLine();
}
void SortArrLine(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            for (int k = 0, el = 0; k < inArray.GetLength(1); k++)
            {
                if (inArray[i, j] > inArray[i, k])
                {
                    el = inArray[i, k];
                    inArray[i, k] = inArray[i, j];
                    inArray[i, j] = el;
                }
            }
        }
    }
}
int n = new Random().Next(3, 7), m = new Random().Next(3, 7);
int[,] array = GetArray(m, n);
PrintArray(array);
SortArrLine(array);
PrintArray(array);