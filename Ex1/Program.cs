// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int[,] Fill(int m, int n)
{
    int[,] arr = new int[m, n];
    int count = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(1, 10);
        }
    }
    return arr;
}
int[,] Print(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            System.Console.Write($"{arr[i, j],4}");
        }
        System.Console.WriteLine();
    }
    return arr;
}

int[,] Sort(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            int pos = j;
            for (int k = j; k < arr.GetLength(1); k++)
            {
                if (arr[i, k] > arr[i, pos]) pos = k;
            }
            int t = arr[i, pos];
            arr[i, pos] = arr[i, j];
            arr[i, j] = t;
        }
    }
    return arr;
}

Print(Sort(Fill(5,5)));