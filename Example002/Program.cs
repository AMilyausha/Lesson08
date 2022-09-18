// Задача 2: Задайте две квадратные матрицы одного размера. Напишите программу,
//  которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
int n = 2;
int[,] array1 = new int[n, n];
int[,] array2 = new int[n, n];
int[,] array3 = new int[n, n];
Random rnd = new Random();

void RandomArray(int[,] array)
{
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = rnd.Next(1, 5);
        }

    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < n; i++)
    {   
        Console.Write("[ ");
        for (int j = 0; j < n; j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.Write("] ");
        Console.Write($"\n");
    }
}

RandomArray(array1);
RandomArray(array2);
void MatrixMultiplication(int[,] array)
{
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++)
        {
            for (int k = 0; k < n; k++)
            {
                array[i, j] = array[i, j] + (array1[i, k] * array2[k, j]);
            }
        }
    }
}


Console.WriteLine("Матрица - А");
PrintArray(array1);
Console.WriteLine("Матрица - B");
PrintArray(array2);
Console.WriteLine("Произведение матриц A*B ");
MatrixMultiplication(array3);
PrintArray(array3);
