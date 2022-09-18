// Задача 1: Задайте двумерный массив. Напишите 
// программу, которая будет находить строку с наименьшей
// суммой элементов.
int n = 3;
int m = 3;
int[,] array = new int[n, m];
Random rnd = new Random();
int minsum = Int32.MaxValue;
int index = 0;

void PrintArray(int[,] array)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = rnd.Next(0, 10);
            Console.Write($"{array[i, j]} ");
        }
        Console.Write($"\n");
    }
}

void FillArray(int[,] array)
{
    for (int i = 0; i < n; i++)
    {
        int sum = 0;
        for (int j = 0; j < m; j++)
        {
            sum = sum + array[i, j];
        }
        if (sum < minsum)
        {
            minsum = sum;
            index++;
        }
    }
    Console.WriteLine("Строка с наименьшей суммой: " + (index) + ", сумма равна: " + (minsum));
}

PrintArray(array);
Console.WriteLine("_________");
FillArray(array);