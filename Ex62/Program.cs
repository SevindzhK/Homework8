// Напишите программу, которая заполнит спирально массив 4 на 4.

Console.Write("Enter first element of array: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter amount rows/columns: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int[,] array = new int[size, size];

void FillSpiralArray2D(int[,] arr, int num)
{
    for (int count = 0; count <= (size / 2); count++) 
    {
        for (int j = count; j < size - 1 - count; j++)
        {
            int i = count;
            array[i, j] = num;
            num++;
        }
        for (int i = count; i < size - 1 - count; i++)
        {
            int j = size - 1 - count;
            array[i, j] = num;
            num++;
        }
        for (int j = size - 1 - count; j > count; j--)
        {
            int i = size - 1 - count;
            array[i, j] = num;
            num++;
        }
        for (int i = size - 1 - count; i > count; i--)
        {
            int j = count;
            array[i, j] = num;
            num++;
        }
    }
    if (size % 2 != 0)
    {
        array[size / 2, size / 2] = num++; 
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

FillSpiralArray2D(array, number);
PrintArray(array);