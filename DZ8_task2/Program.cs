/* Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18 */
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
int[,] GetMultArr(int row, int clm, int[,] arrFrst, int[,] arrScnd){
    int[,] result = new int[row, clm];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < clm; j++)
        {
            int temp = 0;
            for (int k = 0; k < arrFrst.GetLength(1); k++)
            {
                temp += arrFrst[i,k]*arrScnd[k,j]; 
            }
            result[i,j] = temp;
        }
    }
    return result;
}
int n = new Random().Next(3, 7), m = new Random().Next(3, 7);
int[,] arrayFirst = GetArray(m, n);
PrintArray(arrayFirst);
int r = new Random().Next(3, 7);
int[,] arraySecond = GetArray(n, r);
PrintArray(arraySecond);
int[,] multArray = GetMultArr(m,r, arrayFirst, arraySecond);
WriteLine();
PrintArray(multArray);