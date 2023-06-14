/* Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки 
с наименьшей суммой элементов: 1 строка
 */
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
void MinLine(int[,] inArray)
{
    int summLineFirst = 0;
    int summOtherLine = 0;
    int mLine = 0;

    for (int j = 0; j < inArray.GetLength(1); j++)
    {
        summLineFirst += inArray[0, j];
    }
    WriteLine("Строка 0 -> " + summLineFirst);
    for (int i = 1; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            summOtherLine += inArray[i, j];
        }
        WriteLine("Строка " + i + " -> " + summOtherLine);
        if (i < inArray.GetLength(0))
        {
            mLine = (summOtherLine < summLineFirst) ? i : mLine;
            summLineFirst = summOtherLine < summLineFirst ? summOtherLine : summLineFirst;
            summOtherLine = 0;
        }
    }
    WriteLine();
    WriteLine("Индекс строки с минимальной суммой -> " + mLine);
}
int n = new Random().Next(3, 7), m = new Random().Next(3, 7);
int[,] array = GetArray(m, n);
PrintArray(array);
MinLine(array);
WriteLine();