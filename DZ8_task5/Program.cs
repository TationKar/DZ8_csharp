//Из двумерного массива целых чисел удалить строку и столбец, 
//на пересечении которых расположен первый найденный наименьший элемент.
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
int n = new Random().Next(3, 7), m = new Random().Next(3, 7);
int[,] array = GetArray(m, n);
int minEl = array[0, 0];
int[] pos = new int[] { 0, 0 };
int[,] result = new int[m - 1, n - 1];
PrintArray(array);
SeekPos();
WriteLine("Минимальный элемент = " + minEl + ", позиция [i,j] = [" + pos[0] + ", " + pos[1] + "]");
WriteLine();
GetResArr();
PrintArray(result);
void GetResArr()
{
    int tempI = 0;
    int tempJ = 0;
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            if (i != pos[0] && j != pos[1])
            {
                result[tempI, tempJ] = array[i, j];
                tempJ++;
            }
        }
        tempJ = 0;
        if (i != pos[0])
            tempI++;
    }
}

void SeekPos()
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < minEl)
            {
                minEl = array[i, j];
                pos[0] = i;
                pos[1] = j;
            }
        }
    }
}