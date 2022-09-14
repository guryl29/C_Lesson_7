/* Напишите программу, которая на вход принимает позиции 
элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание,
 что такого элемента нет. */

 Console.Write("введите количество строк ");
int n = int.Parse(Console.ReadLine());
Console.Write("Введите количества столбцов ");
int m = int.Parse(Console.ReadLine());

int[,] GetArray(int n, int m, int minValue, int maxValue)
{
    int[,] result = new int[n, m];

    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
        
    }
}

int[,] myArr = GetArray(n, m, 0, 99);
PrintArray(myArr);
Console.WriteLine();

Console.WriteLine("Введите число");
int num = int.Parse(Console.ReadLine());
int result = 0;

for(int i = 0; i<myArr.GetLength(0); ++i)
{
    for( int j =0; j<myArr.GetLength(1); ++j)
    {
        if (myArr[i,j]==num)
        {
            result=1;
        }
    }
}
if (result == 1)
{
    Console.WriteLine($"число {num} есть в данном массиве ");
}
else
{
    Console.WriteLine($"числа {num} нет в данном массиве ");
}

