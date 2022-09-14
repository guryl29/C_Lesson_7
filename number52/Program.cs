/* Задайте двумерный массив из целых чисел.
Найдите среднее арифметическое элементов в каждом столбце. */

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

double sredAr (int [,] array, int num)
{
double sAr=0;
int count = 0;

for (int i = 0; i < array.GetLength(1); i++)
    {
        double sum = 0;
        for (int j = 0; j < array.GetLength(0); j++)
        {
           
                sum += array[j, i];             
               
        }
         count++; 
      
         sAr = sum / num;
        Console.WriteLine($"Среднее арифметическое {count} столбца равно {sAr:f2}");
    }

    return sAr;
}


int[,] myArray = GetArray(n, m, 0, 10);
PrintArray(myArray);
Console.WriteLine();
sredAr(myArray, n);