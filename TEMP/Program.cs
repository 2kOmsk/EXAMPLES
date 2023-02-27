// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2

// 1 -3,3 8 -9,9

// 8 7,8 -7,1 9

Console.Write("количество строл n = ");
string inputrows = Console.ReadLine();
int n = int.Parse(inputrows);
Console.Write(" и еще количество столбцов m = ");
string inputcolum = Console.ReadLine();
int m = int.Parse(inputcolum);
double[,] randomArray = new double[n,m];
double min = -10;
double max = 10;

void RundArray(double[,] array)

{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            double a = new Random().Next(-10,10);
            array[i,j] = a;
    
        }
    }
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}
RundArray(randomArray);
PrintArray(randomArray);


// Console.WriteLine("А теперь число В");
// string inputNum2 = Console.ReadLine();
// int num2 = int.Parse(inputNum2);
// double result = 0;
// result = Math.Pow(num, num2);

// void FullArray(double[] mass)
// {
//     for (int i = 0; i < mass.GetLength(0); i++)
//     {
//         mass[i] = new Random().Next(-100, 100);
//     }
// }
// void PrintArray(double[] mass)
// {
//     for (int i = 0; i < mass.GetLength(0); i++)
//     {
//         Console.Write($"{mass[i]} ");
//     }
//     Console.WriteLine();
// }
// void MinMax(double[] mass)
// {
//      double min = 0;
//         double max = 0;
//     for (int i = 0; i < mass.GetLength(0); i++)
//     {
//         double temp = mass[i];
//         if (temp > max)
//         {
//             max = mass[i];
//         }
//         else if (temp < min)
//         {
//             min = mass[i];
//         }
//     }
//     double result = max-min;
//     Console.WriteLine($" разница между макс и мин элем массива = {result} ");
// }

// FullArray(randomArray);
// PrintArray(randomArray);
// MinMax(randomArray);
