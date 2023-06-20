// Показать треугольник Паскаля
using System;
using static System.Console;
Clear();
Write("Введите количество строк треугольника Паскаля: ");
int rowTriangle = int.Parse(ReadLine());
int[][] pascalInt = new int[rowTriangle][];
for (int i = 0; i < rowTriangle; i++)
{
    pascalInt[i] = new int[(i + 1)];
}
pascalInt[0][0] = 1;
pascalInt[1][0] = 1;
pascalInt[1][1] = 1;
for (int i = 2; i < rowTriangle; i++)
{
    pascalInt[i][0] = 1;
    pascalInt[i][i] = 1;
    for (int j = 1; j < i; j++)
        pascalInt[i][j] = pascalInt[i - 1][j - 1] + pascalInt[i - 1][j];
}
PrintArray(pascalInt);
void PrintArray(int[][] inArray)
{
    string centerText = string.Empty;
    for (int i = 0; i < rowTriangle; i++)
    {
        centerText = string.Join(" ", inArray[i]);
        int centerX = (Console.WindowWidth / 2) - (centerText.Length / 2);
        Console.SetCursorPosition(centerX, i + 2);
        WriteLine(centerText);
        centerText = string.Empty;
    }
    WriteLine();
}