/* Задача 62. Напишите программу, которая заполнит 
спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07 */
using System;
using static System.Console;
Clear();
int strtNum = 1;
Write("Введите размер массива: ");
int dimArr = int.Parse(ReadLine()!);
int[,] emptyArr = new int[dimArr, dimArr];
int[,] decompArr = new int[(dimArr * 2 - 1), dimArr];
for (int i = 0; i < dimArr; i++)//заполнение первой строки массива
{
    emptyArr[0, i] = strtNum;
    strtNum++;
}
FillDecompArr(decompArr);
WriteLine();
FillSpiral(1, dimArr - 1, strtNum);
PrintArray(emptyArr);
void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            if (inArray[i, j] < 10)
                Write($"0{inArray[i, j]} ");
            else
                Write($"{inArray[i, j]} ");
        }
        WriteLine();
    }
    WriteLine();
}
int FillSpiral(int row, int col, int res)
{
    int result = res;
    emptyArr[row, col] = result;
    result++;

    if (result > (dimArr * dimArr))
        return result;

    int caseLine = LineDecompArr(result);
    if (caseLine > 4)
        caseLine %= 4;
    if (caseLine == 0)
        caseLine = 4;

    if (caseLine == 1)
        FillSpiral(row + 1, col, result);
    if (caseLine == 2)
        FillSpiral(row, col - 1, result);
    if (caseLine == 3)
        FillSpiral(row - 1, col, result);
    if (caseLine == 4)
        FillSpiral(row, col + 1, result);
    return 0;
}
void FillDecompArr(int[,] inArr)
{
    int tempN = 1;
    for (int i = 0; i < inArr.GetLength(1); i++)
    {
        inArr[0, i] = tempN;
        tempN++;
    }
    int columnInArr = inArr.GetLength(1) - 2;
    for (int j = 1; j < inArr.GetLength(0); j++)
    {
        for (int k = 0; k < inArr[0, columnInArr]; k++)
        {
            inArr[j, k] = tempN;
            tempN++;
        }
        if (j % 2 == 0)
            columnInArr -= 1;
    }
}
int LineDecompArr(int num)
{
    int resClmn = 1;
    for (int i = 1; i < decompArr.GetLength(0); i++)
    {
        for (int j = 0; j < decompArr.GetLength(1); j++)
        {
            if (num == decompArr[i, j])
                return i;
        }
    }
    return resClmn;
}