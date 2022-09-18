// Задача 3. Сформируйте двухмерный массив из неповторяющихся 
// двузначных чисел (размер массива не более 50 элементов).
// Напишите программу, которая будет построчно выводить массив.
// Вариант создания функции:
// Проверить число на присутствие в массиве (bool Contains(int[,] arr, int value){...} )
int n = 7;
int m = 7;
int[,] array = new int[n, m];
Random rnd = new Random();
void PrintArray(int[,] array)
{
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.Write($"\n");
    }
}

void FillArray(int[,] array)
{
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            int num;
            do
            {
                num = rnd.Next(10, 100);
            }
            while (Contains(array, num) == true);
            array[i, j] = num;
        }

    }
}

bool Contains(int[,] array, int value)
{
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            if (array[i, j] == value)
            {
                return true;
            }
        }
    }
    return false;
}

FillArray(array);
PrintArray(array);