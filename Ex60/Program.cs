// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

Console.Write("Enter number of rows X: ");
int rowsX = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter number of rows Y: ");
int rowsY = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter number of rows Z: ");
int rowsZ = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int[,,] array3D = new int[rowsX, rowsY, rowsZ];

PrintArray(FillMatrix(array3D));

int[,,] FillMatrix(int[,,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            int k = 0;
            while (k < arr.GetLength(2))
            {
                int number = new Random().Next(10, 100);
                if (FindElement(arr, number))
                {
                    continue;
                }
                arr[i, j, k] = number;
                k++;
            }
        }
    }
    return arr;
}


bool FindElement(int[,,] arr, int num)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(2); k++)
            {
                if (arr[i, j, k] == num)
                {
                    return true;
                }
            }
        }
    }
    return false;
}

void PrintArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i, j, k]} ({i},{j},{k})   ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }

}