/* Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся 
двузначных чисел. Напишите программу, которая будет построчно 
выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1) */
using System;
using static System.Console;
Clear();
int[,,] GetArray()
{
    int[] initArr = new int[8];
    int tempEl = 0;
    bool unical = false;
    //for (int i = 0; i < 8; i++)
    int ii = 0;
    do 
    {
        tempEl = new Random().Next(10,100);
        for (int j = 0; j < 8; j++)
        {
            unical = initArr[j] == tempEl ? true : false;
            if (unical)
                break;
        }
        if (unical)
            continue;
        else{
            initArr[ii] = tempEl;
            ii++;
        }           
    } while (initArr[7]==0);
    WriteLine(string.Join(", ", initArr));
    int jj = 0;
    int[,,] result = new int[2, 2, 2];
    for (int i = 0; i < 2; i++)
    {
        for (int j = 0; j < 2; j++)
        {
            for (int k = 0; k < 2; k++)
            {
                result[i, j, k] = initArr[jj];
                jj++;
            }
        }
    }
    return result;
}
void PrintArray(int[,,] inArray)
{
    string tempStr = string.Empty;
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int k = 0; k < inArray.GetLength(1); k++)
        {
            for (int j = 0; j < inArray.GetLength(2); j++)
            {
                tempStr += inArray[i, k, j] + "(" + i + "," + k + "," + j +") ";
            }
            Write(tempStr);
            tempStr = string.Empty;
            WriteLine();
        }
        WriteLine();
    }
    WriteLine();
}

int[,,] array = GetArray();
PrintArray(array);
