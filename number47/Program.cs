   /* Задайте двумерный массив размером m×n,
 заполненный случайными вещественными числами. */

Console.WriteLine("Введите количество строк");
int rows = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int columns = int.Parse(Console.ReadLine());

double[,] GetArray(int rows, int columns, int minValue, int maxValue)
{
    double[,] result = new double[rows, columns];

    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            result[i, j] = new Random().NextDouble() * 30;
        }    
    }
    return result;
} 

 void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        
            Console.Write($"{array[i, j]:f2} ");
        Console.WriteLine();
        
    }
}

double[,] myArray = GetArray(rows, columns, 0, 30);
PrintArray(myArray);
 
 