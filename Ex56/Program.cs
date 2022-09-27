// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

int rows = 5;
int columns = 4;
int[,] array = new int[rows, columns];

FillArrayRandomNumbers(array);
PrintArray(array);
Console.WriteLine(); 
int[] sumOfStr = GetSumOfString(array);
Console.WriteLine(); 
FindStringMinSum(sumOfStr);

int[] GetSumOfString(int[,] array)
{
    int[] sumOfStr = new int[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sumOfStr[i] += array[i, j];
        }
        //Console.WriteLine($"The sum of string #{i + 1}  =  {sumOfStr[i]}"); // можно раскоментировать, чтобы выводить сумму каждой строки
          
    }
    return sumOfStr;
}

void FindStringMinSum(int[] array)
{
    int indexStringMinSum = 0; 
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < array[indexStringMinSum]) indexStringMinSum = i; 
    }
    Console.WriteLine($"The string with minimal sum of elements is {indexStringMinSum + 1}");
}



void FillArrayRandomNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
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

