// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

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

int FindResult(int[,] arr)
{
    int[] countStrings = new int [arr.GetLength(0)];
    int sumElements = 0;
    int result = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            sumElements = sumElements + arr[i,j];
        }
        System.Console.WriteLine($"{i+1} = {sumElements}");
        countStrings[i] = sumElements;
        sumElements = 0;
        result = countStrings[0];
        
    }
    System.Console.WriteLine();
    for (int i = 1; i < arr.GetLength(0); i++)
    {
        if (result > countStrings[i]) 
        {
            result = countStrings[i];
        }
    }
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        if(result == countStrings[i]) 
        System.Console.WriteLine($"RESULT = String: {i+1}");
    }

return result;
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

FindResult(Print(Fill(5,5)));
