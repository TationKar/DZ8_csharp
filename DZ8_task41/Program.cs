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
WriteLine("Введите размеры массива.");
Write("строки row = : ");
int row = int.Parse(ReadLine()!);
Write("колонки col = : ");
int col = int.Parse(ReadLine()!);
int[,] emptyArr = new int[row, col];
int colDecArr = row > col ? row : col;
int[,] decompArr = new int[(row * 2 - 1), colDecArr];
for (int i = 0; i < col; i++)//заполнение первой строки массива
{
    emptyArr[0, i] = strtNum;
    strtNum++;
}
int shift = 1;
int FillSpiral(int rowArr, int colArr, int res)
{
    int result = res;
    emptyArr[rowArr, colArr] = result;
    result++;

    if (result > (row * col))
        return result;

    int caseLine = LineDecompArr(result);
    if (caseLine > 4)
        caseLine %= 4;
    if (caseLine == 0)
        caseLine = 4;

    if (caseLine == 1)
        FillSpiral(rowArr + 1, colArr, result);
    if (caseLine == 2)
        FillSpiral(rowArr, colArr - 1, result);
    if (caseLine == 3)
        FillSpiral(rowArr - 1, colArr, result);
    if (caseLine == 4)
        FillSpiral(rowArr, colArr + 1, result);
    return 0;
}
FillDecompArr(decompArr);
PrintArray(decompArr);
WriteLine();
FillSpiral(1, col - 1, strtNum);
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
void FillDecompArr(int[,] inArr)
{
    int tempN = 1;
    for (int i = 0; i < col; i++)
    {
        inArr[0, i] = tempN;
        tempN++;
    }
    int columnInArr = row-shift;
    for (int j = 1; j < inArr.GetLength(0); j++)
    {
        for (int k = 0; k < columnInArr; k++)
        {
            inArr[j, k] = tempN;
            tempN++;
        }
        
        if (j % 2 == 0){
            shift += 1;
            columnInArr = row-shift;
        }
        else{
            columnInArr = col-shift;
        }
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