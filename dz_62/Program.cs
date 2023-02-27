// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07


int size = 5;
int[,] Matrix = new int[size, size];
int countx = 0;
int county = 0;
int i = 0;
int j = 0;
int mn = 0;



void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }

}



PrintArray(Matrix);
FullMatras(Matrix);
Console.WriteLine();
PrintArray(Matrix);



void FullMatras(int [,] matr)
{
     for (matr[i,j] = 0; j < size; j++)
    {
        matr[i,j] = mn + 1;
        county= j;
        mn++;
        
        // for (matr[i-1,size-1] = 0; i < size-1; i++)
        // {
        //     matr[i,size-1] = mn + 1;
        //     county = i;
        //     mn++;
        // } break;

    } 
}



// int i = 0;
// int j = 0;
// int rows = 0;
// int collums = -1;
// int ModRow = i + rows;
// int ModCol = j + collums;
// while (mn <= size * size)
// {
//     if (0 <= ModRow && ModRow < size && 0 < ModCol && ModCol < size & Matrix[ModRow, ModCol] == 0)
//     {
//         i += rows;
//         j += collums;
//         Matrix[i, j] = mn;
//         mn++;
//     }
//     else if (ModCol == 1)
//     {
//         ModCol = 0;
//         ModRow = 1;
//     }
//     else if (ModRow == 1)
//     {
//         ModRow = 0;
//         ModCol = -1;
//     }
//     else if (ModCol == -1)
//     {
//         ModCol = 0;
//         ModRow = -1;
//     }
//     else if (ModRow == -1)
//     {
//         ModRow = 0;
//         ModCol = 1;
//     }
//     Console.WriteLine(mn);